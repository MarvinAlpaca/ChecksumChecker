using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ChecksumChecker
{
    public class ComputeChecksum
    {
        public string CheckChecksum(HashAlgorithm hashAlgorithm, byte[] data)
        {
            string checksum = string.Empty;

            try
            {
                var hashData = ComputeHash(hashAlgorithm, data);

                checksum = FormatData(hashData);
            }
            catch (System.Exception ex)
            {
            }

            return checksum;
        }

        private string FormatData(byte[] data)
        {
            var formattedData = BitConverter.ToString(data);
            formattedData = formattedData.Replace("-", string.Empty).ToUpper();

            return formattedData;
        }

        private byte[] ComputeHash(HashAlgorithm hashAlgorithm, byte[] data)
        {
            var hashData = hashAlgorithm.ComputeHash(data);

            return hashData;
        }
    }
}