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
    }
}
