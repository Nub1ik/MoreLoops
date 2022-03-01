using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm kusib kasutajalt sisestada kasutaja tunnus ja salasona
            //kui sisestatud kasutaja on admin ja sisestatud salasona on n admin1234
            //siis konsoolis kuvatakse Tere tulemast
            //muul juhul konsoolis kuvatakse Vale kasutajatunnus voi salasona, proovi uuesti
            //kasutaja on kolm katset

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasona");
                string userPassword = Console.ReadLine();

                if(userName != "admin" || userPassword != "admin1234")
                {
                    i++;
                    Console.WriteLine($"Vale kasutajatunnus voi salasona. Saad proovida {3 - i} korda uuesti");
                }
                else
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }

                
            }

            Console.WriteLine("Kena paeva!");

        }
    }
}
