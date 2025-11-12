using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using BLL;
using BO;
using System.Configuration;


namespace GUI
{
    public partial class Produit : Form
    {
        public Produit()
        {
            InitializeComponent();
        }

        private void Produit_Load(object sender, EventArgs e)
        {
            try
            {
                // 🔗 Étape 1 : établir la connexion à la base via la BLL
                string chaine = ConfigurationManager.ConnectionStrings["gestion_commerciale"].ConnectionString;
                GestionProduits.SetchaineConnexion(chaine);

                // 📦 Étape 2 : récupérer la liste des produits depuis la BLL
                List<ProduitBO> lesProduits = GestionProduits.GetProduits();

                // 💡 Étape 3 : afficher dans le DataGridView
                dataGridView1.Rows.Clear();

                foreach (var p in lesProduits)
                {
                    dataGridView1.Rows.Add(p.getCode(), p.getLibelle(), p.getCategorie(), $"{p.getPrix()} €");
                }

                // Sélection automatique de la première ligne
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[0].Selected = true;
                    dataGridView1_SelectionChanged(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des produits : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void addProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton 'Nouveau' cliqué — à relier à la couche BLL/DAL.", "Nouveau", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                txtCode.Text = row.Cells["Code"].Value?.ToString() ?? string.Empty;
                txtLibelle.Text = row.Cells["Libellé"].Value?.ToString() ?? string.Empty;
                cmbCategorie.Text = row.Cells["Catégorie"].Value?.ToString() ?? string.Empty;

                var prixVal = row.Cells["Prix"].Value?.ToString() ?? string.Empty;
                if (prixVal.EndsWith(" €"))
                    prixVal = prixVal.Substring(0, prixVal.Length - 2).Trim();
                txtPrix.Text = prixVal;
            }
            else
            {
                txtCode.Text = "";
                txtLibelle.Text = "";
                cmbCategorie.SelectedIndex = -1;
                txtPrix.Text = "";
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLibelle.Text))
            {
                MessageBox.Show("Le libellé est requis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal prix;
            if (!decimal.TryParse(txtPrix.Text.Replace(',', '.'), out prix))
            {
                MessageBox.Show("Prix invalide. Utilisez un format numérique (ex : 14.99).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Produit modifié : {txtLibelle.Text} ({cmbCategorie.Text}) - {prix} €", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                row.Cells["Libellé"].Value = txtLibelle.Text;
                row.Cells["Catégorie"].Value = cmbCategorie.Text;
                row.Cells["Prix"].Value = $"{prix} €";
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("Aucun produit sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Confirmer la suppression du produit '{txtLibelle.Text}' ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    txtCode.Text = "";
                    txtLibelle.Text = "";
                    cmbCategorie.SelectedIndex = -1;
                    txtPrix.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addProduct_Click(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                dataGridView1_SelectionChanged(sender, e);
            }
        }
    }
}
