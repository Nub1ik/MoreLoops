using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mangus osaleb kaks mangijat - arvuti (cpu)  ja kasutaja (user)
            //molemad viskavad taringuid
            //programm kuvad kumb mangija viskas rohkem
            //mangija kes viskab rohkem ongi voitja
            //*taringuid visatakse kolm korda
            //programm kuulutab voitja

            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random();

                int cpuRandom = rnd.Next(1, 7);

                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas: {cpuRandom}. Kasutaja viskas: {userRandom}");
                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on mängu võitnud.");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");
                    cpuScore = cpuScore;
                    userScore = userScore;
                }

                
            }

            Console.WriteLine($"Arvuti tulemus on {cpuScore} ja kasutaja tulemus on {userScore} ");

            Console.WriteLine("Kena päeva!");
        }
    }
}
