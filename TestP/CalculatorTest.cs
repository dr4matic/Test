using BClass;
using System.Security.Cryptography.X509Certificates;

namespace TestP
{
    public class CalculatorTest
    {
        private CCalculator _calculator;

        public CalculatorTest()
        {
            _calculator = new CCalculator();
        }

        [Fact]
        public void Test1()
        {
            Assert.Throws<CalculatorException>(() => _calculator.Calculate(""));
        }
        [Fact]
        public void CalculatorAddSuccess()
        {
            var result = _calculator.Calculate("10 + 2");
            Assert.Equal(12, result);
        }
        [Fact]
        public void CalculatorSubSuccess()
        {
            var result = _calculator.Calculate("10 - 2");
            Assert.Equal(8, result);
        }

    }
}