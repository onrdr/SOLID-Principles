

namespace Single_Responsibility_Principle
{
    public class Mesajlar
    {
        public static void UygulamaGiriş()
        {
            Console.WriteLine("==================================================\n" +
                "BT Akademi Single Responsibility Principle Örneği\n" +
                "==================================================");
        }
        public static void UygulamaÇıkış()
        {
            Console.WriteLine("==================================================" +
                   "\n\nÇıkmak için bir tuşa basın");
            Console.ReadKey();
        }
        public static void HataMesajınıGörüntüle(string fieldAdi)
        {
            Console.WriteLine($"Geçerli Bir {fieldAdi} Girmediniz");
        }
        public static void MailOluşturmaBaşarılı(Person person)
        {
            Console.WriteLine($"Mail Adresiniz Oluşturuldu: {person.EmailAdress}");
        }
    } 
}
