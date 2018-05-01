using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using NEW.S._2018.Masarnouski._13.Matrix;

namespace Logic.Tests.Matrix
{
    [TestFixture]
    public class SymmetricTests
    {
        [Test]
        public void SymmetricMatrixTest_Create_Size_Less_1_ArgumenOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new SymmetricMatrix<int>(-1));
        }

        [Test]
        public void SymmetricalMatrixTest_ValueChange_Event_Succed()
        {
            SymmetricMatrix<int> matrix = new SymmetricMatrix<int>(3);
            matrix.ChangeValue += (object sender, ChangeElementEventArgs<int> e) => Assert.Pass($"Elemet [{e.i} {e.j}] " +
                $"value {e.OldValue} have changed on {e.NewValue}");

            matrix[1, 1] = 5;
        }

        [Test]
        public void SymmetricMatrixTest_Pass_NoSymmetricalMatrix_ArgumentException()
        {
            int[,] paramMatrix = new int[,]
            {
                { 1, 2, 1},
                { 1, 2, 3},
                { 1, 2, 3}
            };

            Assert.Throws<ArgumentException>(
                () => new SymmetricMatrix<int>(paramMatrix));
        }

        [Test]
        public void SymmetricMatrixTest_Pass_SymmetricalMatrix_Succed()
        {
            int[,] paramMatrix = new int[,]
            {
                { 3, 5, 4},
                { 5, 6, 8},
                { 4, 8, 7}
            };
            SymmetricMatrix<int> symmetricalMatrix = new SymmetricMatrix<int>(paramMatrix);

            Assert.Pass();
        }
    }
}
