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
        static void Main(string[] args)
        {
            populateUser();
 //           populateProduct();

        }

        public static int populateUser()
        {
            Utilisateurs.Add(new Utilisateur("Norman", "nono", 35));
            return 1;
        }
    }
}
