using Cezar.CriptoSystems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCryptosystem
{
    
    [TestClass]
    public class TrtemiusTest
    {
    #region UkrainianTests
        [TestMethod]
        public void Test_Trtemius_Ukrainian_Linear_Encript()
        {
            string decripted = "³��� ̳� �����!";
            Trtemius encripter = new Trtemius(new TrtemiusInitData()
            {
                isEng = false,
                isLinear = true,
                isMotto = false,
                linear = new int[2] { 3, 2 }
            });
            string expected = "����� ��� �����!";
            string result = encripter.encrypt(decripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_Ukrainian_Linear_Decript()
        {
            string encripted = "����� ��� �����!";
            Trtemius encripter = new Trtemius(new TrtemiusInitData()
            {
                isEng = false,
                isLinear = true,
                isMotto = false,
                linear = new int[2] { 3, 2 }
            });
            string expected = "³��� ̳� �����!";
            string result = encripter.decrypt(encripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_Ukrainian_Square_Encript()
        {
            string decripted = "³��� ̳� �����!";
            Trtemius encripter = new Trtemius(new TrtemiusInitData()
            {
                isEng = false,
                isLinear = false,
                isMotto = false,
                square = new int[3] { 3, 2, 1 }
            });
            string expected = "����� ��� �����!";
            string result = encripter.encrypt(decripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_Ukrainian_Square_Decript()
        {
            string encripted = "����� ��� �����!";
            Trtemius encripter = new Trtemius(new TrtemiusInitData()
            {
                isEng = false,
                isLinear = false,
                isMotto = false,
                square = new int[3] { 3, 2, 1 }
            });
            string expected = "³��� ̳� �����!";
            string result = encripter.decrypt(encripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_Ukrainian_Motto_Encript()
        {
            string decripted = "³��� ̳� �����!";
            string MottoText = "����������";
            int[] Motto = new int[MottoText.Length];
            for (int i = 0; i < MottoText.Length; ++i)
            {
                Motto[i] = (int)System.Enum.Parse(typeof(UkrainianABC), MottoText[i].ToString().ToLower());
            }
            Trtemius encripter = new Trtemius(new TrtemiusInitData()
            {
                isEng = false,
                isLinear = false,
                isMotto = true,
                motto = Motto
            });
            string expected = "����� ��� �����!";
            string result = encripter.encrypt(decripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_Ukrainian_Motto_Decript()
        {
            string encripted = "����� ��� �����!";
            string MottoText = "����������";
            int[] Motto = new int[MottoText.Length];
            for (int i = 0; i < MottoText.Length; ++i)
            {
                Motto[i] = (int)System.Enum.Parse(typeof(UkrainianABC), MottoText[i].ToString().ToLower());
            }
            Trtemius encripter = new Trtemius(new TrtemiusInitData()
            {
                isEng = false,
                isLinear = false,
                isMotto = true,
                motto = Motto
            });
            string expected = "³��� ̳� �����!";
            string result = encripter.decrypt(encripted);
            Assert.AreEqual(expected, result);
        }
        #endregion
    #region EnglishTests
        [TestMethod]
        public void Test_Trtemius_English_Linear_Encript()
        {
            string decripted = "Hello My Friend!";
            Trtemius encripter = new Trtemius(new TrtemiusInitData()
            {
                isEng = true,
                isLinear = true,
                isMotto = false,
                linear = new int[2] { 2, 3 }
            });
            string expected = "Kjsuz Bp Aohfqi!";
            string result = encripter.encrypt(decripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_English_Linear_Decript()
        {
            string encripted = "Kjsuz Bp Aohfqi!";
            Trtemius encripter = new Trtemius(new TrtemiusInitData()
            {
                isEng = true,
                isLinear = true,
                isMotto = false,
                linear = new int[2] { 2, 3 }
            });
            string expected = "Hello My Friend!";
            string result = encripter.decrypt(encripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_English_Square_Encript()
        {
            string decripted = "Hello My Friend!";
            Trtemius encripter = new Trtemius(new TrtemiusInitData()
            {
                isEng = true,
                isLinear = false,
                isMotto = false,
                square = new int[3] { 2, 1, 3 }
            });
            string expected = "Kkyjb Pc Xwevdw!";
            string result = encripter.encrypt(decripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_English_Square_Decript()
        {
            string encripted = "Kkyjb Pc Xwevdw!";
            Trtemius encripter = new Trtemius(new TrtemiusInitData()
            {
                isEng = true,
                isLinear = false,
                isMotto = false,
                square = new int[3] { 2, 1, 3 }
            });
            string expected = "Hello My Friend!";
            string result = encripter.decrypt(encripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_English_Motto_Encript()
        {
            string decripted = "Hello My Friend!";
            string MottoText = "GloryToUkraine";
            int[] Motto = new int[MottoText.Length];
            for (int i = 0; i < MottoText.Length; ++i)
            {
                Motto[i] = (int)System.Enum.Parse(typeof(EnglishABC), MottoText[i].ToString().ToLower());
            }
            Trtemius encripter = new Trtemius(new TrtemiusInitData()
            {
                isEng = true,
                isLinear = false,
                isMotto = true,
                motto = Motto
            });
            string expected = "Npzcm As Wrqrrj!";
            string result = encripter.encrypt(decripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_English_Motto_Decript()
        {
            string encripted = "Npzcm As Wrqrrj!";
            string MottoText = "GloryToUkraine";
            int[] Motto = new int[MottoText.Length];
            for (int i = 0; i < MottoText.Length; ++i)
            {
                Motto[i] = (int)System.Enum.Parse(typeof(EnglishABC), MottoText[i].ToString().ToLower());
            }
            Trtemius encripter = new Trtemius(new TrtemiusInitData()
            {
                isEng = true,
                isLinear = false,
                isMotto = true,
                motto = Motto
            });
            string expected = "Hello My Friend!";
            string result = encripter.decrypt(encripted);
            Assert.AreEqual(expected, result);
        }
        //Kkyjb Pc Xwevdw! 2 1 3
        //Npzcm As Wrqrrj!  Glory To Ukraine

        #endregion
    }
}
