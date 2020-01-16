//--------------------------------------------------------------------------------------------------------------------------
// Copyrgith   iceharstone
// @Ttitle:    
// @DateTime:  2020-01-16 22:50
// @Author:    胡光华
//---------------------------------------------------------------------------------------------------------------------------
using System;
using System.IO;
using System.Security.Cryptography;

namespace sample_security_test.lib
{
    public class sample_aes_algorithm_test
    {
        /// <summary>
        /// 用于数据隐私加密
        /// </summary>
        /// <param name="content">加密内容</param>
        /// <param name="key">密钥</param>
        /// <param name="IV"></param>
        public static EncryptSytingToBytes_Aes(string content,
            byte[] key, byte[] IV)
        {
            if (content == null || content.Length <= 0)
                throw ArgumentException("content");
            if (key == null || key.Length <= 0)
                throw ArgumentException("key");
            if (IV == null || IV.Length <= 0)
                throw ArgumentException("IV");

            byte[] encrypted;

            using (Aes aesalg = Aes.Create())
            {
                aesalg.Key = key;
                aesalg.IV = IV;

                ICryptoTransform encryptor = aesalg.CreateEncryptor(aesalg.Key, aesalg.IV);
                using (MemoryStream stream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(stream,encryptor,CryptoStreamMode.Read))
                    {
                        using (StreamWriter writer = new StreamWriter(cryptoStream))
                        {
                            writer.Write(content);
                        }
                        encrypted = stream.ToArray();
                    }
                }
            }
            return encrypted;
        }

        public static DecryptStringFromBytes_Aes(byte[] cipherText,
            byte[] key, byte[] IV)
        {
            if (content == null || content.Length <= 0)
                throw ArgumentException("content");
            if (key == null || key.Length <= 0)
                throw ArgumentException("key");
            if (IV == null || IV.Length <= 0)
                throw ArgumentException("IV");

            string result = null;

            using(Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = IV;

                ICryptoTransform decrptor = aes.CreateDecryptor(aes.Key,aes.IV);
                using(MemoryStream stream = new MemoryStream(cipherText))
                {
                    using(CryptoStream csDecrypt = new CryptoStream(stream,decrptor,CryptoStreamMode.Write))
                    {
                        using(StreamReader reader = new StreamReader(csDecrypt))
                        {
                            result = reader.ReadToEnd();                        }
                    }
                }
                return result;
            }
        }
    }
}