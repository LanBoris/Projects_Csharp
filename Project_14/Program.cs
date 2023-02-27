// Таблица со строковыми данными
// string [,] table = new string[2,5];
// table[0,0]   table[0,1]    table[0,2]    table[0,3]    table[0,4]
// table[1,0]   table[1,1]    table[1,2]    table[1,3]    table[1,4]    

// for (int rows=0; rows<2; rows++)
// {
//   for (int colums = 0; colums < 5; colums++)
//   {
//     Console.Write($"привет ");
//   }
//   Console.WriteLine();
// }


// ____________________________________________________________
// int[,] matrix = new int[3, 4];
// for (int i = 0; i < 3; i++)
// {
//   for (int j = 0; j < 4; j++)
//   {
//     Console.Write($"{matrix[i, j]} ");
//   }
//   Console.WriteLine();
// }

// ___________________________________________________________________
// void PrintArray(int[,] matr)
// {
//   for (int i = 0; i < matr.GetLength(0); i++)
//   {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//       Console.Write($"{matr[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }

// void FillArray(int[,] matr)
// {
//   for (int i = 0; i < matr.GetLength(0); i++)
//   {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//       matr[i,j]=new Random().Next(1,10);
//     }
//   }
// }

// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// PrintArray(matrix);


// ______________________________________________________________________
// int[,] pic = new int[23, 25];
// // сама таблица с 0 и 1 есть в презентации
// void PrintImage(int[,] image)
// {
//   for (int i = 0; i < image.GetLength(0); i++)
//   {
//     for (int j = 0; j < image.GetLength(1); j++)
//     {
//       // Console.Write($"{image[i, j]} ");
//       if (image[i, j] == 0) Console.WriteLine($" ");
//       else Console.WriteLine($"+");
//     }
//     Console.WriteLine();
//   }
// }

// void FillImage(int row, int col)
// {
//   if (pic[row, col] == 0)
//   {
//     pic[row, col] = 1;
//     FillImage(row - 1, col);
//     FillImage(row, col - 1);
//     FillImage(row + 1, col);
//     FillImage(row, col + 1);
//   }
// }

// PrintImage(pic);
// FillImage(13, 13);
// PrintImage(pic);

// ____________________________________________________________________
// Рекурсия при нахождении факториала.
// double Factorial(int n)
// {
//   if (n == 1) return 1;
//   else return n * Factorial(n - 1);
// }

// for (int i=1; i<40; i++)
// {
//   Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// ______________________________________________________________________
// Рекурсия при нахождении чисел Фибоначи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1)+f(n-2)

// double Fibonacci(int n)
// {
//   if (n==1 || n==2) return 1;
//   else return Fibonacci(n-1)+Fibonacci(n-2);
// }

// for (int i=1; i<50; i++)
// {
//   Console.WriteLine($"f{i} = {Fibonacci(i)}");
// }

