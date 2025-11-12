using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BO;

namespace DAL
{
    public class ProduitDAO
    {
        public static List<ProduitBO> GetProduits()
        {
            List<ProduitBO> lesProduits = new List<ProduitBO>();
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand("SELECT id_produit, libelle_produit, id_categorie, prix_vente_HT_produit FROM Produit", maConnexion);
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                var prod = new ProduitBO(
                    Convert.ToInt32(monReader["id_produit"]),
                    monReader["libelle_produit"].ToString(),
                    monReader["id_categorie"].ToString(),
                    Convert.ToDecimal(monReader["prix_vente_HT_produit"]) 
                );
                lesProduits.Add(prod);
            }

            monReader.Close();
            maConnexion.Close();
            return lesProduits;
        }

        public static int UpdateProduit(ProduitBO p)
        {
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand(
                "UPDATE Produit SET libelle_produit=@lib, id_categorie=@cat, prix_vente_HT_produit=@prix WHERE id_produit=@id", maConnexion);

            cmd.Parameters.AddWithValue("@lib", p.getLibelle());
            cmd.Parameters.AddWithValue("@cat", p.getCategorie());
            cmd.Parameters.AddWithValue("@prix", p.getPrix());
            cmd.Parameters.AddWithValue("@id", p.getCode());

            int nb = cmd.ExecuteNonQuery();
            maConnexion.Close();
            return nb;
        }

        public static int DeleteProduit(int code)
        {
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("DELETE FROM Produit WHERE id_produit=@id", maConnexion);
            cmd.Parameters.AddWithValue("@id", code);
            int nb = cmd.ExecuteNonQuery();
            maConnexion.Close();
            return nb;
        }

    }
}
