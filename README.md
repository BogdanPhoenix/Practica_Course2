# Практична робота за другий курс

## Меню

ДАне вікно можна розділити на три частини: меню (зліва), панель для взаємодії (зверху) та панель в якій будуть виводитися форма вибраного пункту меню.

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Menu.png "Головне меню")

Після запуску програми, користувач може обрати один із запропонованих пунктів меню (перший пункт є активним при запуску програми). Перед користувачем при першому запуску буде відображатися меню у прихованому вигляді. Щоб відкрити його, потрібно натиснути на відповідну кнопку у верхньому лівому куті програми.

Щоб змінити форму або оновити активну потрібно натиснути на відповідний пункт меню. Після натиску на кнопку виконується метод [ActivateButton](/Practice/UserProfile.cs). В активної кнопка номер задачі переміщується на праву сторону, а з лівої сторони з'являється оранжева смужка, яка символізує активний пункт.

Після натиску на один із пунктів також викликається метод [DisableButton](/Practice/UserProfile.cs), який надає кнопці стандартного вигляду, і присвоює локальній змінній силку на об'єкт нової активованої кнопки.

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

---

## Задача №1

### Умова

Побудувати програму для обчислення:

- значення функціональної суми для формули **<sup>n, ∞</sup>∑<sub>i=0</sub> cos(x \* i) / i!** накопиченої сумою для кількості членів **_i_** від **_1_** до **_n_** додатків;
- значення суми з потрібною точністю **_ℰ = 0,001_**. Знайти також кількість підсумованих при цьому елементів, результати рішення вивести в таблицю та побудувати графік залежності значення суми від кількості підсумованих членів;
- значення функції **y = ℰ<sup>cos x</sup>cos(sin x)**

Коли користувач вибирає пункт "_Задача №1_", то перед ним постає вибір виконання заданого завадння. В "_Пункті №1_" можна виконати обчислення функціальної суми, ввівші відповідні дані.

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task1_Item1_Default.png "Функціональна сума")

В цьому пункті відбувається просте накопичення функціональної суми з вказаною кількістю ітерацій та обчислення функції, яка служить для того, щоб перевірити точність обчислення. Під час введення користувачем даних в аргументі враховані певні обмеження:

- заборона введення символів для аргументу, крім чисел та певних знаків (кома, мінус);
- для кількості ітерецій можна ввести лише числа, всі інші символи є заборонені;
- додані повідомлення про обмеження кількості у відповідні поля ([метод MaxLengthTextBox](/Practice/FormTaskOne.cs)).

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task1_Item1_Result.png "Функціональна сума після обчислення")

Після виконання завдання користувачу виводить повна інформація:

- формула рівняння;
- формула функції;
- дані, які ввів користувач;
- результат рівняння та функції.

В "_Пункті №2_" відбувається обчислення суми із заданою точністю та побудовою відповідного графіку.

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task1_Item2_Default.png "Значення суми з потрібною точністю")

Після вибору другого пунку перед користувачем постає поле для введення аргументу та повзунець (_слайдер_), за допомогою якого можна вибрати точність від **_10<sup>-9</sup>_** до **_1_**.

Коли користувач натиснув отримати результат перед ним з'являється відповідна інформація:

- формула рівняння;
- введенні дані (аргумент та вибрана точність);
- результат накописеної суми;
- кількість підсумованих елементів;

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task1_Item2_Result.png "Значення суми з потрібною точністю після обчислення")

Також користувачу стає доступною кнопка, щоб відкрити/закрити бокову панель для відображення графіку. Після натиску на цю кнопку з'являється/зникає відповідне поле з таблицею даних для графіку та самим графіком.

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task1_Item2_Graph.png "Графік залежності значення суми від кількості підсумованих членів")

Нижче навелений [фрагмент коду](/Practice/FormTaskOne.cs) який відповідає за виведення повідомлення, якщо користувач достиг максимально дозволеної кількості символів у полів і виводить відповідне повідомлення.

```c#
/// <param name="sender">Об'єкт текстового поля</param>
/// <param name="e">Базовый клас для класів, який містить дані про властивість натиску на клавішу та надає її функціонал</param>
private void MaxLengthTextBox(object sender, KeyPressEventArgs e)
{
    TextBox textBox = (TextBox)sender;
    if (e.KeyChar != (char)Keys.Back && textBox.Text.Length == textBox.MaxLength)
    {
       bunifuSnackbar.Show(ParentForm, $"Ви ввели максимальну кількість символів ({textBox.MaxLength})");
    }
}
```

Даний [метод](/Practice/FormTaskOne.cs) дозволяє за допомогою короткого запису отримати факторіал вказаного числа.

```c#
/// <param name="number">Число для факторіалу</param>
/// <returns>Факторіал вкащаного числа</returns>
private int Fact(int number)
{
    return number == 0 ? 1 : number * Fact(number - 1);
}
```

---

## Задача №2

### Умова

Створити програму для обчислення білінійної форми **_B = m <sup>n</sup>∑<sub>i=1</sub> x<sub>i</sub> <sup>n</sup>∑<sub>k=1</sub> a<sub>ik</sub>y<sub>k</sub>_**, де **_m_** - максимальний елемент вектора **_X_** = (x<sub>1</sub>, x<sub>2</sub>,.. x<sub>n</sub>). Матриця **_A_** = \[a<sub>i,j</sub>]<sub>n\*n</sub>, вектор **_X_** та вектор **_Y_** = (y<sub>1</sub>, y<sub>y</sub>,.. y<sub>n</sub>). задані (n <= 6).

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task1_Default.png "Вигляд поля при виборі даної форми, або її оновленні")

Під час введення даних в матрицю та у вектори виконується перевірка на введені дані та блокуються недопустимі символи.

За допомогою повзунка можна обрати кількість комірок в одновимірних масивах та двовимирній матриці.

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task2_Result.png "Відображення заповнених даних та виведення результату білінійного рівняння")

Після введення всіх даних та натиску клавіші "Результат" користувачу виводиться формула самого рівняння та результат отриманих обчислення.

---

## Задача №3

---

## Задача №4

---

## Задача №5

---

## Маска для текстових полів
