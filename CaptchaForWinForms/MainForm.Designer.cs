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
            this.NumTextLength = new System.Windows.Forms.NumericUpDown();
            this.CBoxSymbol = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBoxUpCaseChar = new System.Windows.Forms.CheckBox();
            this.CBoxLowCaseChar = new System.Windows.Forms.CheckBox();
            this.CBoxNumeric = new System.Windows.Forms.CheckBox();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.RBtnNormCaptcha = new System.Windows.Forms.RadioButton();
            this.RBtnMathCaptcha = new System.Windows.Forms.RadioButton();
            this.GBoxNorm = new System.Windows.Forms.GroupBox();
            this.GBoxMath = new System.Windows.Forms.GroupBox();
            this.CBoxAdd = new System.Windows.Forms.CheckBox();
            this.CBoxSubt = new System.Windows.Forms.CheckBox();
            this.CBoxDiv = new System.Windows.Forms.CheckBox();
            this.CBoxMultp = new System.Windows.Forms.CheckBox();
            this.CBoxMessy = new System.Windows.Forms.CheckBox();
            this.CBoxNoise = new System.Windows.Forms.CheckBox();
            this.CBoxLine = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GroupBoxPref.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTextLength)).BeginInit();
            this.GBoxNorm.SuspendLayout();
            this.GBoxMath.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.BtnCheck.Location = new System.Drawing.Point(12, 133);
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
            this.label1.Location = new System.Drawing.Point(9, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status:";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStatus.Location = new System.Drawing.Point(9, 194);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(0, 16);
            this.LblStatus.TabIndex = 4;
            // 
            // TxtCheckText
            // 
            this.TxtCheckText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TxtCheckText.Location = new System.Drawing.Point(12, 104);
            this.TxtCheckText.Name = "TxtCheckText";
            this.TxtCheckText.Size = new System.Drawing.Size(228, 23);
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
            this.BtnSave.Location = new System.Drawing.Point(70, 133);
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
            this.label2.Size = new System.Drawing.Size(203, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter captcha text or math problem result:";
            // 
            // GroupBoxPref
            // 
            this.GroupBoxPref.Controls.Add(this.groupBox3);
            this.GroupBoxPref.Controls.Add(this.GBoxMath);
            this.GroupBoxPref.Controls.Add(this.GBoxNorm);
            this.GroupBoxPref.Controls.Add(this.RBtnMathCaptcha);
            this.GroupBoxPref.Controls.Add(this.RBtnNormCaptcha);
            this.GroupBoxPref.Location = new System.Drawing.Point(255, 9);
            this.GroupBoxPref.Name = "GroupBoxPref";
            this.GroupBoxPref.Size = new System.Drawing.Size(320, 250);
            this.GroupBoxPref.TabIndex = 9;
            this.GroupBoxPref.TabStop = false;
            this.GroupBoxPref.Text = "Preferences";
            // 
            // NumTextLength
            // 
            this.NumTextLength.Location = new System.Drawing.Point(9, 32);
            this.NumTextLength.Name = "NumTextLength";
            this.NumTextLength.Size = new System.Drawing.Size(64, 20);
            this.NumTextLength.TabIndex = 11;
            this.NumTextLength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumTextLength.ValueChanged += new System.EventHandler(this.NumTextLength_ValueChanged);
            // 
            // CBoxSymbol
            // 
            this.CBoxSymbol.AutoSize = true;
            this.CBoxSymbol.Checked = true;
            this.CBoxSymbol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBoxSymbol.Location = new System.Drawing.Point(79, 85);
            this.CBoxSymbol.Name = "CBoxSymbol";
            this.CBoxSymbol.Size = new System.Drawing.Size(60, 17);
            this.CBoxSymbol.TabIndex = 5;
            this.CBoxSymbol.Tag = "3";
            this.CBoxSymbol.Text = "Symbol";
            this.CBoxSymbol.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Text length:";
            // 
            // CBoxUpCaseChar
            // 
            this.CBoxUpCaseChar.AutoSize = true;
            this.CBoxUpCaseChar.Checked = true;
            this.CBoxUpCaseChar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBoxUpCaseChar.Location = new System.Drawing.Point(79, 62);
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
            this.CBoxLowCaseChar.Location = new System.Drawing.Point(79, 39);
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
            this.CBoxNumeric.Location = new System.Drawing.Point(79, 16);
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
            this.BtnAbout.Location = new System.Drawing.Point(581, 12);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(34, 23);
            this.BtnAbout.TabIndex = 10;
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // RBtnNormCaptcha
            // 
            this.RBtnNormCaptcha.AutoSize = true;
            this.RBtnNormCaptcha.Checked = true;
            this.RBtnNormCaptcha.Location = new System.Drawing.Point(6, 19);
            this.RBtnNormCaptcha.Name = "RBtnNormCaptcha";
            this.RBtnNormCaptcha.Size = new System.Drawing.Size(101, 17);
            this.RBtnNormCaptcha.TabIndex = 13;
            this.RBtnNormCaptcha.TabStop = true;
            this.RBtnNormCaptcha.Tag = "Normal";
            this.RBtnNormCaptcha.Text = "Normal Captcha";
            this.RBtnNormCaptcha.UseVisualStyleBackColor = true;
            // 
            // RBtnMathCaptcha
            // 
            this.RBtnMathCaptcha.AutoSize = true;
            this.RBtnMathCaptcha.Location = new System.Drawing.Point(6, 153);
            this.RBtnMathCaptcha.Name = "RBtnMathCaptcha";
            this.RBtnMathCaptcha.Size = new System.Drawing.Size(92, 17);
            this.RBtnMathCaptcha.TabIndex = 14;
            this.RBtnMathCaptcha.Tag = "Math";
            this.RBtnMathCaptcha.Text = "Math Captcha";
            this.RBtnMathCaptcha.UseVisualStyleBackColor = true;
            // 
            // GBoxNorm
            // 
            this.GBoxNorm.Controls.Add(this.label3);
            this.GBoxNorm.Controls.Add(this.CBoxNumeric);
            this.GBoxNorm.Controls.Add(this.CBoxLowCaseChar);
            this.GBoxNorm.Controls.Add(this.CBoxSymbol);
            this.GBoxNorm.Controls.Add(this.NumTextLength);
            this.GBoxNorm.Controls.Add(this.CBoxUpCaseChar);
            this.GBoxNorm.Location = new System.Drawing.Point(6, 42);
            this.GBoxNorm.Name = "GBoxNorm";
            this.GBoxNorm.Size = new System.Drawing.Size(187, 105);
            this.GBoxNorm.TabIndex = 11;
            this.GBoxNorm.TabStop = false;
            this.GBoxNorm.Text = "Normal Captcha Pref.";
            // 
            // GBoxMath
            // 
            this.GBoxMath.Controls.Add(this.CBoxAdd);
            this.GBoxMath.Controls.Add(this.CBoxSubt);
            this.GBoxMath.Controls.Add(this.CBoxDiv);
            this.GBoxMath.Controls.Add(this.CBoxMultp);
            this.GBoxMath.Location = new System.Drawing.Point(6, 176);
            this.GBoxMath.Name = "GBoxMath";
            this.GBoxMath.Size = new System.Drawing.Size(187, 66);
            this.GBoxMath.TabIndex = 15;
            this.GBoxMath.TabStop = false;
            this.GBoxMath.Text = "Math Captcha Pref.";
            // 
            // CBoxAdd
            // 
            this.CBoxAdd.AutoSize = true;
            this.CBoxAdd.Checked = true;
            this.CBoxAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBoxAdd.Location = new System.Drawing.Point(9, 19);
            this.CBoxAdd.Name = "CBoxAdd";
            this.CBoxAdd.Size = new System.Drawing.Size(64, 17);
            this.CBoxAdd.TabIndex = 0;
            this.CBoxAdd.Tag = "0";
            this.CBoxAdd.Text = "Addition";
            this.CBoxAdd.UseVisualStyleBackColor = true;
            // 
            // CBoxSubt
            // 
            this.CBoxSubt.AutoSize = true;
            this.CBoxSubt.Checked = true;
            this.CBoxSubt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBoxSubt.Location = new System.Drawing.Point(9, 42);
            this.CBoxSubt.Name = "CBoxSubt";
            this.CBoxSubt.Size = new System.Drawing.Size(69, 17);
            this.CBoxSubt.TabIndex = 1;
            this.CBoxSubt.Tag = "1";
            this.CBoxSubt.Text = "Subtract ";
            this.CBoxSubt.UseVisualStyleBackColor = true;
            // 
            // CBoxDiv
            // 
            this.CBoxDiv.AutoSize = true;
            this.CBoxDiv.Checked = true;
            this.CBoxDiv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBoxDiv.Location = new System.Drawing.Point(79, 42);
            this.CBoxDiv.Name = "CBoxDiv";
            this.CBoxDiv.Size = new System.Drawing.Size(56, 17);
            this.CBoxDiv.TabIndex = 5;
            this.CBoxDiv.Tag = "3";
            this.CBoxDiv.Text = "Divide";
            this.CBoxDiv.UseVisualStyleBackColor = true;
            // 
            // CBoxMultp
            // 
            this.CBoxMultp.AutoSize = true;
            this.CBoxMultp.Checked = true;
            this.CBoxMultp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBoxMultp.Location = new System.Drawing.Point(79, 19);
            this.CBoxMultp.Name = "CBoxMultp";
            this.CBoxMultp.Size = new System.Drawing.Size(64, 17);
            this.CBoxMultp.TabIndex = 2;
            this.CBoxMultp.Tag = "2";
            this.CBoxMultp.Text = "Multiply ";
            this.CBoxMultp.UseVisualStyleBackColor = true;
            // 
            // CBoxMessy
            // 
            this.CBoxMessy.AutoSize = true;
            this.CBoxMessy.Checked = true;
            this.CBoxMessy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBoxMessy.Location = new System.Drawing.Point(6, 65);
            this.CBoxMessy.Name = "CBoxMessy";
            this.CBoxMessy.Size = new System.Drawing.Size(80, 17);
            this.CBoxMessy.TabIndex = 6;
            this.CBoxMessy.Text = "Messy Text";
            this.CBoxMessy.UseVisualStyleBackColor = true;
            // 
            // CBoxNoise
            // 
            this.CBoxNoise.AutoSize = true;
            this.CBoxNoise.Checked = true;
            this.CBoxNoise.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBoxNoise.Location = new System.Drawing.Point(6, 42);
            this.CBoxNoise.Name = "CBoxNoise";
            this.CBoxNoise.Size = new System.Drawing.Size(53, 17);
            this.CBoxNoise.TabIndex = 3;
            this.CBoxNoise.Text = "Noise";
            this.CBoxNoise.UseVisualStyleBackColor = true;
            // 
            // CBoxLine
            // 
            this.CBoxLine.AutoSize = true;
            this.CBoxLine.Checked = true;
            this.CBoxLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBoxLine.Location = new System.Drawing.Point(6, 19);
            this.CBoxLine.Name = "CBoxLine";
            this.CBoxLine.Size = new System.Drawing.Size(46, 17);
            this.CBoxLine.TabIndex = 4;
            this.CBoxLine.Text = "Line";
            this.CBoxLine.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CBoxLine);
            this.groupBox3.Controls.Add(this.CBoxMessy);
            this.groupBox3.Controls.Add(this.CBoxNoise);
            this.groupBox3.Location = new System.Drawing.Point(199, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(113, 200);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General Pref.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 265);
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
            ((System.ComponentModel.ISupportInitialize)(this.NumTextLength)).EndInit();
            this.GBoxNorm.ResumeLayout(false);
            this.GBoxNorm.PerformLayout();
            this.GBoxMath.ResumeLayout(false);
            this.GBoxMath.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.NumericUpDown NumTextLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GBoxMath;
        private System.Windows.Forms.CheckBox CBoxAdd;
        private System.Windows.Forms.CheckBox CBoxSubt;
        private System.Windows.Forms.CheckBox CBoxDiv;
        private System.Windows.Forms.CheckBox CBoxMultp;
        private System.Windows.Forms.GroupBox GBoxNorm;
        private System.Windows.Forms.RadioButton RBtnMathCaptcha;
        private System.Windows.Forms.RadioButton RBtnNormCaptcha;
        private System.Windows.Forms.CheckBox CBoxLine;
        private System.Windows.Forms.CheckBox CBoxNoise;
        private System.Windows.Forms.CheckBox CBoxMessy;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

