namespace RegApp
{
    partial class Form1
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
            this.regNr_txt = new System.Windows.Forms.MaskedTextBox();
            this.clientID_txt = new System.Windows.Forms.Label();
            this.tel_txt = new System.Windows.Forms.Label();
            this.date_txt = new System.Windows.Forms.Label();
            this.vinRadio = new System.Windows.Forms.RadioButton();
            this.sumRadio = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radigeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taBortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uppdateraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // regNr_txt
            // 
            this.regNr_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regNr_txt.Location = new System.Drawing.Point(44, 85);
            this.regNr_txt.Mask = "AAA AAA";
            this.regNr_txt.Name = "regNr_txt";
            this.regNr_txt.PromptChar = ' ';
            this.regNr_txt.Size = new System.Drawing.Size(189, 53);
            this.regNr_txt.TabIndex = 0;
            this.regNr_txt.Text = "ABC123";
            this.regNr_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.regNr_txt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.regNr_txt_MaskInputRejected);
            this.regNr_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.regNr_txt_KeyDown);
            this.regNr_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.regNr_txt_KeyDown);
            // 
            // clientID_txt
            // 
            this.clientID_txt.AutoSize = true;
            this.clientID_txt.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientID_txt.Location = new System.Drawing.Point(40, 163);
            this.clientID_txt.Name = "clientID_txt";
            this.clientID_txt.Size = new System.Drawing.Size(80, 32);
            this.clientID_txt.TabIndex = 1;
            this.clientID_txt.Text = "Client id:";
            // 
            // tel_txt
            // 
            this.tel_txt.AutoSize = true;
            this.tel_txt.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel_txt.Location = new System.Drawing.Point(40, 207);
            this.tel_txt.Name = "tel_txt";
            this.tel_txt.Size = new System.Drawing.Size(39, 32);
            this.tel_txt.TabIndex = 2;
            this.tel_txt.Text = "Tel:";
            // 
            // date_txt
            // 
            this.date_txt.AutoSize = true;
            this.date_txt.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_txt.Location = new System.Drawing.Point(40, 252);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(71, 32);
            this.date_txt.TabIndex = 3;
            this.date_txt.Text = "Datum:";
            // 
            // vinRadio
            // 
            this.vinRadio.AutoSize = true;
            this.vinRadio.CausesValidation = false;
            this.vinRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinRadio.Location = new System.Drawing.Point(46, 296);
            this.vinRadio.Name = "vinRadio";
            this.vinRadio.Size = new System.Drawing.Size(93, 21);
            this.vinRadio.TabIndex = 4;
            this.vinRadio.TabStop = true;
            this.vinRadio.Text = "Vinterdäck";
            this.vinRadio.UseVisualStyleBackColor = true;
            // 
            // sumRadio
            // 
            this.sumRadio.AutoSize = true;
            this.sumRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumRadio.Location = new System.Drawing.Point(46, 323);
            this.sumRadio.Name = "sumRadio";
            this.sumRadio.Size = new System.Drawing.Size(108, 21);
            this.sumRadio.TabIndex = 5;
            this.sumRadio.TabStop = true;
            this.sumRadio.Text = "Summardäck";
            this.sumRadio.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.radigeraToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(267, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyToolStripMenuItem});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // nyToolStripMenuItem
            // 
            this.nyToolStripMenuItem.Name = "nyToolStripMenuItem";
            this.nyToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.nyToolStripMenuItem.Text = "Ny";
            // 
            // radigeraToolStripMenuItem
            // 
            this.radigeraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taBortToolStripMenuItem,
            this.uppdateraToolStripMenuItem});
            this.radigeraToolStripMenuItem.Name = "radigeraToolStripMenuItem";
            this.radigeraToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.radigeraToolStripMenuItem.Text = "Radigera";
            // 
            // taBortToolStripMenuItem
            // 
            this.taBortToolStripMenuItem.Name = "taBortToolStripMenuItem";
            this.taBortToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.taBortToolStripMenuItem.Text = "Ta bort";
            // 
            // uppdateraToolStripMenuItem
            // 
            this.uppdateraToolStripMenuItem.Name = "uppdateraToolStripMenuItem";
            this.uppdateraToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.uppdateraToolStripMenuItem.Text = "Uppdatera";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 456);
            this.Controls.Add(this.sumRadio);
            this.Controls.Add(this.vinRadio);
            this.Controls.Add(this.date_txt);
            this.Controls.Add(this.tel_txt);
            this.Controls.Add(this.clientID_txt);
            this.Controls.Add(this.regNr_txt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox regNr_txt;
        private System.Windows.Forms.Label clientID_txt;
        private System.Windows.Forms.Label tel_txt;
        private System.Windows.Forms.Label date_txt;
        private System.Windows.Forms.RadioButton vinRadio;
        private System.Windows.Forms.RadioButton sumRadio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radigeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taBortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uppdateraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

