/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
//Функиця ручного ввода чисел в массив
void NewArrayOfNumber(int [] array)
{
    try
    {
        for (int i = 0; i <= array.Length; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            array[i] = number;
            Array.Resize (ref array,array.Length+1);
        }
    } 
    catch
    {
        /* При возникновении исключения, уменьшаем длину массива на единицу.
        Исключение составляет все символы, знаким и буквы, отличные от типа данных int.
        */
        Array.Resize (ref array,array.Length-1);
    }
    finally
    {
        // Вывод массива
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

int [] array = new int[1];
Console.Write("Хотите заполнить массив вручную? Нажмите клавишу Y/N: ");
ConsoleKeyInfo press = Console.ReadKey();
if (press.Key==ConsoleKey.Y)
{
    Console.WriteLine("\nВведите любое количество цифр:\nДля завершения ввода нажмите Enter"); 
    NewArrayOfNumber(array);
}
else if (press.Key==ConsoleKey.N)
{
    Console.Write("\nВы отказались от ввода данных в массив. Я сделаю это за Вас.\nХотите самостоятельно определить размер массива? Нажмите клавишу Y/N: ");
    ConsoleKeyInfo pressSizeArray = Console.ReadKey();
    if (pressSizeArray.Key==ConsoleKey.Y)
    {
        Console.Write("\nРазмера массива = ");
        int SizeArrayRandom = Convert.ToInt32(Console.ReadLine());
        Array.Resize (ref array, SizeArrayRandom);
        NewArrayOfNumberRandom(array);
    }
    else
    {
        Console.WriteLine("\nРазмер массива создан автоматически.");
        Random randomArray = new Random();
        Array.Resize (ref array, randomArray.Next(1,15));
        NewArrayOfNumberRandom(array); 
    }
}