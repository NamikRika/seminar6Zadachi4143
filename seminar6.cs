// // Урок 6. Двумерные массивы и рекурсия

// // Задача 41: Пользователь вводит с клавиатуры M чисел. 
// // Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 4

// Console.WriteLine("Задача 41:\n Пользователь вводит с клавиатуры M чисел.\n" + 
// "Посчитайте, сколько чисел больше 0 ввёл пользователь. \n");
// Console.WriteLine();
// Console.WriteLine("Решение:");
// Console.WriteLine();

// int AboveZero(int numberM)
// {
//     int amountNumbersAboveZero = 0;
//     int j = 1;

//     for (int i=0; i < numberM; i++)
//     {
        
//         Console.Write("Введите " + j++  + " число из заданного количества чисел ");
        
//         int tempVariable = Convert.ToInt32(Console.ReadLine());

//         if (tempVariable > 0)
//          {
//              amountNumbersAboveZero++;
//          }         

//     }
     
//     return amountNumbersAboveZero;
    
// }

// Console.Write("Задайте количетсво вводимых чисел ");
// int amountNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Количество введённых чисел равных больше ноля равно " + AboveZero(amountNumber));


// // Задача 41: Завершена ---------------------------------------------------


// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// // заданных уравнениями 
// // y = k1 * x + b1, 
// // y = k2 * x + b2; 
// // значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Задача 43:\n Напишите программу, которая найдёт точку " + 
// "пересечения двух прямых,\n" + 
// "заданных уравнениями \n" +
// "y = k1 * x + b1, \n" +
// "y = k2 * x + b2;");
// Console.WriteLine();
// Console.WriteLine("Решение:");
// Console.WriteLine();

// void PointIntersectionTwoLines(double b1, double k1, double b2, double k2) 
// {
   
//     double tempY1 = k1 - k2;    
//     double tempY2 = b2 - b1;    
//     double x1 = tempY2 / tempY1;
//     double x2 = k1 * (x1) + b1;         

//     Console.Write("Точка пересечения двух прямых при заданных значениях будет равна " +
//                                                                      "(" + x1 + ";" + x2 + ")");        

// }

//  Console.Write("Введите начальную ординату b1 ");        
//  double ordinateFirstline = Convert.ToDouble(Console.ReadLine());
//  Console.Write("Введите угловой коэффициент k1 первой прямой ");        
//  double angleInclinationFirstLine = Convert.ToDouble(Console.ReadLine());

//  Console.Write("Введите начальную ординату b2 ");        
//  double ordinateSecondline = Convert.ToDouble(Console.ReadLine());
//  Console.Write("Введите угловой коэффициент k2 второй прямой ");        
//  double angleInclinationSecondLine = Convert.ToDouble(Console.ReadLine());


// PointIntersectionTwoLines(ordinateFirstline, angleInclinationFirstLine , 
//                           ordinateSecondline, angleInclinationSecondLine);

// // Задача 43: Завершена ---------------------------------------------------