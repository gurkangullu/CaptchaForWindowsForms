namespace CaptchaForWinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PanelCaptcha = new System.Windows.Forms.Panel();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.TxtCheckText = new System.Windows.Forms.TextBox();
            this.BtnListen = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupBoxPref = new System.Windows.Forms.GroupBox();
            this.CBoxSymbol = new System.Windows.Forms.CheckBox();
            this.CBoxLine = new System.Windows.Forms.CheckBox();
            this.CBoxNoise = new System.Windows.Forms.CheckBox();
            this.CBoxUpCaseChar = new System.Windows.Forms.CheckBox();
            this.CBoxLowCaseChar = new System.Windows.Forms.CheckBox();
            this.CBoxNumeric = new System.Windows.Forms.CheckBox();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.GroupBoxPref.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCaptcha
            // 
            this.PanelCaptcha.BackColor = System.Drawing.Color.Transparent;
            this.PanelCaptcha.Location = new System.Drawing.Point(12, 12);
            this.PanelCaptcha.Name = "PanelCaptcha";
            this.PanelCaptcha.Size = new System.Drawing.Size(200, 50);
            this.PanelCaptcha.TabIndex = 0;
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(218, 104);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(52, 23);
            this.BtnCheck.TabIndex = 1;
            this.BtnCheck.Text = "Check";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.Location = new System.Drawing.Point(217, 12);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(23, 23);
            this.BtnRefresh.TabIndex = 2;
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(470, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status:";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStatus.Location = new System.Drawing.Point(470, 32);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(0, 16);
            this.LblStatus.TabIndex = 4;
            // 
            // TxtCheckText
            // 
            this.TxtCheckText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TxtCheckText.Location = new System.Drawing.Point(12, 104);
            this.TxtCheckText.Name = "TxtCheckText";
            this.TxtCheckText.Size = new System.Drawing.Size(200, 23);
            this.TxtCheckText.TabIndex = 5;
            // 
            // BtnListen
            // 
            this.BtnListen.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnListen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.BtnListen.Image = ((System.Drawing.Image)(resources.GetObject("BtnListen.Image")));
            this.BtnListen.Location = new System.Drawing.Point(217, 39);
            this.BtnListen.Name = "BtnListen";
            this.BtnListen.Size = new System.Drawing.Size(23, 23);
            this.BtnListen.TabIndex = 6;
            this.BtnListen.UseVisualStyleBackColor = true;
            this.BtnListen.Click += new System.EventHandler(this.BtnListen_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(276, 104);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(52, 23);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter captcha text:";
            // 
            // GroupBoxPref
            // 
            this.GroupBoxPref.Controls.Add(this.CBoxSymbol);
            this.GroupBoxPref.Controls.Add(this.CBoxLine);
            this.GroupBoxPref.Controls.Add(this.CBoxNoise);
            this.GroupBoxPref.Controls.Add(this.CBoxUpCaseChar);
            this.GroupBoxPref.Controls.Add(this.CBoxLowCaseChar);
            this.GroupBoxPref.Controls.Add(this.CBoxNumeric);
            this.GroupBoxPref.Location = new System.Drawing.Point(255, 9);
            this.GroupBoxPref.Name = "GroupBoxPref";
            this.GroupBoxPref.Size = new System.Drawing.Size(200, 89);
            this.GroupBoxPref.TabIndex = 9;
            this.GroupBoxPref.TabStop = false;
            this.GroupBoxPref.Text = "Preferences";
            // 
            // CBoxSymbol
            // 
            this.CBoxSymbol.AutoSize = true;
            this.CBoxSymbol.Enabled = false;
            this.CBoxSymbol.Location = new System.Drawing.Point(119, 15);
            this.CBoxSymbol.Name = "CBoxSymbol";
            this.CBoxSymbol.Size = new System.Drawing.Size(60, 17);
            this.CBoxSymbol.TabIndex = 5;
            this.CBoxSymbol.Tag = "3";
            this.CBoxSymbol.Text = "Symbol";
            this.CBoxSymbol.UseVisualStyleBackColor = true;
            // 
            // CBoxLine
            // 
            this.CBoxLine.AutoSize = true;
            this.CBoxLine.Checked = true;
            this.CBoxLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBoxLine.Location = new System.Drawing.Point(119, 38);
            this.CBoxLine.Name = "CBoxLine";
            this.CBoxLine.Size = new System.Drawing.Size(46, 17);
            this.CBoxLine.TabIndex = 4;
            this.CBoxLine.Text = "Line";
            this.CBoxLine.UseVisualStyleBackColor = true;
            // 
            // CBoxNoise
            // 
            this.CBoxNoise.AutoSize = true;
            this.CBoxNoise.Checked = true;
            this.CBoxNoise.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBoxNoise.Location = new System.Drawing.Point(119, 61);
            this.CBoxNoise.Name = "CBoxNoise";
            this.CBoxNoise.Size = new System.Drawing.Size(53, 17);
            this.CBoxNoise.TabIndex = 3;
            this.CBoxNoise.Text = "Noise";
            this.CBoxNoise.UseVisualStyleBackColor = true;
            // 
            // CBoxUpCaseChar
            // 
            this.CBoxUpCaseChar.AutoSize = true;
            this.CBoxUpCaseChar.Checked = true;
            this.CBoxUpCaseChar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBoxUpCaseChar.Location = new System.Drawing.Point(6, 61);
            this.CBoxUpCaseChar.Name = "CBoxUpCaseChar";
            this.CBoxUpCaseChar.Size = new System.Drawing.Size(107, 17);
            this.CBoxUpCaseChar.TabIndex = 2;
            this.CBoxUpCaseChar.Tag = "2";
            this.CBoxUpCaseChar.Text = "Upper Case Char";
            this.CBoxUpCaseChar.UseVisualStyleBackColor = true;
            // 
            // CBoxLowCaseChar
            // 
            this.CBoxLowCaseChar.AutoSize = true;
            this.CBoxLowCaseChar.Checked = true;
            this.CBoxLowCaseChar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBoxLowCaseChar.Location = new System.Drawing.Point(6, 38);
            this.CBoxLowCaseChar.Name = "CBoxLowCaseChar";
            this.CBoxLowCaseChar.Size = new System.Drawing.Size(107, 17);
            this.CBoxLowCaseChar.TabIndex = 1;
            this.CBoxLowCaseChar.Tag = "1";
            this.CBoxLowCaseChar.Text = "Lower Case Char";
            this.CBoxLowCaseChar.UseVisualStyleBackColor = true;
            // 
            // CBoxNumeric
            // 
            this.CBoxNumeric.AutoSize = true;
            this.CBoxNumeric.Checked = true;
            this.CBoxNumeric.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBoxNumeric.Location = new System.Drawing.Point(6, 15);
            this.CBoxNumeric.Name = "CBoxNumeric";
            this.CBoxNumeric.Size = new System.Drawing.Size(65, 17);
            this.CBoxNumeric.TabIndex = 0;
            this.CBoxNumeric.Tag = "0";
            this.CBoxNumeric.Text = "Numeric";
            this.CBoxNumeric.UseVisualStyleBackColor = true;
            // 
            // BtnAbout
            // 
            this.BtnAbout.Image = ((System.Drawing.Image)(resources.GetObject("BtnAbout.Image")));
            this.BtnAbout.Location = new System.Drawing.Point(577, 2);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(34, 23);
            this.BtnAbout.TabIndex = 10;
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 139);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.GroupBoxPref);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnListen);
            this.Controls.Add(this.TxtCheckText);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.PanelCaptcha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captcha For WinForms";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GroupBoxPref.ResumeLayout(false);
            this.GroupBoxPref.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelCaptcha;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.TextBox TxtCheckText;
        private System.Windows.Forms.Button BtnListen;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GroupBoxPref;
        private System.Windows.Forms.CheckBox CBoxUpCaseChar;
        private System.Windows.Forms.CheckBox CBoxLowCaseChar;
        private System.Windows.Forms.CheckBox CBoxNumeric;
        private System.Windows.Forms.CheckBox CBoxSymbol;
        private System.Windows.Forms.CheckBox CBoxLine;
        private System.Windows.Forms.CheckBox CBoxNoise;
        private System.Windows.Forms.Button BtnAbout;
    }
}

