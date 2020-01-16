//--------------------------------------------------------------------------------------------------------------------------
// Copyrgith   iceharstone
// @Ttitle:    
// @DateTime:  2020-01-16 22:46
// @Author:    胡光华
//---------------------------------------------------------------------------------------------------------------------------
using System;
using System.Security.Cryptography;
using System.Security;
using System.IO;

namespace sample_security_test.lib
{
    public class sample_hmacsha256_test
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