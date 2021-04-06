using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1.Доб_Админ.Звания;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Доб_Админ.Звания.Tests
{
    [TestClass()]
    public class ZvanieTests
    {
        Звания.Zvanie ZV = new Звания.Zvanie();
        [TestMethod()]
        public void InsZvanieTest()
        {

            bool actual = true,
               expected = true;

            string Id = null,
            Звание = "СтСержант";

            try
            {
                actual = ZV.InsZvanie(Id, Звание);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);


        }
        [TestMethod()]
        public void InsRoteTest_id()
        {

            bool actual = false,
               expected = false;

            string Id = "1",
                Звание = "уке";

            try
            {
                actual = ZV.InsZvanie(Id, Звание);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void InsZvanieTest_Symbol()
        {

            bool actual = false,
               expected = false;

            string Id = null,
                Звание = "#^*&";

            try
            {
                actual = ZV.InsZvanie(Id, Звание);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void InsZvanieTest_Syboles()
        {

            bool actual = false,
               expected = false;

            string Id = "sdf",
                Звание = "#^*&";

            try
            {
                actual = ZV.InsZvanie(Id, Звание);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void InsZvanieTest_Null()
        {

            bool actual = false,
               expected = false;

            string Id = null,
                Звание = "";

            try
            {
                actual = ZV.InsZvanie(Id, Звание);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);

        }





    }
    [TestClass()]
    public class ZvanieTestsDel
    {
        Звания.Zvanie ZV = new Звания.Zvanie();










        [TestMethod()]
        public void Delete_ZvanieTest()
        {
            bool actual = true,
              expected = true;

            string Id = "5";


            try
            {
                actual = ZV.Delete_Zvanie(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Delete_ZvanieTest_not_id()
        {

            bool actual = false,
               expected = false;

            string Id = "456";


            try
            {
                actual = ZV.Delete_Zvanie(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Delete_ZvanieTest_Symbol()
        {

            bool actual = false,
               expected = false;

            string Id = "$?*%";


            try
            {
                actual = ZV.Delete_Zvanie(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Delete_ZvanieTest_Text()
        {

            bool actual = false,
               expected = false;

            string Id = "выаыпыпр";


            try
            {
                actual = ZV.Delete_Zvanie(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Delete_ZvanieTest_Null()
        {

            bool actual = false,
               expected = false;

            string Id = "";


            try
            {
                actual = ZV.Delete_Zvanie(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }





    }
    [TestClass()]
    public class ZvanieTestsIns
    {
        Звания.Zvanie ZV = new Звания.Zvanie();






        [TestMethod()]
        public void Update_ZvanieTest()
        {
            bool actual = true,
               expected = true;

            string Id = "1",
                Звание = "Рядовой";

            try
            {
                actual = ZV.Update_Zvanie(Id, Звание);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Update_ZvanieTest_NotId()
        {
            bool actual = false,
               expected = false;

            string Id = "456",
                Звание = "857";

            try
            {
                actual = ZV.Update_Zvanie(Id, Звание);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Update_ZvanieTest_NullFail()
        {
            bool actual = false,
               expected = false;

            string Id = "2",
                Звание = "";

            try
            {
                actual = ZV.Update_Zvanie(Id, Звание);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Update_ZvanieTest_txtId()
        {
            bool actual = false,
               expected = false;

            string Id = "kjhnlkjkj",
                Звание = "857";

            try
            {
                actual = ZV.Update_Zvanie(Id, Звание);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Update_ZvanieTest_Symbol()
        {
            bool actual = false,
               expected = false;

            string Id = "2",
                Звание = "*%$(*&)*&$";

            try
            {
                actual = ZV.Update_Zvanie(Id, Звание);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
    }
}