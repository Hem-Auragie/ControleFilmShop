using System;
using MySql.Data.MySqlClient;

namespace ControleLibrary
{
    public class DataAccess
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
        /// <param name="CheminBDD"></param>
        /// <returns></returns>
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
    }
}
