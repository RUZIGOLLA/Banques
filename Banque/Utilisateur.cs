using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    class Utilisateur
    {
        public string Username { get; set; }
        public string Password { get; set; }
        private int Solde { get; set; }
        private List<Produit> Produits { get; set; }
        public Utilisateur(string usr, string pswd, int solde)
        {
            Username = usr;
            Password = pswd;
            Solde = solde;
        }

        private int Deduction(int prix)
        {
            return Solde - prix;
        }
        public int Achat(Produit produit)
        {
            Produits.Add(produit);
            Solde = Deduction(produit.Prix);
            return 1;
        }
    }
}
