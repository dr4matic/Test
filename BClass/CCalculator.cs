namespace BClass
{
    public class CCalculator : ICalculator
    {
        public decimal Calculate(string expression)
        {
            if (expression == "") 
            {
                throw new CalculatorException();
            }

            if (expression.Contains("+"))
            {
                var a = expression.Split("+").Select(decimal.Parse).Sum();
                return a;
            }

            if (expression.Contains("-"))
            {
                var a = expression.Split("+").Select(decimal.Parse).Sum();
                return a;
            }

            throw new CalculatorException();
        }
    }
}