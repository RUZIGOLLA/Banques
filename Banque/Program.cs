using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    class Program
    {
        static List<Utilisateur> Utilisateurs = new List<Utilisateur>();
        static List<Produit> Produits = new List<Produit>();
        static Utilisateur utilisateurCo = new Utilisateur();
        static void Main(string[] args)
        {
            populateUser();
            populateProduct();
            runProg();
        }


        public static void runProg()
        {
            utilisateurCo = getUser();
/*            while (1)
            {
               // chooseProduct();
            }*/
        }

        public static Utilisateur getUser()
        {
            Utilisateur user = new Utilisateur();
            Console.WriteLine("Type a userName");
            user.Username = Console.ReadLine(); // R
            Console.WriteLine("Type a password");
            user.Password = Console.ReadLine(); // R
            return Utilisateurs.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);
        }
        public static int populateUser()
        {
            Utilisateurs.Add(new Utilisateur(0, "Norman", "nono", 35));
            return 1;
        }

        public static int populateProduct()
        {
            Produits.Add(new Produit("Chemise", 40));
            Produits.Add(new Produit("Jean", 30));
            Produits.Add(new Produit("Chaussure", 50));
            Produits.Add(new Produit("Chaussette", 10));
            Produits.Add(new Produit("Calecon", 20));
            Produits.Add(new Produit("Soutien gorge", 30));
            return 1;
        }
    }
}
