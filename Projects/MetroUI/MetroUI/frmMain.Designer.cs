namespace MetroUI
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.btnOpen = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.txtMessege = new MetroFramework.Controls.MetroTextBox();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.btnRecieve = new MetroFramework.Controls.MetroButton();
            this.txtRecieve = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(34, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Port";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(78, 67);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(119, 29);
            this.metroComboBox1.TabIndex = 1;
            this.metroComboBox1.UseSelectable = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(220, 67);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(60, 28);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseSelectable = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(301, 68);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtMessege
            // 
            // 
            // 
            // 
            this.txtMessege.CustomButton.Image = null;
            this.txtMessege.CustomButton.Location = new System.Drawing.Point(255, 1);
            this.txtMessege.CustomButton.Name = "";
            this.txtMessege.CustomButton.Size = new System.Drawing.Size(115, 115);
            this.txtMessege.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMessege.CustomButton.TabIndex = 1;
            this.txtMessege.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMessege.CustomButton.UseSelectable = true;
            this.txtMessege.CustomButton.Visible = false;
            this.txtMessege.Lines = new string[0];
            this.txtMessege.Location = new System.Drawing.Point(80, 119);
            this.txtMessege.MaxLength = 32767;
            this.txtMessege.Name = "txtMessege";
            this.txtMessege.PasswordChar = '\0';
            this.txtMessege.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMessege.SelectedText = "";
            this.txtMessege.SelectionLength = 0;
            this.txtMessege.SelectionStart = 0;
            this.txtMessege.ShortcutsEnabled = true;
            this.txtMessege.Size = new System.Drawing.Size(371, 117);
            this.txtMessege.TabIndex = 4;
            this.txtMessege.UseSelectable = true;
            this.txtMessege.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMessege.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(391, 242);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(60, 28);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseSelectable = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnRecieve
            // 
            this.btnRecieve.Location = new System.Drawing.Point(391, 399);
            this.btnRecieve.Name = "btnRecieve";
            this.btnRecieve.Size = new System.Drawing.Size(60, 28);
            this.btnRecieve.TabIndex = 7;
            this.btnRecieve.Text = "Recieve";
            this.btnRecieve.UseSelectable = true;
            this.btnRecieve.Click += new System.EventHandler(this.btnRecieve_Click);
            // 
            // txtRecieve
            // 
            // 
            // 
            // 
            this.txtRecieve.CustomButton.Image = null;
            this.txtRecieve.CustomButton.Location = new System.Drawing.Point(255, 1);
            this.txtRecieve.CustomButton.Name = "";
            this.txtRecieve.CustomButton.Size = new System.Drawing.Size(115, 115);
            this.txtRecieve.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRecieve.CustomButton.TabIndex = 1;
            this.txtRecieve.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRecieve.CustomButton.UseSelectable = true;
            this.txtRecieve.CustomButton.Visible = false;
            this.txtRecieve.Lines = new string[0];
            this.txtRecieve.Location = new System.Drawing.Point(80, 276);
            this.txtRecieve.MaxLength = 32767;
            this.txtRecieve.Name = "txtRecieve";
            this.txtRecieve.PasswordChar = '\0';
            this.txtRecieve.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRecieve.SelectedText = "";
            this.txtRecieve.SelectionLength = 0;
            this.txtRecieve.SelectionStart = 0;
            this.txtRecieve.ShortcutsEnabled = true;
            this.txtRecieve.Size = new System.Drawing.Size(371, 117);
            this.txtRecieve.TabIndex = 6;
            this.txtRecieve.UseSelectable = true;
            this.txtRecieve.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRecieve.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Send:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 276);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Recieve:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 445);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnRecieve);
            this.Controls.Add(this.txtRecieve);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessege);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmMain";
            this.Text = "Hello";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroButton btnOpen;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroTextBox txtMessege;
        private MetroFramework.Controls.MetroButton btnSend;
        private MetroFramework.Controls.MetroButton btnRecieve;
        private MetroFramework.Controls.MetroTextBox txtRecieve;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.IO.Ports.SerialPort serialPort1;

    }
}