using System.Globalization;
namespace consoleApp.testForInterface
{
    public class TestClass
    {
     
        public string clr="red";
        public string Model{get;set;}
        private string color="green";
        private int _speed;
        public int Speed{get{
          return _speed;
        }
        set{
          if(value>100){
            Console.WriteLine("Error");
            _speed=0;
          }else{
            _speed=value;
          }
        }}
        protected string Year="1377";
       public TestClass()
          {
              Console.WriteLine($"color is:{color}");
          }

        public void getName(){
          Console.WriteLine("my favorite color is blue");
        }
        protected string seyHi(){
          return "Hi from TestClass";
        }
        public string Speed1{get;set;}
        
       public string getSpeed1
        {
            get { return $"Model: {Model}, Speed: {Speed1} km/h"; }
        }

        
    }
    
}