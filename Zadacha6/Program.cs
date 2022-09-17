//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

//проверить, является ли число четным

Console.WriteLine("введите целое число");
Console.WriteLine( f());
string f()
{
    string str = Console.ReadLine();
    string message;
    int num;
    bool isNum = int.TryParse(str, out num);
    if (isNum)
    {
        if (num % 2 == 1)

            message=("число нечетное");
        else
            message=("Число четное");
    }
    else
    {
        message=("Это не число, либо оно не целое");
    }
    return message;
}
