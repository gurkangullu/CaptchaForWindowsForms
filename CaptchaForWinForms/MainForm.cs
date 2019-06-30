using System;
using System.Drawing;
using System.Windows.Forms;

namespace CaptchaForWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //Setting checked change events of the check boxes.
            //For normal captcha pref.
            CBoxNumeric.CheckedChanged += CBoxs_CheckedChanged;
            CBoxLowCaseChar.CheckedChanged += CBoxs_CheckedChanged;
            CBoxUpCaseChar.CheckedChanged += CBoxs_CheckedChanged;
            CBoxSymbol.CheckedChanged += CBoxs_CheckedChanged;

            //For math captcha pref.
            CBoxAdd.CheckedChanged += CBoxs_CheckedChanged;
            CBoxSubt.CheckedChanged += CBoxs_CheckedChanged;
            CBoxMultp.CheckedChanged += CBoxs_CheckedChanged;
            CBoxDiv.CheckedChanged += CBoxs_CheckedChanged;

            //For general captcha pref.
            CBoxLine.CheckedChanged += CBoxs_CheckedChanged;
            CBoxNoise.CheckedChanged += CBoxs_CheckedChanged;
            CBoxMessy.CheckedChanged += CBoxs_CheckedChanged;
            CBoxDistImg.CheckedChanged += CBoxs_CheckedChanged;

            //Setting checked change events of the radio buttons.
            RBtnNormCaptcha.CheckedChanged += RBtns_CheckedChanged;
            RBtnMathCaptcha.CheckedChanged += RBtns_CheckedChanged;
        }

        /// <summary>
        /// Global objects and variables.
        /// </summary>
        #region Global objects and variables.
        WinFormCaptcha cp;
        #endregion

        /// <summary>
        /// Form load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            /*New instance was created from WinFormCaptcha and
             * was set necessary parameters.*/
            cp = new WinFormCaptcha(int.Parse(NumTextLength.Value.ToString()),
                PanelCaptcha.Width, PanelCaptcha.Height);

            //Captcha image was created and was set as background image of the panel's.
            PanelCaptcha.BackgroundImage = cp.DrawCaptcha();
            PictureBox v = new PictureBox();
            v.Image = cp.DrawCaptcha();
        }

        /// <summary>
        /// This method is run when click refresh button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            //Captcha image was created and was set as background image of the panel's.
            PanelCaptcha.BackgroundImage = cp.DrawCaptcha();
        }

        /// <summary>
        /// This method is run when click listen button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnListen_Click(object sender, EventArgs e)
        {
            //Text on captcha was voiced by computer.
            cp.ListenCaptcha();
        }

        /// <summary>
        /// This method is run when click check button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //Control was made according to the match status of the texts.
            if (cp.CheckCorrect(TxtCheckText.Text))
            {
                LblStatus.ForeColor = Color.Green;
                LblStatus.Text = "Correct!";
            }
            else if (TxtCheckText.Text == string.Empty)
            {
                LblStatus.ForeColor = Color.Red;
                LblStatus.Text = "Please enter text!";
            }
            else
            {
                LblStatus.ForeColor = Color.Red;
                LblStatus.Text = "Wrong!";
            }
        }

        /// <summary>
        /// This method is run when click save button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            cp.SaveCaptcha(Application.StartupPath,
                System.Drawing.Imaging.ImageFormat.Png);
        }

        /// <summary>
        /// This method is change captcha setting when changed captcha preferences.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBoxs_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnNormCaptcha.Checked)
            {
                cp.ChangeNormCaptchaSettings(CBoxNumeric.Checked, CBoxLowCaseChar.Checked,
                    CBoxUpCaseChar.Checked, CBoxSymbol.Checked, CBoxLine.Checked,
                    CBoxNoise.Checked, CBoxMessy.Checked, CBoxDistImg.Checked);
            }
            else if (RBtnMathCaptcha.Checked)
            {
                cp.ChangeMathCaptchaSettings(CBoxAdd.Checked, CBoxSubt.Checked,
                    CBoxMultp.Checked, CBoxDiv.Checked, CBoxLine.Checked,
                    CBoxNoise.Checked, CBoxMessy.Checked, CBoxDistImg.Checked);
            }
        }

        /// <summary>
        /// This method is change text length of the captcha image, when changed captcha preferences.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumTextLength_ValueChanged(object sender, EventArgs e)
        {
            cp.TextLength = (int)NumTextLength.Value;
        }

        /// <summary>
        /// This method is change captcha setting when changed captcha preferences.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBtns_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnNormCaptcha.Checked)
            {
                cp = new WinFormCaptcha(int.Parse(NumTextLength.Value.ToString()),
                    PanelCaptcha.Width, PanelCaptcha.Height, CBoxNumeric.Checked,
                    CBoxLowCaseChar.Checked, CBoxUpCaseChar.Checked, CBoxSymbol.Checked,
                    CBoxLine.Checked, CBoxNoise.Checked, CBoxMessy.Checked, CBoxDistImg.Checked);

                cp.ChangeNormCaptchaSettings(CBoxNumeric.Checked, CBoxLowCaseChar.Checked,
                    CBoxUpCaseChar.Checked, CBoxSymbol.Checked, CBoxLine.Checked,
                    CBoxNoise.Checked, CBoxMessy.Checked, CBoxDistImg.Checked);
            }
            else if (RBtnMathCaptcha.Checked)
            {
                cp.ChangeMathCaptchaSettings(CBoxAdd.Checked, CBoxSubt.Checked,
                    CBoxMultp.Checked, CBoxDiv.Checked, CBoxLine.Checked,
                    CBoxNoise.Checked, CBoxMessy.Checked, CBoxDistImg.Checked);

                cp = new WinFormCaptcha(PanelCaptcha.Width, PanelCaptcha.Height, CBoxAdd.Checked,
                    CBoxSubt.Checked, CBoxMultp.Checked, CBoxDiv.Checked, CBoxLine.Checked,
                    CBoxNoise.Checked, CBoxMessy.Checked, CBoxDistImg.Checked);
            }
        }

        /// <summary>
        /// This method is open about form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbout_Click(object sender, EventArgs e)
        {
            using (AboutForm aboutFrm = new AboutForm())
            {
                aboutFrm.ShowDialog();
            }
        }
    }
}
