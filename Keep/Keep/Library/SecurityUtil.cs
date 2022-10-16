using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Keep.Library
{
    public static class SecurityUtil
    {
        private static string IV = "thisisanivkeythi";
        private static string currentKey = "";

        public static string Encrypt(string plainText)
        {

            byte[] entry = ASCIIEncoding.ASCII.GetBytes(plainText);

            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 128;
            aes.Padding = PaddingMode.PKCS7;
            aes.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Key = ASCIIEncoding.ASCII.GetBytes(currentKey);
            aes.Mode = CipherMode.CBC;

            byte[] enc;
            using (ICryptoTransform icrypt = aes.CreateEncryptor(aes.Key, aes.IV))
            {
                enc = icrypt.TransformFinalBlock(entry, 0, entry.Length);
            }

            return Convert.ToBase64String(enc);
        }

        public static string Decrypt(string encryptedText)
        {
            byte[] entry = Convert.FromBase64String(encryptedText);

            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 128;
            aes.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Key = ASCIIEncoding.ASCII.GetBytes(currentKey);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;

            byte[] decry;

            using (ICryptoTransform icrypt = aes.CreateDecryptor(aes.Key, aes.IV))
            {
                decry = icrypt.TransformFinalBlock(entry, 0, entry.Length);
            }

            return ASCIIEncoding.ASCII.GetString(decry);
        }

        public static void setKey(string key)
        {
            if (key.Length <= 16)
                currentKey = key.PadRight(16);
            else
                currentKey = key.Substring(0,16);
        }


    }
}