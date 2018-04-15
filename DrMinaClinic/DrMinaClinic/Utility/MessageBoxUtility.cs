using System.Windows.Forms;

namespace DrMinaClinic.Utility
{
    public static class MessageBoxUtility
    {
        public static void ShowErrorMsg(string msg)
        {
            MessageBox.Show(msg, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowWarningMsg(string msg)
        {
            MessageBox.Show(msg, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowInfoMsg(string msg)
        {
            MessageBox.Show(msg, @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowConfirmationDialog(string msg)
        {
            return MessageBox.Show(msg, @"Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}