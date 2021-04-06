using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1.Доб_Админ.Сотрудники;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Доб_Админ.Сотрудники.Tests
{

    [TestClass()]
    public class SotrTests
    {
        Сотрудники.Sotr ST = new Сотрудники.Sotr();
        [TestMethod()]
        public void InsSotrTest()
        {

            bool actual = true,
               expected = true;

            string Id = null,
                Сотрудник = "Гена",
                пароль = "33333";

            try
            {
                actual = ST.InsSotr(Id, Сотрудник, пароль);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);


        }
        [TestMethod()]
        public void InsSotrTest_id()
        {

            bool actual = false,
              expected = false;

            string Id = "2134",
                Сотрудник = "Борис",
                пароль = "34536";

            try
            {
                actual = ST.InsSotr(Id, Сотрудник, пароль);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void InsSotrTest_Symbol()
        {

            bool actual = false,
               expected = false;

            string Id = null,
                 Сотрудник = ";?;(**?%",
                 пароль = "343546";

            try
            {
                actual = ST.InsSotr(Id, Сотрудник, пароль);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void InsSotrTest_Number()
        {

            bool actual = false,
               expected = false;

            string Id = null,
                 Сотрудник = "88888888",
                 пароль = "34536";

            try
            {
                actual = ST.InsSotr(Id, Сотрудник, пароль);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void InsSotrTest_Null()
        {

            bool actual = false,
               expected = false;

            string Id = null,
                Сотрудник = "",
                пароль = "";

            try
            {
                actual = ST.InsSotr(Id, Сотрудник, пароль);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);

        }


    }
    [TestClass()]
    public class SotrTestsDel
    {
        Сотрудники.Sotr ST = new Сотрудники.Sotr();

        [TestMethod()]
        public void Delete_SotrTest()
        {
            bool actual = true,
               expected = true;

            string Id = "4";


            try
            {
                actual = ST.Delete_Sotr(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Delete_SotrTest_not_id()
        {

            bool actual = false,
               expected = false;

            string Id = "66";


            try
            {
                actual = ST.Delete_Sotr(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Delete_SotrTest_Symbol()
        {

            bool actual = false,
               expected = false;

            string Id = "$%";


            try
            {
                actual = ST.Delete_Sotr(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Delete_SotrTest_Text()
        {

            bool actual = false,
               expected = false;

            string Id = "выапр";


            try
            {
                actual = ST.Delete_Sotr(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Delete_SotrTest_Null()
        {

            bool actual = false,
               expected = false;

            string Id = "";


            try
            {
                actual = ST.Delete_Sotr(Id);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }


    }
    [TestClass()]
    public class SotrTestsUpd
    {
        Сотрудники.Sotr ST = new Сотрудники.Sotr();


        [TestMethod()]
        public void Update_SotrTest()
        {
            bool actual = true,
               expected = true;

            string Id = "2",
                Сотрудник = "Гена",
                пароль = "33333";

            try
            {
                actual = ST.Update_Sotr(Id, Сотрудник, пароль);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Update_SotrTest_NotId()
        {
            bool actual = false,
               expected = false;

            string Id = "23423",
                Сотрудник = "Гена",
                пароль = "33333";

            try
            {
                actual = ST.Update_Sotr(Id, Сотрудник, пароль);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Update_SotrTest_NullFail()
        {
            bool actual = false,
               expected = false;

            string Id = null,
                Сотрудник = "",
                пароль = "";

            try
            {
                actual = ST.Update_Sotr(Id, Сотрудник, пароль);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Update_SotrTest_txtId()
        {
            bool actual = false,
              expected = false;

            string Id = "wetwd",
                Сотрудник = "Гена",
                пароль = "33333";

            try
            {
                actual = ST.Update_Sotr(Id, Сотрудник, пароль);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Update_SotrTest_Symbol()
        {
            bool actual = false,
                expected = false;

            string Id = null,
                Сотрудник = "%(*&$%",
                пароль = "33333";

            try
            {
                actual = ST.Update_Sotr(Id, Сотрудник, пароль);

            }
            catch
            {
                Assert.Fail();

            }
            Assert.AreEqual(expected, actual);
        }
    }
}