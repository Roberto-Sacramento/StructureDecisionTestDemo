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

