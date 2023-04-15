// Homework 2

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

/*
int SecodNumeral(int num)
{
    int hunders = num / 10 % 10;
    int result = hunders;

    return result;
}

Console.Write("input a three-digit number ");
int num = Convert.ToInt32(Console.ReadLine());
int shortnumber = SecodNumeral(num);
Console.WriteLine("the second digit of the number " + shortnumber);
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

/*
int ThirdNumeral(int num)
{
    while(num > 999)
        {
            num = num / 10;
        }
        int third = num % 10;
        return third;
}

Console.Write("input a number ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100)
    {
        Console.WriteLine("there is no third digit");
    }
else
    {
    int thirdnum = ThirdNumeral(num);
    Console.WriteLine("the third digit of the number " + thirdnum);
    }
*/

// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool Weekend(int num)
{
    if(num == 6 || num == 7)
        return true;
    else
        return false;
}

Console.Write("Input a day of the week ");
int day = Convert.ToInt32(Console.ReadLine());
bool result = Weekend(day);
if(result == true)
{
    Console.WriteLine("Weekend");
}
else
{
    Console.WriteLine("working day");
}
*/
