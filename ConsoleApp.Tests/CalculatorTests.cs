using Xunit;
using ConsoleApp;

namespace ConsoleApp.Tests
{
 public class CalculatorTests
 {
 [Fact]
 public void Sum_ReturnsCorrectResult()
 {
 // Arrange
 var calculator = new Calculator();
 float a =5;
 float b =3;
 // Act
 var result = calculator.Sum(a, b);
 // Assert
 Assert.Equal(8, result);
 }

 [Fact]
 public void Subtract_ReturnsCorrectResult()
 {
 // Arrange
 var calculator = new Calculator();
 float a =5;
 float b =3;
 // Act
 var result = calculator.Subtract(a, b);
 // Assert
 Assert.Equal(2, result);
 }

 [Fact]
 public void Multiply_ReturnsCorrectResult()
 {
 // Arrange
 var calculator = new Calculator();
 float a =5;
 float b =3;
 // Act
 var result = calculator.Multiply(a, b);
 // Assert
 Assert.Equal(15, result);
 }

 [Fact]
 public void Divide_ReturnsCorrectResult()
 {
 // Arrange
 var calculator = new Calculator();
 float a =6;
 float b =3;
 // Act
 var result = calculator.Divide(a, b);
 // Assert
 Assert.Equal(2, result);
 }

 [Fact]
 public void Divide_ByZero_ThrowsException()
 {
 // Arrange
 var calculator = new Calculator();
 float a =6;
 float b =0;
 // Act & Assert
 Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b));
 }
 }
}
