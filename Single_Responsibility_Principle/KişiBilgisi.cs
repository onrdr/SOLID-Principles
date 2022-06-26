using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class KişiBilgisi
    {
        public static Person BilgileriGirKişiyiGeriAl()
        {
            Person person = new Person();

            Console.Write("Lütfen İsminizi Girin: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Lütfen Soyisminizi Girin: ");
            person.LastName = Console.ReadLine();

            return person;

        } 
    } 
}
