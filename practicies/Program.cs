// // Функция 1 типа
// void Method1()
// {
//     Console.WriteLine("Hello, Serjio!");
// }
// Method1();

// // Функция 2 типа
// void Method2(string Name)
// {
//     Console.WriteLine("Иди погуляй, шаги намотай, " + Name);
// }
// string nameOfUser = "Serjio";
// Method2(nameOfUser);

// // Функция 2 типа, v2.0
// void Method2_2(string Name, int num)
// {
//     int count = 0;
//     while (num != count)
//     {
//         Console.WriteLine("Получите посылку, " + Name);
//         count++;
//     }
// }
// string txt = "Serjio";
// Method2_2(txt, 4);

// // Функция 3 типа
// int Method3(string message, int num)
// {
//     int count = 0;
//     while (num != count)
//     {
//         Console.WriteLine(message);
//         count++;
//     }
//     num = 10*num + num/2;
//     return num;
// }
// string msg = "Молодец";
// int a = Method3(msg, 4);
// Console.WriteLine(a);

// // Функция 4 типа
// int Method4()
// {
//    return DateTime.Now.Year;
// }
// int years = Method4();
// Console.WriteLine($"Текущий год, по утверждению компьютера, {years}");

// // Функция 4 типа версия 2.0
// int Method4_2(int count, string txt)
// {
//    for (int i = 0; i < count; i++) {Console.WriteLine(txt);};
//    return DateTime.Now.Year;
// }
// int years = Method4_2(3,"Это код ");
// Console.WriteLine($"Текущий год, по утверждению компьютера, {years}");

// // Вывод таблицы умножения на экран, v1.0
// Console.WriteLine(" ");
// Console.WriteLine("ТАБЛИЦА УМНОЖЕНИЯ");
// Console.WriteLine(" ");
// int i = 0;
// int j = 0;
// if (j == 0) 
// {
//     Console.WriteLine("     0   1   2   3   4   5   6   7   8   9");
//     Console.WriteLine("___________________________________________");
// }
// for(j = 0; j <= 9; j++)
// {
//     for (i = 0; i <= 9; i++)
//     {
//         if (i == 0){Console.Write($"{j}  |  ");}
//         int result = i * j;
//         Console.Write($"{result}   ");
//         if (i == 9) {Console.WriteLine(" ");}
//     }
//     i = 0;
// };

//****************************************
// РАБОТА С ТЕКСТАМИ
// Дан текст. Нужно все пробелы заменить черточками, буквы "к" - буквами "К", а буквы "с" - буквами "С".
Console.WriteLine("ПРИВЕТ!");
string text = "Однажды в студёную зимнюю пору"
            + "Лошадка пипиркой примёрзла к забору!"
            + "Она и лягалась, она и брыкалась!"
            + "Лошадка ушла, а пипирка - осталась...";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);