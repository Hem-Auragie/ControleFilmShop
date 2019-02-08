using System;
using System.Collections.Generic;
using System.Text;

namespace FilmsLibrary
{
    public class Films
    {
        private string titre_film;
        private string realisateur_film;
        private DateTime date_sortie_film;
        private string resume_film;
        private string genre_film;
        private int duree_film;
        private string liste_acteur;
        private int annee_de_sortie;

        public Films()
        {
        }

        public Films(string titre_film, string realisateur_film, DateTime date_sortie_film, string resume_film, string genre_film, int duree_film, string liste_acteur)
        {
            Titre_film = titre_film;
            Realisateur_film = realisateur_film;
            Date_sortie_film = date_sortie_film;
            Resume_film = resume_film;
            Genre_film = genre_film;
            Duree_film = duree_film;
            Liste_acteur = liste_acteur;
        }

        public string Titre_film
        {
            get => titre_film;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("ERREUR: Le titre n'est pas valide");
                }
                else
                {
                    titre_film = value;
                }
            }
        }
        public string Realisateur_film
        {
            get => realisateur_film;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("ERREUR: Le réalisateur n'est pas valide");
                }
                else
                {
                    realisateur_film = value;
                }
            }
        }
        public DateTime Date_sortie_film { get => date_sortie_film; set => date_sortie_film = value; }
        public string Resume_film
        {
            get => resume_film;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("ERREUR: Le resume n'est pas valide");
                }
                else
                {
                    resume_film = value;
                }
            }
        }
        public string Genre_film
        {
            get => genre_film;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("ERREUR: Le genre du film n'est pas valide");
                }
                else
                {
                    genre_film = value;
                }
            }
        }
        public int Duree_film
        {
            get => duree_film;
            set => duree_film = value;
        }
        public string Liste_acteur { get => liste_acteur; set => liste_acteur = value; }
        public int Annee_de_sortie { get => annee_de_sortie; set => annee_de_sortie = Convert.ToInt32(Date_sortie_film.Year); }
    }
}
