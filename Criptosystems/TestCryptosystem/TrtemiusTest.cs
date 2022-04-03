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
            string decripted = "Â³òàş Ì³é Äğóæå!";
            Trtemius encripter = new Trtemius(new TrtemiusInitData()
            {
                isEng = false,
                isLinear = true,
                isMotto = false,
                linear = new int[2] { 3, 2 }
            });
            string expected = "¥ìü³³ìÂà´øÃñ÷ëì!";
            string result = encripter.encrypt(decripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_Ukrainian_Linear_Decript()
        {
            string encripted = "¥ìü³³ìÂà´øÃñ÷ëì!";
            Trtemius encripter = new Trtemius(new TrtemiusInitData()
            {
                isEng = false,
                isLinear = true,
                isMotto = false,
                linear = new int[2] { 3, 2 }
            });
            string expected = "Â³òàş Ì³é Äğóæå!";
            string result = encripter.decrypt(encripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_Ukrainian_Square_Encript()
        {
            string decripted = "Â³òàş Ì³é Äğóæå!";
            Trtemius encripter = new Trtemius(new TrtemiusInitData()
            {
                isEng = false,
                isLinear = false,
                isMotto = false,
                square = new int[3] { 3, 2, 1 }
            });
            string expected = "ÃíäàğíÁãíóĞÿ´ÿ³!";
            string result = encripter.encrypt(decripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_Ukrainian_Square_Decript()
        {
            string encripted = "ÃíäàğíÁãíóĞÿ´ÿ³!";
            Trtemius encripter = new Trtemius(new TrtemiusInitData()
            {
                isEng = false,
                isLinear = false,
                isMotto = false,
                square = new int[3] { 3, 2, 1 }
            });
            string expected = "Â³òàş Ì³é Äğóæå!";
            string result = encripter.decrypt(encripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_Ukrainian_Motto_Encript()
        {
            string decripted = "Â³òàş Ì³é Äğóæå!";
            string MottoText = "ÑëàâàÓêğà¿í³";
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
            string expected = "Ô÷óãÿóŞÿ¿¿Óÿ³ôº!";
            string result = encripter.encrypt(decripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_Ukrainian_Motto_Decript()
        {
            string encripted = "Ô÷óãÿóŞÿ¿¿Óÿ³ôº!";
            string MottoText = "ÑëàâàÓêğà¿í³";
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
            string expected = "Â³òàş Ì³é Äğóæå!";
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
            string expected = "KjsuzmAos ngeph!";
            string result = encripter.encrypt(decripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_English_Linear_Decript()
        {
            string encripted = "KjsuzmAos ngeph!";
            Trtemius encripter = new Trtemius(new TrtemiusInitData()
            {
                isEng = true,
                isLinear = true,
                isMotto = false,
                linear = new int[2] { 2, 3 }
            });
            string expected = "Hello My friend!";
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
            string expected = "Kkyi dMydRovkqh!";
            string result = encripter.encrypt(decripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_English_Square_Decript()
        {
            string encripted = "Kkyi dMydRovkqh!";
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
            string expected = "Oq cmtAskXsrssk!";
            string result = encripter.encrypt(decripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_English_Motto_Decript()
        {
            string encripted = "Oq cmtAskXsrssk!";
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
        #endregion
    }

}
