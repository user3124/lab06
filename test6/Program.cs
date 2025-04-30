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
            // Создание случайной матрицы 3x3
            SquareMatrix matrix = new SquareMatrix(3);
            Console.WriteLine("Исходная матрица:");
            Console.WriteLine(matrix);

            // Создание цепочки обязанностей
            var sumHandler = new SumHandler();
            var transposeHandler = new TransposeHandler();
            var traceHandler = new TraceHandler();
            var diagonalHandler = new DiagonalHandler();

            sumHandler.SetNext(transposeHandler);
            transposeHandler.SetNext(traceHandler);
            traceHandler.SetNext(diagonalHandler);

            bool isRunning = true;

            try
            {
                while (isRunning)
                {
                    Console.WriteLine("Выберите операцию:");
                    Console.WriteLine("0 - Сложение матрицы с собой");
                    Console.WriteLine("1 - Транспонирование матрицы");
                    Console.WriteLine("2 - Нахождение следа матрицы (сумма диагональных элементов)");
                    Console.WriteLine("3 - Приведение матрицы к диагональному виду");
                    Console.WriteLine("4 - Выход");

                    if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || choice > 4)
                    {
                        Console.WriteLine("Неверный ввод. Попробуйте снова.");
                        continue;
                    }

                    if (choice == 4)
                    {
                        isRunning = false;
                        Console.WriteLine("Выход из программы.");
                        break;
                    }

                    // Обработка операции через цепочку обязанностей
                    sumHandler.Handle(choice, matrix);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}

