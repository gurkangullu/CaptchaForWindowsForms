using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Added Library:
using System.Diagnostics;

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
