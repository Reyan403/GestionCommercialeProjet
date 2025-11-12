using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO; // Référence la couche BO
using System.Data.SqlClient;

namespace DAL
{
    public class UtilisateurDAO
    {
        private static UtilisateurDAO unUtilisateurDAO;

        // Singleton
        public static UtilisateurDAO GetunUtilisateurDAO()
        {
            if (unUtilisateurDAO == null)
            {
                unUtilisateurDAO = new UtilisateurDAO();
            }
            return unUtilisateurDAO;
        }

        // Récupère tous les utilisateurs de la table "utilisateur"
        public static List<Utilisateur> GetUtilisateurs()
        {
            List<Utilisateur> lesUtilisateurs = new List<Utilisateur>();

            using (SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT id_user, nom_user, password_user FROM utilisateur", maConnexion);
                SqlDataReader monReader = cmd.ExecuteReader();

                while (monReader.Read())
                {
                    int id = Convert.ToInt32(monReader["id_user"]);
                    string nom = monReader["nom_user"].ToString();
                    string mdp = monReader["password_user"].ToString();

                    Utilisateur unUtilisateur = new Utilisateur(id, nom, mdp);
                    lesUtilisateurs.Add(unUtilisateur);
                }

                monReader.Close();
            }

            return lesUtilisateurs;
        }

        // Vérifie si un utilisateur existe (pour la connexion)
        public static bool VerifierConnexion(string nom, string motDePasse)
        {
            bool estValide = false;

            using (SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM utilisateur WHERE nom_user = @nom AND password_user = @mdp",
                    maConnexion
                );
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@mdp", motDePasse);

                int nb = (int)cmd.ExecuteScalar();
                estValide = (nb > 0);
            }

            return estValide;
        }
    }
}
