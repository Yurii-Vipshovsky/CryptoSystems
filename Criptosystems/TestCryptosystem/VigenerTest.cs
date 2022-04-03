using Cezar.CriptoSystems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCryptosystem
{
    [TestClass]
    public class VigenerTest
    {
        [TestMethod]
        public void Test_Trtemius_Ukrainian_Motto_Encript()
        {
            string decripted = "Вітаю Мій Друже!";
            string MottoText = "Україна";
            int[] Motto = new int[MottoText.Length];
            for (int i = 0; i < MottoText.Length; ++i)
            {
                Motto[i] = (int)System.Enum.Parse(typeof(UkrainianABC), MottoText[i].ToString().ToLower());
            }
            Vigener encripter = new Vigener(new VigenerInitData()
            {
                isEng = false,
                key = Motto
            });
            string expected = "ЦцзбінНбчрЕаєзь!";
            string result = encripter.encrypt(decripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_Ukrainian_Motto_Decript()
        {
            string encripted = "ЦцзбінНбчрЕаєзь!";
            string MottoText = "Україна";
            int[] Motto = new int[MottoText.Length];
            for (int i = 0; i < MottoText.Length; ++i)
            {
                Motto[i] = (int)System.Enum.Parse(typeof(UkrainianABC), MottoText[i].ToString().ToLower());
            }
            Vigener encripter = new Vigener(new VigenerInitData()
            {
                isEng = false,
                key = Motto
            });
            string expected = "Вітаю Мій Друже!";
            string result = encripter.decrypt(encripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_English_Motto_Encript()
        {
            string decripted = "Hello My Friend!";
            string MottoText = "Ukraine";
            int[] Motto = new int[MottoText.Length];
            for (int i = 0; i < MottoText.Length; ++i)
            {
                Motto[i] = (int)System.Enum.Parse(typeof(EnglishABC), MottoText[i].ToString().ToLower());
            }
            Vigener encripter = new Vigener(new VigenerInitData()
            {
                isEng = true,
                key = Motto
            });
            string expected = "BpcmxnRskXsrssy!";
            string result = encripter.encrypt(decripted);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Trtemius_English_Motto_Decript()
        {
            string encripted = "BpcmxnRskXsrssy!";
            string MottoText = "Ukraine";
            int[] Motto = new int[MottoText.Length];
            for (int i = 0; i < MottoText.Length; ++i)
            {
                Motto[i] = (int)System.Enum.Parse(typeof(EnglishABC), MottoText[i].ToString().ToLower());
            }
            Vigener encripter = new Vigener(new VigenerInitData()
            {
                isEng = true,
                key = Motto
            });
            string expected = "Hello My Friend!";
            string result = encripter.decrypt(encripted);
            Assert.AreEqual(expected, result);
        }
    }
}
