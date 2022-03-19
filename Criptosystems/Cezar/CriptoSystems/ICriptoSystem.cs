using System;
using System.Collections.Generic;
using System.Text;

namespace Cezar.CriptoSystems
{
    interface ICriptoSystem
    {
        const byte ENG_ALF_COUNT = 26;
        const byte UKR_ALF_COUNT = 33;
        const int MAX_BYTE_SIZE = 256;
        public bool isEnglish();
        public bool isTextInfo();
        public void changeToEng();
        public void changeToUkr();
        public bool changeKey(int newKey);
        public void nextKey();
        public string encrypt(string text);       
        public byte[] encrypt(byte[] info);
        public string decrypt(string text);
        public byte[] decrypt(byte[] info);
    }
}
