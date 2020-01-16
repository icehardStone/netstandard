using System;
using System.Security.Cryptography;
using System.Security;
using System.IO;

namespace sample_security_test.lib
{
    public class sample_HMACSHA256_test
    {
        public static byte[] Encryptor(string content,byte[] key)
        {
            using(HMACSHA256 hm = new HMACSHA256(key,content))
            {
                using(MemoryStream stream = new MemoryStream())
                {
                    using(StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write(content);
                    }
                    return hm.ComputeHash(stream);
                }
            }
        }
    }
    
}