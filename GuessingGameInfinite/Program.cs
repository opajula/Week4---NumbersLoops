using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu;
            //*programm genereerib juhuslikku numbrit vaid ühe korra

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            Console.WriteLine("Tere tulemast! Hakkate mängima äraarvamismängu.");
            Console.WriteLine("Palun arva ära konsooli genereeritud number:");

            bool loopActive = true;

            while(loopActive)
            {
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == cpuNumber)
                {
                    Console.WriteLine("Arvasite õige numbri! Palju õnne, olete võitnud!");
                    break;
                }
                else
                {
                    Console.WriteLine("Vale arv. Proovi uuesti.");
                }
            }

            Console.WriteLine("Kena päeva!");
        }

    }
}
