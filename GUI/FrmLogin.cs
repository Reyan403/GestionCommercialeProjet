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

            // Initialisation de la connexion à la BD
            var chset = ConfigurationManager.ConnectionStrings["gestion_commerciale"];

            if (chset == null)
            {
                MessageBox.Show("Chaîne de connexion 'gestion_commerciale' introuvable dans App.config !");
                return;
            }

            LoginUtilisateur.SetchaineConnexion(chset);
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string mdp = txtMotDePasse.Text.Trim();

            //Erreur si le champs est vide
            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(mdp))
            {
                MessageBox.Show("Veuillez insérer votre nom et votre mot de passe.",
                                "Champs manquants",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            
            //Erreur si le nom est incorrect
            else if (!LoginUtilisateur.VerifierConnexion(nom, mdp))
            {
                MessageBox.Show("Nom ou mot de passe incorrect.",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            //OK si les identifiants sont corrects
            else
            {
                MessageBox.Show("Connexion réussie !",
                                "Succès",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                FrmAccueil frmAccueil = new FrmAccueil();
                frmAccueil.Show();
                this.Hide();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
