using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class EmailOluşturucu
    {
        public static void Oluştur(Person person)
        {
            string emailDraft = (person.FirstName.Substring(0, 1) + person.LastName).ToLower();

            person.EmailAdress = emailDraft + "@btakademi.com";

            Mesajlar.MailOluşturmaBaşarılı(person);
        }
    } 
}
