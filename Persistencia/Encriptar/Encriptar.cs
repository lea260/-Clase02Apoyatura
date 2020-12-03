using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.Encriptar
{
    public class Encriptar
    {
        /// <summary>
        /// ran
        /// </summary>
        /// <param name="randomString">clave</param>
        /// <returns>string de largo 64</returns>
        public static string sha256(string randomString)
        {            
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
