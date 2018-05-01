using System;
using NUnit.Framework;
using NEW.S._2018.Masarnouski._13.Matrix;

namespace Logic.Tests.Matrix
{
    class DiagonalMatrixTests
    {
        [Test]
        public void DioganalMatrixTest_Create_Size_Less_1_ArgumenOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new DioganalMatrix<int>(-1));
        }

        [Test]
        public void DioganalMatrixTest_ValueChange_Event_Succed()
        {
            DioganalMatrix<int> matrix = new DioganalMatrix<int>(3);
            matrix.ChangeValue += (object sender, ChangeElementEventArgs<int> e) => Assert.Pass($"Elemet [{e.i} {e.j}] " +
                $"value {e.OldValue} have changed on {e.NewValue}");

            matrix[1, 1] = 5;
        }

        [Test]
        public void DioganalMatrixTest_Pass_On_No_Dioganal_IndexOutOfRangeException()
        {
            DioganalMatrix<int> dioganalMatrix = new DioganalMatrix<int>(5);
            Assert.Throws<IndexOutOfRangeException>(
                () => dioganalMatrix[0, 1] = 1);
        }

        [Test]
        public void DioganalMatrixTest_Pass_On_Dioganal_Succed()
        {
            DioganalMatrix<int> dioganalMatrix = new DioganalMatrix<int>(5);
            dioganalMatrix[0, 0] = 1;
            Assert.Pass();
        }
    }
}
