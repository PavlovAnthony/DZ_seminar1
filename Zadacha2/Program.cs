//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
int i = 1;
double num1;
double num2;
num1 = f();
i++;
num2 = f();
double maximal = Math.Max(num1, num2);
Console.WriteLine("max = " + maximal);

//проверка, вводится ли число
double f()
{
    Console.WriteLine("Введите " + Convert.ToInt16(i) + "-е число:");
    string x = Console.ReadLine();
    double num;
    bool isNum = double.TryParse(x, out num);
    if (isNum == false)
    {
        Console.WriteLine("Это не число!");
        Environment.Exit(0);
    }

    return num;
}