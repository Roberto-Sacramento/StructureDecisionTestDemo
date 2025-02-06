1. Equality Assertions
Check if two values are equal.

Examples:

Assert.Equal(expected, actual); // xUnit
Assert.AreEqual(expected, actual); // NUnit, MSTest

2. Inequality Assertions
Check if two values are not equal.

Examples:

Assert.NotEqual(unexpected, actual); // xUnit
Assert.AreNotEqual(unexpected, actual); // NUnit, MSTest

3. Boolean Assertions
Check if a condition is true or false.

Examples:

Assert.True(condition); // xUnit, NUnit, MSTest
Assert.False(condition); // xUnit, NUnit, MSTest

4. Null Assertions
Check if a value is null or not null.

Examples:

Assert.Null(actual); // xUnit, NUnit, MSTest
Assert.NotNull(actual); // xUnit, NUnit, MSTest

5. Reference Equality Assertions
Check if two objects refer to the same instance.

Examples:

Assert.Same(expected, actual); // xUnit, NUnit, MSTest
Assert.NotSame(unexpected, actual); // xUnit, NUnit, MSTest

6. Type Assertions
Check if an object is of a specific type.

Examples:

Assert.IsType<ExpectedType>(actual); // xUnit
Assert.IsInstanceOfType(actual, typeof(ExpectedType)); // NUnit, MSTest

7. Collection Assertions
Check properties of collections (e.g., equality, containment).

Examples:

Assert.Contains(expectedItem, collection); // xUnit, NUnit, MSTest
Assert.DoesNotContain(unexpectedItem, collection); // xUnit, NUnit, MSTest
Assert.All(collection, item => Assert.True(condition)); // xUnit
Assert.Equal(expectedCollection, actualCollection); // xUnit

8. Exception Assertions
Check if a specific exception is thrown.

Examples:

var exception = Assert.Throws<ExpectedException>(() => codeUnderTest()); // xUnit
Assert.Throws<ExpectedException>(() => codeUnderTest()); // NUnit, MSTest

9. String Assertions
Check properties of strings (e.g., equality, containment, matching).

Examples:

Assert.StartsWith(expectedPrefix, actualString); // xUnit, NUnit, MSTest
Assert.EndsWith(expectedSuffix, actualString); // xUnit, NUnit, MSTest
Assert.Contains(expectedSubstring, actualString); // xUnit, NUnit, MSTest
Assert.Matches("regexPattern", actualString); // xUnit, NUnit

10. Numeric Assertions
Check properties of numeric values (e.g., range, comparison).

Examples:

Assert.InRange(actual, low, high); // xUnit
Assert.Greater(actual, expected); // NUnit, MSTest
Assert.Less(actual, expected); // NUnit, MSTest

11. File and Directory Assertions
Check properties of files and directories (e.g., existence).

Examples:

Assert.True(File.Exists(filePath)); // xUnit, NUnit, MSTest
Assert.True(Directory.Exists(directoryPath)); // xUnit, NUnit, MSTest

12. Custom Assertions
Create custom assertions for specific use cases.

Examples:

Assert.True(customCondition, "Custom error message"); // xUnit, NUnit, MSTest



Fact Attribute
The Fact attribute is used to denote a test method that's a simple unit test, which doesn't take any parameters. It's a way to indicate that this method should be run as a test.

Description
Usage: A method with Fact is a test that has no parameters.

Purpose: To define a single test method.

Code Example
csharp
using Xunit;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(2, 3);

        // Assert
        Assert.Equal(5, result);
    }
}

Theory Attribute
The Theory attribute is used when you want to run the same test with different sets of data. It's a way to test a method with multiple inputs.

Description
Usage: A method with Theory can take parameters.

Purpose: To define a parameterized test method.

Data Sources: Usually combined with InlineData or other data sources.

Code Example
csharp
using Xunit;

public class CalculatorTests
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(3, 3, 6)]
    [InlineData(2, 4, 6)]
    public void Add_ReturnsCorrectSum(int a, int b, int expected)
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}
InlineData Attribute
The InlineData attribute is used to provide parameter values for a Theory. Each InlineData specifies a different set of arguments for the test method.

Description
Usage: Used in conjunction with Theory to provide inline data.

Purpose: To supply the data for parameterized tests directly.

Code Example
csharp
using Xunit;

public class CalculatorTests
{
    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(3, 7, 10)]
    [InlineData(0, 0, 0)]
    public void Add_ReturnsCorrectSum(int a, int b, int expected)
    {
       // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}


Summary

Fact: Simple, parameter-less test method.

Theory: Parameterized test method with multiple inputs.

InlineData: Provides the input data for Theory methods.