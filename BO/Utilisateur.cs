using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Utilisateur
    {
        private int id_utilisateur;
        private string nom_utilisateur;
        private string mot_de_passe_utilisateur;

        public Utilisateur (string nom_utilisateur, string mot_de_passe_utilisateur)
        {
            this.nom_utilisateur = nom_utilisateur;
            this.mot_de_passe_utilisateur = mot_de_passe_utilisateur;
        }
        
        public int getId_utilisateur()
        {
            return id_utilisateur;
        }

        public string getNom_utilisateur()
        {
            return nom_utilisateur;
        }

        public string getMot_de_passe_utilisateur()
        {
            return mot_de_passe_utilisateur;
        }

        public void setId_utilisateur(int id_utilisateur)
        {
            this.id_utilisateur = id_utilisateur;
        }

        public void setNom_utilisateur(string nom_utilisateur)
        {
            this.nom_utilisateur = nom_utilisateur;
        }

        public void setMot_de_passe_utilisateur(string mot_de_passe_utilisateur)
        {
            this.mot_de_passe_utilisateur = mot_de_passe_utilisateur;
        }

    }
}
