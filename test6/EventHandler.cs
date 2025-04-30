using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test6
{
    public abstract class EventHandler 
    {
        protected EventHandler NextHandler { get; set; }

        public void SetNext(EventHandler nextHandler)
        {
            NextHandler = nextHandler;
        }

        public virtual void Handle(int operation, SquareMatrix matrix)
        {
            if (NextHandler != null)
                NextHandler.Handle(operation, matrix);
            else
                Console.WriteLine("Операция не поддерживается.");
        }
    }

    public class SumHandler : EventHandler
    {
        public override void Handle(int operation, SquareMatrix matrix)
        {
            if (operation == 0)
            {
                Console.WriteLine("Результат сложения:");
                Console.WriteLine(matrix + matrix);
            }
            else
            {
                base.Handle(operation, matrix);
            }
        }
    }

    public class TransposeHandler : EventHandler
    {
        public override void Handle(int operation, SquareMatrix matrix)
        {
            if (operation == 1)
            {
                Console.WriteLine("Транспонированная матрица:");
                Console.WriteLine(matrix.GetTransposedMatrix());
            }
            else
            {
                base.Handle(operation, matrix);
            }
        }
    }

    public class TraceHandler : EventHandler
    {
        public override void Handle(int operation, SquareMatrix matrix)
        {
            if (operation == 2)
            {
                Console.WriteLine($"След матрицы: {matrix.GetMatrixTrace()}");
            }
            else
            {
                base.Handle(operation, matrix);
            }
        }
    }

    public class DiagonalHandler : EventHandler
    {
        public override void Handle(int operation, SquareMatrix matrix)
        {
            if (operation == 3)
            {
                Console.WriteLine("Диагональная матрица:");
                Console.WriteLine(MatrixOperations.ToDiagonal(matrix));
            }
            else
            {
                base.Handle(operation, matrix);
            }
        }
    }
}
