using System;
using NUnit.Framework;
using NEW.S._2018.Masarnouski._13.Matrix;

namespace Logic.Tests
{
    [TestFixture]
    public class SquareMatrixTests
    {
        [Test]
        public void Indexer_AddNewElementToMatrixTests()
        {
            SquareMatrix<int> matrix = new SquareMatrix<int>(3);
            matrix.ChangeValue += (object sender, ChangeElementEventArgs<int> e) => Assert.Pass($"Elemet [{e.i} {e.j}] " +
                $"value {e.OldValue} have changed on {e.NewValue}");

            matrix[1, 1] = 5;
        }
        [Test]
        public void SquareMatrixTest_Create_Size_Less_1_ArgumenOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new SquareMatrix<int>(-1));
        }
    }
}
