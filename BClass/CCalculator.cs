namespace BClass
{
    public class CCalculator : ICalculator
    {
        public decimal Calculate(string expression)
        {
            throw new NotImplementedException();
        }
    }

    public class CalculatorException : Exception
    {

    }
}