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

            SqlCommand cmd = new SqlCommand("SELECT Code, Libelle, Categorie, Prix FROM Produit", maConnexion);
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                var prod = new ProduitBO(
                    Convert.ToInt32(monReader["Code"]),
                    monReader["Libelle"].ToString(),
                    monReader["Categorie"].ToString(),
                    Convert.ToDecimal(monReader["Prix"]) 
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
                "UPDATE Produit SET Libelle=@lib, Categorie=@cat, Prix=@prix WHERE Code=@id", maConnexion);

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
            SqlCommand cmd = new SqlCommand("DELETE FROM Produit WHERE Code=@id", maConnexion);
            cmd.Parameters.AddWithValue("@id", code);
            int nb = cmd.ExecuteNonQuery();
            maConnexion.Close();
            return nb;
        }
        public static List<ProduitBO> GetProduits()
        {
            List<ProduitBO> lesProduits = new List<ProduitBO>();
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Produit", maConnexion);
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                ProduitBO p = new ProduitBO(
                    Convert.ToInt32(monReader["Code"]),
                    monReader["Libelle"].ToString(),
                    monReader["Categorie"].ToString(),
                    Convert.ToSingle(monReader["Prix"])
                );
                lesProduits.Add(p);
            }

            maConnexion.Close();
            return lesProduits;
        }

    }
}
