using System.Windows.Forms;

namespace Matcha.Generics
{
    public static class MessageBox
    {
        public static DialogResult ShowInformationMessage(string contents)
        {
            return System.Windows.Forms.MessageBox.Show(contents, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowErrorMessage(string contents)
        {
            return System.Windows.Forms.MessageBox.Show(contents, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
