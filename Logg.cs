namespace consoleApp.testForInterface
{
    //Singelton
    public class Logg
    {
        //adding private Field of Logg class
        private static Logg logger;
        private static Logg _instance;
        private Logg(){}
        //checking logger 
        //1:Method
        // public static Logg GetLogger(){
        //     if(logger==null){
        //         //new object
        //         logger=new Logg();
        //     }
        //     return logger;
        // }
        //2:Property
           public static Logg Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logg();
                }
                return _instance;
            }
        }
        
    }
    
}