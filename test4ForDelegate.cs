namespace consoleApp.testForInterface
{
    public class Test4ForDelegate
    {
        public delegate void Dg1(int a, int b);
        public delegate int Dg2(int a, int b);

        public static void Sum(int a, int b)
        {
            Console.WriteLine($"Sum is: {a + b}");
        }
        public static void Minus(int a, int b)
        {
            Console.WriteLine($"minus is: {a - b}");
        }
        public static void Divide(int a, int b)
        {
            Console.WriteLine($"Divide is: {a / b}");
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine($"Multiply is: {a * b}");
        }
        public static int sum1(int a, int b)
        {
           return a+b;
        }
    }
}
