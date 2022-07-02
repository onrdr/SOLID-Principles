
namespace Original_Project
{
   public class Program
    {
        public static void Process()
        {
            /* 
             
            ==> This original project violates the Interface Segragate Principle, Because :  
            ==> ISP states that a client should not be forced to depend on interfaces they dont use.

            ==> Some Example why it violates ISP : 
            ==> An Audio book does not have pages in real life so, it should not have "Pages" property.  
            ==> Reference books are not allowed to leave the library so, it should not have "CheckOutDurationInDays" property.
            ==> They also should not have CheckIn Method, Borrower property, CheckOut Method and GetDueDate Method.
            ==> Also DVD class should not have Pages property... ans so on... But you got the idea.

            ==> The solution : The solution is to divide and conquer. 
            ==> We have to divide ILibraryItem interface into smaller interfaces which should fit in all classes perfectly.
            ==> For modified version of the project, look at the ModifiedWithISP folder in this project.

             */

            Console.ReadKey();
        }
    }
}