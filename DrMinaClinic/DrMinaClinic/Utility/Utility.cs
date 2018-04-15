using System;
using System.Windows.Forms;

namespace DrMinaClinic.Utility
{
    public static class Utility
    {
        //TODO: need to move this method to patient manager
        public static string GetNextPatientId(string lastPatientId)
        {
            var today = DateTime.Now;
            if (!lastPatientId.IsNullOrEmptyOrWhiteSpace())
            {
                var datePartOfLastPatientIdString = lastPatientId.Substring(0, 8);
                if (int.TryParse(datePartOfLastPatientIdString.Substring(0, 4), out int year) &&
                    int.TryParse(datePartOfLastPatientIdString.Substring(4, 2), out int month) &&
                    int.TryParse(datePartOfLastPatientIdString.Substring(6, 2), out int day) &&
                    today.Date == new DateTime(year, month, day))
                {
                    var lastNumber = int.Parse(lastPatientId.Substring(8));
                    return $"{datePartOfLastPatientIdString}{lastNumber + 1}";
                }
            }
            return $"{today.Year:0000}{today.Month:00}{today.Day:00}1";
        }

        public static void SetAutoCompleteSourceForTextBox(TextBox textBox, AutoCompleteStringCollection collection)
        {
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.AutoCompleteCustomSource = collection;
        }
    }
}