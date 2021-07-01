using System;
using System.Numerics;
using System.Security.Cryptography;
namespace ClassLibrary1
{
   /// <summary>
   /// Генератор генерации
   /// </summary>
    public class Generate
    {
        /// <summary>
        /// Генерирует число без внешних ограничений
        /// </summary>
        /// <returns>
        /// Простое число формата BigInteger.
        /// </returns>
        static public BigInteger getRandom()
        {
            byte[] data;
            bool anal = false;
            BigInteger ass; byte length = 3;
            do
            {

                Random random = new Random();
                data = new byte[length];
                random.NextBytes(data);
                ass = new BigInteger(data);
                if (ass >= 0)
                {
                    anal = MillerRabin.MillerRabinTest(ass);
                }
            } while (anal == false);
            return ass;
        }
        /// <summary>
        /// Генерирует число по заданной длинне
        /// </summary>
        /// <returns>
        /// Простое число формата BigInteger.
        /// </returns>
        static public BigInteger getRandom(int length)
        {
            byte[] data;
            bool anal = false;
            BigInteger ass;
            do
            {

                Random random = new Random();
                data = new byte[length];
                random.NextBytes(data);
                ass = new BigInteger(data);
                if (ass >= 0)
                {
                    anal = MillerRabin.MillerRabinTest(ass);
                }
            } while (anal == false);
            return ass;
        }

        static public RNGCryptoServiceProvider _RNG = new RNGCryptoServiceProvider();
        /// <summary>
        /// Генерирует число по двум переменным.Min,Max
        /// </summary>
        /// <returns>
        /// Простое число формата BigInteger.
        /// </returns>
        public static BigInteger getRandom(int min, int max)
        {
            bool anal = false;
            Decimal NewValue;
            do
            {
                byte[] rndBytes = new byte[4];
                _RNG.GetBytes(rndBytes);
                int rand = BitConverter.ToInt32(rndBytes, 0);
                const Decimal OldRange = (Decimal)int.MaxValue - (Decimal)int.MinValue;
                Decimal NewRange = max - min;
                NewValue = ((Decimal)rand - (Decimal)int.MinValue) / OldRange * NewRange + (Decimal)min;
                if (NewValue >= 0)
                {
                    anal = MillerRabin.MillerRabinTest((BigInteger)NewValue);
                }
            } while (anal == false);
            return (BigInteger)NewValue;
        }
    }
    /// <summary>
    /// Алгоритм проверки на простоту
    /// </summary>
    public   class MillerRabin
        {
            /// <summary>
            /// Алгоритм проверки
            /// </summary>
            static public bool MillerRabinTest(BigInteger n)
            {
                // если n == 2 или n == 3 - эти числа простые, возвращаем true
                if (n == 2 || n == 3)
                    return true;

                // если n < 2 или n четное - возвращаем false
                if (n < 2 || n % 2 == 0)
                    return false;

                // представим n − 1 в виде (2^s)·t, где t нечётно, это можно сделать последовательным делением n - 1 на 2
                BigInteger t = n - 1;

                int s = 0;

                while (t % 2 == 0)
                {
                    t /= 2;
                    s += 1;
                }
                // выберем случайное целое число a в отрезке [2, n − 2]
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

                byte[] _a = new byte[n.ToByteArray().LongLength];

                BigInteger a;

                do
                {
                    rng.GetBytes(_a);
                    a = new BigInteger(_a);
                }
                while (a < 2 || a >= n - 2);

                // x ← a^t mod n, вычислим с помощью возведения в степень по модулю
                BigInteger x = BigInteger.ModPow(a, t, n);

                // если x == 1 или x == n − 1, то перейти на следующую итерацию цикла
                if (x == 1 || x == n - 1)
                    return true;

                // повторить s − 1 раз
                for (int r = 1; r < s; r++)
                {
                    // x ← x^2 mod n
                    x = BigInteger.ModPow(x, 2, n);

                    // если x == 1, то вернуть "составное"
                    if (x == 1)
                        return false;

                    // если x == n − 1, то перейти на следующую итерацию внешнего цикла
                    if (x == n - 1)
                        break;
                }

                if (x != n - 1)
                    return false;

                // вернуть "вероятно простое"
                return true;
            }
     }
    /// <summary>
    /// Умножение 2 простых чисел
    /// </summary>
    public class Sravnisuka
        {
        /// <summary>
        /// Умножение 2 простых чисел введенных из вне.Имеется проверка на простоту
        /// </summary>
        /// <param name="sukOne"></param>
        /// <param name="sukaTwo"></param>
        static public BigInteger sravnisuka(BigInteger sukOne, BigInteger sukaTwo) 
            {
                if (MillerRabin.MillerRabinTest(sukOne)==false) { Console.WriteLine("Пошле нахуй число 1 сосет очко"); return 0; }
                    if (MillerRabin.MillerRabinTest(sukaTwo) == false) { Console.WriteLine("Пошле нахуй число 2 сосет очко");return 0; }

            BigInteger sukaUltimete= sukOne* sukaTwo;
            string Mid = sukaUltimete.ToString();
            int index = Mid.Length;
            index = (index / 2) - 1;
            if (Mid.Length % 2 != 0)
            {
                Console.WriteLine(Mid[index+1]);
            }
            else 
            {
                Console.WriteLine(Mid[index] + " " + Mid[index + 1]);
            }
            return sukaUltimete;
            }
        /// <summary>
        /// Умножение 2 простых чисел сгенерированных классом Generate
        /// </summary>
        /// <returns></returns>
        static public BigInteger sravnisuka()
            {
            BigInteger sukOne= Generate.getRandom();
            BigInteger sukaTwo = Generate.getRandom();
            BigInteger sukaUltimete = sukOne * sukaTwo;
            Console.WriteLine(sukOne);
            Console.WriteLine(sukaTwo);
            string Mid = sukaUltimete.ToString();
            int index = Mid.Length;
            index = (index / 2) - 1;
            if (Mid.Length % 2 != 0)
            {
                Console.WriteLine(Mid[index + 1]);
            }
            else
            {
                Console.WriteLine(Mid[index] + " " + Mid[index + 1]);
            }
           
            return sukaUltimete;
            }
        }
}

