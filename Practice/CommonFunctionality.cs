using System.Linq;
using System.Windows.Forms;

namespace Practice
{
    internal class CommonFunctionality
    {
        /// <summary>
        /// Константа яка відповідає за клавішу видалення попереднього символу перед курсором
        /// </summary>
        private const char charBack = (char)Keys.Back;

        /// <summary>
        /// Метод для перевірки введеного символу, який дозволяє відображати лише числові символи, за певними правилами для деяких чисел, та символи коми та мінуса
        /// </summary>
        /// <param name="sender">Об'єкт текстового поля</param>
        /// <param name="e">Базовый клас для класів, який містить дані про властивість натиску на клавішу та надає її функціонал</param>
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
        /// <summary>
        /// Метод для відображення лише числових симолів та певних правил для відображення нуля
        /// </summary>
        /// <param name="sender">Об'єкт текстового поля</param>
        /// <param name="e">Базовый клас для класів, який містить дані про властивість натиску на клавішу та надає її функціонал</param>
        public static void OnlyDigit(object sender, KeyPressEventArgs e)
        {
            e.Handled = ((e.KeyChar == '0' && ((TextBox)sender).Text.Length == 0) || !char.IsDigit(e.KeyChar)) && e.KeyChar != charBack;
        }
    }
}
