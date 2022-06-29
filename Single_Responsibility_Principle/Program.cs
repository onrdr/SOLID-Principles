
namespace Single_Responsibility_Principle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mesajlar.UygulamaGiriş();

            Person person = KişiBilgisi.BilgileriGirKişiyiGeriAl();

            bool kontrol = KişiKontol.KişiGeçerliMi(person);

            if (!kontrol)
            {
                Mesajlar.UygulamaÇıkış();
                return;
            }

            EmailOluşturucu.Oluştur(person);

            Mesajlar.UygulamaÇıkış(); 
        }





        public static void EskiMainMethod()
        {
            #region Uygulama Başlığı 
            Console.WriteLine("BT Akademi Single Responsibility Principle Örneği !!!\n");
            #endregion


            #region Kişi Bilgisi İste
            Person person = new Person();

            Console.Write("Lütfen İsminizi Girin: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Lütfen Soyisminizi Girin: ");
            person.LastName = Console.ReadLine();
            #endregion


            #region İsim ve Soyismin geçerli olup olmadığını kontrol et
            if (string.IsNullOrEmpty(person.FirstName) || person.FirstName.StartsWith(" "))
            {
                Console.WriteLine("Geçerli Bir İsim Girmediniz");
                Console.ReadKey();
                return;
            }
            if (string.IsNullOrEmpty(person.FirstName) || person.LastName.StartsWith(" "))
            {
                Console.WriteLine("Geçerli Bir Soyisim Girmediniz");
                Console.ReadKey();
                return;
            }
            #endregion


            #region Eğer geçerliyse email adresi oluştur 
            string emailDraft = (person.FirstName.Substring(0, 1) + person.LastName).ToLower();
            person.EmailAdress = emailDraft + "@btakademi.com";
            Console.WriteLine($"Mail Adresiniz Oluşturuldu: {person.EmailAdress}");
            #endregion

            Console.ReadKey();
        }
    }

}