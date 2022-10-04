using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cezar.CriptoSystems
{
    public enum EnglishABCUit
    {
        _,
        a,
        b,
        c,
        d,
        e,
        f,
        g,
        h,
        i,
        j,
        k,
        l,
        m,
        n,
        o,
        p,
        q,
        r,
        s,
        t,
        u,
        v,
        w,
        x,
        y,
        z,
        ю
    }
    public enum UkrainianABCUit
    {
        _,
        а,
        б,
        в,
        г,
        ґ,
        д,
        е,
        є,
        ж,
        з,
        и,
        і,
        й,
        ї,
        к,
        л,
        м,
        н,
        о,
        п,
        р,
        с,
        т,
        у,
        ф,
        х,
        ц,
        ч,
        ш,
        щ,
        ь,
        ю,
        я,
        z
    }
    public class UitstoneInitData
    {
        public string firstWord { get; set; }
        public string secondWord { get; set; }
        public bool isEng { get; set; }
    }
    class Uitstone : ICriptoSystem
    {
        const byte ENG_ALF_COUNT = 28;//4*7
        const byte UKR_ALF_COUNT = 35;//5*7
        public bool isEng;
        private char[][] firstMatr;
        private char[][] secondMatr;
        public Uitstone(UitstoneInitData data)
        {
            isEng = data.isEng;
            char[] firstWord = data.firstWord.ToLower().Distinct().ToArray();
            char[] secondWord = data.secondWord.ToLower().Distinct().ToArray();
            if (isEng)
            {
                firstMatr = new char[4][];
                secondMatr = new char[4][];
                for(int i = 0; i < 4; ++i) 
                {
                    firstMatr[i] = new char[7];
                    secondMatr[i] = new char[7];
                }
                int j = 0;
                foreach(char elem in firstWord)
                {
                    firstMatr[j / 4][j % 4] = elem;
                    j++;
                }
                int enumCounter = 0;
                for (; j < ENG_ALF_COUNT; ++j)
                {
                    char elem = ((EnglishABCUit)enumCounter).ToString().First();
                    while (firstWord.Contains(elem))
                    {
                        enumCounter++;
                        elem = ((EnglishABCUit)enumCounter).ToString().First();
                    }
                    firstMatr[j / 7][j % 7] = elem;
                    enumCounter++;
                }
                j = 0;
                foreach (char elem in secondWord)
                {
                    secondMatr[j / 7][j % 7] = elem;
                    j++;
                }
                enumCounter = 0;
                for (; j < ENG_ALF_COUNT; ++j)
                {
                    char elem = ((EnglishABCUit)enumCounter).ToString().First();
                    while (secondWord.Contains(elem))
                    {
                        enumCounter++;
                        elem = ((EnglishABCUit)enumCounter).ToString().First();
                    }
                    secondMatr[j / 7][j % 7] = elem;
                    enumCounter++;
                }
            }
            else
            {
                firstMatr = new char[5][];
                secondMatr = new char[5][];
                for (int i = 0; i < 5; ++i)
                {
                    firstMatr[i] = new char[7];
                    secondMatr[i] = new char[7];
                }
                int j = 0;
                foreach (char elem in firstWord)
                {
                    firstMatr[j / 7][j % 7] = elem;
                    j++;
                }
                int enumCounter = 0;
                for (; j < UKR_ALF_COUNT; ++j)
                {
                    char elem = ((UkrainianABCUit)enumCounter).ToString().First();
                    while (firstWord.Contains(elem))
                    {
                        enumCounter++;
                        elem = ((UkrainianABCUit)enumCounter).ToString().First();
                    }
                    firstMatr[j / 7][j % 7] = elem;
                    enumCounter++;
                }
                j = 0;
                foreach (char elem in secondWord)
                {
                    secondMatr[j / 7][j % 7] = elem;
                    j++;
                }
                enumCounter = 0;
                for (; j < UKR_ALF_COUNT; ++j)
                {
                    char elem = ((UkrainianABCUit)enumCounter).ToString().First();
                    while (secondWord.Contains(elem))
                    {
                        enumCounter++;
                        elem = ((UkrainianABCUit)enumCounter).ToString().First();
                    }
                    secondMatr[j / 7][j % 7] = elem;
                    enumCounter++;
                }
            }
        }

        private char[] selectElements(char[] elems) 
        {
            int i1 = 0;
            int j1 = 0;
            int i2 = 0;
            int j2 = 0;
            int size = 4;
            if (!isEng)
            {
                size = 5;
            }
            for(int n = 0; n < size; ++n)
            {
                for(int m = 0; m < 7; ++m)
                {
                    if (firstMatr[n][m] == elems[0])
                    {
                        i1 = n;
                        j1 = m;
                    }
                }
            }
            for (int n = 0; n < size; ++n)
            {
                for (int m = 0; m < 7; ++m)
                {
                    if (secondMatr[n][m] == elems[1])
                    {
                        i2 = n;
                        j2 = m;
                    }
                }
            }
            return new char[] { firstMatr[i1][j2], secondMatr[i2][j1] };
        }

        //private char[] selectElementsDecript(char[] elems)
        //{
        //    int i1 = 0;
        //    int j1 = 0;
        //    int i2 = 0;
        //    int j2 = 0;
        //    int size = 4;
        //    if (!isEng)
        //    {
        //        size = 5;
        //    }
        //    for (int n = 0; n < size; ++n)
        //    {
        //        for (int m = 0; m < 7; ++m)
        //        {
        //            if (firstMatr[n][m] == elems[0])
        //            {
        //                i1 = n;
        //                j1 = m;
        //            }
        //        }
        //    }
        //    for (int n = 0; n < size; ++n)
        //    {
        //        for (int m = 0; m < 7; ++m)
        //        {
        //            if (secondMatr[n][m] == elems[1])
        //            {
        //                i2 = n;
        //                j2 = m;
        //            }
        //        }
        //    }
        //    return new char[] { firstMatr[i1][j2], secondMatr[i2][j1] };
        //}

        public string decrypt(string text)
        {
            string result = "";

            char[][] elements = new char[(text.Length) / 2][];
            for (int i = 0; i < (text.Length) / 2; ++i)
            {
                elements[i] = new char[2];
                elements[i][0] = text[i * 2];
                elements[i][1] = text[i * 2 + 1];
            }
            foreach (var elem in elements)
            {
                if (!Char.IsLetter(elem[0]) && elem[0] != '_')
                {
                    result += elem[0].ToString() + elem[1].ToString();
                    continue;
                }
                if (!Char.IsLetter(elem[1]) && elem[1] != '_')
                {
                    result += elem[0].ToString() + elem[1].ToString();
                    continue;
                }
                bool isUpper0 = false;
                bool isUpper1 = false;
                if (Char.IsUpper(elem[0]))
                {
                    isUpper0 = true;
                    elem[0] = elem[0].ToString().ToLower()[0];
                }
                if (Char.IsUpper(elem[1]))
                {
                    isUpper1 = true;
                    elem[1] = elem[1].ToString().ToLower()[0];
                }

                char[] newElem = selectElements(elem);
                if (isUpper0)
                {
                    result += newElem[0].ToString().ToUpper();
                }
                else
                {
                    result += newElem[0].ToString();
                }
                if (isUpper1)
                {
                    result += newElem[1].ToString().ToUpper();
                }
                else
                {
                    result += newElem[1].ToString();
                }
            }

            return result.Replace("_", " ");
        }

        public byte[] decrypt(byte[] info)
        {
            throw new NotImplementedException();
        }

        public string encrypt(string text)
        {
            text = text.Replace(" ", "_");
            string result = "";
            char[][] elements;
            if (text.Length % 2 != 0)
            {
                text += '_';
            }
            elements = new char[(text.Length)/2][];
            for(int i =0;i< (text.Length) / 2; ++i)
            {
                elements[i] = new char[2];
                elements[i][0] = text[i * 2];
                elements[i][1] = text[i * 2 + 1];    
            }
            
            
                foreach (var elem in elements)
                {
                    if (!Char.IsLetter(elem[0]) && elem[0] != '_')
                    {
                        result += elem[0].ToString()+elem[1].ToString();
                        continue;
                    }
                    if (!Char.IsLetter(elem[1]) && elem[1] != '_')
                    {
                        result += elem[0].ToString() + elem[1].ToString();
                    continue;
                    }
                    bool isUpper0 = false;
                    bool isUpper1 = false;
                    if (Char.IsUpper(elem[0]))
                    {
                        isUpper0 = true;
                        elem[0] = elem[0].ToString().ToLower()[0];


                    }
                    if (Char.IsUpper(elem[1]))
                    {
                        isUpper1 = true;
                        elem[1] = elem[1].ToString().ToLower()[0];
                    }

                    char[] newElem = selectElements(elem);
                    if (isUpper0)
                    {
                        result += newElem[0].ToString().ToUpper();
                    }
                    else
                    {
                        result += newElem[0].ToString();
                    }
                    if (isUpper1)
                    {
                        result += newElem[1].ToString().ToUpper();
                    }
                    else
                    {
                        result += newElem[1].ToString();
                    }
                }
            
            return result;
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
