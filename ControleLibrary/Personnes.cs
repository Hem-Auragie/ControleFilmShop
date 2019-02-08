using System;
using System.Collections.Generic;
using System.Text;

namespace FilmsLibrary
{
    public class Personnes
    {
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private string adresse;
        private string ville;
        private string codePostal;
        private int taille;
        private int poids;
        private int age;
        private string nomComplet;

        public Personnes()
        {
        }

        public Personnes(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public string Nom
        {
            get => nom;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("ERREUR: Le nom n'est pas valide");
                }
                else
                {
                    nom = value;
                }
            }
        }
        public string Prenom
        {
            get => prenom;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("ERREUR: Le prénom n'est pas valide");
                }
                else
                {
                    prenom = value;
                }
            }
        }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string Adresse
        {
            get => adresse;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("ERREUR: L'adresse n'est pas valide");
                }
                else
                {
                    adresse = value;
                }
            }
        }
        public string Ville
        {
            get => ville.ToUpper();
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("ERREUR: Le nom de la ville n'est pas valide");
                }
                else
                {
                    ville = value;
                }
            }
        }
        public string CodePostal
        {
            get => codePostal;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("ERREUR: Le code postal n'est pas valide");
                }
                else
                {
                    codePostal = value;
                }
            }
        }
        public int Taille { get => taille; set => taille = value; }
        public int Poids { get => poids; set => poids = value; }
        public int Age { get => age; set => age = value; }
        public string NomComplet { get => nomComplet; set => nomComplet = Nom + " " + Prenom; }
    }
}
