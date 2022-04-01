using System;
using System.Collections.Generic;
using System.Text;

namespace Cezar.CriptoSystems
{
    public class Gamma : ICriptoSystem
    {
        public List<int> gamma = new List<int>();
        //public bool isEng { get; set; }
        //public Gamma(bool eng) { isEng = eng; }
        public Gamma() { }
        private void createGama(int n)
        {
            Random generator = new Random();
            while (gamma.Count < n)
            {
                //if (isEng)
                //{
                //    gamma.Add(generator.Next(0, ICriptoSystem.ENG_ALF_COUNT));
                //}
                //else
                //{
                //    gamma.Add(generator.Next(0, ICriptoSystem.UKR_ALF_COUNT));
                //}
                gamma.Add(generator.Next(0, ICriptoSystem.MAX_BYTE_SIZE));
            }
        }
        //public string decrypt(string text)
        //{
        //    string result = ""; 
        
        //    for(int i = 0; i < text.Length; ++i)
        //    {
        //        if (!Char.IsLetter(text[i]) && text[i] != '_')
        //        {
        //            result += text[i];
        //            continue;
        //        }
        //        bool isUpper = false;
        //        if (Char.IsUpper(text[i]))
        //        {
        //            isUpper = true;
        //        }
        //        string newElem = "";
        //        if (isEng)
        //        {
        //            int ABCnumb = (int)Enum.Parse(typeof(EnglishABC), text[i].ToString().ToLower());
        //            newElem = ((EnglishABC)(((((ABCnumb - gamma[i]) % ICriptoSystem.ENG_ALF_COUNT) + ICriptoSystem.ENG_ALF_COUNT) % ICriptoSystem.ENG_ALF_COUNT))).ToString();
        //        }
        //        else
        //        {
        //            int ABCnumb = (int)Enum.Parse(typeof(UkrainianABC), text[i].ToString().ToLower());
        //            newElem = ((UkrainianABC)(((((ABCnumb - gamma[i]) % ICriptoSystem.UKR_ALF_COUNT) + ICriptoSystem.UKR_ALF_COUNT) % ICriptoSystem.UKR_ALF_COUNT))).ToString();
        //        }
        //        if (isUpper)
        //        {
        //            result += newElem.ToUpper();
        //        }
        //        else
        //        {
        //            result += newElem;
        //        }
        //    }
        //    return result.Replace("_", " ");
        //}

        public string decrypt(string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; ++i)
            {
                result += (char)(text[i] - gamma[i]);
            }
            return result;
        }

        public byte[] decrypt(byte[] info)
        {
            throw new NotImplementedException();
        }

        //public string encrypt(string text)
        //{
        //    text = text.Replace(" ", "_");
        //    string result = "";
        //    createGama(text.Length);
        //    for(int i=0; i < text.Length; ++i)
        //    {
        //        if (!Char.IsLetter(text[i]) && text[i] != '_')
        //        {
        //            result += text[i];
        //            continue;
        //        }
        //        bool isUpper = false;
        //        if (Char.IsUpper(text[i]))
        //        {
        //            isUpper = true;
        //        }
        //        string newElem = "";
        //        if (isEng)
        //        {
        //            int ABCnumb = (int)Enum.Parse(typeof(EnglishABC), text[i].ToString().ToLower());
        //            newElem = ((EnglishABC)((ABCnumb + gamma[i]) % ICriptoSystem.ENG_ALF_COUNT)).ToString();
        //        }
        //        else
        //        {
        //            int ABCnumb = (int)Enum.Parse(typeof(UkrainianABC), text[i].ToString().ToLower());
        //            newElem = ((UkrainianABC)((ABCnumb + gamma[i]) % ICriptoSystem.UKR_ALF_COUNT)).ToString();
        //        }
        //        if (isUpper)
        //        {
        //            result += newElem.ToUpper();
        //        }
        //        else
        //        {
        //            result += newElem;
        //        }
        //    }
        //    return result;
        //}

        public string encrypt(string text)
        {
            Encoding utf8 = Encoding.UTF8;
            string result = "";
            createGama(text.Length);
            for (int i = 0; i < text.Length; ++i)
            {
                result += (char)(text[i] + gamma[i]);
            }
            return result;
        }

        public byte[] encrypt(byte[] info)
        {
            throw new NotImplementedException();
        }

        public bool isEnglish()
        {
            //return isEng;
            return true;
        }

        public bool isTextInfo()
        {
            return true;
        }

        public void nextKey()
        {
            throw new NotImplementedException();
        }
    }
}
