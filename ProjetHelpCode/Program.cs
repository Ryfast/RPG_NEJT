using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetHelpCode
{
    class Program
    {

        static void Main(string[] args)
        {
            Debut();
        }

        public static void Debut()
        {
            Console.WriteLine("Bienvenue dans le jeu");
            Console.WriteLine("Appuie sur Entrer pour commencer");
            Console.ReadLine();
            Console.Clear();
            
        }

        public static void GameOver()
        {

        }

        public static void Win()
        {

        }


    }
    public class CreateCharacter
    {
        static void Main(string[] args)
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

    public class RoleplayEvent
    {
        Random rnd = new Random();


        int lastEvent;
        int indexEvent;

        public void RandomEvent()
        {
            indexEvent = rnd.Next(0, 5);

            if (indexEvent == lastEvent)
            {
                indexEvent = rnd.Next(0, 5);
            }
            switch (indexEvent)
            {
                case 0:
                    Event01();
                    break;

                case 1:
                    Event02();
                    break;

                case 2:
                    Event03();
                    break;

                case 3:
                    Event04();
                    break;

                case 4:
                    Event05();
                    break;

                case 5:
                    Event06();
                    break;
            }
            lastEvent = indexEvent;
        }
    }
}