using System;
using System.Linq;

namespace ConsoleApp1 {
    
    class Program
    {
        
        
        static void MatrixAddition(int[,] c)
        {
            Console.WriteLine("Введите матрицу размерности {0}x{1}", c.GetLength(0), c.GetLength(1));
            int[,] b = new int[c.GetLength(0), c.GetLength(1)];
            for (int i = 0; i < c.GetLength(0); )
            {
                for (int j = 0; j < c.GetLength(1);)
                {
                    if (i >= c.GetLength(0))
                    {
                        break;
                    }
                    Checks.CheckMultipleInput(b, ref i,ref j);
                }
            }
            for (int i = 0; i < c.GetLength(0);i++ )
            {
                for (int j = 0; j < c.GetLength(1);j++)
                {
                    c[i, j] += b[i, j];
                }
            }
            }
            static void MatrixSubstraction(int[,] c)
            {
            Console.WriteLine("Введите матрицу размерности {0}x{1}", c.GetLength(0), c.GetLength(1));
            int[,] b = new int[c.GetLength(0), c.GetLength(1)];
                for (int i = 0; i < c.GetLength(0); )
                {
                    for (int j = 0; j < c.GetLength(1);)
                    {
                        if (i >= c.GetLength(0))
                        {
                         break;
                        }
                        Checks.CheckMultipleInput(b, ref i, ref j);
                }
                }
                for (int i = 0; i < c.GetLength(0); i++)
                {
                    for (int j = 0; j < c.GetLength(1); j++)
                    {
                        c[i, j] -= b[i, j];
                    }

                }
            }
            static void MatrixMultiplication(int[,] c)
            {
            Console.WriteLine("Введите матрицу размерности {0}x{1}", c.GetLength(1), c.GetLength(1));
            int sum;
                int[,] b = new int[c.GetLength(1), c.GetLength(1)];
                for (int i = 0; i < c.GetLength(1); )
                {
                    for (int j = 0; j < c.GetLength(1);)
                    {
                    if (i >= c.GetLength(1))
                    {
                        break;
                    }
                    Checks.CheckMultipleInput(b, ref i, ref j);
                }
                }
                for (int i = 0; i < c.GetLength(0); i++)
                    for (int j = 0; j < c.GetLength(1); j++)
                    {
                        sum = 0;
                        for (int k = 0; k < c.GetLength(1); k++)
                        {
                            sum += c[i, k] * b[k, j];
                        }
                        c[i, j] = sum;
                    }

            }
            static void MatrixMultiplicationByNumber(int[,] c)
            {
            Console.WriteLine("Введите число, на которое нужно умножать");
            int a = Convert.ToInt32(Checks.CheckSingleInput());

                for (int i = 0; i < c.GetLength(0); i++)
                {
                    for (int j = 0; j < c.GetLength(1); j++)
                    {
                        c[i, j] *= a;
                    }

                }
            }
            static void MatrixDivisionByNumber(int[,] c)
            {
            Console.WriteLine("Введите число, на которое нужно делить !=0");
            int a = Convert.ToInt32(Checks.CheckSingleInput());
            while (a == 0)
            {
                Console.WriteLine("Введите не 0");
                a = Convert.ToInt32(Checks.CheckSingleInput());
            }
            for (int i = 0; i < c.GetLength(0); i++)
                {
                    for (int j = 0; j < c.GetLength(1); j++)
                    {
                        c[i, j] = c[i, j] / a;
                    }
                }
            }
            static void MatrixOutput(int[,] c)
            {
                for (int i = 0; i < c.GetLength(0); i++)
                {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                    Console.WriteLine();
                }
            }



            static void Main(string[] args)
            {
            Console.WriteLine("Введите количество строк");
            int n = Convert.ToInt32(Checks.CheckSingleInput());
            while (n <= 0)
            {
                Console.WriteLine("Введите правильную размерность");
                n = Convert.ToInt32(Checks.CheckSingleInput());
            }
            Console.WriteLine("Введите количество столбцов");
            int m = Convert.ToInt32(Checks.CheckSingleInput());
            while (m <= 0)
            {
                Console.WriteLine("Введите правильную размерность");
                m = Convert.ToInt32(Checks.CheckSingleInput());
            }
            int[,] x = new int[n, m];
            Console.WriteLine("Введите матрицу");
            for (int i = 0; i < n; )
                {
                    for (int j = 0; j < m; )
                    {
                        if (i >= x.GetLength(0))
                        {
                            break;
                        }
                        Checks.CheckMultipleInput(x, ref i, ref j);
                }
            }
            int a;
                while (true)
                {
                Console.WriteLine("Нажмите 1 для сложения исходной матрицы с вводимой матрицой,2 для вычитания вводимой матрицы из исходной матрицы");
                Console.WriteLine("Нажмите 3 для умножения исходной матрицы с вводимой матрицой,4 для умноженя исходной матрицы на вводимое число");
                Console.WriteLine("Нажмите 5 для деления исходной матрицы на вводимое число,6 для просмотра исходной матрицы");
                Console.WriteLine("7 для выхода из программы");
                a = Convert.ToInt32(Checks.CheckSingleInput());
                switch (a)
                {
                    case 1: MatrixAddition(x);break;
                    case 2: MatrixSubstraction(x); break;
                    case 3: MatrixMultiplication(x);break;
                    case 4: MatrixMultiplicationByNumber(x);break;
                    case 5: MatrixDivisionByNumber(x);break;
                    case 6: MatrixOutput(x);break;
                    case 7: return;
                    default:break;
                }

                }
            }
        
    }
}
