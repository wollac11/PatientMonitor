using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PatientMonitor
{
    // A class for encypting and verifying password hashes.
    // Based on MDSN MD5 libary example: https://goo.gl/FbSRoa

    class Password
    {
        /// <summary>
        /// Generates encrypted MD5 hash for password string
        /// </summary>
        /// <param name="input">String to hash</param>
        public static string encrypt(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        /// <summary>
        /// Verifies an MD5 hash with an unhashed string.
        /// </summary>
        /// <param name="input">String to verify</param>
        /// <param name="hash">Hash to compare with</param>
        public static bool verify(string input, string hash)
        {
            // Hash the input.
            string hashOfInput = encrypt(input);

            // Create a StringComparer and compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
