using System;
using System.IO;
using System.Net.Mail;
using System.Threading;

namespace FilePulse
{
    class Pulse
    {
        private int gSleepTime;
        private string gFilePath;

        string gEmailFrom;
        string gEmailTo;
        string gEmailFromPassword;
        string gEmailDomain;

        public Pulse(FilePulseGUI gui, int sleepTime, string filePath, string domain, string from, string pass, string to)
        {
            gSleepTime = sleepTime;
            gFilePath = filePath;
            gEmailFrom = from;
            gEmailTo = to;
            gEmailFromPassword = pass;
            gEmailDomain = domain;

            CheckPulse();
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
                    mail.Subject = "NAS Recording Failure";
                    mail.IsBodyHtml = true;
                    string htmlBody;
                    htmlBody = "Your NAS Recording has stopped. Directory size has not changed.";
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

                Thread.Sleep(gSleepTime);
            }
        }
    }
}
