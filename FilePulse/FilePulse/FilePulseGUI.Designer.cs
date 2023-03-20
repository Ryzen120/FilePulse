
namespace FilePulse
{
    partial class FilePulseGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilePulseGUI));
            this.m_LabelPathToCheck = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.m_TextBoxPath = new System.Windows.Forms.TextBox();
            this.m_LabelSleepTime = new System.Windows.Forms.Label();
            this.m_TextBoxSleepTime = new System.Windows.Forms.TextBox();
            this.m_ButtonRun = new System.Windows.Forms.Button();
            this.m_ButtonCancel = new System.Windows.Forms.Button();
            this.emailTo = new System.Windows.Forms.TextBox();
            this.emailFromPass = new System.Windows.Forms.TextBox();
            this.emailFrom = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.m_ButtonBrowse = new System.Windows.Forms.Button();
            this.m_LabelRunning = new System.Windows.Forms.Label();
            this.m_LabelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_LabelPathToCheck
            // 
            this.m_LabelPathToCheck.AutoSize = true;
            this.m_LabelPathToCheck.Location = new System.Drawing.Point(44, 53);
            this.m_LabelPathToCheck.Name = "m_LabelPathToCheck";
            this.m_LabelPathToCheck.Size = new System.Drawing.Size(77, 13);
            this.m_LabelPathToCheck.TabIndex = 0;
            this.m_LabelPathToCheck.Text = "Path to check:";
            // 
            // m_TextBoxPath
            // 
            this.m_TextBoxPath.Location = new System.Drawing.Point(127, 50);
            this.m_TextBoxPath.Name = "m_TextBoxPath";
            this.m_TextBoxPath.Size = new System.Drawing.Size(233, 20);
            this.m_TextBoxPath.TabIndex = 1;
            this.m_TextBoxPath.TextChanged += new System.EventHandler(this.m_TextBoxPath_TextChanged);
            // 
            // m_LabelSleepTime
            // 
            this.m_LabelSleepTime.AutoSize = true;
            this.m_LabelSleepTime.Location = new System.Drawing.Point(36, 105);
            this.m_LabelSleepTime.Name = "m_LabelSleepTime";
            this.m_LabelSleepTime.Size = new System.Drawing.Size(85, 13);
            this.m_LabelSleepTime.TabIndex = 4;
            this.m_LabelSleepTime.Text = "Sleep Time (ms):";
            // 
            // m_TextBoxSleepTime
            // 
            this.m_TextBoxSleepTime.Location = new System.Drawing.Point(127, 102);
            this.m_TextBoxSleepTime.Name = "m_TextBoxSleepTime";
            this.m_TextBoxSleepTime.Size = new System.Drawing.Size(100, 20);
            this.m_TextBoxSleepTime.TabIndex = 3;
            this.m_TextBoxSleepTime.TextChanged += new System.EventHandler(this.m_TextBoxSleepTime_TextChanged);
            // 
            // m_ButtonRun
            // 
            this.m_ButtonRun.Location = new System.Drawing.Point(312, 360);
            this.m_ButtonRun.Name = "m_ButtonRun";
            this.m_ButtonRun.Size = new System.Drawing.Size(75, 23);
            this.m_ButtonRun.TabIndex = 6;
            this.m_ButtonRun.Text = "Run";
            this.m_ButtonRun.UseVisualStyleBackColor = true;
            this.m_ButtonRun.Click += new System.EventHandler(this.m_ButtonRun_Click);
            // 
            // m_ButtonCancel
            // 
            this.m_ButtonCancel.Location = new System.Drawing.Point(418, 360);
            this.m_ButtonCancel.Name = "m_ButtonCancel";
            this.m_ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.m_ButtonCancel.TabIndex = 7;
            this.m_ButtonCancel.Text = "Cancel";
            this.m_ButtonCancel.UseVisualStyleBackColor = true;
            this.m_ButtonCancel.Click += new System.EventHandler(this.m_ButtonCancel_Click);
            // 
            // emailTo
            // 
            this.emailTo.Location = new System.Drawing.Point(127, 128);
            this.emailTo.Name = "emailTo";
            this.emailTo.Size = new System.Drawing.Size(100, 20);
            this.emailTo.TabIndex = 4;
            this.emailTo.TextChanged += new System.EventHandler(this.emailTo_TextChanged);
            // 
            // emailFromPass
            // 
            this.emailFromPass.Location = new System.Drawing.Point(127, 180);
            this.emailFromPass.Name = "emailFromPass";
            this.emailFromPass.Size = new System.Drawing.Size(100, 20);
            this.emailFromPass.TabIndex = 6;
            this.emailFromPass.TextChanged += new System.EventHandler(this.emailFromPass_TextChanged);
            // 
            // emailFrom
            // 
            this.emailFrom.Location = new System.Drawing.Point(127, 154);
            this.emailFrom.Name = "emailFrom";
            this.emailFrom.Size = new System.Drawing.Size(100, 20);
            this.emailFrom.TabIndex = 5;
            this.emailFrom.TextChanged += new System.EventHandler(this.emailFrom_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Email To:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Email From Pass:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Email From:";
            // 
            // m_ButtonBrowse
            // 
            this.m_ButtonBrowse.Location = new System.Drawing.Point(366, 48);
            this.m_ButtonBrowse.Name = "m_ButtonBrowse";
            this.m_ButtonBrowse.Size = new System.Drawing.Size(75, 23);
            this.m_ButtonBrowse.TabIndex = 2;
            this.m_ButtonBrowse.Text = "Browse";
            this.m_ButtonBrowse.UseVisualStyleBackColor = true;
            this.m_ButtonBrowse.Click += new System.EventHandler(this.m_ButtonBrowse_Click);
            // 
            // m_LabelRunning
            // 
            this.m_LabelRunning.AutoSize = true;
            this.m_LabelRunning.Location = new System.Drawing.Point(373, 334);
            this.m_LabelRunning.Name = "m_LabelRunning";
            this.m_LabelRunning.Size = new System.Drawing.Size(56, 13);
            this.m_LabelRunning.TabIndex = 34;
            this.m_LabelRunning.Text = "Running...";
            this.m_LabelRunning.Visible = false;
            // 
            // m_LabelError
            // 
            this.m_LabelError.AutoSize = true;
            this.m_LabelError.Location = new System.Drawing.Point(363, 334);
            this.m_LabelError.Name = "m_LabelError";
            this.m_LabelError.Size = new System.Drawing.Size(76, 13);
            this.m_LabelError.TabIndex = 35;
            this.m_LabelError.Text = "Error Occured!";
            this.m_LabelError.Visible = false;
            // 
            // FilePulseGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_LabelError);
            this.Controls.Add(this.m_LabelRunning);
            this.Controls.Add(this.m_ButtonBrowse);
            this.Controls.Add(this.emailTo);
            this.Controls.Add(this.emailFromPass);
            this.Controls.Add(this.emailFrom);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.m_ButtonCancel);
            this.Controls.Add(this.m_ButtonRun);
            this.Controls.Add(this.m_TextBoxSleepTime);
            this.Controls.Add(this.m_LabelSleepTime);
            this.Controls.Add(this.m_TextBoxPath);
            this.Controls.Add(this.m_LabelPathToCheck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FilePulseGUI";
            this.Text = "File Pulse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_LabelPathToCheck;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox m_TextBoxPath;
        private System.Windows.Forms.Label m_LabelSleepTime;
        private System.Windows.Forms.TextBox m_TextBoxSleepTime;
        private System.Windows.Forms.Button m_ButtonRun;
        private System.Windows.Forms.Button m_ButtonCancel;
        private System.Windows.Forms.TextBox emailTo;
        private System.Windows.Forms.TextBox emailFromPass;
        private System.Windows.Forms.TextBox emailFrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button m_ButtonBrowse;
        private System.Windows.Forms.Label m_LabelRunning;
        private System.Windows.Forms.Label m_LabelError;
    }
}

