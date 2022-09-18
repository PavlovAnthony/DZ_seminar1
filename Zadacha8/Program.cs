//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8
int f()
{
    bool Flag = false;
    string str;
    int num = 0;
    while (!Flag)
    {
        Console.WriteLine("введите целое число больще > 2");
        str = Console.ReadLine();
        bool isNum = int.TryParse(str, out num);
        if (isNum == false)
        {
            Console.WriteLine("Это не число либо оно не целое, введите число >2");
            Flag = false;
            continue;
        }
        if (num < 2)
        {
            Console.WriteLine("в заданном диапазоне нет четных чисел, введите число >2");
            Flag = false;
        }

        else Flag = true;
    }
    return num;
}


int num1 = f();
int i = 0;
int count = 2;
int[] array = new int[num1 / 2];
Console.Write("все чётные числа от 1 до " + num1 + " : ");
while (count <= num1)
{
    array[i] = count;

    count = count + 2;
    i++;
}
Console.WriteLine("[{0}]", string.Join(", ", array));




