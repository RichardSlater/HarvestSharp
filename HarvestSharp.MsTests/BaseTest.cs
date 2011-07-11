using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HarvestSharp.test
{
    [TestClass]
    public class BaseTest
    {
        public Account_Mock account;
        public Harvest harvest;

        [TestInitialize()]
        public void MyTestInitialize()
        {
            CreateNewAccount();
        }

        private void CreateNewAccount()
        {
            account = new Account_Mock();
            harvest = new Harvest(account);
        }
    }
}
