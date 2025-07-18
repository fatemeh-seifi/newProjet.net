using System.Collections.Immutable;
using System.Globalization;
namespace consoleApp.testForInterface
{
    public class User
    {
        public string name;
        public string lastName;
        public string Adrress;
      //این خصوصی باید باش واس اینک دسترسی نداشه باشه
        private User(){}
        //کلاس داخلی 
        public class Builder{
        private User Person=new User();
        public Builder SetName(string name){
            Person.name=name;
            return this;
        }
        public Builder SetLastName(string lastName){
            Person.lastName=lastName;
            return this;
        }
        public Builder SetAddress(string Adrress){
            Person.Adrress=Adrress;
            return this;
        }
        public User Build(){
            return Person;
        }
        }

    }

  
    
}