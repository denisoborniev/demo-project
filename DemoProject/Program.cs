namespace DemoProject
{
    public class Program
    {
        private static void Main(string[] args)
        {
        }

        public static int CalculateSum(int a = int.MinValue, int b = int.MinValue)
        {
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentException("Both parameters 'a' and 'b' must be provided.");
            }

            return a + b;
        }


        public int CalculateFactorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("Number must be non-negative.");

            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

        private static int CalculateStringLength(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("The input string cannot be null or empty.");
            }

            return input.Length;
        }

    }
}