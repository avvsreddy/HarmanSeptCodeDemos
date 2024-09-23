namespace Calculator.Business.TestProject
{
    [TestClass]
    public class SimpleCalculatorUnitTest
    {
        [TestMethod]
        public void SumTest_WithValidInput_ShouldReturnsValidResult()  // Test Case
        {
            // write only plain code
            // no conditional statements
            // no looping statements
            // no try...catch...finally
            // no complex code

            // AAA
            // A - Arrange
            SimpleCalculator target = new SimpleCalculator();
            int a = 10;
            int b = 20;
            int expected = 30;
            // A - Act
            int actual = target.FindSum(a, b);
            // A - Assert
            Assert.AreEqual(expected, actual);



        }

        [TestMethod]
        public void SumTest_WithZeroInput_ShouldReturnsZeroResult()  // Test Case
        {
            // write only plain code
            // no conditional statements
            // no looping statements
            // no try...catch...finally
            // no complex code

            // AAA
            // A - Arrange
            SimpleCalculator target = new SimpleCalculator();
            int a = 0;
            int b = 0;
            int expected = 0;
            // A - Act
            int actual = target.FindSum(a, b);
            // A - Assert
            Assert.AreEqual(expected, actual);



        }

        [TestMethod]
        public void SumTest_WithNegativeInput_ShouldReturnsnegativeResult()  // Test Case
        {
            // write only plain code
            // no conditional statements
            // no looping statements
            // no try...catch...finally
            // no complex code

            // AAA
            // A - Arrange
            SimpleCalculator target = new SimpleCalculator();
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
        [DataRow(0, 0, 0)]
        [DataRow(-1, -1, -2)]
        [DataRow(0, 1, 1)]
        public void SumTest_WithAllTypeofInput_ShouldReturnsValidResult(int a, int b, int expected)  // Test Case
        {
            // write only plain code
            // no conditional statements
            // no looping statements
            // no try...catch...finally
            // no complex code

            // AAA
            // A - Arrange
            SimpleCalculator target = new SimpleCalculator();
            //int a = -1;
            //int b = -1;
            //int expected = -2;
            // A - Act
            int actual = target.FindSum(a, b);
            // A - Assert
            Assert.AreEqual(expected, actual);



        }
    }
}