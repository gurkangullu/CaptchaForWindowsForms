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

        //Normal captcha's properties.
        bool IsIncludeNumeric { get; set; }
        bool IsIncludeLowerCaseChar { get; set; }
        bool IsIncludeUpperCaseChar { get; set; }
        bool IsIncludeSymbol { get; set; }

        //Math captcha's properties.
        bool IsIncludeMathAddition { get; set; }
        bool IsIncludeMathSubstract { get; set; }
        bool IsIncludeMathMultiply { get; set; }
        bool IsIncludeMathDivide { get; set; }

        //General captcha's properties.
        bool IsIncludeLineOnCaptcha { get; set; }
        bool IsIncludeNoiseOnCaptcha { get; set; }
        bool IsMessyText { get; set; }
        bool IsDistortImage { get; set; }

        WinFormCaptcha.CaptchaStyles CaptchaStyle { get; set; }
        #endregion

        #region IMethods
        Bitmap DrawCaptcha();
        bool CheckCorrect(string checkText);
        void ListenCaptcha();
        void SaveCaptcha(string savePath, ImageFormat imgFrm);
        void ChangeNormCaptchaSettings(bool isIncludeNumeric, bool isIncludeLowerCaseChar,
            bool isIncludeUpperCaseChar, bool isIncludeSymbol,
            bool isIncludeLineOnCaptcha, bool isIncludeNoiseOnCaptcha,
            bool isMessyText, bool isDistortImage);
        void ChangeMathCaptchaSettings(bool isIncludeMathAddition, bool isIncludeMathSubstract,
            bool isIncludeMathMultiply, bool isIncludeMathDivide,
            bool isIncludeLineOnCaptcha, bool isIncludeNoiseOnCaptcha,
            bool isMessyText, bool isDistortImage);
        void Dispose();
        #endregion
    }
}
