using System;

namespace BO
{
    public class ProduitBO
    {
        private int code;
        private string libelle;
        private string categorie;
        private decimal prix; 

        public ProduitBO(int code, string libelle, string categorie, decimal prix)
        {
            this.code = code;
            this.libelle = libelle;
            this.categorie = categorie;
            this.prix = prix;
        }

        public int getCode()
        {
            return code;
        }

        public void setCode(int code)
        {
            this.code = code;
        }

        public string getLibelle()
        {
            return libelle;
        }

        public void setLibelle(string libelle)
        {
            this.libelle = libelle;
        }

        public string getCategorie()
        {
            return categorie;
        }

        public void setCategorie(string categorie)
        {
            this.categorie = categorie;
        }

        public decimal getPrix()
        {
            return prix;
        }

        public void setPrix(decimal prix)
        {
            this.prix = prix;
        }
    }
}
