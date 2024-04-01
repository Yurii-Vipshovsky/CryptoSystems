using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Cezar.CriptoSystems
{
    public class RSA : ICriptoSystem
    {
        public int openKey { get; set; }
        public int closedKey { get; set; }
        public int n { get; set; }
        public bool isParalel { get; set; }
        public int threadCount { get; set; }
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
        public RSA(bool isParalel, int threadCount)
        {
            int p = 4;
            int q = 4;
            Random rand = new Random();
            while (!isPrime(p))
            {
                p = rand.Next(3, 2000);
            }
            while (!isPrime(q) || q == p)
            {
                q = rand.Next(3, 2000);
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
            this.isParalel = isParalel;
            this.threadCount = threadCount;
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

        public string decryptSyn(string text)
        {
            string result = "";
            //text = text.TrimStart(';');
            string[] characters = text.Split(';');
            for (int i = 0; i < characters.Length - 1; ++i)
            {
                result += (char)(fastPow(Convert.ToInt32(characters[i]), closedKey));
            }
            return result;
        }

        public string decryptSyn(string[] characters)
        {
            string result = "";
            for (int i = 0; i < characters.Length; ++i)
            {
                result += (char)(fastPow(Convert.ToInt32(characters[i]), closedKey));
            }
            return result;
        }

        public string decrypt(string text)
        {
            string result = "";
            if (isParalel)
            {
                text = text.Trim(';');
                string[] characters = text.Split(';');
                string[] encryptedDataArray = new string[threadCount];

                // Create and start threads for RSA encryption
                Thread[] threads = new Thread[threadCount];
                int elementsForThread = characters.Length / threadCount;
                for (int i = 0; i < threadCount; i++)
                {
                    int index = i; // Capture the loop variable for each thread
                    if (i == threadCount - 1)
                    {
                        threads[i] = new Thread(() =>
                        {
                            int length = characters.Length - index * elementsForThread;
                            string[] temp = new string[length];
                            Array.Copy(characters, index * elementsForThread, temp, 0, length);
                            encryptedDataArray[index] = decryptSyn(temp);
                        });
                    }
                    else
                    {
                        threads[i] = new Thread(() =>
                        {
                            int length = elementsForThread;
                            string[] temp = new string[length];
                            Array.Copy(characters, index * elementsForThread, temp, 0, length);
                            encryptedDataArray[index] = decryptSyn(temp);
                        });
                    }
                    threads[i].Start();
                }
                foreach (Thread thread in threads)
                {
                    thread.Join();
                }
                for (int i = 0; i < threadCount; i++)
                {
                    result += encryptedDataArray[i];
                }
            }
            else
            {
                result = decryptSyn(text);
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
        
        public string encryptSyc(string text)
        {
            string result = "";
            byte[] utf8Bytes = Encoding.UTF8.GetBytes(text);
            for (int i = 0; i < text.Length; ++i)
            {
                int elemI = utf8Bytes[i];
                long elemP = fastPow(text[i], openKey);
                result += elemP + ";";
                //Encoding.UTF8.GetBytes(elemP)
                //int elem = fastPow(text[i],openKey);
                //result += (char)(elemP);
            }
            return result;
        }

        public string encrypt(string text)
        {
            string result = "";
            if (isParalel)
            {
                string[] encryptedDataArray = new string[threadCount];

                // Create and start threads for RSA encryption
                Thread[] threads = new Thread[threadCount];
                int elementsForThread = text.Length/threadCount;
                for (int i = 0; i < threadCount; i++)
                {
                    int index = i; // Capture the loop variable for each thread
                    if (i == threadCount - 1)
                    {
                        threads[i] = new Thread(() =>
                        {
                            encryptedDataArray[index] = this.encryptSyc(text.Substring(index * elementsForThread));
                        });
                    }
                    else
                    {
                        threads[i] = new Thread(() =>
                        {
                            encryptedDataArray[index] = this.encryptSyc(text.Substring(index*elementsForThread, elementsForThread));
                        });
                    }
                    
                    threads[i].Start();
                }
                foreach (Thread thread in threads)
                {
                    thread.Join();
                }
                for (int i = 0; i < threadCount; i++)
                {
                    result += encryptedDataArray[i];
                }
            }
            else
            {
                return encryptSyc(text);
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
