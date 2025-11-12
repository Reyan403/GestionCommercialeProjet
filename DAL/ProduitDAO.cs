using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace DAL
{
    internal class ProduitDAO
    {

        // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table Identification
        public Produit GetProduitById(int id)
        {
            Produit produit = null;
            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Requête SQL 
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM dbo.produit WHERE id_produit = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader monReader = cmd.ExecuteReader();

            if (monReader.Read())
            {
                produit = new Produit
                {
                    IdProduit = (int)monReader["id_produit"],
                    LibelleProduit = monReader["libelle_produit"].ToString(),
                    PrixVenteHTProduit = (float)monReader["prix_vente_HT_produit"],
                    IdCategorie = (int)monReader["id_categorie"]
                };
            }

            monReader.Close();
            ConnexionBD.GetConnexionBD().CloseConnexion();

            return produit;
        }
    }
}
