using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kolos;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// test czy funkcja poprawnie wykryje liczby półpierwsze
        /// </summary>
        [TestMethod]
        public void TestSemiPrime()
        {
            int[] P = new int[] { 1, 4, 16 };
            int[] Q = new int[] { 26, 10, 20 };
            int N = 26;
            int[] M = new int[3];
            int[] expection = new int[] { 10, 4, 0 };

            Kolos.Program.SemiPrime(N, P, Q, M);
            
            for (int i=0; i<P.Length-1; i++)
            {
                Assert.AreEqual(expection[i], M[i]);
            }     
        }

        /// <summary>
        /// test czy tablica wyjściowa M nie jest pusta
        /// </summary>
        [TestMethod]
        public void NullTest()
        {
            int[] P = new int[] { 1};
            int[] Q = new int[] { 5};
            int N = 5;
            int[] M = new int[1];

            Kolos.Program.SemiPrime(N, P, Q, M);
            Assert.IsNotNull(M);
        }

        /// <summary>
        /// test czy funkcja pomocnicza prawidłowo weryfikuje czy
        /// liczba jest liczbą półpierwszą
        /// </summary>
        [TestMethod]
        public void IsSemiPrimeTest()
        {
            Assert.IsTrue(Kolos.Program.IsSemiPrime(10));
            Assert.IsFalse(Kolos.Program.IsSemiPrime(7));
        }
    }
}
