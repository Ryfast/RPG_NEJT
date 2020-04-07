using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetHelpCode
{
    class CreateCharacter
    {
        static void creaperso()
        {
            writeYourName();
            sexChoose();
        }

        static void writeYourName()
        {
            string playerName;
            Console.Write("Enter your name - ");
            playerName = Console.ReadLine();
            Console.WriteLine("You name is '{0}'", playerName);
            Console.ReadKey();
        }

        static void sexChoose()
        {
            string playerGenre;
            Console.Write("You're male or female - ");
            playerGenre = Console.ReadLine();
            Console.WriteLine("You are '{0}'", playerGenre);
            Console.ReadKey();
        }

        static void faction()
        {
            string faction;
            Console.Write("What's your faction? - ");
            faction = Console.ReadLine();
            Console.WriteLine("You are '{0}'", faction);
            Console.ReadKey();
        }
    }
}
