//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
//максимальное число из 3

int i = 1;
double num1;
double num2;
double num3;
num1 = f();
i++;
num2 = f();
i++;
num3 = f();
double maximal = Math.Max(Math.Max(num1, num2), num3);
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