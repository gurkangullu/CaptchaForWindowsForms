using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Added Library:
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Drawing.Imaging;
using System.IO;

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
        #endregion

        #region Properties
        public string Text { get; private set; } = "";

        public int TextLength { get; set; } = 5;
        public int Height { get; set; } = 0;
        public int Width { get; set; } = 0;

        public bool IsIncludeNumeric { get; set; } = true;
        public bool IsIncludeLowerCaseChar { get; set; } = true;
        public bool IsIncludeUpperCaseChar { get; set; } = true;
        public bool IsIncludeSymbol { get; set; } = true;

        public bool IsIncludeLineOnCaptcha { get; set; } = true;
        public bool IsIncludeNoiseOnCaptcha { get; set; } = true;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor of the WinFormCaptcha class.
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
        /// <param name="_isIncludeLineOverCaptcha">
        /// Checks that the captcha contains line on text.
        /// </param>
        public WinFormCaptcha(int _textLenght, int _width, int _height,
            bool _isIncludeNumeric, bool _isIncludeLowerCaseChar,
            bool _isIncludeUpperCaseChar, bool _isIncludeSymbol,
            bool _isIncludeLineOnCaptcha, bool _isIncludeNoiseOnCaptcha)
        {
            rnd = new Random();

            TextLength = _textLenght;

            Width = _width;
            Height = _height;

            ChangeCaptchaSettings(_isIncludeNumeric, _isIncludeLowerCaseChar,
                _isIncludeUpperCaseChar, _isIncludeSymbol, _isIncludeLineOnCaptcha,
                _isIncludeNoiseOnCaptcha);

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
        /// This method checks necessary attributes. (e.g: lower case char)
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
        /// This method generates random captcha text.
        /// </summary>
        private void GenerateRandomText()
        {
            Text = "";
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
                        Text += "G"; //TO DO: Make a symbols.
                        break;
                }
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
                    (Color.FromArgb(50, rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256))), 2))
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
        /// This method allow draw captcha to screen.
        /// </summary>
        /// <returns>Return drawn captcha image.</returns>
        public Bitmap DrawCaptcha()
        {
            StopTts();
            CheckIncludesChar();
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
                            //The font size is adjusted according to the bitmap image.
                            float fontSize = bmSz.Height + 1;
                            do
                            {
                                fontSize--;
                            } while (g.MeasureString(Text, font).Width > bmSz.Width + 1);

                            g.DrawString(Text, font, br, txtPt);

                            DrawRandomLine();
                            DrawRandomNoise();

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
            if (_checkText == Text)
            {
                return true;
            }
            else
            {
                return false;
            }
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
        /// This method allows change settings of the captcha.
        /// </summary>
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
        /// <param name="_isIncludeLineOverCaptcha">
        /// Checks that the captcha contains line on text.
        /// </param>
        public void ChangeCaptchaSettings(bool _isIncludeNumeric, bool _isIncludeLowerCaseChar,
            bool _isIncludeUpperCaseChar, bool _isIncludeSymbol,
            bool _isIncludeLineOnCaptcha, bool _isIncludeNoiseOnCaptcha)
        {
            IsIncludeNumeric = _isIncludeNumeric;
            IsIncludeLowerCaseChar = _isIncludeLowerCaseChar;
            IsIncludeUpperCaseChar = _isIncludeUpperCaseChar;
            IsIncludeSymbol = _isIncludeSymbol;

            IsIncludeLineOnCaptcha = _isIncludeLineOnCaptcha;
            IsIncludeNoiseOnCaptcha = _isIncludeNoiseOnCaptcha;
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
