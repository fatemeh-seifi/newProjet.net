
namespace consoleApp.testForInterface
{
    public class OverLoading
    {
        public string name;
        public string family;
        public int age;
        public OverLoading(string Name,string Family,int Age){
            this.name=Name;
            this.family=Family;
            this.age=Age;
            
        }
        //OverLoading:
        public void FullInfo(){
            Console.WriteLine($"{name}");
        }
        public string FullInfo(string name,string family){
           return ($"My name is {name} My Family is {family}");
        }
    }
}