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
