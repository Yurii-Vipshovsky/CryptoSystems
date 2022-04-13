using Cezar.CriptoSystems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCryptosystem
{
    [TestClass]
    public class RSATest
    {
        RSA rsa = new RSA() {openKey = 3, closedKey = 6111579, n = 9173503 };
        
        //prepere before tests set values for open key, closed key, n

        [TestMethod]
        public void Test_RSA_Ukrainian_Encript()
        {
            string decripted = "Вітаю Мій Друже!";
            string expected = "3025219;779053;1565077;2675846;8115273;32768;8391230;779053;6444530;32768;378812;3623052;5132648;5130144;1647125;35937;";
            string result = rsa.encrypt(decripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_RSA_Ukrainian_Decript()
        {
            string encripted = "3025219;779053;1565077;2675846;8115273;32768;8391230;779053;6444530;32768;378812;3623052;5132648;5130144;1647125;35937;";
            string expected = "Вітаю Мій Друже!";
            string result = rsa.decrypt(encripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_RSA_English_Encript()
        {
            string decripted = "Hello My Friend!";
            string expected = "373248;1030301;1259712;1259712;1367631;32768;456533;1771561;32768;343000;1481544;1157625;1030301;1331000;1000000;35937;";
            string result = rsa.encrypt(decripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_RSA_English_Decript()
        {
            string encripted = "373248;1030301;1259712;1259712;1367631;32768;456533;1771561;32768;343000;1481544;1157625;1030301;1331000;1000000;35937;";
            string expected = "Hello My Friend!";
            string result = rsa.decrypt(encripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_RSA_Creation()
        {
            string decripted = "Hello My Friend!";
            RSA rsa1 = new RSA();
            string result1 = rsa1.encrypt(decripted);
            rsa1 = new RSA();
            string result2 = rsa1.encrypt(decripted);
            Assert.AreNotEqual(result1, result2);
        }
        [TestMethod]
        public void Test_RSA_int()
        {
            Assert.AreEqual(4051753, rsa.encrypt(111111));
        }
        [TestMethod]
        public void Test_RSA_intD()
        {
            Assert.AreEqual(111111, rsa.decrypt(4051753));
        }
    }
}
