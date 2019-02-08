using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmsLibrary;

namespace FilmConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        #region [Interface] Menu Principal
        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.Write("Que souhaitez-vous faire ? \n" +
                     "\n\t - [1] AJOUTER UNE PERSONNE" +
                     "\n\t - [2] AJOUTER UN FILM" +
                     "\n\t - [3] VOIR TOUS LES FILMS" +
                     "\n\t - [4] VOIR TOUTE LES PERSONNES");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    AjouterUnePersonne();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    AjouterUnFilm();
                    Console.Clear();
                    break;
                case ConsoleKey.NumPad3:
                    Console.Clear();
                    Showfilm();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case ConsoleKey.NumPad4:
                    Console.Clear();
                    Showpersonne();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
        #endregion

        #region [Interface] Ajouter une personne
        public static void AjouterUnePersonne()
        {
            Console.WriteLine("Ajout d'une personne: ");
            bool veriftest = false;
            Personnes x = new Personnes();

            #region Chant Nom
            while (veriftest == false)
            {
                try
                {
                    Console.Write("Nom: ");
                    x.Nom= Console.ReadLine();
                    veriftest = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Nom invalide !");
                }
            }
            veriftest = false;
            #endregion

            #region Chant Prénom
            while (veriftest == false)
            {
                try
                {
                    Console.Write("Prénom: ");
                    x.Prenom = Console.ReadLine();
                    veriftest = true;
                }
                catch (Exception )
                {
                    Console.WriteLine("Prénom invalide !");
                }
            }
            veriftest = false;
            #endregion

            #region Chant Date de naissance 
            while (veriftest == false)
            {
                try
                {
                    Console.Write("Date de naissance (YYYY/MM/DD) : ");
                    string date = Console.ReadLine();
                    x.DateNaissance = Convert.ToDateTime(date);
                    veriftest = true;
                }
                catch (Exception )
                {
                    Console.WriteLine("Date de naissance invalide !");
                }
            }
            veriftest = false;
            #endregion

            #region Chant adresse
            while (veriftest == false)
            {
                try
                {
                    Console.Write("Adresse postal: ");
                    x.Adresse = Console.ReadLine();
                    veriftest = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Adresse invalide !");
                }
            }
            veriftest = false;
            #endregion

            #region Chant ville
            while (veriftest == false)
            {
                try
                {
                    Console.Write("Ville: ");
                    x.Ville = Console.ReadLine();
                    veriftest = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("No mde ville invalide !");
                }
            }
            veriftest = false;
            #endregion

            #region Chant CodePostal
            while (veriftest == false)
            {
                try
                {
                    Console.Write("Adresse postal: ");
                    x.CodePostal = Console.ReadLine();
                    veriftest = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Code postal invalide !");
                }
            }
            veriftest = false;
            #endregion

            #region Chant taille
            while (veriftest == false)
            {
                try
                {
                    Console.Write("Taille: ");
                    x.Taille= Convert.ToInt32(Console.ReadLine());
                    veriftest = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Taille invalide!");
                }
            }
            veriftest = false;
            #endregion

            #region Chant poids
            while (veriftest == false)
            {
                try
                {
                    Console.Write("Poids: ");
                    x.Adresse = Console.ReadLine();
                    veriftest = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Poids invalide !");
                }
            }
            veriftest = false;
            #endregion

            DataAccess.AddPersonnes(x);
            Console.Clear();
            MenuPrincipal();
        }
        #endregion

        #region [Interface] Ajouter un film
        public static void AjouterUnFilm()
        {
            Console.WriteLine("Ajout d'un film: ");
            bool veriftest = false;
            Films x = new Films();

            #region Chant Titre
            while (veriftest == false)
            {
                try
                {
                    Console.Write("Titre: ");
                    x.Titre_film = Console.ReadLine();
                    veriftest = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Titre invalide !");
                }
            }
            veriftest = false;
            #endregion

            #region Chant Réalisateur
            while (veriftest == false)
            {
                try
                {
                    Console.Write("Réalisateur: ");
                    x.Realisateur_film = Console.ReadLine();
                    veriftest = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Réalisateur invalide !");
                }
            }
            veriftest = false;
            #endregion

            #region Chant DateDeSortie
            while (veriftest == false)
            {
                try
                {
                    Console.Write("Date de sortie : ");
                    string date = Console.ReadLine();
                    x.Date_sortie_film = Convert.ToDateTime(date);
                    veriftest = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Date de sortie invalide !");
                }
            }
            veriftest = false;
            #endregion

            #region Chant Resumé
            while (veriftest == false)
            {
                try
                {
                    Console.Write("Résumer: ");
                    x.Resume_film = Console.ReadLine();
                    veriftest = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Resume invalide !");
                }
            }
            veriftest = false;
            #endregion

            #region Chant Genre
            while (veriftest == false)
            {
                try
                {
                    Console.Write("Genre: ");
                    x.Genre_film = Console.ReadLine();
                    veriftest = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Genre invalide !");
                }
            }
            veriftest = false;
            #endregion

            #region Chant Durée
            while (veriftest == false)
            {
                try
                {
                    Console.Write("Durée: ");
                    x.Duree_film = Convert.ToInt32(Console.ReadLine());
                    veriftest = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Durée invalide !");
                }
            }
            veriftest = false;
            #endregion

            DataAccess.AddFilm(x);
            Console.Clear();
            MenuPrincipal();
        }
        #endregion

        #region [Interface] Voir tout les films
        static void Showfilm()
        {
            List<Films> films = DataAccess.GetAllFilms();
            foreach(Films film in films)
            {
                Console.WriteLine("\nTitre: " + film.Titre_film + " | Réalisateur: " + film.Realisateur_film + " | Date sortie film: " + film.Date_sortie_film + " | Resumé: " + film.Resume_film + " | Genre: " + film.Genre_film + " | Durée film: " + film.Duree_film);
            }
        }
        #endregion

        #region [Interface] Voir toute les personnes
        static void Showpersonne()
        {
            List<Personnes> personne = DataAccess.GetAllPersonnes();
            foreach (Personnes x in personne)
            {
                Console.WriteLine("\nNom: " + x.Nom + " | Prénom: " + x.Prenom + " | Date de naissance : " + x.DateNaissance + " | Adresse: " + x.Adresse + " | Ville: " + x.Ville + " | Code postal: " + x.CodePostal + " | Taille: " + x.Taille + " | Poids: "+ x.Poids);
            }
        }
        #endregion
    }
}
