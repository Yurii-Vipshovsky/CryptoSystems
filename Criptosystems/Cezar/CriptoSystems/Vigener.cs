using System;
using System.Collections.Generic;
using System.Text;

namespace Cezar.CriptoSystems
{
    public class VigenerInitData
    {
        public bool isEng { get; set; }
        public int[] key { get; set; }
    }
    public class Vigener : ICriptoSystem
    {
        bool isEng;
        int[] key;
        public Vigener(VigenerInitData data)
        {
            isEng = data.isEng;
            key = data.key;
        }
        public string decrypt(string text)
        {
            text = text.Replace(' ', '_');
            string result = "";
            if (key == null)
            {
                throw new ArgumentNullException("Незадано гасло");
            }
            for (int i = 0; i < text.Length; ++i)
            {
                if (!Char.IsLetter(text[i]) && text[i] != '_')
                {
                    result += text[i];
                    continue;
                }
                int keyElem = key[i % key.Length];
                bool isUpper = false;
                if (Char.IsUpper(text[i]))
                {
                    isUpper = true;
                }
                string newElem;
                if (isEng)
                {
                    int ABCnumb = (int)Enum.Parse(typeof(EnglishABC), text[i].ToString().ToLower());
                    newElem = ((EnglishABC)(((((ABCnumb - keyElem) % ICriptoSystem.ENG_ALF_COUNT) + ICriptoSystem.ENG_ALF_COUNT) % ICriptoSystem.ENG_ALF_COUNT))).ToString();
                }
                else
                {
                    int ABCnumb = (int)Enum.Parse(typeof(UkrainianABC), text[i].ToString().ToLower());
                    newElem = ((UkrainianABC)(((((ABCnumb - keyElem) % ICriptoSystem.UKR_ALF_COUNT) + ICriptoSystem.UKR_ALF_COUNT) % ICriptoSystem.UKR_ALF_COUNT))).ToString();
                }
                if (isUpper && newElem != "_")
                {
                    result += newElem.ToUpper();
                }
                else
                {
                    result += newElem;
                }
            }
            return result.Replace('_',' ');
        }

        public byte[] decrypt(byte[] info)
        {
            throw new NotImplementedException();
        }

        public string encrypt(string text)
        {
            text = text.Replace(" ", "_");
            string result = "";
            if (key == null)
            {
                throw new ArgumentNullException("Незадано гасло");
            }
            for (int i = 0; i < text.Length; ++i)
            {
                if (!Char.IsLetter(text[i]) && text[i] != '_')
                {
                    result += text[i];
                    continue;
                }
                int keyElem = key[i % key.Length];
                bool isUpper = false;
                if (Char.IsUpper(text[i]))
                {
                    isUpper = true;
                }
                string newElem;
                if (isEng)
                {
                    int ABCnumb = (int)Enum.Parse(typeof(EnglishABC), text[i].ToString().ToLower());
                    newElem = ((EnglishABC)((ABCnumb + keyElem) % ICriptoSystem.ENG_ALF_COUNT)).ToString();
                }
                else
                {
                    int ABCnumb = (int)Enum.Parse(typeof(UkrainianABC), text[i].ToString().ToLower());
                    newElem = ((UkrainianABC)((ABCnumb + keyElem) % ICriptoSystem.UKR_ALF_COUNT)).ToString();
                }
                if (isUpper && newElem != "_")
                {
                    result += newElem.ToUpper();
                }
                else
                {
                    result += newElem;
                }
            }
            return result.Replace('_', ' ');
        }

        public byte[] encrypt(byte[] info)
        {
            throw new NotImplementedException();
        }

        public bool isEnglish()
        {
            return isEng;
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
