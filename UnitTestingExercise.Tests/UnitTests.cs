using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(4, 7, 8, 19)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var test = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            var actual = test.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);


        }

        [Theory]
        [InlineData(6,6,0)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test2 = new Calculator();
            //Act

            var actual  = test2.Subtract(minuend, subtrhend);
            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5,3,0)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            var test3 = new Calculator();
            //Act

            var actual = test3.Multiply(num1, num2);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(12,6,2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange

            var test4 = new Calculator();
            //Act
            var actual = test4.Divide(num1, num2);
            //Assert

            Assert.Equal(expected, actual);

        }

    }
}
