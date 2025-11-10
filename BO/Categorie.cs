using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Categorie
    {
        public int IdCategorie { get; set; }
        public string NomCategorie { get; set; }

        public Categorie() { }

        public Categorie(int idCategorie, string nomCategorie)
        {
            IdCategorie = idCategorie;
            NomCategorie = nomCategorie;
        }
    }
}
