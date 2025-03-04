using Calculator;

namespace Tests;

public class CachedCalculatorTest
{
    [Test]
    public void Add()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 2;
        var b = 3;

        // Act
        var result = calc.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    
    public void Subtract()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 2;
        var b = 1;

        // Act
        var result = calc.Subtract(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }
    
    public void Multiply()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 10;
        var b = 2;

        // Act
        var result = calc.Multiply(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }
    
    public void Divide()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 4;
        var b = 2;

        // Act
        var result = calc.Divide(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    public void Factorial_ThrowsArgumentException()
    {
        // Arrange
        var calc = new CachedCalculator();
        var n = -1;
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => calc.Factorial(n));
    }
    
    [Test]
    public void Factorial_Returns1()
    {
        // Arrange
        var calc = new CachedCalculator();
        var n = 0;
        
        // Act
        var result = calc.Factorial(n);
        
        // Assert
        Assert.That(result, Is.EqualTo(1));
    }
    
    [Test]
    public void Factorial_ReturnsFactorial()
    {
        // Arrange
        var calc = new CachedCalculator();
        var n = 5;
        
        // Act
        var result = calc.Factorial(n);
        
        // Assert
        Assert.That(result, Is.EqualTo(120));
    }
    
    [Test]
    public void IsPrime_LessThan2()
    {
        // Arrange
        var calc = new CachedCalculator();
        var cand = 1;
        
        // Act
        var result = calc.IsPrime(cand);
        
        // Assert
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void IsPrime_ReturnsTrue()
    {
        // Arrange
        var calc = new CachedCalculator();
        var cand = 7;
        
        // Act
        var result = calc.IsPrime(cand);
        
        // Assert
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void IsPrime_ReturnsFalse()
    {
        // Arrange
        var calc = new CachedCalculator();
        var cand = 10;
        
        // Act
        var result = calc.IsPrime(cand);
        
        // Assert
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void CanRetrieveCachedData()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 2;
        var b = 3;

        // Act
        calc.Add(a, b);
        var result = calc.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
}