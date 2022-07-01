using System.Linq;
using System.Windows.Forms;

namespace Practice
{
    internal class CommonFunctionality
    {
        private const char charBack = (char)Keys.Back;

        public static void CheckDigit(object sender, KeyPressEventArgs e)
        {
            TextBox text = (TextBox)sender;
            switch (e.KeyChar)
            {
                case '.': e.Handled = true; break;
                case ',':
                    bool result = text.Text.StartsWith("-");
                    e.Handled = !((char.IsDigit(text.Text[0]) || (result && text.Text.Length > (result ? 1 : 0))) && text.Text.Count(c => (c == ',')) == 0); break;
                case charBack: e.Handled = false; break;
                case '-': e.Handled = text.Text.Length > 0 && text.Text.Count(f => (f == '-')) > 0; break;
                case '0': e.Handled = text.Text.Length < 2 && text.Text.Count(c => c == '0') > 0 && text.Text.Count(c => (c == ',')) < 1; break;
                default: e.Handled = (text.Text.Length == 1 && text.Text[0] == '0') || !char.IsDigit(e.KeyChar); break;
            }
        }

        public static void OnlyDigit(object sender, KeyPressEventArgs e)
        {
            e.Handled = ((e.KeyChar == '0' && ((TextBox)sender).Text.Length == 0) || !char.IsDigit(e.KeyChar)) && e.KeyChar != charBack;
        }
    }
}
