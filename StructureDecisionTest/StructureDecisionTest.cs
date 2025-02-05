using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Structure_Decision;

namespace StructureDecision.Test.UnitTest;

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
            Assert.NotEqual(secondNumber, result);
            Assert.NotEqual(thirdNumber, result);
        }

       [Fact]
       public void CalculatedBiggestNumber_GivenThreeNumber_WhenSecondNumberIsBigger_ShouldReturnSecondNumber()
       {
        //Act
        BaseClasss baseClasss = new BaseClasss();
        int firstNumber = 5;
        int secondNumber = 10;
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
        Assert.Equal(secondNumber, result);
        Assert.NotEqual(firstNumber, result);
        Assert.NotEqual(thirdNumber, result);
       }

        [Fact]
       public void CalculatedBiggestNumber_GivenThreeNumber_WhenThirdNumberIsBigger_ShouldReturnThirdNumber()
       {
            //Act
            BaseClasss baseClasss = new BaseClasss();
            int firstNumber = 5;
            int secondNumber = 2;
            int thirdNumber = 10;
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
            Assert.Equal(thirdNumber, result);
            Assert.NotEqual(firstNumber, result);
            Assert.NotEqual(secondNumber, result);
       }
       [Fact]
       public void CalculatedBiggestNumber_GivenThreeNumber_WhenAllNumberAreEqual_ShouldReturnZero()
       {
        //Act
        BaseClasss baseClasss = new BaseClasss();
        int firstNumber = 5;
        int secondNumber = 5;
        int thirdNumber = 5;
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
        Assert.Equal(0, result);
        
       }

    }

