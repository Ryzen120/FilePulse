using System;
using System.IO;
using System.Net.Mail;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace FilePulse
{
    class Pulse
    {
        private int gSleepTimeInMS;
        private string gSleepTime;
        private string gFilePath;

        string gEmailFrom;
        string gEmailTo;
        string gEmailFromPassword;
        string gEmailDomain;

        public Pulse(FilePulseGUI gui, string sleepTime, string filePath, string domain, string from, string pass, string to)
        {
            gSleepTime = sleepTime;
            gFilePath = filePath;
            gEmailFrom = from;
            gEmailTo = to;
            gEmailFromPassword = pass;
            gEmailDomain = domain;

            try
            {
                ConvertSleepTime();

                if (gSleepTimeInMS < 60000)
                {
                    MessageBox.Show("Please select a time greater than 1 minute!");
                }
                else
                {
                    CheckPulse();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error occured: " + e.Message + " " + e.StackTrace + ".");
            }
        }

        private void ConvertSleepTime()
        {
            gSleepTimeInMS = Convert.ToInt32(gSleepTime);
            gSleepTimeInMS = gSleepTimeInMS * 60 * 1000;
        }

        private void CheckPulse()
        {
            long previousSize = 0;

            while (!Globals.Cancelled)
            {
                // Get the current size of the directory
                long currentSize = 0;
                foreach (string filePath in Directory.GetFiles(gFilePath))
                {
                    currentSize += new FileInfo(filePath).Length;
                }

                // Compare the current size to the previous size
                if (currentSize > previousSize)
                {
                    Console.WriteLine("The directory has grown in size!");
                }
                else
                {
                    Console.WriteLine("The directory size has not changed.");

                    SmtpClient SmtpServer = new SmtpClient(gEmailDomain);
                    var mail = new MailMessage();
                    mail.From = new MailAddress(gEmailFrom);
                    mail.To.Add(gEmailTo);
                    mail.Subject = "Alert: Directory size has not changed.";
                    mail.IsBodyHtml = true;
                    string htmlBody;
                    htmlBody = "Directory size has not changed within the specified time.";
                    mail.Body = htmlBody;
                    SmtpServer.Port = 587;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(gEmailFrom, gEmailFromPassword);
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);

                    return;
                }

                // Update the previous size for the next check
                previousSize = currentSize;

                Thread.Sleep(gSleepTimeInMS);
            }
        }
    }
}
