﻿// Функция 1 типа
void Method1()
{
    Console.WriteLine("Hello, Serjio!");
}
Method1();

// Функция 2 типа
void Method2(string Name)
{
    Console.WriteLine("Иди погуляй, шаги намотай, " + Name);
}
string nameOfUser = "Serjio";
Method2(nameOfUser);

// Функция 2 типа, v2.0
void Method2_2(string Name, int num)
{
    int count = 0;
    while (num != count)
    {
        Console.WriteLine("Получите посылку, " + Name);
        count++;
    }
}
string txt = "Serjio";
Method2_2(txt, 4);