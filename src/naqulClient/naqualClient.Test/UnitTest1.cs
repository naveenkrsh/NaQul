using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using naqulClient.Helper;

namespace naqualClient.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataSet ds = DBHelper.GetDataFromDB("SELECT * FROM Employees;");

            //Assert
            Assert.AreEqual(1, ds.Tables.Count);

        }

        [TestMethod]
        public void TestMultipleTable()
        {
            DataSet ds = DBHelper.GetDataFromDB("SELECT * FROM Employees;SELECT * FROM Customers;");

            //Assert
            Assert.AreEqual(2, ds.Tables.Count);

        }
    }
}
