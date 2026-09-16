using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BussinessLogicLayer
{
    internal static class clsEncryptDecrypt
    {

        // Fixed 32-byte key and 16-byte IV (must stay the same for encrypt/decrypt to match)
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("MySecretKey12345MySecretKey12345"[..32]);
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("MyIV1234567890AB"[..16]);

        internal static string Encrypt(string plainText)
        {
            using Aes aes = Aes.Create();
            aes.Key = Key;
            aes.IV = IV;

            using MemoryStream ms = new();
            using (CryptoStream cs = new(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
            using (StreamWriter sw = new(cs))
            {
                sw.Write(plainText);
            }

            return Convert.ToBase64String(ms.ToArray());
        }

        internal static string Decrypt(string cipherText)
        {
            byte[] fullCipher = Convert.FromBase64String(cipherText);

            using Aes aes = Aes.Create();
            aes.Key = Key;
            aes.IV = IV;

            using MemoryStream ms = new(fullCipher);
            using CryptoStream cs = new(ms, aes.CreateDecryptor(), CryptoStreamMode.Read);
            using StreamReader sr = new(cs);

            return sr.ReadToEnd();
        }


    }

}
