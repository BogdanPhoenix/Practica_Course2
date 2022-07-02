# Практична робота за другий курс

## Меню

### Опис

Дане вікно можна розділити на три частини: меню (зліва), панель для взаємодії (зверху) та панель в якій будуть виводитися форма вибраного пункту меню.

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

### Опис

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

### Опис

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task2_Default.png "Вигляд поля при виборі даної форми, або її оновленні")

Під час введення даних в матрицю та у вектори виконується перевірка на введені дані та блокуються недопустимі символи.

За допомогою повзунка можна обрати кількість комірок в одновимірних масивах та двовимирній матриці.

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task2_Result.png "Відображення заповнених даних та виведення результату білінійного рівняння")

Після введення всіх даних та натиску клавіші "Результат" користувачу виводиться формула самого рівняння та результат отриманих обчислення.

---

## Задача №3

### Умова

1. Скласти програму обчислення значень функцій і вивести їх результат у вигляді таблиці.

2. Дослідити способами математичного аналізу поведінку функції свого варіанту при заданих значеннях аргументу. При наявності особливих випадків передбачити в програмі відповідний захист.

3. Для тригонометричних функцій включити значення **_x_**, кратне числу **_π_**.

4. Вивести на екран графіки функції за допомогою підпрограми-процедури.

**Функції до табулювання**

|         Функція №1          |            Функція №2             |              Функція №3              |        Функція №4        |      Функція №5       |        Функція №6         |        Функція №7        |
| :-------------------------: | :-------------------------------: | :----------------------------------: | :----------------------: | :-------------------: | :-----------------------: | :----------------------: |
| $$ 1 \over x^2 (1 - x^4) $$ | $$ x^2 \over \sqrt[3]{1 + x^3} $$ | $$ 1 \over \sqrt[3]{1 - sin^3(x)} $$ | $$ 1 \over x^2e^{x^2} $$ | $$ 1 \over ch^2(x) $$ | $$ x \over ln^2(x - 1) $$ | $$ 1 \over ch(cos(x)) $$ |

### Опис

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task3_Default.png "Вигляд поля при виборі даної форми, або її оновленні")

При виборі третього пункту перед користувачем з'являється форма з трьома текстовими полями та однією кнопкою для отримання результату. В дані текстові поля можна ввести дані, межі відрізка (**_x<sub>min</sub>_** та **_x<sub>max</sub>_**) та крок (**_h_**), з яким буде здійснювати автоматичне отримання даних для заповнення таблиці.

Для кожного текстового поля встановлено спеціальну маску, яка обмежує введення символів, які заборонено вводити та виводить повідомлення коли було введено максимальну кількість символів.

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task3_ResultForm.png 'Вигляд поля при натиску на кнопку "Результат"')

Після заповнення всіх текстових полів та натиску на кнопку "Результат" здійснюється обчислення даних для кожної з функцій та отриманий результат заноситься у відповідну комірку. Після обчислення дані в таблиці змінити самостійно - не можливо.

Також після отримання результату з'являється кнопка (справа від таблиці), яка дозволяє відкрити графік вибраної форми. Вибрана форма знаходиться в салатовому квадраті, щоб вибрати якусь іншу форму потрібно натиснути на неї.

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task3_ResultGraph1.png "Вигляд поля при відкритті поля з відображенням графіку першої функції")

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task3_ResultGraph2.png "Вигляд поля при відкритті поля з відображенням графіку шостої функції")

Після відображення бокового поля перед користувачем з'явиться графік вибраної функції.

### **Метод для обчислення результату та заповнення таблиці даних**

В даному методі, який розташований у файлі [FormTaskThree.cs](/Practice/FormTaskThree.cs) відбувається обчислення даних в таблиці.

**Етапи виконання даного методу**

1. Здійснюється приховування надпису, який інформує про відсутність даних, та відображення таблиці з майбутніми даними.
2. Очищення попередніх даних, якщо вони були присутні до цього.
3. Отримання меж відрізка (**_x<sub>min</sub>_** та **_x<sub>max</sub>_**) та їхнього кроку (**_h_**), які заносяться у відповідні змінні `min, max, step`.
4. Отримання кількості розрядів числа, які будуть використувуватися для заокруглення кінцевого результату (змінна `dig`).
5. Отримання крайнього лівого значення числа **$\pi$**, яке може зустрітися на даному проміжку. Якщо даний результат дорівнює нулю то в змінні `pi` присвоюється `0,25`, що буде слугувати першим числом **$\pi$**.
6. Після отримання всіх даних відбувається обчислення значень для кожної функції. Виконується перевірка чи поточний аргумент є рівним числу **$\pi$** помножене на відповідний коефіціент. Якщо дане твердження є істинним, то відбувається заповнення лише тих комірок, які відповідають тригонометричним функціям, для всіх інших ставляться прочерки `"-"`. Також здійснюється збільшення коефіцієнта на `0,25`. що відображає наступне загальновживане число **$\pi$**. Якщо дане число не є одним із варіантів числа **$\pi$**, то виконується обчислення для всіх функцій із заданим аргументом.
7. Після завершення заповнення даних викликається метод _`CreateGraph`_ - для побудови графіків (_опис читати нижче_).
8. Відбуваєтья відображення кнопки, яка відкриває бокове меню з графіком, якщо вона до цього була скрита.

```c#
/// <param name="sender">Об'єкт кнопки</param>
/// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
private void ButtonResult_Click(object sender, EventArgs e)
{
    labelInfo.Visible = false;
    tableLayoutPanelFunction.Visible = true;
    dataResult.Rows.Clear();
    double min = Convert.ToDouble(minX.Text);
    double max = Convert.ToDouble(maxX.Text);
    double step = Convert.ToDouble(stepX.Text);
    int dig = stepX.Text.Length - stepX.Text.IndexOf(',') - 1;
    double pi = min == 0 ? 0.25 : Math.Ceiling(min / Math.PI);
    for (double i = min; i <= max; i += step)
    {
        i = Math.Round(i, dig);
        if (i != 0 && Math.Round(pi * Math.PI, dig) == i)
        {
            dataResult.Rows.Add($"{pi}π", "-", "-", FunctionThree(pi * Math.PI), "-", FunctionFive(pi * Math.PI), "-", FunctionSeven(pi * Math.PI));
            pi += 0.25;
            i -= step;
            if (pi == 0)
            {
                pi += 0.25;
            }
        }
        else
        {
            dataResult.Rows.Add(i, FunctionOne(i), FunctionTwo(i), FunctionThree(i), FunctionFour(i), FunctionFive(i), FunctionSix(i), FunctionSeven(i));
        }
    }
    CreateGraph(buttonFunction1, new EventArgs());
    if (panelRight.Width == 1)
    {
        panelRight.Width = closeWidthPanelRight;
    }
}
```

### **Метод для створення графіка функції, які залежить від від вибраної функції**

В даному методі, який розташований у файлі [FormTaskThree.cs](/Practice/FormTaskThree.cs) відбувається побудова графіку для вибраної функції.

**Етапи виконання даного методу**

1. Відбувається перевірка чи було побудовано графік до цього. Якщо так, то попередній графік колір фону стає за замовчуванням і текст спливаючої підказки також стає за стандартом.
2. Відбувається присвоєння натиснутої кнопки до змінної, яка відповідає для запам'ятовування попередньо активованої функції.
3. Колір фону замінюється на салатовий і текст спливаючої підказки змінюється на: `'Побудовано графік даної функції'`.
4. Отримання кількості розрядів числа, які будуть використувуватися для заокруглення кінцевого результату (змінна `dig`).
5. Відбувається очищення поля для виведення графіків, щоб можна було побудувати новий графік.
6. Отримання номеру графіку та запам'ятовування його у змінну `index`.
7. Після отримання номеру графіка відбувається вибір відповідної функції, яка буде будувати його. (_Опис функцій наведено нижче_).

```c#
/// <param name="sender">Об'єкт кнопки</param>
/// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
private void CreateGraph(object sender, EventArgs e)
{
    if (currentFunction != null)
    {
        currentFunction.BackColor = Color.Transparent;
        bunifuToolTip.SetToolTip(currentFunction, "Натисніть, щоб побудувати графік функції");
    }
    currentFunction = (BunifuImageButton)sender;
    currentFunction.BackColor = Color.FromArgb(102, 204, 51);
    bunifuToolTip.SetToolTip(currentFunction, "Побудовано графік даної функції");

    int dig = stepX.Text.Length - stepX.Text.IndexOf(',') - 1;
    for (int i = 0; i < chart.Series.Count; ++i)
    {
        chart.Series[i].Points.Clear();
    }
    int index = Convert.ToInt32(((BunifuImageButton)sender).Tag.ToString());
    switch (index)
    {
        case 1: GraphOne(dig); break;
        case 2: GraphTwo(dig); break;
        case 3: GraphThree(dig); break;
        case 4: GraphFour(dig); break;
        case 5: GraphFive(dig); break;
        case 6: GraphSix(dig); break;
        case 7: GraphSeven(dig); break;
    }
}
```

### **Метод для побудови графіка**

Методи для побудови графіків майже є однаковими, але відрізняються ОДЗ. Опис буде здійснюватися для методу, який будує графік першої функції.

Створюється дві змінні, `series` - необхідний для тогоЮ щоб вказати компілятору яку пряму використовувати (необхідний для того, щоб на графіку будувалися розрили) та `buffer` в яку поміщується результат конвертації даних з комірки таблиці в дробове число.

Під час кожного разу перевіряється чи значення функції в точці аргументу не дорівнює прочерку. Якщо в даній комірці розташований прочерк `"-"`, то точка не будується. Якщо в комірці розташоване якесь число то продовжується отримання аргументу з таблиці та перевірка цього аргументу на ОДЗ, яке дає змогу визначити яку лінію будувати.

Якщо рівняння є тригонометричним (метод GraphThree), то також виконується перевірка на те, чи аргумент відповідає числу **$\pi$** та після перевірки та отримання істинного результат виконується числове обчислення числа **$\pi$** (метод GetPi).

```c#
/// <summary> Метод для побудови графіка до формули №1 </summary>
/// <param name="dig">Кількість знаків після коми</param>
private void GraphOne(int dig)
{
    int series;
    double buffer;
    for (int i = 0; i < dataResult.RowCount; ++i)
    {
        if (!dataResult.Rows[i].Cells[1].Value.Equals("-"))
        {
            buffer = Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[0].Value.ToString()), dig);
            if (buffer < -1)
            {
                series = 0;
            }
            else if (buffer < 0)
            {
                series = 1;
            }
            else if (buffer < 1)
            {
                series = 2;
            }
            else
            {
                series = 3;
            }
            chart.Series[series].Points.AddXY(buffer, Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[1].Value), dig));
        }
    }
}
/// <summary> Метод для побудови графіка до формули №3 </summary>
/// <param name="dig">Кількість знаків після коми</param>
private void GraphThree(int dig)
{
    double buffer;
    for (int i = 0; i < dataResult.RowCount; ++i)
    {
        if (!dataResult.Rows[i].Cells[3].Value.Equals("-"))
        {
            if (dataResult.Rows[i].Cells[0].Value.ToString().EndsWith("π"))
            {
                buffer = GetPi(dataResult.Rows[i].Cells[0].Value.ToString(), dig);
            }
             else
            {
                buffer = Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[0].Value.ToString()), dig);
            }

            chart.Series[0].Points.AddXY(buffer, Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[3].Value), dig));
        }
    }
}

```

---

## Задача №4

### Умова задачи

Дано файл _F_, компоненти _u<sub>0</sub>,u<sub>1</sub>,...,u<sub>n</sub>_ якого є послідовними числами Фібоначчі. Одержати у файлі _F_ послідовні числа Фібоначчі _u<sub>0</sub>,u<sub>1</sub>,...,u<sub>n + 1</sub>_

### Опис

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task4_Default.png "Вигляд поля при виборі даної форми, або її оновленні")

При виборі четвертого пункту перед користувачем з'являється форма з наступних елементів:

- поле для введення та відображеня файлу, з якого будуть імпортуватися далі. Дане поле може приймати файли з розширенням `.txt, .docx, та .xlsx`.
- спосіб заповнення даних таблиці, щоб обчислення здійснювалися від нуля до того числа, яке є меншим або рівним числу введеним у відповідне поле, другий варіант передбачає вивести ряд Фібоначчі до вказаного номера.
- поле в яке вводяться число, присутній захист від всіх символів, окрім цифр.
- кнопка обчислення для побудови ряду Фібоначчі.
- текстове поле, яке інформує, що обчислення іще не були проведені.

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task4_CreateMaxValue.png "Заповнення таблиці числами Фібоначчі за максимальним значенням")

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task4_CreateMaxNumber.png "Заповнення таблиці числами Фібоначчі до вказаного номера")

Приклад побудови ряду Фібоначчі за максимальнм значенням або за номером. Даний ряд будується зліва направо та зверху вниз. Також при змінні розміру вікна відбувається або зжимання або розтягування таблиці даних, яка адаптується до розмірів вікна.

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task4_ImportFile.png "Запозичення даних з файлу")

Щоб імпортувати дані з файлу потрібно ввести у відповідне текстове меню шлях до файлу і натиснути кнопку справа (_синя стрілка донизу_) що дозволить отримати дані з файлу або не вводити шлях до файлу, а відразу натиснути на кнопку завантаження, тоді на екрані з'явиться відповідне поле для завантаження файлу.

Після занесення даних у ряд Фібоначчі відбувається перевірка за трьома пунктами:

- присутність чисел, які не входять у ряд Фібоначчі (_червоний колір_);
- присутність елементів, які повторюються (_жовтий колір_);
- перевірка чи всі елементі розташовані в правильному порядку.

Після отримання даних (_метод `ImageButtonDownload_Click` наведений нижче_) максимальний елемент, який знаходився у файлі заноситься у відповідне поле.

Якщо у файлі були якісь сторонні символи або невдалося зчитати число, то даний елемент пропускається і програма продовжує роботу.

Якщо було знайдено відповідну помилку то на екрані з'явиться кнопка на таблицею (_справа_), яка буде відповідати за те, щоб виправити ряд Фібоначчі та присутні в ньому помилки.

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task4_RemoveExcess.png "Видалення числе, які не входять в ряд Фібоначчі")

Вище наведено приклад Фібоначчі після того, як користувач натиснув на відповідну кнопку (_білий хрестик в червоному колі_), після чого з ряду було видалено всі елементи, які не входять у ряд Фібоначчі.

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task4_DeleteDuplicate.png "Видалення дублікатів з таблиці")

Вище наведено приклад ряду Фібоначчі після того, як користувач натиснув на відповідну кнопку (_жовтий знак оклику в шестерні_), після чого з ряду було видалено всі елементи, які повторювалися. В ряді Фібоначчі може бути присутньо дві одиницю, тому на фото перші дві одиниці не позначено, а позначена лише третя.

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task4_Sort.png "Сортування таблиці")

Вище наведенно приклад вже відсортованого ряду Фібоначчі, де всі елементи стоять на своєму місці. Сортування відбувається тих даних, які було імпортовано із файлу, а не записаного нового ряду Фібоначчі.

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task4_Export.png "Збереження даних у файл")

Вище наведено вікно для збереження даних у файл. Для того, щоб відкрити вікно для збереження потрібно натиснути відповідну кнопку (_зелена стрілка вгору_). В даному вікні можна зберегти дані в наступні формати файлів:

- `.txt` можливо лише у форматі списку, також можливо додати нумерацію елементів;
- `.docx`
  - список, можлива нумерація;
  - таблиця, нумерація відсутня;
- `.xlsx` нумераці відсутня
  - список
  - таблиця

Після вибору типу файлу можна буде вручну ввести або вибрати за допомогою відповідного поля файл для збереження. Після вибору файлу можна натиснути кнопку "Зберегти"

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task4_Search.png "Поле для пошуку елемента в ряді фібоначчі")

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task4_SearchResult.png "Отримання значення з ряду Фібоначчі за вказаним номером")

Вище наведенно поле, яке допомагає знайти елемент за вказаним номером елемента, який ввів користувач. Якщо користувач ввів номер, який відповідає за пусту клітинку, то виведеться відповідне повідомлення. Також в даній формі стоїть обмеження про можливість ввести максимальний номер елемента, щоб він не був більший за кількість комірок таблиці.

### **Метод для створення та заповнення таблиці імпортованими або згенерованими даними**

Даний метод розташований у файлі [FormTaskFour.cs](/Practice/FormTaskFour.cs), та дозволяє відображати дані ряду Фібоначчі в таблиці при побудові ряду з нуля, при змінні розміру програми, при імпортуванні даних, при виправленні помилок.

**Етапи виконання даного методу**

1. Сперш за все при виклику даного метода відбувається перевірка поля, в яке вводяться дані про максимальне значення ряду Фібоначчі або номер ряду, все залежить від вибраного варіанту побудови ряду. Якщо поле є пустим, то виводиться відповідне повідомлення.
2. Якщо поле не є пустим, то відбувається очищення таблиці, якщо вона до цього була заповнена та виконується її відображення.
3. Відбувається обчислення максимальної кількості стовпчиків для таблиці при даних розмірах програми.
4. Створення стовпчиків, присвоюючи їм відповідне ім'я, відсутність можливості редагувати дані та відсутність можливості змінювати розмір колонок.
5. Обчислення кількості рядків таблиці.
6. Заповнення комірок таблиці даними з масиву Фібоначчі за допомогою метода [GetFibonachi](/Practice/FormTaskFour.cs), який просто розбиває один масив на декілька менших.
7. Виконується перевірка чи всі дані були вміщенні в таблицію, якщо ні, то створюється іще один рядок і заповнюється рештою даних.
8. Виконання перевірок самого ряду за допомогою методів `CheckEqualsError, CheckEqualsWarning та CheckEqualsDuplication` (_опис наведено нижче_).
9. Виведення графічного відображення тих елементів, які не входять у ряд Фібоначчі або повторюються в ньому.
10. Перевірка чи всі помилки виправлені, якщо так, то кнопка пошуку стає активною.

```c#
/// <param name="dictionary">Колекцію з координатами та значеннями ряду</param>
private void DataResultPrint(Dictionary<int, decimal> dictionary)
{
    if (textBoxMaxNumber.Text.Length != 0)
    {
        dataResults.Columns.Clear();
        labelErrorData.Height = 0;
        imageButtonSearch.Visible = imageButtonCreate.Visible = dataResults.Visible = true;

        int max = dataResults.Width / widthColumn;
        for (int i = 0; i < max; i++)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
            {
                HeaderText = $"Column{i}",
                Name = $"Column{i}",
                ReadOnly = true,
                Resizable = DataGridViewTriState.False
            };
            dataResults.Columns.Add(column);
        }

        int rows = dictionary.Count / dataResults.ColumnCount;
        for (int i = 0; i < rows; i++)
        {
            dataResults.Rows.Add(GetFibonachi(dictionary, dataResults.ColumnCount, dataResults.ColumnCount * i, dataResults.ColumnCount * i + dataResults.ColumnCount));

        }
        if (rows * dataResults.ColumnCount < dictionary.Count)
        {
            dataResults.Rows.Add(GetFibonachi(dictionary, dictionary.Count - rows * dataResults.ColumnCount, dataResults.ColumnCount * rows, dictionary.Count));
        }
        CheckEqualsError();
        CheckEqualsWarning();
        CheckEqualsDuplication();
        if (duplicatError.Count > 0)
        {
            UpdateData(duplicatError, Color.Orange);
        }
        if (extraError.Count > 0)
        {
            UpdateData(extraError, Color.Red);
        }
        formSerch.IsSearch = !buttonError.Visible && !buttonWarning.Visible && !buttonDuplication.Visible;
    }
    else
    {
        labelErrorData.Height = 200;
        imageButtonSearch.Visible = imageButtonCreate.Visible = dataResults.Visible = false;
    }
}
```

### **Метод для пошуку значень, які не входять в ряд Фібоначчі**

Даний метод розташований у файлі [FormTaskFour.cs](/Practice/FormTaskFour.cs), та дозволяє отримати словник даних, де `Key` виступає індекс в ряду Фібоначчі, а з `Value` відповідне значення за індексом. Даний спосіб запам'ятовування необхідний для пошуку тих елементів, які не входять в ряд Фібоначчі, тому що пошук здійснюється за `Value`, а індекс потрібний для того, якщо користувач захоче виконати виправлення інших помилок, тому індекси можуть змінитися, а видалення елементів за індексом.

**Етапи виконання даного методу**

1. Очищення словника, в який зберігаються даних про елемент.
2. Створення словника з правильним рядом Фібоначчі.
3. Перевірка елементів, які невходять в ряд Фібоначчі, та занесення їхніх даних у відповідний словник.
4. Відображення кнопки, яка викликає метод `DeleteErrorOrDuplication`, який необхідний для видалення зайвих елементів.
5. Виведення повідомлення про те, скільки було виявлено помилок.

```c#
private void CheckEqualsError()
{
    extraError.Clear();
    Dictionary<int, decimal> trueResult = FibonachiNumbers();
    foreach (var item in fibonachi)
    {
        if (!trueResult.ContainsValue(item.Value))
        {
            extraError.Add(item.Key, item.Value);
        }
    }

    buttonError.Visible = extraError.Count > 0;
    buttonError.ToolTipText = $"Виявлено дані, які не входять в ряд Фібоначі. ({extraError.Count})";
}
```

### **Метод для перевірки чи в таблиці знаходяться дублікати чи ні**

Даний метод розташований у файлі [FormTaskFour.cs](/Practice/FormTaskFour.cs), та дозволяє отримати словник даних, де `Key` виступає індекс в ряду Фібоначчі, а з `Value` відповідне значення за індексом. Даний спосіб запам'ятовування необхідний для пошуку тих елементів, які повторюються декілька разів.

**Етапи виконання даного методу**

1. Очищення словника, в який зберігається дані про елементи.
2. Отримання даних з основного словника, але в новому словнику відсутні будь-які дублікати.
3. Здійснення ітерації по основному словнику та перевірка чи присутній в ньому даний індекс. Якщо ні, то виконується наступна умова.
4. Перевірка на те, чи дане значення для даного ключа дорівнює `одиниці` і чи її менше ніж `2`. Якщо значення хибне, виконується продовження циклу, інакше інденк та значення елементу додаються в словник.
5. Відображення кнопки, яка викликає метод `DeleteErrorOrDuplication`, який необхідний для видалення зайвих елементів.
6. Виведення повідомлення про те, скільки було виявлено помилок.

```c#
private void CheckEqualsDuplication()
{
    duplicatError.Clear();
    int indexOne = 0;
    var result = fibonachi.GroupBy(kvp => kvp.Value).ToDictionary(grp => grp.First().Key, grp => grp.Key);
    foreach (var item in fibonachi)
    {
        if (!result.ContainsKey(item.Key))
        {
            if (item.Value == 1 && indexOne++ < 1)
            {
                continue;
            }
            duplicatError.Add(item.Key, item.Value);
        }
    }
    buttonDuplication.Visible = duplicatError.Count > 0;
    buttonDuplication.ToolTipText = $"Виявлено дані, які повторюються. ({duplicatError.Count})";
}
```

### **Метод для перевірки чи значення в таблиці стоять в правильному порядку чи ні**

Метод, який потрібний, щоб визначити чи всі елементи розташовані в правильному порядку чи ні. Виконується сортування в буферний словний та виконується перевірка за допомогою метода `EqualsDictionary`, який просто виконує порівняння кожного із елементів двох словників. Якщо словник не рівні, то кнопка для сортування ствє активною.

```c#
private void CheckEqualsWarning()
{
    int index = 0;
    var sortedDict = from entry in fibonachi orderby entry.Value ascending select entry;
    Dictionary<int, decimal> buffer = sortedDict.ToDictionary(entry => index++, entry => entry.Value);
    buttonWarning.Visible = !EqualsDictionary(fibonachi, buffer);
}
```

### **Метод для сортування даних в таблиці**

**Етапи виконання даного методу**

1. Створення впорядкованої послідовності в якій всі дані є відсортованими.
2. Переписування основного словника таким чином, щоб в нього всі елементи знаходилися в порядку зростянна та присвоювання їм нових індексів.
3. Зміна індексів тим елементам, які повторюються або потрібно видалити.
4. Виведення отриманого результату.
5. Приховування відповідної кнопки.

```c#
/// <param name="sender">Об'єкт кнопки</param>
/// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
private void ButtonSort_Click(object sender, EventArgs e)
{
    int index = 0;
    var sortedDict = from entry in fibonachi orderby entry.Value ascending select entry;
    fibonachi = sortedDict.ToDictionary(entry => index++, entry => entry.Value);
    extraError = extraError.ToDictionary(entry => entry.Key, entry => fibonachi.FirstOrDefault(x => x.Value == entry.Key).Value);
    duplicatError = duplicatError.ToDictionary(entry => entry.Key, entry => fibonachi.FirstOrDefault(x => x.Value == entry.Key).Value);
    DataResultPrint(fibonachi);
    buttonWarning.Visible = false;
}
```

### **Метод для видаленння елементів в таблиці, які викликають помилки**

**Етапи виконання даного методу**

1. Видалення тих елементів, які порушують ряд Фібоначчі за індексами.
2. Перезаписування елементам, ті що залишилися, нових індексів.
3. Виведення отриманого результату.
4. Приховування відповідної кнопки.

```c#
/// <param name="sender">Об'єкт кнопки</param>
/// <param name="dictionary">Колекція даних для видалення</param>
private void DeleteErrorOrDuplication(object sender, Dictionary<int, decimal> dictionary)
{
    int index = 0;
    foreach (var item in dictionary)
    {
        fibonachi.Remove(item.Key);
    }
    fibonachi = fibonachi.ToDictionary(entry => index++, entry => entry.Value);
    dictionary = dictionary.ToDictionary(entry => entry.Key, entry => fibonachi.FirstOrDefault(x => x.Value == entry.Key).Value);
    DataResultPrint(fibonachi);
    ((BunifuImageButton)sender).Visible = false;
}
```

### **Метод для імпорту даних з файлу**

**Етапи виконання даного методу**

1. Перевірка чи було введено шлях до файлу.
2. Оновлення форми для пошуку. Скидання всіх полів.
3. Перевірка чи таблиця даних не пуста. Якщо значення істинна, то відбувається очищення даних.
4. Відповідно до розширення файлу відбувається імпорт даних. Імпорт даних наведений у файлах: [TXTDocument.cs](/Practice/InteractionFile/TXTDocument.cs), [WordDocument.cs](/Practice/InteractionFile/WordDocument.cs), [ExcelDocument.cs](/Practice/InteractionFile/ExcelDocument.cs). Якщо розширення файлу відсутнє в умовному операторі то виводиться відповідне повідомлення та метод припиняє роботу.
5. Якщо розширення файлу знаходиться в умовному операторі, то після отримання даних для цього файлу здійснюється ряду Фібоначчі та таблиці з результатом.
6. Здійснюється пошук максимального елемента у файлі, та результат присвоюється у відповідне поле.
7. Варіант побудови становиться "за максимальним значенням".
8. Виведення результату на екран.

```c#
/// <param name="sender">Об'єкт кнопки</param>
/// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
private void ImageButtonDownload_Click(object sender, EventArgs e)
{
    try
    {
        if (textBoxPathFile.Text.Length == 0)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPathFile.Text = openFileDialog.FileName;
            }
            else
            {
                MessageBox.Show("Ви не обрали файл з даними. Введіть шлях до файлу вручну або виберіть його через спеціальну форму, щоб продовжити імпорт.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        formSerch.UpdateForm();
        int index = 0, indexNumber;
        string number;
        if (dataTable != null)
        {
            dataTable.Clear();
        }
        switch (Path.GetExtension(textBoxPathFile.Text))
        {
            case ".txt": dataTable = TXTDocument.ImportTXTFile(textBoxPathFile.Text); break;
            case ".docx": dataTable = WordDocument.ImportWordFile(textBoxPathFile.Text); break;
            case ".xlsx": dataTable = ExcelDocument.ImportExcelFile(textBoxPathFile.Text); break;
            default: MessageBox.Show("Вибраний вами файл має розширення, з яким не працює програма.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
        }
        fibonachi.Clear();
        foreach (DataRow row in dataTable.Rows)
        {
            for (int i = 0; i < row.ItemArray.Length; ++i)
            {
                number = row[i].ToString();
                indexNumber = number.LastIndexOf(": ");
                number = indexNumber > 0 ? number.Substring(indexNumber + 2) : number;
                if (decimal.TryParse(number, out decimal buffer))
                {
                    fibonachi.Add(index++, Convert.ToDecimal(number));
                }
            }
        }
        textBoxMaxNumber.Text = fibonachi.Values.Max().ToString();
        radioButtonMaxValue.Checked = true;
        DataResultPrint(fibonachi);
    }
    catch (IOException ex)
    {
        MessageBox.Show($"Під час отримання даних із файлу сталася помилка. \nТекст помилки: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Під час отримання даних сталася помилка. \nТекст помилки: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
```

---

## Задача №5

### Умова задачи

Дана дійсна прямокуна матриця _A = \[a<sub>ij</sub>\]<sub>m\*n</sub>_. Побудувати програму, що має головний модуль та підпрограми перестановки сатриці без зменшення кількості позитивних елементів стовпців.

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task5_AutoCreate.png "Заповнення даних автоматично")

При виборі п'ятого пункту перед користувачем з'являється форма з наступних елементів:

- Повзунець, який дозволяє вибрати розмір квадратної матриці. Максимально можливий розміру залежить від розміру вікна і відображається справа.
- Варіант вибору заповнення даних.
  - При автоматичному варіанті виконання заповнення відбувається, при виборі розміру матриці. Змінити дані в комірках неможливо.
  - При ручному режимі дозволяється редагування даних таблиці.
- Кнопка активації сортування за вище поставленим завданям.
- Кнопки (_справа_) пошуку позитианих (_кнопка з плюсом_) та негативних (_кнопка з мінусом_) чисел у двох таблиціях та графічному відображенні.
- Дві таблиці, одна до, а інша після сортування. Заповнити можна лише ліву.

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task5_Sort.png "Сортування даних згідно завдання")

Вище наведено результат виконання сортування за поставленою задачею.

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task5_NegativeNumbers.png "Відображення лише негативнийх чисел")

![](https://github.com/BogdanPhoenix/Practica_Course2/raw/master/Images/Task5_PositiveNumbers.png "Відображення лише позитивних чисел")

Відображення негативних (_зелений_) та позитивних (_помаранчевий_) чисел у двох таблиція, що дозволяє переглянути правельність виконання завдання.

### **Метод для визначення максимальної кількості стовпчиків та рядків таблиць в залежності від розмірів вікна**

**Етапи виконання даного методу**

1. Визначення максимально можливої кількості стовпчикі певного розміру (`widthColumn = 100`), які можуть вміститися в дані таблиці при даному розміру форми.
2. Виведення на екран максимально можливої кількості стовпчиків таблиць.
3. Якщо поточне значення кількості стовпчиків більше за максимальне, то воно змінюється на максимальне та виводиться на екран, після чого відбувається оновлення повзунка.
4. Якщо твердження хибне, то максимально можливому розміру повзунка присвоюється максимально можливе значення стовпчиків.

```c#
private void MaxCountColumn()
{
    try
    {
        maxCountColumn = dataResults.Width / widthColumn;
        sizeMatrixMax.Text = maxCountColumn.ToString();
        if (sizeMatrix.Value > maxCountColumn)
        {
            sizeMatrix.Value = maxCountColumn;
            sizeMatrixNow.Text = sizeMatrix.Value.ToString();
            UpdateScroll();
        }
        sizeMatrix.Maximum = maxCountColumn;
    }
    catch { }
}
```

### **Метод для сортування введених даних та виведення відсортованої таблиці**

**Етапи виконання методу `Sort`**

1. Зчитування даних з таблиці.
2. Виклик метода `SortArray` та передача в нього масиву для сортування.
3. Виведення в іншу таблицю відсортованих даних.

```c#
private void Sort()
{
    double[] buffer = new double[sizeMatrix.Value * sizeMatrix.Value];
    int count = 0;
    for(int i = 0; i < sizeMatrix.Value; ++i)
    {
        for(int j = 0; j < sizeMatrix.Value; ++j)
        {
            buffer[count++] = A[i, j];
        }
    }
    SortArray(buffer);
    count = 0;
    for(int i = 0; i < dataSortResults.RowCount; ++i)
    {
        for(int j = 0; j < dataSortResults.ColumnCount; ++j)
        {
             dataSortResults.Rows[i].Cells[j].Value = buffer[count++];
        }
    }
}
```

### **Метод для сортування масиву**

**Етапи виконання методу `SortArray`**

1. Ініціалізація змінних для запам'ятовування значення на індексу найменшого елемента.
2. Виконання сортування масиву _методом вибору_.
   1. Присвоїти змінній індексу та буферу дані про поточний елемент.
   2. Виконати перебір елементів масиву від наступного до закінчення масиву.
   3. Якщо даний елемент є меншим нуля або більший рівний йому і поточний елемент є менший за попередній, то виконується заміна даних про поточний елемент.
   4. Виконання перестановки даних.

```c#
/// <param name="array">Масив, який потрібно відсортувати</param>
private void SortArray(double[] array)
{
    double buffer;
    int min;

    for (int i = 0; i < array.Length; ++i)
    {
        min = i;
        buffer = array[i];
        for (int j = i + 1; j < array.Length; ++j)
        {
            if ((array[i] < 0 || array[j] >= 0) && array[j] < buffer)
            {
                min = j;
                buffer = array[j];
            }
        }
        array[min] = array[i];
        array[i] = buffer;
    }
}
```
