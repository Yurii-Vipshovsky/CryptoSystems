using Cezar.CriptoSystems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCryptosystem
{


    [TestClass]
    public class GammaTest
    {
        Gamma gamma = new Gamma();

        [TestMethod]
        public void Test_Gamma_Ukrainian_Encript_Costant1()
        {
            string decripted = "Вітаю Мій Друже!";
            for (int i = 0; i < decripted.Length; ++i)
            {
                gamma.gamma.Add(1);
            }
            string expected = "Гїубя!Нїк!Есфзж\"";
            string result = gamma.encrypt(decripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Gamma_Ukrainian_Decript_Constant1()
        {
            string encripted = "Гїубя!Нїк!Есфзж\"";
            string expected = "Вітаю Мій Друже!";
            for (int i = 0; i < encripted.Length; ++i)
            {
                gamma.gamma.Add(1);
            }
            string result = gamma.decrypt(encripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Gamma_English_Encript_Constant1()
        {
            string decripted = "Hello My Friend!";
            for (int i = 0; i < decripted.Length; ++i)
            {
                gamma.gamma.Add(1);
            }
            string expected = "Ifmmp!Nz!Gsjfoe\"";
            string result = gamma.encrypt(decripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Gamma_English_Decript_Constant1()
        {
            string encripted = "Ifmmp!Nz!Gsjfoe\"";
            string expected = "Hello My Friend!";
            for (int i = 0; i < encripted.Length; ++i)
            {
                gamma.gamma.Add(1);
            }
            string result = gamma.decrypt(encripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Gamma_Creation()
        {
            string decripted = "Hello My Friend!";
            gamma.gamma.Clear();
            string result1 = gamma.encrypt(decripted);
            gamma.gamma.Clear();
            string result2 = gamma.encrypt(decripted);
            Assert.AreNotEqual(result1, result2);
        }

    }
}
