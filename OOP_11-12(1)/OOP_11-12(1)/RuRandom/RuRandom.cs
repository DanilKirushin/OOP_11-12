using System;
using System.Security.Cryptography;

namespace RuFramework.RuRandom
{
    // C# Helper
    // http://csharphelper.com/blog/2014/08/use-a-cryptographic-random-number-generator-in-c/
    //
    // Use a cryptographic random number generator in C#
    // Posted on August 8, 2014 by Rod Stephens
    public class RuRandom
    {
        /// <summary>
        /// Return a random integer between a min and max value.
        /// The number max is not returned.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>RandomNumber</returns>
        public static int GenerateRandomNumber(int min, int max)
        {
            // The random number provider.
            RNGCryptoServiceProvider Rand = new RNGCryptoServiceProvider();

            uint scale = uint.MaxValue;
            while (scale == uint.MaxValue)
            {
                // Get four random bytes.
                byte[] four_bytes = new byte[4];
                Rand.GetBytes(four_bytes);

                // Convert that into an uint.
                scale = BitConverter.ToUInt32(four_bytes, 0);
            }
            // Add min to the scaled difference between max and min.
            return (int)(min + (max - min) * (scale / (double)uint.MaxValue));
        }
    }
}
