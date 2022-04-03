using System;
using System.Collections.Generic;
using System.Text;

namespace Cezar.CriptoSystems
{
    public class Gamma : ICriptoSystem
    {
        public List<int> gamma = new List<int>();
        public Gamma() { }
        private void createGama(int n)
        {
            Random generator = new Random();
            while (gamma.Count < n)
            {
                gamma.Add(generator.Next(0, ICriptoSystem.MAX_BYTE_SIZE));
            }
        }

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
            throw new NotImplementedException();
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
