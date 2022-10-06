using CalculatorFinalTask;

namespace CalculatorTests
{
    public class Tests
    {
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(200, 20) == 220);
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue() 
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(100, 50) == 50);
        }

        [Test]
        public void Miltiplication_MustReturnCorrectValue() 
        {
            var calculator = new Calculator();
            Assert.That(calculator.Miltiplication(4, 9) == 36);
        }

        [Test]
        public void Division_MustReturnCorrectValue() 
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(50, 25) == 2);
        }
    }
}