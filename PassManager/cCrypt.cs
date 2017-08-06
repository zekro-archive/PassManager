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

        public static Database currentDatabase;


        [Serializable]
        public class Database
        {
            public List<Account> accounts = new List<Account>();
        }
        

        public class Account
        {
            public string name;
            public string username;
            public byte[] key;
            public string url;
            public string notes;
        }
        

        public static void addAccount(string name, string username, string password, string url, string notes)
        {
            Account acc = new Account();
            acc.name = name;
            acc.username = username;
            acc.url = url;
            acc.notes = notes;

            Aes aes = Aes.Create();
            byte[] assambedKey = new byte[48];
            Array.Copy(aes.IV, assambedKey, 16);
            Array.Copy(getKey(password), assambedKey, 32);
            acc.key = assambedKey;

            currentDatabase.accounts.Add(acc);
            
        }

        public static string getPass(byte[] key)
        {
            byte[] rawKey = key.Skip(16).ToArray();
            string rawPass = Encoding.UTF8.GetString(rawKey);
            return rawPass.Substring(rawPass.IndexOf("²"));
        }

        public static byte[] getKey(string password)
        {
            string pass = password;
            if (password.Length < 32)
            {
                for (int i = password.Length; i < 32; i++)
                {
                    pass += "²";
                }
            }

            return Encoding.UTF8.GetBytes(pass); ;
        }

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
