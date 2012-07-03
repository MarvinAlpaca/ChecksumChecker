using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ChecksumChecker.Model
{
    public class ChecksumModel
    {
        public ChecksumModel()
        {
            //todo support other types
            ChecksumType = new MD5CryptoServiceProvider();
        }

        public string RawChecksum { get; set; }

        public string FormattedChecksum { get; set; }

        public string ExpectedChecksum { get; set; }

        public string ActualChecksum { get; set; }

        public bool ChecksumMatch
        {
            get
            {
                return string.Equals(ExpectedChecksum, ActualChecksum, StringComparison.InvariantCultureIgnoreCase);
            }
        }

        public HashAlgorithm ChecksumType { get; set; }
    }
}