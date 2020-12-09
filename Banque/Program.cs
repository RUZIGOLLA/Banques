using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    public class Program
    {
        public static List<Utilisateur> Utilisateurs = new List<Utilisateur>();
        public static List<Produit> Produits = new List<Produit>();
        static Utilisateur utilisateurCo = new Utilisateur();
        static void Main(string[] args)
        {
            populateUser();
            populateProduct();
            runProg();
        }


        public static void runProg()
        {
            utilisateurCo = getUser("Norman", "nono");
/*            while (1)
            {
               // chooseProduct();
            }*/
        }

        public static Utilisateur getUser(string Username, string Password)
        {
            Utilisateur user = new Utilisateur();
            user.Username = Username; // R
            user.Password = Password; // R
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
