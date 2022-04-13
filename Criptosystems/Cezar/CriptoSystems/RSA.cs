using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Cezar.CriptoSystems
{
    public class RSA : ICriptoSystem
    {
        public int openKey { get; set; }
        public int closedKey { get; set; }
        public int n { get; set; }
        private bool isPrime(int n)
        {
            bool isPrime = true;
            var sqrt = Math.Sqrt(n);
            for (var i = 2; i <= sqrt; i++)
                if ((n % i) == 0) isPrime = false;
            return isPrime;
        }
        private int GCD(int a, int b)
        {
            while (b != 0)
                b = a % (a = b);
            return Math.Abs(a);
        }
        public Int64 FastPowFunc(Int64 Number, Int64 Pow)
        {
            Int64 Result = 1;
            Int64 Bit = Number % n;

            while (Pow > 0)
            {
                if ((Pow & 1) == 1)
                {
                    Result *= Bit;
                    Result %= n;
                }
                Bit *= Bit;
                Bit %= n;
                Pow >>= 1;
            }
            return Result;
        }
        private int fastPow(int elem, int pow)
        {
            return (int)BigInteger.ModPow(elem, pow, n);
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
        public RSA()
        {
            int p = 4;
            int q = 4;
            Random rand = new Random();
            while (!isPrime(p))
            {
                p = rand.Next(3,3000);
            }
            while (!isPrime(q) || q==p)
            {
                q = rand.Next(3,3000);
            }
            n = p * q;
            int fi = (p - 1) * (q - 1);
            int e = rand.Next((int)fi);
            while (GCD(e, fi) != 1)
            {
                e = rand.Next((int)fi);
            }
            openKey = e;
            closedKey = invmod(e, fi);
        }
        public RSA(int e)
        {
            openKey = e;
            int p = 4;
            int q = 4;
            Random rand = new Random();
            int fi = e;
            while (GCD(e, fi) != 1)
            { 
                p = 4;
                q = 4;
                while (!isPrime(p))
                {
                    p = rand.Next(e/2, e*3);
                }
                while (!isPrime(q) || q == p)
                {
                    q = rand.Next(e/2, e*3);
                }
                fi = (p - 1) * (q - 1);
            }
            n = p * q;
            closedKey = invmod(e, fi);
        }
        public string decrypt(string text)
        {
            string result = "";
            string[] characters = text.Split(';');
            for (int i = 0; i < characters.Length - 1; ++i)
            {
                result += (char)(fastPow(Convert.ToInt32(characters[i]), closedKey));
            }
            //for (int i = 0; i < text.Length; ++i)
            //{
            //    int elemI = text[i];
            //    long elemP = fastPow(text[i], closedKey);
            //    //byte[] elem = BitConverter.GetBytes(fastPow(text[i], closedKey));
            //    //mb reverse
            //    //Array.Reverse(elem);
            //    //result += Encoding.Convert(Encoding.Unicode, Encoding.UTF8, elem);
            //    result += (char)(elemP);
            //}
            return result;
        }
        public long decrypt(int elem)
        {
            return fastPow(elem, closedKey);
        }

        public byte[] decrypt(byte[] info)
        {
            throw new NotImplementedException();
        }

        public string encrypt(string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; ++i)
            {

                int elemI = text[i];
                long elemP = fastPow(text[i], openKey);
                result+=elemP+";";
                //int elem = fastPow(text[i],openKey);
                //result += (char)(elemP);
            }
            return result;
        }

        public long encrypt(int elem)
        {
            return fastPow(elem, openKey);
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
