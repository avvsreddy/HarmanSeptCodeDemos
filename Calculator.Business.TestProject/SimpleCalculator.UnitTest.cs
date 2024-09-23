using Moq;
namespace Calculator.Business.TestProject
{

    //class MockCalculatorRepo : ICalculatorRepo
    //{
    //    public void Save(string s)
    //    {
    //        //
    //    }
    //}


    [TestClass]

    public class SimpleCalculatorUnitTest
    {
        SimpleCalculator target = null;
        Mock<ICalculatorRepo> mock = null;

        [TestInitialize]
        public void Init()
        {
            mock = new Mock<ICalculatorRepo>();
            mock.Setup(m => m.Save($"{1} + {1} = {1 + 1}"));
            target = new SimpleCalculator(mock.Object);
            //target = new SimpleCalculator(new CalculatorRepo());
        }


        [TestCleanup]
        public void CleanUp()
        {
            target = null;
        }

        [TestMethod]
        public void SumTest_WithValidInput_ShouldReturnsValidResult()  // Positive Test Case
        {
            // write only plain code
            // no conditional statements
            // no looping statements
            // no try...catch...finally
            // no complex code

            // AAA
            // A - Arrange
            //SimpleCalculator target = new SimpleCalculator();
            //int a = 10;
            //int b = 20;
            //int expected = 30;
            // A - Act
            int actual = target.FindSum(1, 1);
            // A - Assert
            Assert.AreEqual(1 + 1, actual);



        }

        [TestMethod]
        [ExpectedException(typeof(ZeroInputException))]
        public void SumTest_WithZeroInput_ShouldThrowsExp()  // Negative Test Case
        {
            // write only plain code
            // no conditional statements
            // no looping statements
            // no try...catch...finally
            // no complex code

            // AAA
            // A - Arrange
            //SimpleCalculator target = new SimpleCalculator();
            int a = 0;
            int b = 0;
            //int expected = 0;
            // A - Act
            int actual = target.FindSum(a, b);
            // A - Assert
            //Assert.AreEqual(expected, actual);



        }

        [TestMethod]
        [Ignore]
        public void SumTest_WithNegativeInput_ShouldReturnsnegativeResult()  // Test Case
        {
            // write only plain code
            // no conditional statements
            // no looping statements
            // no try...catch...finally
            // no complex code

            // AAA
            // A - Arrange
            //SimpleCalculator target = new SimpleCalculator();
            int a = -1;
            int b = -1;
            int expected = -2;
            // A - Act
            int actual = target.FindSum(a, b);
            // A - Assert
            Assert.AreEqual(expected, actual);



        }

        [TestMethod]
        [DataRow(1, 1, 2)]
        //[DataRow(0, 0, 0)]
        //[DataRow(-1, -1, -2)]
        //[DataRow(0, 1, 1)]
        public void SumTest_WithAllTypeofInput_ShouldReturnsValidResult(int a, int b, int expected)  // Test Case
        {
            // write only plain code
            // no conditional statements
            // no looping statements
            // no try...catch...finally
            // no complex code

            // AAA
            // A - Arrange
            //SimpleCalculator target = new SimpleCalculator();
            //int a = -1;
            //int b = -1;
            //int expected = -2;
            // A - Act
            int actual = target.FindSum(a, b);
            // A - Assert
            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        //[Ignore]
        [ExpectedException(typeof(NegativeInputException))]
        public void SumTest_WithNegativeInput_ThrowsExp()
        {
            //SimpleCalculator target = new SimpleCalculator();
            target.FindSum(-1, -1);
        }



        [TestMethod]
        public void SubtractTest_WithValidInput_ShouldReturnValidResult()
        {
            int actual = target.Subtract(10, 10);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ZeroInputException))]
        public void SubtractTest_WithZeroInput_ShouldThrowsExp()
        {
            int actual = target.Subtract(0, 0);
        }
        [TestMethod]
        //[ExpectedException(typeof(ZeroInputException))]
        public void SubtractTest_WithValidInput_ShouldCallSaveMethod()
        {
            int actual = target.Subtract(10, 10);
            mock.Verify(m => m.Save($"{10} - {10} = {10 - 10}"), Times.AtLeastOnce);
        }

    }
}