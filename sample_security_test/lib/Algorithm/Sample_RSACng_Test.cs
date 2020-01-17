using System;
using System.IO;
using System.Security;
using System.Security.Cryptography;

namespace sample_security_test.lib
{
    public class Sample_RSACng_Test
    {
        public Sameple_RSACng_Test()
        {
            using (RSACng rsacng = new RSACng())
            {
                // sample 1
                byte[] bt1 = new byte[];
                rsacng.SignData(bt1,HashAlgorithmName.SHA1,RSASignaturePadding.Pkcs1);

                // sample 2
                byte[] bt2 = new byte[];
                rsacng.SignData(bt2,0,bt2.Length,HashAlgorithmName.SHA1,RSASignaturePadding.Pkcs1);

                // sample 3
                using (MemoryStream stream = new MemoryStream())
                {
                    rsacng.SignData(stream,HashAlgorithmName.SHA512,RSASignaturePadding.Pkcs1);                    
                }
            }
        }
    }
}