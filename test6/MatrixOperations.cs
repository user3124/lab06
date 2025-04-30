using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test6
{
    public class MatrixOperations
    {
        public delegate SquareMatrix DiagonalDelegate(SquareMatrix matrix);

        public static DiagonalDelegate ToDiagonal = delegate (SquareMatrix inputMatrix)
        {
            SquareMatrix diagonal = new SquareMatrix(inputMatrix.Size, 0, 0);

            for (int diagonalIndex = 0; diagonalIndex < inputMatrix.Size; ++diagonalIndex)
            {
                diagonal.Matrix[diagonalIndex, diagonalIndex] = inputMatrix.Matrix[diagonalIndex, diagonalIndex];
            }

            return diagonal;
        };
    }
}
