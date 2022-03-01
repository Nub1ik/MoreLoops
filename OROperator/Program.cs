using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm kusib kasutajalt sisestada kasutaja tunnus ja salasona
            //kui sisestatud kasutaja on admin ja sisestatud salasona on n admin1234
            //siis konsoolis kuvatakse Tere tulemast
            //muul juhul konsoolis kuvatakse Vale kasutajatunnus voi salasona, proovi uuesti

            //OR (või)  || (pipes)

            //true || true --> true
            //false || true --> true
            //true || false --> true
            //false || false --> false 

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasona");
            string userPassword = Console.ReadLine();

            if(userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutaja tunnus voi salasona. Proovi uuesti");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }



        }
    }
}
