using consoleApp.testForInterface;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Test1 test = new Test1(21, "fatemeh", true);
            test.printData("Student");
            NewProduct test2 = new NewProduct();
            Console.WriteLine(test2.Product());
            test2.Product1();
            Test3 sum = new Test3(1, 9);
            Console.WriteLine(sum.Sum());
            Number numbers = Number.nim1;
            Console.WriteLine((int)numbers);
             // while 
            int num=5;
            while (num>0)
            {
                Console.WriteLine(num);
                    num--;
            }
            Console.WriteLine("عملیات به پایان رسید" );
            string? action;
            //do/while
            do
            {
                Console.Write("Enter first number: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter action (sum, minus, multiply, divide,exit)");
                action = Console.ReadLine()?.ToLower();

                // delegate
                Test4ForDelegate.Dg1 dg1 = new Test4ForDelegate.Dg1(Test4ForDelegate.Sum);
                Test4ForDelegate.Dg2 dg2 = new Test4ForDelegate.Dg2(Test4ForDelegate.sum1);
                // Console.WriteLine(dg2(a,b));
                // dg1 += Test4ForDelegate.Minus;
                // dg1 += Test4ForDelegate.Multiply;
                // dg1 += Test4ForDelegate.Divide;
                // dg1 -= Test4ForDelegate.Divide;
                // dg1(a, b);

                // switch
                switch (action)
                {
                    case "sum":
                        dg1 = Test4ForDelegate.Sum;
                        break;
                    case "minus":
                        dg1 = Test4ForDelegate.Minus;
                        break;
                    case "multiply":
                        dg1 = Test4ForDelegate.Multiply;
                        break;
                    case "divide":
                        dg1 = Test4ForDelegate.Divide;
                        break;
                    case "exit":
                        Console.WriteLine("Program exited.");
                        break;
                    default:
                        Console.WriteLine("Invalid action");
                        continue;
                }

                // if/else
                if (dg1 != null && action != "exit")
                {
                    dg1(a, b);
                }
                else if (action != "exit")
                {
                    Console.WriteLine("No valid action selected.");
                }

            } while (action != "exit");
           
        }
    }
}
