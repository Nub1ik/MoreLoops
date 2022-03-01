using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm kusib kasutajalt sisestada kasutaja tunnus ja salasona
            //kui sisestatud kasutaja on admin ja sisestatud salasona on n admin1234
            //siis konsoolis kuvatakse Tere tulemast
            //muul juhul konsoolis kuvatakse Vale kasutajatunnus voi salasona, proovi uuesti

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasona");
            string userPassword = Console.ReadLine();

            //AND (&&)

            //"admin" AND "admin1234" --> true
            //"admin1"  AND "admin1234" --> false
            //"admin"  AND "admin234" --> false 


            if(userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus voi salasona. Proovi uuesti.");
            }

            Console.WriteLine("Kena paeva!");
        }

    }
}
