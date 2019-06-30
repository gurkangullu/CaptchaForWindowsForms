using System;
using System.Speech.Synthesis;

namespace CaptchaForWinForms
{
    class TTS : ITTS, IDisposable
    {
        #region Private Fields and Objects
        private SpeechSynthesizer speaker;
        private Prompt pb;
        #endregion

        #region Properties
        public string Data { private get; set; }
        public int VoiceRate { get; set; } = -2;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor of the TTS class.
        /// </summary>
        public TTS()
        {
            speaker = new SpeechSynthesizer();
            speaker.Rate = VoiceRate;
        }

        /// <summary>
        /// Constructor of the TTS class.
        /// </summary>
        /// <param name="voiceRate">This is value of the TTS rate attribute.</param>
        public TTS(int voiceRate)
        {
            speaker = new SpeechSynthesizer();
            speaker.Rate = voiceRate;
        }
        #endregion

        #region Methods
        /// <summary>
        /// This method allows listening to the captcha text.
        /// </summary>
        public void Speak()
        {
            pb = new Prompt(Data);
            speaker.SpeakAsync(pb);

            //foreach (char dt in Data.ToCharArray())
            //{
            //    speaker.SpeakAsync(Convert.ToString(dt));
            //}
        }

        /// <summary>
        /// This method allows stop listening to the captcha text.
        /// </summary>
        public void Stop()
        {
            if (speaker.State == SynthesizerState.Speaking)
            {
                speaker.SpeakAsyncCancel(pb);
            }
        }

        /// <summary>
        /// Dispose method.
        /// </summary>
        public void Dispose()
        {
            speaker.Dispose();
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
