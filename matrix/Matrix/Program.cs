using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            var matrix1 = new MatrixArray(5, 5);
            matrix1.Fill(10);

            var matrix2 = new MatrixList(5, 5);
            matrix2.Fill(20);

            var newMatrix = matrix1.Add(matrix2); 

        }
    }
}
