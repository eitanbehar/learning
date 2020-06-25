using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MatrixArrayFactory : MatrixFactory
    {
        public MatrixArrayFactory(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }

        public override IMatrix GetMatrix()
        {
            return new MatrixArray(X, Y);
        }
    }
}
