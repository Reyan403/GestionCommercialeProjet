using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class ProduitBLL
    {
        private ProduitDAO produitDAO = new ProduitDAO();

        public Produit GetProduitById(int id)
        {
            Produit Produit1 =  produitDAO.GetProduitById(id);
            return Produit1;
        }
    }
}
