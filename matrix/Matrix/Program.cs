using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main()
        {

            MatrixFactory sourceMatrixFactory = null; // don't know yet which matrix to use
            MatrixFactory targetMatrixFactory = null;

            Console.Write("Select source matrix: '1' for Matrix Array, else for Matrix List... ");
            if (Console.ReadLine() == "1")
            {
                sourceMatrixFactory = new MatrixArrayFactory(10, 10);
                targetMatrixFactory = new MatrixListFactory(10, 10);
            }
            else
            {
                sourceMatrixFactory = new MatrixListFactory(10, 10);
                targetMatrixFactory = new MatrixArrayFactory(10, 10);
            }

            var sourceMatrix = sourceMatrixFactory.GetMatrix();
            var targetMatrix = targetMatrixFactory.GetMatrix();

            sourceMatrix.Fill(10);
            targetMatrix.Fill(30);

            var newMatrix = sourceMatrix.Add(targetMatrix);

        }
    }
}
