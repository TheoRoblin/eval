using EvaluationSampleCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.UnitTest
{
    [TestClass]
    public class MathOperationsTest
    {
        private MathOperations _mathOperations;

        [TestInitialize]
        public void Init()
        {
            _mathOperations = new MathOperations();
        }


        [TestMethod]
        [DataRow(2,1)]
        public void Substract_2Minus1_Return1(int numberOne, int numberTwo)
        {
            _mathOperations.Subtract(numberOne, numberTwo);
            Assert.AreEqual(1,_mathOperations.Subtract(numberOne, numberTwo));
        }

        [TestMethod]
        [DataRow(1,2)]
        public void Substract_1Minus2_ThrowException(int numberOne, int numberTwo)
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.Subtract(numberOne, numberTwo));
        }

        [TestMethod]
        [DataRow(1200,2)]
        [DataRow(1201,2)]
        public void Substract_NumberOneEqual1200OrHighter_ThrowException(int numberOne, int numberTwo)
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.Subtract(numberOne, numberTwo));
        }

        [TestMethod]
        [DataRow(-1)]
        public void GetColorFromOddsNumber_NumberIsNegatif_ThrowException(int number)
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.GetColorFromOddsNumber(number));
        }

        [TestMethod]
        [DataRow(0)]
        public void GetColorFromOddsNumber_NumberDividedBy2Equal0_ReturnRed(int number)
        {
            _mathOperations.GetColorFromOddsNumber(number);
            Assert.AreEqual("Red", _mathOperations.GetColorFromOddsNumber(number));
        }

        [TestMethod]
        [DataRow(1)]
        public void GetColorFromOddsNumber_NumberIsNotNegatifAndNotEqual0WhenDividedBy2_ReturnBlue(int number)
        {
            _mathOperations.GetColorFromOddsNumber(number);
            Assert.AreEqual("Blue", _mathOperations.GetColorFromOddsNumber(number));
        }

    }
}
