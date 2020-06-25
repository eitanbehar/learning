using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    abstract class MatrixBase : IMatrix
    {
        public IMatrix Add(IMatrix matrix)
        {
            var resultMatrix = matrix.GetNewMatrix();
            Parallel.For(0, matrix.LenghtDimension0, (i) =>
            {
                Parallel.For(0, matrix.LenghtDimension1, (j) =>
                {
                    resultMatrix.SetValue(i, j, GetValue(i, j) + matrix.GetValue(i, j));
                });
            });
            return resultMatrix;
        }

        public void Fill(int value)
        {
            Parallel.For(0, LenghtDimension0, (i) =>
            {
                Parallel.For(0, LenghtDimension1, (j) =>
                {
                    SetValue(i, j, value);
                });
            });
            
        }

        public abstract IMatrix GetNewMatrix();


        public abstract int GetValue(int x, int y);


        public abstract int LenghtDimension0 { get; }

        public abstract int LenghtDimension1 { get; }

        public abstract void SetValue(int x, int y, int value);

    }
}
