using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    class Produit
    {
        public string Libelle { get; set; }
        public int Prix { get; set; }
        public Produit(string libelle, int prix)
        {
            Libelle = libelle;
            Prix = prix;
        }

        public override string ToString()
        {
            return Libelle + " " + Prix;
        }
    }
}
