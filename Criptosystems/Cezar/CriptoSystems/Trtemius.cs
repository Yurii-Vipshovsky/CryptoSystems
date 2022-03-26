using System;
using System.Collections.Generic;
using System.Text;

namespace Cezar.CriptoSystems
{
    public class TrtemiusInitData
    {
        public bool isEng { get; set; }
        public bool isMotto { get; set; }
        public bool isLinear { get; set; }
        public int[] motto { get; set; }
        public int[] linear { get; set; }
        public int[] square { get; set; }
    }
    public class Trtemius : ICriptoSystem
    {
        bool isEng;
        bool isMotto;
        bool isLinear;
        int[] motto;
        int[] linear;
        int[] square;

        public Trtemius(TrtemiusInitData data)
        {
            isEng = data.isEng;
            isMotto = data.isMotto;
            isLinear = data.isLinear;
            motto = data.motto;
            linear = data.linear;
            square = data.square;
        }

        public string decrypt(string text)
        {
            text = text.Replace(' ', '_');
            string result = "";
            if (isMotto)
            {
                if (motto == null)
                {
                    throw new ArgumentNullException("Незадано гасло");
                }
                for (int i = 0; i < text.Length; ++i)
                {
                    if (!Char.IsLetter(text[i]) && text[i]!='_')
                    {
                        result += text[i];
                        continue;
                    }
                    int key = motto[i % motto.Length];
                    bool isUpper = false;
                    if (Char.IsUpper(text[i]))
                    {
                        isUpper = true;
                    }
                    string newElem;
                    if (isEng)
                    {
                        int ABCnumb = (int)Enum.Parse(typeof(EnglishABC), text[i].ToString().ToLower());
                        newElem = ((EnglishABC)(((((ABCnumb - key) % ICriptoSystem.ENG_ALF_COUNT) + ICriptoSystem.ENG_ALF_COUNT) % ICriptoSystem.ENG_ALF_COUNT))).ToString();
                    }
                    else
                    {
                        int ABCnumb = (int)Enum.Parse(typeof(UkrainianABC), text[i].ToString().ToLower());
                        newElem = ((UkrainianABC)(((((ABCnumb - key) % ICriptoSystem.UKR_ALF_COUNT) + ICriptoSystem.UKR_ALF_COUNT) % ICriptoSystem.UKR_ALF_COUNT))).ToString();
                    }
                    if (isUpper && newElem!="_")
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
                for(int i = 0; i < text.Length; ++i)
                {
                    if (!Char.IsLetter(text[i]) && text[i]!='_')
                    {
                        result += text[i];
                        continue;
                    }
                    int key;
                    if (isLinear)
                    {
                        if (linear == null)
                        {
                            throw new ArgumentNullException("Незадано лінійне рівняння");
                        }
                        key = linear[0] * i + linear[1];
                    }
                    else
                    {
                        if (square == null)
                        {
                            throw new ArgumentNullException("Незадано квадратне рівняння");
                        }
                        key = square[0] * i * i + square[1] * i + square[2];
                    }
                    bool isUpper = false;
                    if (Char.IsUpper(text[i]))
                    {
                        isUpper = true;
                    }
                    string newElem;
                    if (isEng)
                    {
                        int ABCnumb = (int)Enum.Parse(typeof(EnglishABC), text[i].ToString().ToLower());
                        newElem = ((EnglishABC)(((ABCnumb + ICriptoSystem.ENG_ALF_COUNT) -(key%ICriptoSystem.ENG_ALF_COUNT)) % ICriptoSystem.ENG_ALF_COUNT)).ToString();
                    }
                    else
                    {
                        int ABCnumb = (int)Enum.Parse(typeof(UkrainianABC), text[i].ToString().ToLower());
                        newElem = ((UkrainianABC)(((ABCnumb + ICriptoSystem.UKR_ALF_COUNT) - (key % ICriptoSystem.UKR_ALF_COUNT)) % ICriptoSystem.UKR_ALF_COUNT)).ToString();
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
            if (isMotto)
            {
                if (motto == null)
                {
                    throw new ArgumentNullException("Незадано гасло");
                }
                for(int i = 0; i < text.Length; ++i)
                {
                    if (!Char.IsLetter(text[i]) && text[i]!='_')
                    {
                        result += text[i];
                        continue;
                    }
                    int key = motto[i%motto.Length];
                    bool isUpper = false;
                    if (Char.IsUpper(text[i]))
                    {
                        isUpper = true;
                    }
                    string newElem;
                    if (isEng)
                    {
                        int ABCnumb = (int)Enum.Parse(typeof(EnglishABC), text[i].ToString().ToLower());
                        newElem = ((EnglishABC)((ABCnumb + key) % ICriptoSystem.ENG_ALF_COUNT)).ToString();
                    }
                    else
                    {
                        int ABCnumb = (int)Enum.Parse(typeof(UkrainianABC), text[i].ToString().ToLower());
                        newElem = ((UkrainianABC)((ABCnumb + key) % ICriptoSystem.UKR_ALF_COUNT)).ToString();
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
            }
            else
            {
                for (int i = 0; i < text.Length; ++i)
                {
                    if (!Char.IsLetter(text[i]) && text[i]!='_')
                    {
                        result += text[i];
                        continue;
                    }
                    int key;
                    if (isLinear)
                    {
                        if (linear == null)
                        {
                            throw new ArgumentNullException("Незадано лінійне рівняння");
                        }
                        key = linear[0] * i + linear[1];
                    }
                    else
                    {
                        if (square == null)
                        {
                            throw new ArgumentNullException("Незадано квадратне рівняння");
                        }
                        key = square[0] * i * i + square[1] * i + square[2];
                    }
                    bool isUpper = false;
                    if (Char.IsUpper(text[i]))
                    {
                        isUpper = true;
                    }
                    string newElem;
                    if (isEng)
                    {
                        int ABCnumb = (int)Enum.Parse(typeof(EnglishABC), text[i].ToString().ToLower());
                        newElem = ((EnglishABC)((ABCnumb + key) % ICriptoSystem.ENG_ALF_COUNT)).ToString();
                    }
                    else
                    {
                        int ABCnumb = (int)Enum.Parse(typeof(UkrainianABC), text[i].ToString().ToLower());
                        newElem = ((UkrainianABC)((ABCnumb + key) % ICriptoSystem.UKR_ALF_COUNT)).ToString();
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
            }
            return result.Replace('_',' ');
        }

        public byte[] encrypt(byte[] info)
        {
            throw new NotImplementedException();
        }

        public bool isEnglish()
        {
            return isEng;
        }

        //only true
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
