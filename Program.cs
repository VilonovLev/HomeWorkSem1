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

int inputNum, count = 1;
Console.WriteLine("Задача 4. Введите три целых числа: ");
max = Convert.ToInt32(Console.ReadLine());
while(count<3)
{
    inputNum = Convert.ToInt32(Console.ReadLine());
    if(inputNum > max) {max = inputNum;}
    count++;
}
Console.WriteLine("Max = " + max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Задача 6. Введите целое число: ");
inputNum = Convert.ToInt32(Console.ReadLine());
if(inputNum % 2 == 0) {Console.WriteLine("Четное");}
else {Console.WriteLine("Не четное");}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе 
//показывает все чётные числа от 1 до N.

Console.WriteLine("Задача 8. Введите целое число: ");
inputNum = Convert.ToInt32(Console.ReadLine());
string result = "";

if (inputNum < 2 & inputNum > -2) 
{
    Console.WriteLine("Нет четных чисел.");
    
}
else 
{
    if (inputNum > 0)
    {
        for(int i = 2; i <= inputNum; i += 2) 
        {
            result += (Convert.ToString(i) + ", ");
        }
    }
    else
    {
    for(int i = -2; i >= inputNum; i -= 2) 
        {   
            result += (Convert.ToString(i) + ", ");
        }
    }
Console.Write("Все четные числа от 0 до "+ inputNum + ": " + result);
}