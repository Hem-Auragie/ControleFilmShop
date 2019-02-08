using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace FilmsLibrary
{
    public static class DataAccess
    {
        //Chemin BDD
        #region [BDD] Chemin vers la base de données
        /// <summary>
        /// Chemin d'accès à la base de données ici sur MySql PhpmyAdmin.
        /// </summary>
        public const string CHEMINBDD = "SERVER=127.0.0.1; DATABASE=bdd_filmshop; UID=root; PASSWORD=;";
        #endregion

        #region [BDD] Test de connexion
        /// <summary>
        /// Fonction servant à tester si la base de données fonctionne
        /// </summary>

        public static bool TestDeConnexionBaseDeDonnees(string CheminBDD)
        {
            bool resultat = false;
            try
            {
                using (MySqlConnection db = new MySqlConnection(CheminBDD))
                {
                    db.Open();
                    resultat = true;
                }
                return resultat;
            }
            catch (Exception)
            {
                return resultat;
            }
        }
        #endregion


        //Fonctions Ajouter
        #region [BDD] Ajouter une personne
        public static void AddPersonnes(Personnes x)
        {
            using (MySqlConnection db = new MySqlConnection(CHEMINBDD))
            {
                db.Open();

                MySqlCommand firstInsert =
                    new MySqlCommand("INSERT INTO personnes (Nom_Pers,Prenom_Pers,DateNaissance_Pers,Adresse_Pers,Ville_Pers,CodePostal_Pers,Taille_Pers,Poids_Pers) VALUES (@nom, @prenom, @datenaissance, @adresse, @ville, @codepostal,@taille, @poids)", db);
                var nomParameter = new MySqlParameter("@nom", x.Nom);
                var prenomParameter = new MySqlParameter("@prenom", x.Prenom);
                var datenaissanceParameter = new MySqlParameter("@datenaissance", x.DateNaissance);
                var adresseParameter = new MySqlParameter("@adresse", x.Adresse);
                var villeParameter = new MySqlParameter("@ville", x.Ville);
                var codepostalParameter = new MySqlParameter("@codepostal", x.CodePostal);
                var tailleParameter = new MySqlParameter("@taille", x.Taille);
                var poidsParameter = new MySqlParameter("@poids", x.Poids);
                firstInsert.Parameters.Add(nomParameter);
                firstInsert.Parameters.Add(prenomParameter);
                firstInsert.Parameters.Add(datenaissanceParameter);
                firstInsert.Parameters.Add(adresseParameter);
                firstInsert.Parameters.Add(villeParameter);
                firstInsert.Parameters.Add(codepostalParameter);
                firstInsert.Parameters.Add(tailleParameter);
                firstInsert.Parameters.Add(poidsParameter);
                firstInsert.ExecuteNonQuery();
            }

        }
        #endregion

        #region [BDD] Ajouter un film 
        public static void AddFilm(Films x)
        {
            using (MySqlConnection db = new MySqlConnection(CHEMINBDD))
            {
                db.Open();

                MySqlCommand firstInsert =
                    new MySqlCommand("INSERT INTO films (Titre_Film,Realisateur_Film,DateSortie_Film,Resume_Film,Genre_Film,Duree_Film) VALUES (@titre, @realisateur, @datesortie, @resume, @genre, @duree)", db);
                var titreParameter = new MySqlParameter("@titre", x.Titre_film);
                var realisateurParameter = new MySqlParameter("@realisateur", x.Realisateur_film);
                var datesortieParameter = new MySqlParameter("@datesortie", x.Date_sortie_film);
                var resumeParameter = new MySqlParameter("@resume", x.Resume_film);
                var genreParameter = new MySqlParameter("@genre", x.Genre_film);
                var dureeParameter = new MySqlParameter("@duree", x.Duree_film);
                firstInsert.Parameters.Add(titreParameter);
                firstInsert.Parameters.Add(realisateurParameter);
                firstInsert.Parameters.Add(datesortieParameter);
                firstInsert.Parameters.Add(resumeParameter);
                firstInsert.Parameters.Add(genreParameter);
                firstInsert.Parameters.Add(dureeParameter);
                firstInsert.ExecuteNonQuery();
            }
        }
        #endregion

        //Fonctions Afficher
        #region [BDD] Afficher tous les films
        public static List<Films> GetAllFilms()
        {
            List<Films> entries = new List<Films>();
            using (MySqlConnection db = new MySqlConnection(CHEMINBDD))
            {
                db.Open();

                MySqlCommand selectCommand = new MySqlCommand
                    ("SELECT * FROM films", db);

                MySqlDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    Films x = new Films();
                    x.Titre_film = query.GetString(1);
                    x.Realisateur_film = query.GetString(2);
                    x.Date_sortie_film = query.GetDateTime(3);
                    x.Resume_film = query.GetString(4);
                    x.Genre_film = query.GetString(5);
                    x.Duree_film = query.GetInt32(6);
                    entries.Add(x);
                }
                return entries;
            }
        }
        #endregion

        #region [BDD] Afficher toutes les personnes
        public static List<Personnes> GetAllPersonnes()
        {
            List<Personnes> entries = new List<Personnes>();
            using (MySqlConnection db = new MySqlConnection(CHEMINBDD))
            {
                db.Open();

                MySqlCommand selectCommand = new MySqlCommand
                    ("SELECT * FROM personnes", db);

                MySqlDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    Personnes x = new Personnes();
                    x.Nom = query.GetString(1);
                    x.Prenom = query.GetString(2);
                    x.DateNaissance = query.GetDateTime(3);
                    x.Adresse = query.GetString(4);
                    x.Ville = query.GetString(5);
                    x.CodePostal = query.GetString(6);
                    x.Taille = query.GetInt32(7);
                    x.Poids = query.GetInt32(8);
                    entries.Add(x);
                }
                return entries;
            }
        }
        #endregion


        #region [BDD] Affiche un film grâce à son ID
        public static void GetFilmById(int ID)
        {
            using (MySqlConnection db = new MySqlConnection(CHEMINBDD))
            {
                db.Open();
                MySqlCommand firstInsert = new MySqlCommand("SELECT * FROM films WHERE ID_Film = @id)", db);
                firstInsert.Parameters.AddWithValue("@id", ID);
                MySqlDataReader reader = firstInsert.ExecuteReader();
                firstInsert.ExecuteNonQuery();
            }
        }
        #endregion

        #region [BDD] Affiche une personne grâce à son ID
        public static void GetPersonneById(int ID)
        {
            using (MySqlConnection db = new MySqlConnection(CHEMINBDD))
            {
                db.Open();
                MySqlCommand firstInsert = new MySqlCommand("SELECT * FROM personnes WHERE ID_Film = @id)", db);
                firstInsert.Parameters.AddWithValue("@id", ID);
                MySqlDataReader reader = firstInsert.ExecuteReader();
                firstInsert.ExecuteNonQuery();
            }
        }
        #endregion

        #region [BDD] Affiche un film en fonction de son genre
        public static void GetFilmByGenre(string genre)
        {
            using (MySqlConnection db = new MySqlConnection(CHEMINBDD))
            {
                db.Open();
                MySqlCommand firstInsert = new MySqlCommand("SELECT * FROM films WHERE Genre_Film= @genre)", db);
                firstInsert.Parameters.AddWithValue("@genre", genre);
                firstInsert.ExecuteNonQuery();
                MySqlDataReader reader = firstInsert.ExecuteReader();
            }
        }
        #endregion

        #region [BDD] Affiche un film en fonction de l'année de sortie
        public static void GetFilmByGenre(int annee)
        {
            using (MySqlConnection db = new MySqlConnection(CHEMINBDD))
            {
                db.Open();
                MySqlCommand firstInsert = new MySqlCommand("SELECT * FROM films WHERE DateSortie_Film= @annee)", db);
                firstInsert.Parameters.AddWithValue("@annee", annee);
                firstInsert.ExecuteNonQuery();
                MySqlDataReader reader = firstInsert.ExecuteReader();
            }
        }
        #endregion


    }

}
