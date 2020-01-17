using System;
using System.Security;
using System.Security.Cryptography;
using System.IO;

namespace sample_security_test.lib
{
    public class Sample_Hmacsha256_Test
    {
        public Sample_Hmacsha256_Test()
        {

        }
        public byte[] Encryptor(byte[] key, string content)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(content);
                }

                using (HMACSHA512 mACSHA512 = new HMACSHA512(key))
                {
                    byte[] result = mACSHA512.ComputeHash(stream);
                    return result;
                }
            }
        }
    }
}