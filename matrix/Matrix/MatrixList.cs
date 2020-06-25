using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MatrixList : MatrixBase
    {
        private List<int[]> _matrix;

        public MatrixList(int x, int y)
        {
            _matrix = new List<int[]>();
            for (int i = 0; i < x; i++)
                _matrix.Add(new int[y]);
        }

        public override int GetValue(int x, int y)
        {
            return _matrix[x][y];
        }

        public override void SetValue(int x, int y, int value)
        {
            _matrix[x][y] = value;
        }

        public override IMatrix GetNewMatrix()
        {
            return new MatrixList(LenghtDimension0, LenghtDimension1);
        }

        public override int LenghtDimension0
        {
            get
            {
                return _matrix.Count;
            }
        }

        public override int LenghtDimension1
        {
            get
            {
                return _matrix[0].Length;
            }
        }

    }
}
