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
            //  while 
            // int num=5;
            // while (num>0)
            // {
            //     Console.WriteLine(num);
            //         num--;
            // }
            // Console.WriteLine("عملیات به پایان رسید" );
            // string? action;
            // // do/while
            // do
            // {
            //     Console.Write("Enter first number: ");
            //     int a = Convert.ToInt32(Console.ReadLine());

            //     Console.Write("Enter second number: ");
            //     int b = Convert.ToInt32(Console.ReadLine());

            //     Console.Write("Enter action (sum, minus, multiply, divide,exit)");
            //     action = Console.ReadLine()?.ToLower();

            //     // delegate
            //     Test4ForDelegate.Dg1 dg1 = new Test4ForDelegate.Dg1(Test4ForDelegate.Sum);
            //     Test4ForDelegate.Dg2 dg2 = new Test4ForDelegate.Dg2(Test4ForDelegate.sum1);
            //     // Console.WriteLine(dg2(a,b));
            //     // dg1 += Test4ForDelegate.Minus;
            //     // dg1 += Test4ForDelegate.Multiply;
            //     // dg1 += Test4ForDelegate.Divide;
            //     // dg1 -= Test4ForDelegate.Divide;
            //     // dg1(a, b);

            //     // switch
            //     switch (action)
            //     {
            //         case "sum":
            //             dg1 = Test4ForDelegate.Sum;
            //             break;
            //         case "minus":
            //             dg1 = Test4ForDelegate.Minus;
            //             break;
            //         case "multiply":
            //             dg1 = Test4ForDelegate.Multiply;
            //             break;
            //         case "divide":
            //             dg1 = Test4ForDelegate.Divide;
            //             break;
            //         case "exit":
            //             Console.WriteLine("Program exited.");
            //             break;
            //         default:
            //             Console.WriteLine("Invalid action");
            //             continue;
            //     }

            //     // if/else
            //     if (dg1 != null && action != "exit")
            //     {
            //         dg1(a, b);
            //     }
            //     else if (action != "exit")
            //     {
            //         Console.WriteLine("No valid action selected.");
            //     }

            // } while (action != "exit");
           
        OverLoading m1=new OverLoading("Eli","seifi",21);
        TestClass m2=new TestClass();
        ChildTestClass m3=new ChildTestClass();
        // testCalss1 m4=new testCalss1();
        m1.FullInfo();
        m2.getName();
        m3.getData();
       Console.WriteLine(m1.FullInfo("fatemeh","seifi"));
       TestClass testt1=new TestClass();
       testt1.getName();
       //MyClass. Methos Name()/Field Name in static
        Console.WriteLine(testCalss1.Sum(100,1)); 
        //Property
        testt1.Speed=500;
        Console.WriteLine(testt1.Speed);
        //Generic
        List<int> number=new List<int>();
        number.Add(10);
        number.Add(20);
        number.Add(30);
        number.Add(40);
        number.Add(50);
        foreach (int item in number)
        {
            // Console.WriteLine(item);
        }
        
        // Console.WriteLine(testt1.getSpeed(50));
        testt1.Model="Benz"; 
        testt1.Speed1="100";
        Console.WriteLine(testt1.getSpeed1);
        var obj = new TestClass(); 
        Console.WriteLine(obj);
        MyClass1 ts=new MyClass1();
        //partial
        // Console.WriteLine(ts.sum(5,500));
        // Console.WriteLine(ts.minus(5,500));
        Ts1 testCat=new Ts1();
        Logger Logger=new Logger();
        testCat.getDataForCar();
        Logger.Log("HIIII WELCOME To This Page");
        // ts.Log("slam");
        // Logg getData1=Logg.GetLogger();
        // Logg getData2=Logg.GetLogger();
        // Logg getData3=Logg.Instance;
        Logg getData3=Logg.Instance;
        Logg getData4=Logg.Instance;
      User getData5 = new User.Builder()
        .SetName("Elly")
        .SetLastName("seyfi")
        .SetAddress("...")
        .Build();
        Console.WriteLine(getData5.name + " "+ getData5.lastName+" " + getData5.Adrress);
        // Console.WriteLine(getData1.GetHashCode());
        // Console.WriteLine(getData2.GetHashCode());
        Console.WriteLine(getData3.GetHashCode());
        Console.WriteLine(getData4.GetHashCode());
        } 
            
    }
}
