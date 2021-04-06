using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1.Доб_Админ.Роты;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Доб_Админ.Роты.Tests
{

    [TestClass()]
    public class RoteTests
    {

        Роты.Rote RT = new Роты.Rote();
        [TestMethod()]
        public void InsRoteTest()
        {

            bool actual = true,
               expected = true;

            string Id = null,
                Рота = "887";

            try
            {
                actual = RT.InsRote(Id, Рота);

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
                Рота = "857";

            try
            {
                actual = RT.InsRote(Id, Рота);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void InsRoteTest_Symbol()
        {

            bool actual = false,
               expected = false;

            string Id = null,
                Рота = "#^*&";

            try
            {
                actual = RT.InsRote(Id, Рота);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void InsRoteTest_Syboles()
        {

            bool actual = false,
               expected = false;

            string Id = "sdf",
                Рота = "#^*&";

            try
            {
                actual = RT.InsRote(Id, Рота);

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
                Рота = "";

            try
            {
                actual = RT.InsRote(Id, Рота);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);

        }


    }
    [TestClass()]
    public class RoteTestsDel
    {

        Роты.Rote RT = new Роты.Rote();



        [TestMethod()]
        public void Delete_RoteTest()
        {

            bool actual = true,
               expected = true;

            string Id = "3";


            try
            {
                actual = RT.Delete_Role(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Delete_RoteTest_not_id()
        {

            bool actual = false,
               expected = false;

            string Id = "66";


            try
            {
                actual = RT.Delete_Role(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Delete_RoteTest_Symbol()
        {

            bool actual = false,
               expected = false;

            string Id = "$%";


            try
            {
                actual = RT.Delete_Role(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Delete_RoteTest_Text()
        {

            bool actual = false,
               expected = false;

            string Id = "выапр";


            try
            {
                actual = RT.Delete_Role(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Delete_RoteTest_Null()
        {

            bool actual = false,
               expected = false;

            string Id = "";


            try
            {
                actual = RT.Delete_Role(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }




    }
    [TestClass()]
    public class RoteTestsUpd
    {

        Роты.Rote RT = new Роты.Rote();



        [TestMethod()]
        public void Update_RoteTest()
        {
            bool actual = true,
               expected = true;

            string Id = "2",
                Рота = "857";

            try
            {
                actual = RT.InsRote(Id, Рота);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Update_RoteTest_NotId()
        {
            bool actual = false,
               expected = false;

            string Id = "456",
                Рота = "857";

            try
            {
                actual = RT.InsRote(Id, Рота);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Update_RoteTest_NullFail()
        {
            bool actual = false,
               expected = false;

            string Id = "2",
                Рота = "";

            try
            {
                actual = RT.InsRote(Id, Рота);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Update_RoteTest_txtId()
        {
            bool actual = false,
               expected = false;

            string Id = "kjhnlkjkj",
                Рота = "857";

            try
            {
                actual = RT.InsRote(Id, Рота);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Update_RoteTest_Symbol()
        {
            bool actual = false,
               expected = false;

            string Id = "2",
                Рота = "*%$(*&)*&$";

            try
            {
                actual = RT.InsRote(Id, Рота);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }

    }
}