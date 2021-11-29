using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud arvu ära arvata;
            //siis mängu võidab arvuti;
            //*programm genereerib juhuslikku numbrit vaid ühe korra


            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            Console.WriteLine("Tere tulemast! Hakkate mängima äraarvamismängu. Teil on kolm katset.");
            Console.WriteLine("Palun arva ära konsooli genereeritud number:");
            int i = 0;

            while(i < 3)
            {
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if(userGuess == cpuNumber)
                {
                    Console.WriteLine("Arvasite õigesti! Olete mängu võitnud!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale arv. Teil on veel {3 - i} katset on jäänud.");
                }
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
