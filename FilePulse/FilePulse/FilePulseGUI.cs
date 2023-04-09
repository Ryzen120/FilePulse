using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilePulse
{
    public partial class FilePulseGUI : Form
    {
        private string gSleepTime;
        private string gFilePath;

        string gEmailFrom;
        string gEmailTo;
        string gEmailFromPassword;
        string gEmailDomain = "smtp.office365.com";

        public FilePulseGUI()
        {
            InitializeComponent();
        }

        async private void m_ButtonRun_Click(object sender, EventArgs e)
        {
            m_LabelError.Visible = false;

            Globals.Cancelled = false;
            m_LabelRunning.Visible = true;
            Task task1 = Task.Factory.StartNew(() => new Pulse(this, gSleepTime, gFilePath, gEmailDomain, gEmailFrom, gEmailFromPassword, gEmailTo));

            await task1;
            m_LabelRunning.Visible = false;
        }

        private void CheckAllFields()
        {
            if (String.IsNullOrEmpty(gEmailTo) || String.IsNullOrEmpty(gEmailFrom) || String.IsNullOrEmpty(gEmailFromPassword) || String.IsNullOrEmpty(gFilePath) || String.IsNullOrEmpty(gSleepTime))
            {
                m_ButtonRun.Enabled = false;
            }
            else
            {
                m_ButtonRun.Enabled = true;
            }
        }

        private void m_TextBoxPath_TextChanged(object sender, EventArgs e)
        {
            gFilePath = m_TextBoxPath.Text;
            CheckAllFields();
        }

        private void m_TextBoxSleepTime_TextChanged(object sender, EventArgs e)
        {
        
            gSleepTime = m_TextBoxSleepTime.Text;
            CheckAllFields();
        }

        private void m_ButtonCancel_Click(object sender, EventArgs e)
        {
            Globals.Cancelled = true;
        }

        private void emailFrom_TextChanged(object sender, EventArgs e)
        {
            gEmailFrom = emailFrom.Text;
            CheckAllFields();
        }

        private void emailFromPass_TextChanged(object sender, EventArgs e)
        {
            gEmailFromPassword = emailFromPass.Text;
            CheckAllFields();
        }

        private void emailTo_TextChanged(object sender, EventArgs e)
        {
            gEmailTo = emailTo.Text;
            CheckAllFields();
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
            CheckAllFields();
        }
    }
}
