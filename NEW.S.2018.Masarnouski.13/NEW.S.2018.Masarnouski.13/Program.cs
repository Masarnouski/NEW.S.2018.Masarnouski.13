using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NEW.S._2018.Masarnouski._13.Matrix;

namespace NEW.S._2018.Masarnouski._13
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareMatrix<int> matrix = new SquareMatrix<int>(2);
            matrix.ChangeValue += (object sender, ChangeElementEventArgs<int> e) => Console.WriteLine($"Elemet [{e.i} {e.j}] " +
                $"value {e.OldValue} have changed on {e.NewValue}] Event raised by {sender.ToString()}");
            matrix[0, 0] = 1;
            matrix[0, 1] = 1;
            matrix[1, 0] = 1;
            matrix[1, 1] = 1;
            SquareMatrix<int> matrix1 = new SquareMatrix<int>(2);
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 1;
            matrix1[1, 0] = 1;
            matrix1[1, 1] = 1;
            SquareMatrix<int> resultMatrix = new SquareMatrix<int>(2);
            resultMatrix = matrix.Multiply(matrix1);
           
            
            Console.ReadLine();

        }
    }
}
