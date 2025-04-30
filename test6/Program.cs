using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SquareMatrix matrix = new SquareMatrix(3); // Создаем случайную матрицу 3x3
            Console.WriteLine("Исходная матрица:");
            Console.WriteLine(matrix);

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("0 - Сложение");
                Console.WriteLine("1 - Умножение");
                Console.WriteLine("2 - Транспонирование");
                Console.WriteLine("3 - Нахождение следа");
                Console.WriteLine("4 - Приведение к диагональному виду");
                Console.WriteLine("5 - Выход");

                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || choice > 6)
                {
                    Console.WriteLine("Неверный ввод. Попробуйте снова.");
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Результат сложения:");
                        Console.WriteLine(matrix + matrix);
                        break;
                    case 1:
                        Console.WriteLine("Результат умножения:");
                        Console.WriteLine(matrix * matrix);
                        break;
                    case 2:
                        Console.WriteLine("Транспонированная матрица:");
                        Console.WriteLine(matrix.GetTransposeMatrix());
                        break;
                    case 3:
                        Console.WriteLine($"След матрицы: {matrix.GetMatrixTrace()}");
                        break;
                    case 4:
                        Console.WriteLine("Диагональная матрица:");
                        Console.WriteLine(MatrixOperations.ToDiagonal(matrix));
                        break;
                    case 5:
                        isRunning = false;
                        Console.WriteLine("Выход из программы.");
                        break;
                }
            }
        }
    }
}

