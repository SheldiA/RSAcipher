using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSA
{
    class RSA
    {
        private int p;
        private int q;
        private int r;
        private int functionEuler;
        private int publicKey;
        private int privateKey;
        private Generator generator;
        private ResidueNumberSstem modArithmetic;

        public RSA()
        {
            generator = new Generator();
            modArithmetic = new ResidueNumberSstem();
        }

        private void CalculateData()
        {
            p = 41;
            q = 59;
            r = p * q;
            functionEuler = (p - 1) * (q - 1);
            publicKey = generator.GenerateCoprimeInteger(functionEuler);
            privateKey = modArithmetic.ExtendedEuclid(functionEuler, publicKey);
        }

        public int Encrypt(int message)
        {
            int result = 0;
            CalculateData();
            result = modArithmetic.FastExp(message, publicKey, r);
            return result;
        }

        public int Decrypt(int cipher)
        {
            int result = 0;
            CalculateData();
            result = modArithmetic.FastExp(cipher, privateKey, r);
            return result;
        }
    }
}
