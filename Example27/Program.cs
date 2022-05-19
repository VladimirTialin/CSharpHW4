/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
try
{
int FindSumOfNumber (int number)
{
    int result = 0;
    for (int i =0; i <= number; i++)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}      
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number=Math.Abs(number);
int SumOfNumber = FindSumOfNumber(number);
 Console.WriteLine($"{number} - > {SumOfNumber}");
}
catch
{
Console.ForegroundColor= ConsoleColor.Red;
Console.WriteLine("Ошибка ввода! Вы ввели не числовое значение! повторите ввод.");
Console.ResetColor();  
}
 