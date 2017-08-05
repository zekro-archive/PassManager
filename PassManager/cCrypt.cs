using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PassManager
{
    class cCrypt
    {

        /// <summary>
        /// Encryption of the entered input text with a 32 byte key and a 16 byte initialization vector
        /// </summary>
        /// <param name="input"></param>
        /// <param name="key"></param>
        /// <param name="inivector"></param>
        /// <returns></returns>
        static byte[] encrypt(string input, byte[] key, byte[] inivector)
        {
            if (input.Length < 1 || key.Length < 1 || inivector.Length < 1)
                throw new ArgumentNullException();

            Aes aes = Aes.Create();
            aes.Key = key;
            aes.IV = inivector;

            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            using (MemoryStream memstream = new MemoryStream())
            {
                using (CryptoStream stream = new CryptoStream(memstream, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(stream))
                    {
                        sw.Write(input);
                    }
                }
                return memstream.ToArray();
            }

        }

        /// <summary>
        /// Decryption of input cipher byte array with a 32 byte key and a 16 byte initialization vector
        /// </summary>
        /// <param name="cipher"></param>
        /// <param name="key"></param>
        /// <param name="inivector"></param>
        /// <returns></returns>
        static string decrypt(byte[] cipher, byte[] key, byte[] inivector)
        {
            if (cipher.Length < 1 || key.Length < 1 || inivector.Length < 1)
                throw new ArgumentNullException();

            Aes aes = Aes.Create();
            aes.Key = key;
            aes.IV = inivector;

            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

            string outtext;

            using (MemoryStream memstream = new MemoryStream(cipher))
            {
                using (CryptoStream stream = new CryptoStream(memstream, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(stream))
                    {
                        outtext = sr.ReadToEnd();
                    }
                }
            }
            return outtext;
        }

    }
}
