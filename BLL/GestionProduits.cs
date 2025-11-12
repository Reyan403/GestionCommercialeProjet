using System;
using System.Collections.Generic;
using System.Configuration; // nécessaire pour ConnectionStringSettings
using BO;
using DAL;

namespace BLL
{
    public class GestionProduits
    {
        private static GestionProduits uneGestionProduits;

        public static GestionProduits GetGestionProduits()
        {
            if (uneGestionProduits == null)
                uneGestionProduits = new GestionProduits();
            return uneGestionProduits;
        }

        public static void SetchaineConnexion(string chaine)
        {
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }


        public static List<ProduitBO> GetProduits()
        {
            return Prod6uitDAO.GetProduits();
        }

        public static int ModifierProduit(ProduitBO p)
        {
            return ProduitDAO.UpdateProduit(p);
        }

        public static int SupprimerProduit(int code)
        {
            return ProduitDAO.DeleteProduit(code);
        }
    }
}
