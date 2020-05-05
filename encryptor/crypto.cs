using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace encryptor
{
    class crypto
    {
        public string base64Encode(string text)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(plainTextBytes);
       
        }
        public string base64Decode(string text)
        {
            string output;
            try
            {
                var base64EncodedBytes = System.Convert.FromBase64String(text);
                output = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
            catch
            {
                output = "Invaild input";
            }
            return output;
        }
        public string md5hash(byte[] text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();        
            md5.ComputeHash(text);
           
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //her baytı 2 hexadecimal hane olarak değiştirir
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
        public string sha256Hash(byte[] rawData)
        {

            SHA256 sha256Hash = SHA256.Create();
            
            
                byte[] bytes = sha256Hash.ComputeHash(rawData);

                
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            
        }

        public byte[] aesEncrypt(byte[] clearText, string key, string iv)
        {
            AesCryptoServiceProvider acsp = new AesCryptoServiceProvider();
           
            try
            {
                acsp.Key = Encoding.ASCII.GetBytes(key);// set key

            }
            catch
            {
                return Encoding.ASCII.GetBytes("Invalid Key Size !");
            }

            try { 
            acsp.IV  =  Encoding.ASCII.GetBytes(iv); // set iv
            }
            catch
            {
                return Encoding.ASCII.GetBytes("Invalid IV Size !");
            }

            acsp.Mode = CipherMode.CBC; // set cipher mode cbc
            
            //create encrytor
            ICryptoTransform cryptoTransform = acsp.CreateEncryptor();

            //encrypt bytes
            byte[] cipherTextBytes = cryptoTransform.TransformFinalBlock((clearText), 0, clearText.Length);

            return cipherTextBytes;

        }
        public byte[] aesDecrypt(byte[] cipherText, string key, string iv)
        {
            AesCryptoServiceProvider acsp = new AesCryptoServiceProvider();
            try
            {
                acsp.Key = Encoding.ASCII.GetBytes(key);// set key

            }
            catch
            {
                return Encoding.ASCII.GetBytes("Invalid Key Size !");
            }

            try
            {
                acsp.IV = Encoding.ASCII.GetBytes(iv); // set iv
            }
            catch
            {
                return Encoding.ASCII.GetBytes("Invalid IV Size !");
            }

            acsp.Mode = CipherMode.CBC; // set cipher mode cbc

            //create decrytor
            ICryptoTransform cryptoTransform = acsp.CreateDecryptor();

            //decrypt bytes
            byte[] clearTextBytes = cryptoTransform.TransformFinalBlock(cipherText, 0, cipherText.Length);

            return clearTextBytes;


        }


    }
}
