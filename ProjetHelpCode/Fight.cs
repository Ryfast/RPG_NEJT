using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetHelpCode
{
    class Fight
    {
        static void Main(string[] args)
        {
            Character perso1 ;//gentil
            Character perso2;//méchant
            //celui avec l'agilité la plus grande commence
            if (perso1.agi > perso2.agi)
            {
                perso1.turn = true;
            }
            else
            {
                perso2.turn = true;
            }
            if(perso1.turn)
            {
                //option : attack, master, item ou flee
            }
            else if (perso2.turn)
            {
                //option : attack, master, item ou flee
            }
            else
            {
                perso1.turn = false;
                perso2.turn = false;
            }
        }
        void attaque(Character Attaquant, Character Defenseur){
            Random rnd = new Random();
            if ((Attaquant.agilite * 2) <= Defenseur.agilite && rnd.next(0, Defenseur.agilite) >= Attaquant.agilite)
            {
                //le défenseur esquive l'attaque
            }
            else{
                Defenseur.vie -= (Attaquant.attaque);
            }
        }
        void maitrise(Player Attaquant, Player Defenseur)
        {
            Defenseur.pv -= (Attaquant.intelligence);
            Attaquant.pm--;
        }
        void objet(Character Utilisateur, Character Cible)
        {
            Utilisateur.inventaire[i].Effet(Cible);
        }
    }
}