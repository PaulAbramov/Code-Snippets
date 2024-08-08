namespace Snippets.Helper
{
    public class CalculationHelper
    {
        #region Divide

        public static int Divide(int dividend, int divisor, bool throwError = false)
        {
            return Divide<int>(dividend, divisor, throwError);
        }

        public static long Divide(long dividend, long divisor, bool throwError = false)
        {
            return Divide<long>(dividend, divisor, throwError);
        }

        public static decimal Divide(decimal dividend, decimal divisor, bool throwError = false)
        {
            return Divide<decimal>(dividend, divisor, throwError);
        }

        public static double Divide(double dividend, double divisor, bool throwError = false)
        {
            return Divide<double>(dividend, divisor, throwError);
        }

        public static T Divide<T>(T dividend, T divisor, bool throwError = false) where T : struct
        {
            if (throwError && (dynamic)divisor == 0)
            {
                throw new DivideByZeroException();
            }

            if ((dynamic)divisor == 0)
            {
                return default(T);
            }

            return (T)Convert.ChangeType((dynamic)dividend / (dynamic)divisor, typeof(T));
        }

        #endregion Divide
    }
}
