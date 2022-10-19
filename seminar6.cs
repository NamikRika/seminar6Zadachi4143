// Урок 6. Двумерные массивы и рекурсия

// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Задача 41:\n Пользователь вводит с клавиатуры M чисел.\n" + 
"Посчитайте, сколько чисел больше 0 ввёл пользователь. \n");
Console.WriteLine();
Console.WriteLine("Решение:");
Console.WriteLine();

int AboveZero(int numberM)
{
    int amountNumbersAboveZero = 0;
    int j = 1;

    for (int i=0; i < numberM; i++)
    {
        
        Console.Write("Введите " + j++  + " число из заданного количества чисел ");
        
        int tempVariable = Convert.ToInt32(Console.ReadLine());

        if (tempVariable > 0)
         {
             amountNumbersAboveZero++;
         }         

    }
     
    return amountNumbersAboveZero;
    
}

Console.Write("Задайте количетсво вводимых чисел ");
int amountNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество введённых чисел равных больше ноля равно " + AboveZero(amountNumber));





// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)