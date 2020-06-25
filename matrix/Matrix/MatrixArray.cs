using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MatrixArray : MatrixBase
    {
        private readonly int[,] _matrix;

        public MatrixArray(int x, int y)
        {
            _matrix = new int[x, y];
        }

        public override int GetValue(int x, int y)
        {
            return _matrix[x, y];
        }
        public override void SetValue(int x, int y, int value)
        {
            _matrix[x, y] = value;
        }
        
        public override IMatrix GetNewMatrix()
        {
            return new MatrixArray(LenghtDimension0, LenghtDimension1);
        }

        public override int LenghtDimension0 { 
            get {
                return _matrix.GetLength(0);
            }  
        }

        public override int LenghtDimension1
        {
            get
            {
                return _matrix.GetLength(0);
            }
        }

    }
}
