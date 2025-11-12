using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Produit
    {
        public int IdProduit { get; set; }
        public string LibelleProduit { get; set; }
        public float PrixVenteHTProduit { get; set; }
        public int IdCategorie { get; set; }

        public Produit() { }

        public Produit(int idProduit, string libelleProduit, float prixVenteHTProduit, int idCategorie)
        {
            IdProduit = idProduit;
            LibelleProduit = libelleProduit;
            PrixVenteHTProduit = prixVenteHTProduit;
            IdCategorie = idCategorie;
        }
    }
}
