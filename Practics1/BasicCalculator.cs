
namespace Practics1
{
    public class BasicCalculator
    {
        public double Calculate(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num2 != 0 ? num1 / num2 : double.NaN;
                default:
                    throw new InvalidOperationException("Invalid operation");
            }
        }
    }

}
