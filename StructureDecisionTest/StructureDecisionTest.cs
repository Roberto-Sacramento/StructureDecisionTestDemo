using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Structure_Decision;

namespace StructureDecision.Test.UnitTest
{
    public class StructureDecisionTest
    {
        [Fact]
        public void CalculatedBiggestNumber_GivenThreeNumber_WhenFirstNumberIsBigger_ShouldReturnFirstNumber()
        {
            //Act
            BaseClasss baseClasss = new BaseClasss();
            int firstNumber = 10;
            int secondNumber = 5;
            int thirdNumber = 2;
            int result = 0;

            //Arrange
            baseClasss.CalculateBiggestNumber(firstNumber, secondNumber, thirdNumber);
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
               result = firstNumber;
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                result = secondNumber;
            }
            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                result = thirdNumber;
            }
            else
            {
                result = 0;
            }

            //Assert
            Assert.Equal(firstNumber, result);
        }
    }
}
