using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CaptchaForWinForms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is open my github page in default browser.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PboxGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/gurkangullu");
        }
    }
}
