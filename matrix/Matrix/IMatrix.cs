using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public interface IMatrix
    {
        IMatrix Add(IMatrix matrix);
        int GetValue(int x, int y);
        void SetValue(int x, int y, int value);
        void Fill(int value);
        IMatrix GetNewMatrix();
        
        int LenghtDimension0 { get; }
        int LenghtDimension1 { get; }

    }
}
