using BClass;

internal class Program
{
    private static void Main(string[] args)
    {
        var read = Console.ReadLine();

        var a = new CCalculator();

        Console.WriteLine(a.Calculate(read));
    }
}