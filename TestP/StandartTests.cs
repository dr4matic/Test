using BClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestP
{
    [TestClass]
    public class StandartTests
    {
        private CCalculator _calculator;

        public StandartTests()
        {
            _calculator = new CCalculator();
        }

        /*[Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("10 * 2")]
        [InlineData("kapibara")]*/
        public void Test1(string expression)
        {
            Assert.Throws<CalculatorException>(() => _calculator.Calculate(expression));
        }
        /*[Fact]*/
        public void CalculatorAddSuccess()
        {
            var a = new Random();
            var b = a.Next(10, 150);
            var c = a.Next(10, 150);
            var x = b + c;
            var result = _calculator.Calculate($"{b}+{c}");
            Assert.Equal(x, result);
        }
        /*[Fact]*/
        public void CalculatorSubSuccess()
        {
            var a = new Random();
            var b = a.Next(10, 150);
            var c = a.Next(10, 150);
            var x = b - c;
            var result = _calculator.Calculate($"{b}-{c}");
            Assert.Equal(x, result);
        }

    }
}