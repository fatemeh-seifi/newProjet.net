//interface
namespace consoleApp.testForInterface

{
    public interface Iproduct
    {
        string Product();
        void Product1();
    }
    public class NewProduct : Iproduct
    {
        public string Product()
        {
            return "Welcome to Page";
        }
        public void Product1()
        {
            Console.WriteLine("HI of product1");
        }
    }
}
