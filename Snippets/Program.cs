namespace Snippets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dividend = 10;
            var divisor = 10;

            var test = Helper.CalculationHelper.Divide(dividend, divisor);

            divisor = 0;
            var test3 = Helper.CalculationHelper.Divide(dividend, divisor);
            try
            {
                var test2 = Helper.CalculationHelper.Divide(dividend, divisor, true);
            }
            catch (DivideByZeroException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}