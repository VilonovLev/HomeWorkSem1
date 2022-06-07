// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.WriteLine("Задача 2. Введите два целых числа: ");
int numFirst = Convert.ToInt32(Console.ReadLine()),
    numSecond = Convert.ToInt32(Console.ReadLine());
int min,max;
    if (numFirst > numSecond)
    {
        max = numFirst; min = numSecond;
    }
    else
    {
        min = numFirst; max = numSecond;
    }
Console.WriteLine("Max = "+ max + "\n" + "Min = " + min);

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int num;
Console.WriteLine("Задача 4. Введите три целых числа: ");
for(int i = 0; i < 3; ++i)
{
    if(i == 0) { max = Convert.ToInt32(Console.ReadLine()); continue; }
    num = Convert.ToInt32(Console.ReadLine());
    max = Math.Max(max,num);
}
Console.WriteLine("Max = " + max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Задача 6. Введите целое число: ");
num = Convert.ToInt32(Console.ReadLine());
string evenOrNo = num % 2 == 0 ? "Четное" : "Не четное";
Console.WriteLine(evenOrNo);

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе 
//показывает все чётные числа от 1 до N.

Console.WriteLine("Задача 8. Введите целое число: ");
num = Convert.ToInt32(Console.ReadLine());
string result = "";

if (num < 2 & num > -2) 
{
    Console.WriteLine("Нет четных чисел.");
    
}
else 
{
    if (num > 0)
    {
        for(int i = 2; i <= num; i += 2) 
        {
            result += (Convert.ToString(i) + ", ");
        }
    }
    else
    {
    for(int i = -2; i >= num; i -= 2) 
        {   
            result += (Convert.ToString(i) + ", ");
        }
    }
Console.Write("Все четные числа от 0 до "+ num + ": " + result);
}