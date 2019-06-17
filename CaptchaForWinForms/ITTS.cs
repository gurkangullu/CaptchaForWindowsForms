using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptchaForWinForms
{
    interface ITTS
    {
        #region IProperties
        int VoiceRate { get; set; }
        #endregion

        #region IMethods
        void Speak();
        void Stop();
        void Dispose();
        #endregion
    }
}
