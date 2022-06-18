using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Practice
{
    /// <summary>
    /// Клас для відображення користувачу меню та вікон кожного з пунктів
    /// </summary>
    public partial class UserProfile : Form
    {
        private BunifuButton2 currentBtn;
        private readonly Panel leftBorderBtn;
        private Form currentChildForm;

        /// <summary>
        /// Конструктор класу
        /// </summary>
        public UserProfile()
        {
            InitializeComponent();

            leftBorderBtn = new Panel { Size = new Size(7, 70) };
            bunifuGradientPanelMenu.Controls.Add(leftBorderBtn);
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;

            CollapseMenu();
            TaskOne();

            bunifuButtonMenu.Click += (s, e) => { CollapseMenu(); };
            bunifuButtonTaskOne.Click += (s, e) => { TaskOne(); };
            bunifuButtonClose.Click += (s, e) => { Application.Exit(); };
            bunifuButtonMinimized.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            bunifuButtonMaximize.Click += (s, e) => { WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal; };
        }
        /// <summary>
        /// Метод для відображення активованої кнопки та виведення форми даного пункту меню
        /// </summary>
        /// <param name="sender">Об'єкт активованої кнопки</param>
        private void ActivateButton(object sender)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            if (sender != null && (BunifuButton2)sender != currentBtn)
            {
                DisableButton();

                currentBtn = (BunifuButton2)sender;

                leftBorderBtn.BackColor = Color.FromArgb(240, 170, 104);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.Image = currentBtn.IdleIconLeftImage;
                currentBtn.TextPadding = new Padding(40, 0, 0, 0);
                currentBtn.IconLeftPadding = new Padding(30, 0, 0, 0);
            }
        }
        /// <summary>
        /// Метод для надання активованій кнопці звичайного вигляду, який в неї був до активації
        /// </summary>
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.TextPadding = new Padding(10, 0, 0, 0);
                currentBtn.IconLeftPadding = new Padding(10, 0, 0, 0);
            }
        }
        /// <summary>
        /// Метод для відкриває необхідної форми в залежності від того, який пункт меню є активованим
        /// </summary>
        /// <param name="childForm">Об'єкт форми, яка належить до даного пункту меню</param>
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            bunifuGradientPanelDesktop.Controls.Add(childForm);
            bunifuGradientPanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelCurrentChildForm.Text = childForm.Text;
        }
        /// <summary>
        /// Метод для згортання/розгортання бокового меню
        /// </summary>
        private void CollapseMenu()
        {
            bool width = bunifuGradientPanelMenu.Width > 200;
            bunifuGradientPanelMenu.Width = width ? 100 : 230;
            foreach (BunifuButton2 menuButton in bunifuGradientPanelMenu.Controls.OfType<BunifuButton2>())
            {
                menuButton.Text = width ? "" : menuButton.Tag.ToString();
            }
            bunifuButtonMenu.Text = width ? "" : bunifuButtonMenu.Tag.ToString();
            bunifuButtonMenu.IconLeftPadding = new Padding((width ? 30 : 10), 3, 3, 3);
        }
        /// <summary>
        /// Метод для активації пункту меню "Завдання №1"
        /// </summary>
        private void TaskOne()
        {
            ActivateButton(bunifuButtonTaskOne);
            OpenChildForm(new FormTaskOne());
        }
        /// <summary>
        /// Метод для активації кнопки пункту "Завдання №2"
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void TaskTwo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormTaskTwo());
        }
        /// <summary>
        /// Метод для активації пункту меню "Завдання №3"
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void TaskThree_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormTaskThree(this));
        }
        /// <summary>
        /// Метод для активації пункту меню "Завдання №4"
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void TaskFour_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormTaskFour());
        }
        /// <summary>
        /// Метод для активації пункту меню "Завдання №5"
        /// </summary>
        /// <param name="sender">Об'єкт поля, для якого викликається метод</param>
        /// <param name="e">Базовий клас для класів, який містить дані властивостей і надає значення для властивостей, не зберігаючи в собі даних</param>
        private void TaskFive_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormTaskFive());
        }
    }
}