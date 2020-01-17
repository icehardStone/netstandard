using System;
using System.IO;
using System.Security;
using System.Security.Cryptography;

namespace sample_security_test.lib
{
    public class Sample_ECDsaCng_Test
    {
        public Sample_ECDsaCng_Test()
        {
            using(ECDsaCng eCDsa = new ECDsaCng())
            {
                eCDsa.HashAlgorithm = CngAlgorithm.MD5;
                // sample 1
                byte[] bt1 = new byte[];
                eCDsa.SignData(bt1);

                // sample 2
                byte[] bt2 = new byte[];
                eCDsa.SignData(bt2,0,bt2.Length);

                // sample 3
                byte[] bt3 = new byte[];
                eCDsa.SignData(bt3,CngAlgorithm.Rsa);

                // sample 4
                using (MemoryStream stream = new MemoryStream())
                {
                    eCDsa.SignData(stream);
                }

                // sample 5
                using (MemoryStream stream = new MemoryStream())
                {
                    eCDsa.SignData(stream,CngAlgorithm.ECDsaP521);
                }

                // sample 6
                byte[] bt4 = new byte[];
                eCDsa.SignData(bt4,0,bt4.Length,CngAlgorithm.ECDsaP384);
            }
        }
    }
}