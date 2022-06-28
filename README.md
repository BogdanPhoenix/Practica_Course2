# Практична робота за другий курс

## Меню

Програму можна розділити на три частини: меню (зліва), панель для взаємодії (зверху) та панель в якій будуть виводитися форма вибраного пункту меню.

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Menu.png "Головне меню")

Після запуску програми, користувач може обрати один із запропонованих пунктів меню (перший пункт є активним при запуску програми). Перед користувачем при першому запусці буду відображатися меню у згорноному вигляді. Щоб розгорнути його, потрібно натиснути на відповідну кнопку у верхньому лівому куті програми.

Щоб змінити форму або оновити активну потрібно натиснути на відповідний пункт меню. Після натиску на кнопку виконується метод [ActivateButton](/Practice/UserProfile.cs).

В даному методі відбувається візуальне відображення того, що пункт є активним. Після натиску на один із пунктів викликається метод [DisableButton](/Practice/UserProfile.cs), який надає кнопці стандартного вигляду, і присвоює локальній змінній силку на об'єкт нової активованої кнопки.

Якщо користувач натиснув на активну кнопку іще раз, то бідбудеться очищення всього змісту на формі (форма прийме дефолтний вигляд).

```c#
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
private void DisableButton()
{
    if (currentBtn != null)
    {
        currentBtn.TextPadding = new Padding(10, 0, 0, 0);
        currentBtn.IconLeftPadding = new Padding(10, 0, 0, 0);
    }
}
```

Для того, щоб відкрити необхідну форму можна стористатися методом [OpenChildForm](/Practice/UserProfile.cs). Виконується закриття попередньої форми, якщо вона була викликана і продовжується присвоєння силки на об'єкт форми до локальної зміни, в якій відбувається основна робота відповідно до завдання.

```c#
///<param name="childForm">Об'єкт форми, яка належить до даного пункту меню</param>
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
```
