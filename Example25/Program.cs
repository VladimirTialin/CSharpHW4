/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int NewPow (int arg1, int arg2)
{
   int  result = arg1;
    for (int i = 1; i < 5; i++)
    {
        arg1=result*arg1;
    }
    return arg1; 
}
try
{
Console.WriteLine("Введите числа: ");
int numberOne =Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor= ConsoleColor.DarkGreen;
Console.WriteLine($"В какую степень будем вводить число {numberOne} ?");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();
int ResultPow = NewPow(numberOne, numberTwo);
Console.WriteLine();
Console.WriteLine($"{numberOne}, {numberTwo} -> {ResultPow}");
}
catch
{
Console.ForegroundColor= ConsoleColor.Red;
Console.WriteLine("Ошибка ввода! Вы ввели не числовое значение! повторите ввод.");
Console.ResetColor();  
}