using System;
using System.Configuration;
using System.Windows.Forms;
using BO;
using UtilisateursBLL; 

namespace GUI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            // On définit la chaîne de connexion au lancement du formulaire
            LoginUtilisateur.SetchaineConnexion(ConfigurationManager.ConnectionStrings["gestion_commerciale"]);
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string mdp = txtMotDePasse.Text.Trim();

            if (LoginUtilisateur.VerifierConnexion(nom, mdp))
            {
                MessageBox.Show("Connexion réussie !");

                // Afficher le formulaire principal
                FrmAccueil frmAccueil = new FrmAccueil();
                frmAccueil.Show();

                this.Hide(); // on cache le form de login
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect.",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
