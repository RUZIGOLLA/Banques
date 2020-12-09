using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Solde { get; set; }
        public List<Produit> Produits { get; set; }
        public Utilisateur(int id, string usr, string pswd, int solde)
        {
            Id = id;
            Username = usr;
            Password = pswd;
            Solde = solde;
            Produits = new List<Produit>();
        }
        public Utilisateur() { }
        public int Deduction(int prix)
        {
            if (Solde - prix >= 0)
            {
                Solde -= prix;
                return 1;
            }
            else return -1;
        }
        public int Achat(Produit produit)
        {
            if (Deduction(produit.Prix) == 1)
            {
                Produits.Add(produit);
                return 1;
            }
            return -1;
        }

        public int Crediter(int amount)
        {
            Solde += amount;
            return 1;
        }
    }
}
