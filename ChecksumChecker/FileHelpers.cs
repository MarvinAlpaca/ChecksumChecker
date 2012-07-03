using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChecksumChecker
{
    internal static class FileHelpers
    {
        public static byte[] ReadFileToEnd(string file)
        {
            byte[] data;

            using (var fs = GetFileStream(file))
            {
                data = ReadFully(fs);
            }

            return data;
        }

        private static byte[] ReadFully(FileStream input)
        {
            //todo add checks!
            byte[] bytes;

            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                bytes = ms.ToArray();
            }

            return bytes;
        }

        private static FileStream GetFileStream(string pathName)
        {
            return (new FileStream(pathName, FileMode.Open,
                          FileAccess.Read, FileShare.ReadWrite));
        }
    }
}