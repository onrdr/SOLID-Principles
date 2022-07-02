
namespace ModifiedWithISP
{
   public class Program
    {
        public static void Process()
        {
            /*
            ==> IMPORTANT : 

            ==> In IDVD and IAudioBook interfaces, it seems that we violate DRY Principle 
                by using RunTimeInMinutes property since both have this property. Actually we dont. 
                Because DVD and AudioBook doesnt have anything in common. They are two different things. 
                Dont just look at the different class properties and say : 
                DON'T ==> "if two classes have same property, we should connect them via an interface". 
             */  



            Console.ReadKey();
        }
    }
}