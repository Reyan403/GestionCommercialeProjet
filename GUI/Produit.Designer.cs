namespace GUI
{
    partial class Produit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addProduct = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libellé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catégorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // addProduct
            // 
            this.addProduct.BackColor = System.Drawing.SystemColors.Highlight;
            this.addProduct.ForeColor = System.Drawing.Color.White;
            this.addProduct.Location = new System.Drawing.Point(40, 25);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(120, 35);
            this.addProduct.TabIndex = 0;
            this.addProduct.Text = "Nouveau";
            this.addProduct.UseVisualStyleBackColor = false;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Libellé,
            this.Catégorie,
            this.Prix});
            this.dataGridView1.Location = new System.Drawing.Point(40, 80);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(850, 450);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 60;
            // 
            // Libellé
            // 
            this.Libellé.HeaderText = "Libellé";
            this.Libellé.Name = "Libellé";
            this.Libellé.ReadOnly = true;
            this.Libellé.Width = 280;
            // 
            // Catégorie
            // 
            this.Catégorie.HeaderText = "Catégorie";
            this.Catégorie.Name = "Catégorie";
            this.Catégorie.ReadOnly = true;
            this.Catégorie.Width = 180;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix de vente HT";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            this.Prix.Width = 150;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right))));
            this.pnlDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetail.Controls.Add(this.btnSupprimer);
            this.pnlDetail.Controls.Add(this.btnModifier);
            this.pnlDetail.Controls.Add(this.txtPrix);
            this.pnlDetail.Controls.Add(this.cmbCategorie);
            this.pnlDetail.Controls.Add(this.txtLibelle);
            this.pnlDetail.Controls.Add(this.txtCode);
            this.pnlDetail.Controls.Add(this.lblPrix);
            this.pnlDetail.Controls.Add(this.lblCategorie);
            this.pnlDetail.Controls.Add(this.lblLibelle);
            this.pnlDetail.Controls.Add(this.lblCode);
            this.pnlDetail.Controls.Add(this.lblDetail);
            this.pnlDetail.Location = new System.Drawing.Point(920, 25);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(350, 505);
            this.pnlDetail.TabIndex = 2;
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDetail.Location = new System.Drawing.Point(20, 15);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(57, 21);
            this.lblDetail.TabIndex = 0;
            this.lblDetail.Text = "Détail";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(22, 60);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 13);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code:";
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(22, 110);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(43, 13);
            this.lblLibelle.TabIndex = 2;
            this.lblLibelle.Text = "Libellé:";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(22, 160);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(58, 13);
            this.lblCategorie.TabIndex = 3;
            this.lblCategorie.Text = "Catégorie:";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(22, 210);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(80, 13);
            this.lblPrix.TabIndex = 4;
            this.lblPrix.Text = "Prix de vente HT:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(130, 57);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 5;
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(130, 107);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(180, 20);
            this.txtLibelle.TabIndex = 6;
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Items.AddRange(new object[] {
            "réseau",
            "consommable",
            "PC",
            "pièces détachées"});
            this.cmbCategorie.Location = new System.Drawing.Point(130, 157);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(180, 21);
            this.cmbCategorie.TabIndex = 7;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(130, 207);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(100, 20);
            this.txtPrix.TabIndex = 8;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.LimeGreen;
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(25, 260);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(120, 35);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Crimson;
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(170, 260);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(120, 35);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1300, 550);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addProduct);
            this.Name = "Produit";
            this.Text = "Produits";
            this.Load += new System.EventHandler(this.Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libellé;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catégorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
    }
}
