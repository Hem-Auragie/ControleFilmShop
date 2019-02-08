using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilmsLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class Tests
    {
        #region [TEST] Connexion base de données
        //Test quand la connexion est bonne
        [TestMethod]
        public void TestConnexionBDDOK()
        {
            bool result = DataAccess.TestDeConnexionBaseDeDonnees(DataAccess.CHEMINBDD);
            Assert.AreEqual(true, result);
        }

        //Test quand la connexion n'est pas bonne
        [TestMethod]
        public void TestConnexionBDDPasOK()
        {
            bool result = DataAccess.TestDeConnexionBaseDeDonnees(" ");
            Assert.AreEqual(false, result);
        }
        #endregion

        //Vérifie quand c'est bon
        [TestMethod]
        public void Verifie_Si_Nom_Est_Bon()
        {
            var personne = new Personnes();
            personne.Nom = "test";

            Assert.AreEqual("test", personne.Nom);
        }


        //Vérifie quand c'est bon
        [TestMethod]
        public void Verifie_Si_Prenom_Est_Bon()
        {
            var personne = new Personnes();
            personne.Prenom = "test";

            Assert.AreEqual("test", personne.Prenom);
        }

        //Vérifie quand c'est bon
        [TestMethod]
        public void Verifie_Si_Ville_Est_Bon()
        {
            var personne = new Personnes();
            personne.Ville = "test";

            Assert.AreEqual("TEST", personne.Ville);
        }

        //Vérifie quand c'est bon
        [TestMethod]
        public void Verifie_Si_Adresse_Est_Bon()
        {
            var personne = new Personnes();
            personne.Adresse = "test";

            Assert.AreEqual("test", personne.Adresse);
        }

        //Vérifie quand c'est bon
        [TestMethod]
        public void Verifie_Si_Titre_Est_Bon()
        {
            var film = new Films();
            film.Titre_film = "test";

            Assert.AreEqual("test", film.Titre_film);
        }

        //Vérifie quand c'est bon
        [TestMethod]
        public void Verifie_Si_Resume_Est_Bon()
        {
            var film = new Films();
            film.Resume_film = "test";

            Assert.AreEqual("test", film.Resume_film);
        }

        //Vérifie quand c'est bon
        [TestMethod]
        public void Verifie_Si_Genre_Est_Bon()
        {
            var film = new Films();
            film.Genre_film = "test";

            Assert.AreEqual("test", film.Genre_film);
        }

        //Vérifie quand c'est bon
        [TestMethod]
        public void Verifie_Si_CodePostal_Est_Bon()
        {
            var personne = new Personnes();
            personne.CodePostal = "67230";

            Assert.AreEqual("67230", personne.CodePostal);
        }
    }
}
