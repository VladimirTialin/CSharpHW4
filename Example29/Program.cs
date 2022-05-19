/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
//Функиця ручного ввода чисел в массив
void NewArrayOfNumber(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            array[i] = number;
        }
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    { 
        Console.Write(array[i]);
        if (i !=array.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
//Функиця автоматического ввода чисел в массив
void NewArrayOfNumberRandom(int [] array)
{
Random randomNumber = new Random();
for (int i = 0; i < array.Length; i++)
    {
        array[i] = randomNumber.Next(0,1000);
    }
    Console.Write("[");  
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i !=array.Length-1)
        {
            Console.Write(", ");
        }
       
    }
    Console.WriteLine("]");
}

int [] array = new int[8];
Console.WriteLine($"Хотите заполнить массив вручную? Напиши Да или Нет!");
string? text = Console.ReadLine();
if(text=="Да")
{
    Console.WriteLine("Введите 8 цифр: "); 
    NewArrayOfNumber(array); 
}
else
{
    NewArrayOfNumberRandom(array);
}

          
        