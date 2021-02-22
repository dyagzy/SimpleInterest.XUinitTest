using System;
using WebApplication2.utilities;
using Xunit;

namespace XUnitTestProject1
{

    //XUnit 
    public class UnitTest1
    {
        //[Fact]
        //public void Test3(decimal principal, decimal rate, decimal time, decimal sum)
        //{

        //}



        [Theory]
        [InlineData(10000, 5, 1, 10500)]
        [InlineData(1, 5, 1, 1)]
        [InlineData(-20000, 10, 0.5, 0)]
        [InlineData(2000, 5, 1, 2050)]
        public void Test2(decimal principal, decimal rate, decimal time, decimal sum)
        {//

            //arrange
            /* the above declartions of parameters, and the inline data or test values to be tested forms the 
             ARRANGE part of the test method*/

            //Act
            var save = new Savings();
            var mySum = save.InterestCalculator(principal, rate, time);

            //Assert
            Assert.Equal(sum,mySum);
        }
    }
}
