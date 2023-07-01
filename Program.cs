// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int ReadIn (string messerge)
{
    Console.Write ( messerge);
    string InputedStr  = Console.ReadLine ();
    int number = Convert. ToInt32 (ItputedStr);
    return number;
}
bool check (int number)
{
    if (100<= number && number  <=1000  )
    { 
        return true;
    }
    Concole.WriteLine ("Число не трехзначное");
    return false;
}

int num;
int num = ReadIn ("Введите трехзначное число");
if (check(num))
{
    int secondDigit = num % 20;
}
Console.WriteLine ("Последняя цифра числа" + num + " равна " + secondDigit);
