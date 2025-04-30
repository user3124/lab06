using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static test6.Delegates;

namespace test6
{
    public class MatrixOperations
    {
        public static DiagonalDelegate ToDiagonal = delegate (SquareMatrix inputMatrix)
        {
            SquareMatrix diagonal = new SquareMatrix(inputMatrix.Size);

            for (int diagonalIndex = 0; diagonalIndex < inputMatrix.Size; ++diagonalIndex)
            {
                diagonal.Matrix[diagonalIndex, diagonalIndex] = inputMatrix.Matrix[diagonalIndex, diagonalIndex];
            }

            return diagonal;
        };
    }
}
