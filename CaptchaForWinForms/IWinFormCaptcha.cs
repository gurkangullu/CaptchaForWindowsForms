using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Added Library:
using System.Drawing;
using System.Drawing.Imaging;

namespace CaptchaForWinForms
{
    interface IWinFormCaptcha
    {
        #region IProperties
        int TextLength { get; set; }
        int Height { get; set; }
        int Width { get; set; }

        bool IsIncludeNumeric { get; set; }
        bool IsIncludeLowerCaseChar { get; set; }
        bool IsIncludeUpperCaseChar { get; set; }
        bool IsIncludeSymbol { get; set; }
        bool IsIncludeLineOnCaptcha { get; set; }
        bool IsIncludeNoiseOnCaptcha { get; set; }
        #endregion

        #region IMethods
        Bitmap DrawCaptcha();
        bool CheckCorrect(string _checkText);
        void ListenCaptcha();
        void SaveCaptcha(string savePath, ImageFormat imgFrm);
        void ChangeCaptchaSettings(bool _isIncludeNumeric, bool _isIncludeLowerCaseChar,
            bool _isIncludeUpperCaseChar, bool _isIncludeSymbol,
            bool _isIncludeLineOnCaptcha, bool _isIncludeNoiseOnCaptcha);
        void Dispose();
        #endregion
    }
}
