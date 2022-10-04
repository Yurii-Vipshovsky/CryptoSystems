using Cezar.CriptoSystems;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cezar
{
    public class CezarInitData
    {
        public int[] linear { get; set; }
        public bool isEng { get; set; }
    }
    class Cezar : ICriptoSystem
    {
        public int[] linear { get; set; }
        bool isEng;
        public Cezar(CezarInitData data)
        {
            linear = data.linear;
            isEng = data.isEng;
        }
        public void nextKey()
        {
            throw new NotImplementedException();

        }
        public string encrypt(string text)
        {
            text = text.Replace(" ", "_");
            string result = ""; 
            if (isEng)
            {           
                foreach (var elem in text)
                {
                    if (!Char.IsLetter(elem) && elem!='_')
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
                    string newElem = ((EnglishABC)((((ABCnumb * linear[0]) % ICriptoSystem.ENG_ALF_COUNT)+linear[1]) % ICriptoSystem.ENG_ALF_COUNT)).ToString();
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
                    if (!Char.IsLetter(elem) && elem != '_')
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
                    string newElem = ((UkrainianABC)((((ABCnumb * linear[0]) % ICriptoSystem.UKR_ALF_COUNT) + linear[1]) % ICriptoSystem.UKR_ALF_COUNT)).ToString();
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
            throw new NotImplementedException();
        }

        static (int, int, int) gcdex(int a, int b)
        {
            if (a == 0)
                return (b, 0, 1);
            (int gcd, int x, int y) = gcdex(b % a, a);
            return (gcd, y - (b / a) * x, x);
        }

        static int invmod(int a, int m)
        {
            (int g, int x, int y) = gcdex(a, m);
            return g > 1 ? 0 : (x % m + m) % m;
        }

        public string decrypt(string text)
        {
            
            string result = "";
            if (isEng)
            {
                int tempLinear1 = invmod(linear[0], ICriptoSystem.ENG_ALF_COUNT);
                foreach (var elem in text)
                {
                    if (!Char.IsLetter(elem) && elem !='_')
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
                    string newElem = ((EnglishABC)((((((ABCnumb - linear[1]) % ICriptoSystem.ENG_ALF_COUNT)+ICriptoSystem.ENG_ALF_COUNT)* tempLinear1) % ICriptoSystem.ENG_ALF_COUNT))).ToString();
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
                int tempLinear1 = invmod(linear[0], ICriptoSystem.UKR_ALF_COUNT);
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
                    string newElem = ((UkrainianABC)((((((ABCnumb - linear[1]) % ICriptoSystem.UKR_ALF_COUNT) + ICriptoSystem.UKR_ALF_COUNT)* tempLinear1) % ICriptoSystem.UKR_ALF_COUNT))).ToString();
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
            return result.Replace("_"," ");
        }
        public byte[] decrypt(byte[] info)
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
    }
}
