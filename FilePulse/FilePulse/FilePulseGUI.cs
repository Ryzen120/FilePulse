using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilePulse
{
    public partial class FilePulseGUI : Form
    {
        private int gSleepTime;
        private string gFilePath;

        string gEmailFrom;
        string gEmailTo;
        string gEmailFromPassword;
        string gEmailDomain = "smtp.office365.com";

        public FilePulseGUI()
        {
            gSleepTime = 0;
            InitializeComponent();
        }

        async private void m_ButtonRun_Click(object sender, EventArgs e)
        {
            m_LabelError.Visible = false;

            if(String.IsNullOrEmpty(gEmailTo) || String.IsNullOrEmpty(gEmailFrom) || String.IsNullOrEmpty(gEmailFromPassword) || String.IsNullOrEmpty(gFilePath) || gSleepTime < 5000)
            {
                m_LabelError.Visible = true;
            }
            else
            {
                Globals.Cancelled = false;
                m_LabelRunning.Visible = true;
                Task task1 = Task.Factory.StartNew(() => new Pulse(this, gSleepTime, gFilePath, gEmailDomain, gEmailFrom, gEmailFromPassword, gEmailTo));

                await task1;
                m_LabelRunning.Visible = false;
            }
        }

        private void m_TextBoxPath_TextChanged(object sender, EventArgs e)
        {
            gFilePath = m_TextBoxPath.Text;
        }

        private void m_TextBoxSleepTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                gSleepTime = Convert.ToInt32(m_TextBoxSleepTime.Text);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error occured with sleep time " + ex.Message);
            }
            finally
            {
                gSleepTime = 600000;
            }
        }

        private void m_ButtonCancel_Click(object sender, EventArgs e)
        {
            Globals.Cancelled = true;
        }

        private void emailFrom_TextChanged(object sender, EventArgs e)
        {
            gEmailFrom = emailFrom.Text;
        }

        private void emailFromPass_TextChanged(object sender, EventArgs e)
        {
            gEmailFromPassword = emailFromPass.Text;
        }

        private void emailTo_TextChanged(object sender, EventArgs e)
        {
            gEmailTo = emailTo.Text;
        }

        private void m_ButtonBrowse_Click(object sender, EventArgs e)
        {
            var folderDialogBrowser1 = new FolderBrowserDialog();

            DialogResult result = folderDialogBrowser1.ShowDialog();

            if(result == DialogResult.OK)
            {
                string folderName = folderDialogBrowser1.SelectedPath;
                m_TextBoxPath.Text = folderName;
            }
        }
    }
}
