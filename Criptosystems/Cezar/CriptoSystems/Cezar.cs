using Cezar.CriptoSystems;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cezar
{
    public class CezarInitData
    {
        public int key { get; set; }
        public bool isEng { get; set; }
        public bool isText { get; set; }
    }
    class Cezar : ICriptoSystem
    {
        public int key { get; set; }
        bool isEng;
        bool isText { get; set; }
        public Cezar(CezarInitData data)
        {
            key = data.key;
            isEng = data.isEng;
            isText = data.isText;
        }
        public void changeToEng() { isEng = true; }
        public void changeToUkr() { isEng = false; }
        public bool changeKey(int newKey)
        {
            if(!isText&& newKey >= ICriptoSystem.MAX_BYTE_SIZE)
            {
                return false;
            }
            else if(!isText && newKey > ICriptoSystem.MAX_BYTE_SIZE)
            {
                key = newKey;
                return true;
            }
            //мб просто міняти і поколу зсувати
            if (isEng && newKey >= ICriptoSystem.ENG_ALF_COUNT)//більше за кількість букв
            {
                return false;
            }
            else if(!isEng && newKey >= ICriptoSystem.UKR_ALF_COUNT)
            {
                return false;
            }
            else
            {
                key = newKey;
                return true;
            }
        }
        public void nextKey()
        {
            if(!isText && key+1 > ICriptoSystem.MAX_BYTE_SIZE)
            {
                key = 1;
            }
            else
            {
                key++;
            }
            if (isEng && key+1 > ICriptoSystem.ENG_ALF_COUNT)//більше за кількість букв
            {
                key = 1;
            }
            else if (!isEng && key+1 > ICriptoSystem.UKR_ALF_COUNT)
            {
                key = 1;
            }
            else
            {
                key++;
            }
        }
        public string encrypt(string text)
        {
            string result = ""; 
            if (isEng)
            {           
                foreach (var elem in text)
                {
                    if (!Char.IsLetter(elem))
                    {
                        result += elem;
                        continue;
                    }
                    bool isUpper = false;
                    if (Char.IsUpper(elem))
                    {
                        isUpper = true;
                    }
                    int ABCnumb = (int)Enum.Parse(typeof(EnglishABC), elem.ToString().ToLower());
                    string newElem = ((EnglishABC)((ABCnumb + key) % ICriptoSystem.ENG_ALF_COUNT)).ToString();
                    if (isUpper)
                    {
                        result += newElem.ToUpper();
                    }
                    else
                    {
                        result += newElem;
                    }
                }
            }
            else
            {
                foreach (var elem in text)
                {
                    if (!Char.IsLetter(elem))
                    {
                        result += elem;
                        continue;
                    }
                    bool isUpper = false;
                    if (Char.IsUpper(elem))
                    {
                        isUpper = true;
                    }
                    int ABCnumb = (int)Enum.Parse(typeof(UkrainianABC), elem.ToString().ToLower());
                    string newElem = ((UkrainianABC)((ABCnumb + key) % ICriptoSystem.UKR_ALF_COUNT)).ToString();
                    if (isUpper)
                    {
                        result += newElem.ToUpper();
                    }
                    else
                    {
                        result += newElem;
                    }
                }
            }
            return result;
        }
        public byte[] encrypt(byte[] info)
        {
            byte[] result = new byte[info.Length];
            for(int i = 0; i < info.Length; ++i)
            {
                result[i] = (byte)((Convert.ToInt32(info[i])+key) % ICriptoSystem.MAX_BYTE_SIZE);
            }
            return result;
        }
        public string decrypt(string text)
        {
            string result = "";
            if (isEng)
            {
                foreach (var elem in text)
                {
                    if (!Char.IsLetter(elem))
                    {
                        result += elem;
                        continue;
                    }
                    bool isUpper = false;
                    if (Char.IsUpper(elem))
                    {
                        isUpper = true;
                    }
                    int ABCnumb = (int)Enum.Parse(typeof(EnglishABC), elem.ToString().ToLower());
                    string newElem = ((EnglishABC)(((((ABCnumb - key) % ICriptoSystem.ENG_ALF_COUNT)+ICriptoSystem.ENG_ALF_COUNT)% ICriptoSystem.ENG_ALF_COUNT))).ToString();
                    if (isUpper)
                    {
                        result += newElem.ToUpper();
                    }
                    else
                    {
                        result += newElem;
                    }
                }
            }
            else
            {
                foreach (var elem in text)
                {
                    if (!Char.IsLetter(elem))
                    {
                        result += elem;
                        continue;
                    }
                    bool isUpper = false;
                    if (Char.IsUpper(elem))
                    {
                        isUpper = true;
                    }
                    int ABCnumb = (int)Enum.Parse(typeof(UkrainianABC), elem.ToString().ToLower());
                    string newElem = ((UkrainianABC)(((((ABCnumb - key) % ICriptoSystem.UKR_ALF_COUNT) + ICriptoSystem.UKR_ALF_COUNT) % ICriptoSystem.UKR_ALF_COUNT))).ToString();
                    if (isUpper)
                    {
                        result += newElem.ToUpper();
                    }
                    else
                    {
                        result += newElem;
                    }
                }
            }
            return result;
        }
        public byte[] decrypt(byte[] info)
        {
            byte[] result = new byte[info.Length];
            for (int i = 0; i < info.Length; ++i)
            {
                result[i] = (byte)((((Convert.ToInt32(info[i])-key) % ICriptoSystem.MAX_BYTE_SIZE) + ICriptoSystem.MAX_BYTE_SIZE) % ICriptoSystem.MAX_BYTE_SIZE);
            }
            return result;
        }

        public bool isEnglish()
        {
            return isEng;
        }

        public bool isTextInfo()
        {
            return isText;
        }
    }
}
