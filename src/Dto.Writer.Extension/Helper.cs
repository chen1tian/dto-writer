﻿using System.IO;
using System.Threading.Tasks;

namespace Dto.Writer
{
    internal class Helper
    {
        public static Task<string> ReadFile(string path)
        {
            return Task.Run(() =>
            {
                if (!File.Exists(path))
                {
                    return null;
                }

                using (var reader = new StreamReader(path))
                {
                    return reader.ReadToEnd();
                }
            });
        }
    }
}
