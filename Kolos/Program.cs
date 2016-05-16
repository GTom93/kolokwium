using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos
{
   public class Program
    {
       /// <summary>
       /// metoda sprawdzająca czy liczba jest półpierwszą
       /// </summary>
       /// <param name="c"> liczba którą chcemy sprawdzić </param>
       /// <returns> zwraca prawdę jesli liczba jest półpierwszą</returns>
       public static  bool IsSemiPrime( int c )
        {
             int a = 2, b = 0;
             while( b < 3 && c != 1 )
             {
	            if( ( c % a )!=0 ) 
	            { c /= a; b++; }
	            else a++;
             }
            return b==2 ;
        }
        /// <summary>
        /// metoda wyszukująca z podanych zakresów liczby półpierwsze
        /// </summary>
        /// <param name="N">najwieksza liczba w tabeli</param>
        /// <param name="P"> tablica  zawierająca początkowe zakresy sprawdzanych przedziałów</param>
        /// <param name="Q">tablica  zawierająca kńcowe zakresy sprawdzanych przedziałów</param>
        /// <param name="M"> liczba  zakresów do sprawdzenia</param>
        /// <returns> tablica  zawirająca w kolejności z każdego zakresu ile jest w nim liczb półpierwszych</returns>
        public static int[] SemiPrime(int N, int[] P, int[] Q, int []M)
        {       
            for (int i = 0; i < P.Length; i++ )
            {
                int left  = P[i];
                int right = Q[i];
                int count=0;
                for (int j=left; j<=right; j++)
                {
                    if (IsSemiPrime(j) == true) count++; 
                }
                M[i] = count; 
            }
                return M;
        }
        static void Main(string[] args) { }
    }
}
