using System;

namespace kps
{
    class Program
    {
        static void Main(string[] args)
        {
            Random satunnaisluku = new Random();
            string UserGuess = "", ComputerGuess = "";
            int CompWins = 0;
            int UserWins = 0;
            int Draw = 0;
            int Games = 0;
            decimal voittoprosentti;

            Console.WriteLine("Tervetuloa KIVI-PAPERI-SAKSET -ohjelmaan!");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Kirjoita K/P/S (K=Kivi, P=Paperi, S=Sakset)");
            UserGuess = Console.ReadLine();
            UserGuess = UserGuess.ToUpper();

            while (UserGuess != "L")
            {
                string valinta = "";
                int arvottu = satunnaisluku.Next(1, 4);
                if (arvottu == 1)
                {
                    valinta = "K";
                }
                if (arvottu == 2)
                {
                    valinta = "P";
                }
                if (arvottu == 3)
                {
                    valinta = "S";
                }

                ComputerGuess = valinta;

                if (UserGuess == ComputerGuess)
                {
                    Console.WriteLine("Tasapeli! Valitsitte molemmat saman. Yritä uudelleen!");
                    Console.WriteLine();
                    Draw++;
                    Games++;
                }

                if (UserGuess == "S" && ComputerGuess == "K")
                {
                    Console.WriteLine("Käyttäjä valitsi: Sakset");
                    Console.WriteLine("Tietokoneen valinta oli: Kivi");
                    Console.WriteLine("Hävisit pelin!");
                    CompWins++;
                    Games++;
                    Console.WriteLine();
                }

                if (UserGuess == "S" && ComputerGuess == "P")
                {
                    Console.WriteLine("Käyttäjä valitsi: Sakset");
                    Console.WriteLine("Tietokoneen valinta oli: Paperi");
                    Console.WriteLine("Onnittelut! Voitit pelin.");
                    UserWins++;
                    Games++;
                    Console.WriteLine();
                }

                if (UserGuess == "P" && ComputerGuess == "S")
                {
                    Console.WriteLine("Käyttäjä valitsi: Paperi");
                    Console.WriteLine("Tietokoneen valinta oli: Sakset");
                    Console.WriteLine("Hävisit pelin!");
                    CompWins++;
                    Games++;
                    Console.WriteLine();
                }

                if (UserGuess == "P" && ComputerGuess == "K")
                {
                    Console.WriteLine("Käyttäjä valitsi: Paperin");
                    Console.WriteLine("Tietokoneen valinta oli: Kivi");
                    Console.WriteLine("Onnittelut! Voitit pelin.");
                    UserWins++;
                    Games++;
                    Console.WriteLine();
                }
                if (UserGuess == "K" && ComputerGuess == "S")
                {
                    Console.WriteLine("Käyttäjä valitsi: Kiven");
                    Console.WriteLine("Tietokoneen valinta oli: Sakset");
                    Console.WriteLine("Onnittelut! Voitit pelin.");
                    UserWins++;
                    Games++;
                    Console.WriteLine();
                }
                if (UserGuess == "K" && ComputerGuess == "P")
                {
                    Console.WriteLine("Käyttäjä valitsi: Kiven");
                    Console.WriteLine("Tietokoneen valinta oli: Paperi");
                    Console.WriteLine("Hävisit pelin!");
                    CompWins++;
                    Games++;
                    Console.WriteLine();
                }
                UserGuess = UserAnswer();
            }

            voittoprosentti = (decimal)UserWins / Games * 100;
            Console.WriteLine("Pelejä pelattiin yhteensä {0} kappaletta", Games);
            Console.WriteLine("Voitit tietokoneen {0} kertaa", UserWins);
            Console.WriteLine("Tietokone voitti sinut {0} kertaa", CompWins);
            Console.WriteLine("Tasapelejä oli {0} kappaletta! ", Draw);
            Console.WriteLine("Voittoprosenttisi oli {0:f2}%", voittoprosentti);


        }
        static string UserAnswer()
        {
            string UserGuess;
            // pyydä käyttäjän arvaus
            Console.WriteLine("Valitse K/P/S (K=Kivi, P=Paperi, S=Sakset / L=Lopeta");
            UserGuess = Console.ReadLine();
            UserGuess = UserGuess.ToUpper();
            return UserGuess;
        }
    }
}
