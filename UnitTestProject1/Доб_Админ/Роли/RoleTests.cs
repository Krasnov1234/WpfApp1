using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1.Доб_Админ.Роли;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Доб_Админ.Роли.Tests
{
    [TestClass()]
    public class RoleTests
    {
        Роли.Role RL = new Роли.Role();
        [TestMethod()]
        public void InsRoleTest()
        {
            bool actual = true,
               expected = true;

            string Id = null,
                Роли = "Старшина";

            try
            {
                actual = RL.InsRole(Id, Роли);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);


        }
        [TestMethod()]
        public void InsRoleTest_id()
        {

            bool actual = false,
               expected = false;

            string Id = "1",
                Роли = "правпрапроа";

            try
            {
                actual = RL.InsRole(Id, Роли);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void InsRoleTest_Symbol()
        {

            bool actual = false,
               expected = false;

            string Id = null,
                Роли = "#^*&";

            try
            {
                actual = RL.InsRole(Id, Роли);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void InsRoleTest_Number()
        {

            bool actual = false,
               expected = false;

            string Id = null,
                Роли = "23478";

            try
            {
                actual = RL.InsRole(Id, Роли);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void InsRoteTest_Null()
        {

            bool actual = false,
               expected = false;

            string Id = null,
                Роли = "";

            try
            {
                actual = RL.InsRole(Id, Роли);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);

        }


    }
    [TestClass()]
    public class RoleTestsDel
    {
        Роли.Role RL = new Роли.Role();





        [TestMethod()]
        public void Delete_RoleTest()
        {

            bool actual = true,
               expected = true;

            string Id = "3";


            try
            {
                actual = RL.Delete_Role(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Delete_RoleTest_not_id()
        {

            bool actual = false,
               expected = false;

            string Id = "66";


            try
            {
                actual = RL.Delete_Role(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Delete_RoleTest_Symbol()
        {

            bool actual = false,
               expected = false;

            string Id = "$%";


            try
            {
                actual = RL.Delete_Role(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Delete_RoleTest_Text()
        {

            bool actual = false,
               expected = false;

            string Id = "выапр";


            try
            {
                actual = RL.Delete_Role(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Delete_RoleTest_Null()
        {

            bool actual = false,
               expected = false;

            string Id = "";


            try
            {
                actual = RL.Delete_Role(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }


    }
    [TestClass()]
    public class RoleTestsIns
    {
        Роли.Role RL = new Роли.Role();



        [TestMethod()]
        public void Update_RoleTest()
        {
            bool actual = false,
               expected = false;

            string Id = "2",
                Роли= "857";

            try
            {
                actual = RL.Update_Role(Id, Роли);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Update_RoleTest_NotId()
        {
            bool actual = false,
               expected = false;

            string Id = "456",
                Роли = "857";

            try
            {
                actual = RL.Update_Role(Id, Роли);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Update_RoleTest_NullFail()
        {
            bool actual = false,
               expected = false;

            string Id = "2",
                Роли = "";

            try
            {
                actual = RL.Update_Role(Id, Роли);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Update_RoleTest_txtId()
        {
            bool actual = false,
               expected = false;

            string Id = "kjhnlkjkj",
                Роли = "857";

            try
            {
                actual = RL.Update_Role(Id, Роли);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Update_RoleTest_Symbol()
        {
            bool actual = false,
               expected = false;

            string Id = "2",
                Роли = "*%$(*&)*&$";

            try
            {
                actual = RL.Update_Role(Id, Роли);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
    }
}