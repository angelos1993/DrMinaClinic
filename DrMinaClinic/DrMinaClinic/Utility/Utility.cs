using System.Windows.Forms;

namespace DrMinaClinic.Utility
{
    public static class Utility
    {
        public static void SetAutoCompleteSourceForTextBox(TextBox textBox, AutoCompleteStringCollection collection)
        {
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.AutoCompleteCustomSource = collection;
        }

        public static string ToOrdinal(this int i)
        {
            if (i <= 0)
                return i.ToString();
            switch (i % 100)
            {
                case 11:
                case 12:
                case 13:
                    return i + "th";
            }
            switch (i % 10)
            {
                case 1:
                    return i + "st";
                case 2:
                    return i + "nd";
                case 3:
                    return i + "rd";
                default:
                    return i + "th";
            }
        }
    }
}