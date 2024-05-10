//Домашнее задание. Тема 16. Урок 1. Двумерные
//массивы.

//1.Создать двумерный массив 3х3. Заполнить его дробными числами от
//0 до 20.
//Оформить вывод на экран всех чисел.
//Добавить возможность замены значения пользователем.
//Вывод нового массива.

//Random random = new Random();
//double[,] mas = new double[3, 3];
//Console.WriteLine("Исходный массив:");
//for (int i = 0;i<3; i++)
//{
//    for(int j = 0; j < 3; j++)
//    {
//        mas[i, j] = Math.Round(random.NextDouble() * 20, 2);
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.Write("\nВведите номер строки (0-2): ");
//int row = int.Parse(Console.ReadLine());
//Console.Write("Введите номер столбца (0-2): ");
//int col = int.Parse(Console.ReadLine());
//Console.Write("Введите новое значение: ");
//double newValue = double.Parse(Console.ReadLine());

//mas[row, col] = newValue;

//Console.WriteLine("\nНовый массив:");
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}

// Создать массив символов 5х2.
//Заполнить его символами по желанию в разнобой.
//Вывести на экран понятное слово

//char[,] mas = new char[5, 2];
//mas[0, 0] = 'H';
//mas[0, 1] = 'e';
//mas[1, 0] = 'l';
//mas[1, 1] = 'l';
//mas[2, 0] = 'o';
//mas[2, 1] = ' ';
//mas[3, 0] = 'W';
//mas[3, 1] = 'o';
//mas[4, 0] = 'r';
//mas[4, 1] = 'd';
//Console.WriteLine("Полученное слово:");
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        Console.Write(mas[i, j]);
//    }
//}
//Console.WriteLine();


   