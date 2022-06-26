using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class KişiKontol
    {
        public static bool KişiGeçerliMi(Person person)
        {
            if (string.IsNullOrEmpty(person.FirstName) || person.FirstName.StartsWith(" "))
            {
                Mesajlar.HataMesajınıGörüntüle("isim");
                return false;
            }
            if (string.IsNullOrEmpty(person.LastName) || person.LastName.StartsWith(" "))
            {
                Mesajlar.HataMesajınıGörüntüle("soyisim");
                return false;
            }
            return true;
        }
    } 
}
