using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static test6.Delegates;

namespace test6
{
    public static class MatrixExtensionMethods
    {
        // Метод транспонирования матрицы
        public static SquareMatrix GetTransposeMatrix(this SquareMatrix matrix)
        {
            SquareMatrix transposed = new SquareMatrix(matrix.Size);
            for (int row = 0; row < matrix.Size; ++row)
            {
                for (int column = 0; column < matrix.Size; ++column)
                {
                    transposed.Matrix[row, column] = matrix.Matrix[column, row];
                }
            }
            return transposed;
        }

        // Метод нахождения следа матрицы (сумма диагональных элементов)
        public static int GetMatrixTrace(this SquareMatrix matrix)
        {
            int trace = 0;
            for (int i = 0; i < matrix.Size; ++i)
            {
                trace += matrix.Matrix[i, i];
            }
            return trace;
        }
    }
}
