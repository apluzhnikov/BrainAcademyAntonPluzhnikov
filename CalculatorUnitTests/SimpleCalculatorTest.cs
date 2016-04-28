using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;


namespace CalculatorUnitTests
{
    [TestClass]
    public class SimpleCalculatorTest
    {
        SimpleCalculator _simpleCalculator;

        [TestInitialize]
        public void TestInitialize() {
            _simpleCalculator = new SimpleCalculator();
        }

        [TestMethod]
        public void Add10And2() {
            //arrange            
            double first = 10;
            double second = 2;

            //act
            var result = _simpleCalculator.Add(first, second);

            //assert
            Assert.AreEqual(12, result);

        }

        [TestMethod]
        public void Sub15And5() {
            //arrange
            double first = 15;
            double second = 5;

            //act
            var result = _simpleCalculator.Sub(first, second);

            //assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Div8By2() {
            //arrange
            double first = 8;
            double second = 2;

            //act
            var result = _simpleCalculator.Div(first, second);

            //assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Div8By0() {
            //arrange
            double first = 8;
            double second = 0;

            //act
            var result = _simpleCalculator.Div(first, second);

            //assert is exception in attribute
            //Assert.AreEqual(4, result);
        }

        [TestMethod()]
        public void MulTest() {
            Assert.IsTrue(_simpleCalculator.Mul(2, 5) == 10);
        }
    }
}
