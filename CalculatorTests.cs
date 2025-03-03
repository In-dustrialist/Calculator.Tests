namespace Calculator.Tests
{
    [TestFixture] 
    public class CalculatorTests
    {
        private CalculatorClass _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new CalculatorClass();
        }

        [Test]
        public void Additional_ValidInputs_ReturnsCorrectResult()
        {
            int result = _calculator.Additional(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Subtraction_ValidInputs_ReturnsCorrectResult()
        {
            int result = _calculator.Subtraction(5, 3);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Miltiplication_ValidInputs_ReturnsCorrectResult()
        {
            int result = _calculator.Miltiplication(2, 3);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Division_ValidInputs_ReturnsCorrectResult()
        {
            int result = _calculator.Division(6, 3);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Division_DivideByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Division(6, 0));
        }
    }
}
