using System;
using System.Linq;
using System.Windows.Forms;

namespace DrMinaClinic.Utility
{
    public static class InputLanguageUtility
    {
        private static InputLanguage Arabic => InputLanguage.InstalledInputLanguages.Cast<InputLanguage>()
            .FirstOrDefault(inputLanguage => inputLanguage.LayoutName?.Contains("Arabic") ?? false);

        private static InputLanguage English => InputLanguage.InstalledInputLanguages.Cast<InputLanguage>()
            .FirstOrDefault(inputLanguage => inputLanguage.LayoutName?.Contains("English") ?? false);

        public static void SetArabicInputLanguage(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = Arabic;
            var textBox = sender as TextBox;
            if (textBox == null)
                return;
            textBox.RightToLeft = RightToLeft.Yes;
        }

        public static void SetEnglishInputLanguage(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = English;
            var textBox = sender as TextBox;
            if (textBox == null)
                return;
            textBox.RightToLeft = RightToLeft.No;
        }
    }
}