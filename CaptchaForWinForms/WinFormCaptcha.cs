using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;

namespace CaptchaForWinForms
{
    public class WinFormCaptcha : IWinFormCaptcha, IDisposable
    {
        #region Private Fields and Objects
        Random rnd;
        Graphics g;
        Font font;
        Bitmap bitmap;
        Size bmSz, txtSz;
        Point rectPt, txtPt;
        TTS tts;

        List<string> fontList = new List<string>();
        List<int> charStyleTrueList = new List<int>();
        List<int> mathCaptchaTrueList = new List<int>();

        List<char> mathOperandList = new List<char>() { '+', '-', '*', '/' };
        List<char> symbolsList = new List<char>() { '!', '#', '$', '%', '&' };
        Array hatchStyleArray, fontStyleArray;
        #endregion

        #region Enums
        enum CharStyle
        {
            Numeric = 0,
            LowerCaseChar = 1,
            UpperCaseChar = 2,
            Symbol = 3
        }

        public enum CaptchaStyles
        {
            Normal = 0,
            Math = 1,
        }

        public enum MathCaptchaPref
        {
            Addition = 0,
            Subtract = 1,
            Multiply = 2,
            Divide = 3,
        }
        #endregion

        #region Properties
        public string Text { get; private set; } = "";
        public double MathResult { get; private set; } = 0;

        public int TextLength { get; set; } = 5;
        public int Height { get; set; } = 0;
        public int Width { get; set; } = 0;

        //Normal captcha's properties.
        public bool IsIncludeNumeric { get; set; } = true;
        public bool IsIncludeLowerCaseChar { get; set; } = true;
        public bool IsIncludeUpperCaseChar { get; set; } = true;
        public bool IsIncludeSymbol { get; set; } = true;

        public struct NormalCaptchaProperties
        {
            public bool IsIncludeNumeric;
            public bool IsIncludeLowerCaseChar;
            public bool IsIncludeUpperCaseChar;
            public bool IsIncludeSymbol;
        }

        //Math captcha's properties.
        public bool IsIncludeMathAddition { get; set; } = true;
        public bool IsIncludeMathSubstract { get; set; } = true;
        public bool IsIncludeMathMultiply { get; set; } = true;
        public bool IsIncludeMathDivide { get; set; } = true;

        //General captcha's properties.
        public bool IsIncludeLineOnCaptcha { get; set; } = true;
        public bool IsIncludeNoiseOnCaptcha { get; set; } = true;
        public bool IsMessyText { get; set; } = true;
        public bool IsDistortImage { get; set; } = true;

        public CaptchaStyles CaptchaStyle { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor of the WinFormCaptcha class. (For normal captcha.)
        /// </summary>
        /// <param name="_textLenght">The length of the text to be created.</param>
        /// <param name="_width">The width of the captcha box to be created.</param>
        /// <param name="_height">The height of the captcha box to be created.></param>
        /// <param name="_isIncludeNumeric">Checks that the captcha contains numbers.</param>
        /// <param name="_isIncludeLowerCaseChar">
        /// Checks that the captcha contains lower case characters.
        /// </param>
        /// <param name="_isIncludeUpperCaseChar">
        /// Checks that the captcha contains upper case characters.
        /// </param>
        /// <param name="_isIncludeSymbol">
        /// Checks that the captcha contains symbol.
        /// </param>
        /// <param name="_isIncludeLineOnCaptcha">
        /// Checks that the captcha contains lines on text.
        /// </param>
        /// <param name="_isIncludeNoiseOnCaptcha">
        /// Checks that the captcha contains noises on text.
        /// </param>
        /// <param name="_isMessyText">
        /// Checks that the captcha contains messy texts.
        /// </param>
        /// <param name="_isDistortImage">
        /// Checks that the captcha distort.
        /// </param>
        public WinFormCaptcha(int _textLenght, int _width, int _height,
            bool _isIncludeNumeric, bool _isIncludeLowerCaseChar,
            bool _isIncludeUpperCaseChar, bool _isIncludeSymbol,
            bool _isIncludeLineOnCaptcha, bool _isIncludeNoiseOnCaptcha,
            bool _isMessyText, bool _isDistortImage)
        {
            rnd = new Random();
            CaptchaStyle = CaptchaStyles.Normal;

            TextLength = _textLenght;

            Width = _width;
            Height = _height;

            ChangeNormCaptchaSettings(_isIncludeNumeric, _isIncludeLowerCaseChar,
                _isIncludeUpperCaseChar, _isIncludeSymbol, _isIncludeLineOnCaptcha,
                _isIncludeNoiseOnCaptcha, _isMessyText, _isDistortImage);

            bmSz = new Size(Width, Height);
            txtSz = new Size(Width, Height);
            rectPt = new Point(0, 0);
            txtPt = new Point(2, Height / TextLength);

            hatchStyleArray = Enum.GetValues(typeof(HatchStyle));
            fontStyleArray = Enum.GetValues(typeof(FontStyle));

            tts = new TTS();
            ListFont();
        }

        /// <summary>
        /// Constructor of the WinFormCaptcha class. (For math captcha.)
        /// </summary>
        /// <param name="_width">The width of the captcha box to be created.</param>
        /// <param name="_height">The height of the captcha box to be created.></param>
        /// <param name="_isIncludeMathAddition">
        /// Checks that the math captcha contains addition math problems.
        /// </param>
        /// <param name="_isIncludeMathSubstract">
        /// /// Checks that the math captcha contains substract math problems.
        /// </param>
        /// <param name="_isIncludeMathMultiply">
        /// /// Checks that the math captcha contains multiply math problems.
        /// </param>
        /// <param name="_isIncludeMathDivide">
        /// /// Checks that the math captcha contains divide math problems.
        /// </param>
        /// <param name="_isIncludeLineOnCaptcha">
        /// Checks that the captcha contains lines on text.
        /// </param>
        /// <param name="_isIncludeNoiseOnCaptcha">
        /// Checks that the captcha contains noises on text.
        /// </param>
        /// <param name="_isMessyText">
        /// Checks that the captcha contains messy texts.
        /// </param>
        /// <param name="_isDistortImage">
        /// Checks that the captcha distort.
        /// </param>
        public WinFormCaptcha(int _width, int _height, bool _isIncludeMathAddition,
            bool _isIncludeMathSubstract, bool _isIncludeMathMultiply, bool _isIncludeMathDivide,
            bool _isIncludeLineOnCaptcha, bool _isIncludeNoiseOnCaptcha, bool _isMessyText,
            bool _isDistortImage)
        {
            rnd = new Random();
            CaptchaStyle = CaptchaStyles.Math;

            Width = _width;
            Height = _height;

            ChangeMathCaptchaSettings(_isIncludeMathAddition, _isIncludeMathSubstract,
                _isIncludeMathMultiply, _isIncludeMathDivide,
                _isIncludeLineOnCaptcha, _isIncludeNoiseOnCaptcha, _isMessyText,
                _isDistortImage);

            bmSz = new Size(Width, Height);
            txtSz = new Size(Width, Height);
            rectPt = new Point(0, 0);
            txtPt = new Point(2, Height / TextLength);

            hatchStyleArray = Enum.GetValues(typeof(HatchStyle));
            fontStyleArray = Enum.GetValues(typeof(FontStyle));

            tts = new TTS();
            ListFont();
        }
        #endregion

        #region Methods
        /// <summary>
        /// This method checks necessary normal captcha attributes. (e.g: lower case char)
        /// </summary>
        private void CheckIncludesChar()
        {
            if (IsIncludeNumeric == false &&
                IsIncludeLowerCaseChar == false &&
                IsIncludeUpperCaseChar == false &&
                IsIncludeSymbol == false)
            {
                IsIncludeNumeric = true;
                IsIncludeLowerCaseChar = true;
                IsIncludeUpperCaseChar = true;
                IsIncludeSymbol = true;
            }

            //Here the properties of the captcha are set.
            charStyleTrueList = new bool[]
            { IsIncludeNumeric, IsIncludeLowerCaseChar, IsIncludeUpperCaseChar, IsIncludeSymbol }.
            Select((item, index) => new { Item = item, Index = index }).
            Where(o => o.Item.Equals(true)).
            Select(o => o.Index).
            ToList();
        }

        /// <summary>
        /// This method checks necessary math captcha attributes. (e.g: addition)
        /// </summary>
        private void CheckIncludesMathCaptcha()
        {
            if (IsIncludeMathAddition == false &&
                IsIncludeMathSubstract == false &&
                IsIncludeMathMultiply == false &&
                IsIncludeMathDivide == false)
            {
                IsIncludeMathAddition = true;
                IsIncludeMathSubstract = true;
                IsIncludeMathMultiply = true;
                IsIncludeMathDivide = true;
            }

            //Here the properties of the captcha are set.
            mathCaptchaTrueList = new bool[]
            { IsIncludeMathAddition, IsIncludeMathSubstract, IsIncludeMathMultiply, IsIncludeMathDivide }.
            Select((item, index) => new { Item = item, Index = index }).
            Where(o => o.Item.Equals(true)).
            Select(o => o.Index).
            ToList();
        }

        /// <summary>
        /// This method generates random captcha text. (For normal and math captcha's)
        /// </summary>
        private void GenerateRandomText()
        {
            Text = "";
            MathResult = 0;

            switch (CaptchaStyle)
            {
                case CaptchaStyles.Normal:
                    for (int i = 0; i < TextLength; i++)
                    {
                        switch ((CharStyle)charStyleTrueList[rnd.Next(0, charStyleTrueList.Count)])
                        {
                            case CharStyle.Numeric:
                                Text += (char)rnd.Next(48, 58);
                                break;
                            case CharStyle.LowerCaseChar:
                                Text += (char)rnd.Next(97, 123);
                                break;
                            case CharStyle.UpperCaseChar:
                                Text += (char)rnd.Next(65, 91);
                                break;
                            case CharStyle.Symbol:
                                Text += symbolsList[rnd.Next(0, symbolsList.Count)];
                                break;
                        }
                    }
                    break;

                case CaptchaStyles.Math:
                    int num1 = rnd.Next(1, 100);
                    int num2 = rnd.Next(1, 10);

                    int rndNum = mathCaptchaTrueList[rnd.Next(0, mathCaptchaTrueList.Count)];
                    switch ((MathCaptchaPref)rndNum)
                    {
                        case MathCaptchaPref.Addition:
                            MathResult = num1 + num2;
                            Text = num1.ToString() + " " + mathOperandList[rndNum] + " " + num2;
                            break;

                        case MathCaptchaPref.Subtract:
                            MathResult = num1 - num2;
                            Text = num1.ToString() + " " + mathOperandList[rndNum] + " " + num2;
                            break;

                        case MathCaptchaPref.Multiply:
                            MathResult = num1 * num2;
                            Text = num1.ToString() + " " + mathOperandList[rndNum] + " " + num2;
                            break;

                        case MathCaptchaPref.Divide:
                            do
                            {
                                num1 = rnd.Next(1, 100);
                                num2 = rnd.Next(1, 10);

                                MathResult = (double)num1 / num2;
                                Text = num1.ToString() + " " + mathOperandList[rndNum] + " " + num2;
                            } while (MathResult % 1 != 0);
                            break;
                    }
                    break;
            }
        }

        /// <summary>
        /// This method lists the all fonts on the computer.
        /// </summary>
        private void ListFont()
        {
            using (InstalledFontCollection fontsCollection = new InstalledFontCollection())
            {
                FontFamily[] fontFamilies = fontsCollection.Families;
                foreach (FontFamily font in fontFamilies)
                {
                    fontList.Add(font.Name);
                }
            }
        }

        /// <summary>
        /// This method stop tts voice.
        /// </summary>
        private void StopTts()
        {
            tts.Stop();
        }

        /// <summary>
        /// This method allows you to draw random lines on the text.
        /// </summary>
        private void DrawRandomLine()
        {
            if (IsIncludeLineOnCaptcha)
            {
                using (Pen pen = new Pen(new SolidBrush
                    (Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256))), 1.8F))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        g.DrawLine(pen,
                            new Point(rnd.Next(0, txtSz.Width / 2), rnd.Next(0, txtSz.Height / 2)),
                            new Point(rnd.Next(0, txtSz.Width), rnd.Next(0, txtSz.Height)));
                    }
                }
            }
        }

        /// <summary>
        /// This method allows you to draw random noises on the text.
        /// </summary>
        private void DrawRandomNoise()
        {
            if (IsIncludeNoiseOnCaptcha)
            {
                using (Pen pen = new Pen(new SolidBrush
                    (Color.FromArgb(60,
                    rnd.Next(100, 256), rnd.Next(100, 256), rnd.Next(100, 256))), 4))
                {
                    for (int i = 0; i < (int)(bmSz.Width * bmSz.Height / 40F); i++)
                    {
                        g.DrawEllipse(pen,
                            rnd.Next(0, bmSz.Width), rnd.Next(0, bmSz.Height),
                            Math.Max(bmSz.Width, bmSz.Height) / 50,
                            Math.Max(bmSz.Width, bmSz.Height) / 50);
                    }
                }
            }
        }

        /// <summary>
        /// This method allows you to draw texts on the captcha image.
        /// </summary>
        /// <param name="br">Brush necessary for drawing.</param>
        private void DrawText(Brush br)
        {
            if (IsMessyText)
            {
                int tempWidth = bmSz.Width / Text.Length;
                int tempHeight = bmSz.Height / Text.Length;

                for (int i = 0; i < Text.Length; i++)
                {
                    int x = i * (int)font.Size +
                        rnd.Next(TextLength) +
                        rnd.Next(TextLength) +
                        rnd.Next(TextLength);

                    int y = rnd.Next(txtPt.Y + TextLength);

                    g.DrawString(Text[i].ToString(), font, br, new Point(x, y));
                }
            }
            else
            {
                g.DrawString(Text, font, br, txtPt);
            }
        }

        /// <summary>
        /// This method calculate font size according to bitmap size.
        /// </summary>
        /// <param name="_font">The font to use.</param>
        private void CalculateFontSize(ref Font _font)
        {
            //The font size is adjusted according to the bitmap image.
            float fontSize = bmSz.Height - 20;

            if (IsMessyText)
            {
                int messyTextSize;
                do
                {
                    messyTextSize = TextLength * (int)fontSize;
                    fontSize--;
                    _font = new Font("Verdana", fontSize,
                (FontStyle)fontStyleArray.GetValue(rnd.Next(fontStyleArray.Length)),
                GraphicsUnit.Pixel);
                } while (g.MeasureString(Text, _font).Width > bmSz.Width - 20);

                do
                {
                    messyTextSize = TextLength * (int)fontSize;
                    fontSize--;
                    _font = new Font("Verdana", fontSize,
                (FontStyle)fontStyleArray.GetValue(rnd.Next(fontStyleArray.Length)),
                GraphicsUnit.Pixel);
                } while (messyTextSize > bmSz.Width - 20);
            }
            else
            {
                do
                {
                    fontSize--;
                    _font = new Font("Verdana", fontSize,
                (FontStyle)fontStyleArray.GetValue(rnd.Next(fontStyleArray.Length)),
                GraphicsUnit.Pixel);
                } while (g.MeasureString(Text, _font).Width > bmSz.Width + 1);
            }
        }

        /// <summary>
        /// This method allows change settings of the general captcha.
        /// </summary>
        /// <param name="_isIncludeLineOnCaptcha">
        /// Checks that the captcha contains lines on text.
        /// </param>
        /// <param name="_isIncludeNoiseOnCaptcha">
        /// Checks that the captcha contains noises on text.
        /// </param>
        /// <param name="_isMessyText">
        /// Checks that the captcha contains messy texts.
        /// </param>
        /// <param name="_isDistortImage">
        /// Checks that the captcha distort.
        /// </param>
        private void ChangeGeneralCaptchaSettings(bool _isIncludeLineOnCaptcha,
            bool _isIncludeNoiseOnCaptcha, bool _isMessyText, bool _isDistortImage)
        {
            IsIncludeLineOnCaptcha = _isIncludeLineOnCaptcha;
            IsIncludeNoiseOnCaptcha = _isIncludeNoiseOnCaptcha;
            IsMessyText = _isMessyText;
            IsDistortImage = _isDistortImage;
        }

        /// <summary>
        /// This method allows distort of the captcha image.
        /// </summary>
        private void DistortImage()
        {
            if (IsDistortImage)
            {
                using (var cloneBitmap = (Bitmap)bitmap.Clone())
                {
                    int newX = 0, newY = 0, distValue = 4;

                    for (int y = 0; y < bmSz.Height; y++)
                    {
                        for (int x = 0; x < bmSz.Width; x++)
                        {
                            //Wave effect applying.
                            newX = (int)(x + (distValue * Math.Sin(Math.PI * y / 70.0)));
                            newY = (int)(y + (distValue * Math.Cos(Math.PI * x / 50.0)));

                            if (newX < 0 || newX >= bmSz.Width) newX = 0;
                            if (newY < 0 || newY >= bmSz.Height) newY = 0;

                            bitmap.SetPixel(x, y, cloneBitmap.GetPixel(newX, newY));
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This method allow draw captcha to screen.
        /// </summary>
        /// <returns>Return drawn captcha image.</returns>
        public Bitmap DrawCaptcha()
        {
            StopTts();
            switch (CaptchaStyle)
            {
                case CaptchaStyles.Normal:
                    CheckIncludesChar();
                    break;
                case CaptchaStyles.Math:
                    CheckIncludesMathCaptcha();
                    break;
            }
            GenerateRandomText();
            bitmap = new Bitmap(bmSz.Width, bmSz.Height, PixelFormat.Format32bppArgb);

            using (g = Graphics.FromImage(bitmap))
            {
                //The quality of the drawing is improved.
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = TextRenderingHint.AntiAlias;

                using (HatchBrush hbr = new HatchBrush((HatchStyle)hatchStyleArray.
                            GetValue(rnd.Next(hatchStyleArray.Length)),
                            Color.FromArgb(rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100))))
                {
                    using (Brush br = new SolidBrush(Color.FromArgb
                            (rnd.Next(100, 256), rnd.Next(100, 256), rnd.Next(100, 256))))
                    {
                        g.FillRectangle(hbr, rectPt.X, rectPt.Y,
                            bmSz.Width, bmSz.Height);

                        //If you want to use the all fonts on your computer in a random way
                        // **fontList.OrderBy(x => Guid.NewGuid()).FirstOrDefault()**

                        using (font = new Font("Verdana", txtSz.Width / 10,
                            (FontStyle)fontStyleArray.GetValue(rnd.Next(fontStyleArray.Length)),
                            GraphicsUnit.Pixel))
                        {
                            //Calculating font size for normal or messy text.
                            CalculateFontSize(ref font);

                            //g.DrawString(Text, font, br, txtPt);
                            DrawText(br);

                            //Applying some general captcha settings.
                            DrawRandomLine();
                            DrawRandomNoise();
                            DistortImage();

                            return bitmap;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This method check and compare captcha text and user entered text.
        /// </summary>
        /// <param name="_checkText">User's entered text.</param>
        /// <returns>Returns the result of control and comparison.</returns>
        public bool CheckCorrect(string _checkText)
        {
            bool result = false;

            switch (CaptchaStyle)
            {
                case CaptchaStyles.Normal:
                    result = _checkText == Text ? true : false;
                    break;

                case CaptchaStyles.Math:
                    result = _checkText == MathResult.ToString() ? true : false;
                    break;
            }

            return result;
        }

        /// <summary>
        /// This method allows the user listen to voice.
        /// </summary>
        public void ListenCaptcha()
        {
            tts.Data = Text;
            tts.Speak();
        }

        /// <summary>
        /// This method allows save captcha image to computer.
        /// </summary>
        /// <param name="savePath">The file path of the captcha image to be saved.</param>
        /// <param name="imgFrm">The image format of the captcha image to be saved.</param>
        public void SaveCaptcha(string savePath, ImageFormat imgFrm)
        {
            int i = 1;
            string tempPath = savePath;

            savePath = tempPath + "\\CaptchaImage." + imgFrm.ToString().ToLower();
            do
            {
                if (!File.Exists(savePath))
                {
                    break;
                }
                savePath = tempPath + "\\CaptchaImage" + i.ToString() + "." + imgFrm.ToString().ToLower();
                i++;
            } while (true);

            bitmap.Save(savePath, imgFrm);
        }

        /// <summary>
        /// This method allows change settings of the normal captcha.
        /// </summary>
        /// <param name="_isIncludeNumeric">Checks that the normal captcha contains numbers.</param>
        /// <param name="_isIncludeLowerCaseChar">
        /// Checks that the normal captcha contains lower case characters.
        /// </param>
        /// <param name="_isIncludeUpperCaseChar">
        /// Checks that the normal captcha contains upper case characters.
        /// </param>
        /// <param name="_isIncludeSymbol">
        /// Checks that the normal captcha contains symbol.
        /// </param>
        /// <param name="_isIncludeLineOnCaptcha">
        /// Checks that the captcha contains lines on text.
        /// </param>
        /// <param name="_isIncludeNoiseOnCaptcha">
        /// Checks that the captcha contains noises on text.
        /// </param>
        /// <param name="_isMessyText">
        /// Checks that the captcha contains messy texts.
        /// </param>
        /// <param name="_isDistortImage">
        /// Checks that the captcha distort.
        /// </param>
        public void ChangeNormCaptchaSettings(bool _isIncludeNumeric, bool _isIncludeLowerCaseChar,
            bool _isIncludeUpperCaseChar, bool _isIncludeSymbol, bool _isIncludeLineOnCaptcha,
            bool _isIncludeNoiseOnCaptcha, bool _isMessyText, bool _isDistortImage)
        {
            IsIncludeNumeric = _isIncludeNumeric;
            IsIncludeLowerCaseChar = _isIncludeLowerCaseChar;
            IsIncludeUpperCaseChar = _isIncludeUpperCaseChar;
            IsIncludeSymbol = _isIncludeSymbol;

            ChangeGeneralCaptchaSettings(_isIncludeLineOnCaptcha, _isIncludeNoiseOnCaptcha,
                _isMessyText, _isDistortImage);
        }

        /// <summary>
        /// This method allows change settings of the math captcha.
        /// </summary>
        /// <param name="_isIncludeMathAddition">
        /// Checks that the math captcha contains addition math problems.
        /// </param>
        /// <param name="_isIncludeMathSubstract">
        /// /// Checks that the math captcha contains substract math problems.
        /// </param>
        /// <param name="_isIncludeMathMultiply">
        /// /// Checks that the math captcha contains multiply math problems.
        /// </param>
        /// <param name="_isIncludeMathDivide">
        /// /// Checks that the math captcha contains divide math problems.
        /// </param>
        /// <param name="_isIncludeLineOnCaptcha">
        /// Checks that the captcha contains lines on text.
        /// </param>
        /// <param name="_isIncludeNoiseOnCaptcha">
        /// Checks that the captcha contains noises on text.
        /// </param>
        /// <param name="_isMessyText">
        /// Checks that the captcha contains messy texts.
        /// </param>
        /// <param name="_isDistortImage">
        /// Checks that the captcha distort.
        /// </param>
        public void ChangeMathCaptchaSettings(bool _isIncludeMathAddition, bool _isIncludeMathSubstract,
            bool _isIncludeMathMultiply, bool _isIncludeMathDivide, bool _isIncludeLineOnCaptcha,
            bool _isIncludeNoiseOnCaptcha, bool _isMessyText, bool _isDistortImage)
        {
            IsIncludeMathAddition = _isIncludeMathAddition;
            IsIncludeMathSubstract = _isIncludeMathSubstract;
            IsIncludeMathMultiply = _isIncludeMathMultiply;
            IsIncludeMathDivide = _isIncludeMathDivide;

            ChangeGeneralCaptchaSettings(_isIncludeLineOnCaptcha, _isIncludeNoiseOnCaptcha,
                _isMessyText, _isDistortImage);
        }

        /// <summary>
        /// Dispose method.
        /// </summary>
        public void Dispose()
        {
            fontList.Clear();
            charStyleTrueList.Clear();

            hatchStyleArray = null;
            fontStyleArray = null;

            bitmap.Dispose();
            g.Dispose();
            tts.Dispose();
            font.Dispose();
            bitmap.Dispose();

            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
