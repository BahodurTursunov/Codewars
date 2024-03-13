namespace Fundamentals_Return
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int Add(int a, int b) => a + b;
        
        public static int Multiply(int a, int b) => a * b;

        public static int Divide(int a, int b) => a / b;

        public static int Mod(int a, int b)
        {
            int result = a + b;
            return Math.Abs(result);
        }
        public static int Exponent(int a, int b) => (int)Math.Exp( a * b);

        public static int Subt(int a, int b) => a - b;
    }
}