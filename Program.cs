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
int maxTask4 = Convert.ToInt32(Console.ReadLine());
while(count<3)
{
    inputNum = Convert.ToInt32(Console.ReadLine());
    if(inputNum > maxTask4) {maxTask4 = inputNum;}
    count++;
}
Console.WriteLine("Max = " + maxTask4);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Задача 6. Введите целое число: ");
int inputNumTask6 = Convert.ToInt32(Console.ReadLine());
if(inputNumTask6 % 2 == 0) {Console.WriteLine("Четное");}
else {Console.WriteLine("Не четное");}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе 
//показывает все чётные числа от 1 до N.

Console.WriteLine("Задача 8. Введите целое число: ");
int inputNumTask8 = Convert.ToInt32(Console.ReadLine()),
    step;
string result = "";

if (inputNumTask8 < 2 & inputNumTask8 > -2) 
{
    Console.WriteLine("Нет четных чисел.");
    
}
else 
{
    if (inputNumTask8 > 0)
    {
        step = 2;
        while(step <= inputNumTask8)
        {
            result += (Convert.ToString(step) + ", ");
            step += 2;
        }
    }
    else
    {
        step = -2;
        while(step >= inputNumTask8)
        {
            result += (Convert.ToString(step) + ", ");
            step -= 2;
        }
    
    }
Console.Write("Все четные числа от 0 до "+ inputNumTask8 + ": " + result);
}