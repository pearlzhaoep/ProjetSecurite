using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSecurite
{
    public class Util
    {
        public static string hashing(string rawMessage)
        {
            string hashedmessage = "";
            using (SHA256 sha256Hashing = SHA256.Create())
            {
                byte[] hashValue = sha256Hashing.ComputeHash(Encoding.UTF8.GetBytes(rawMessage));
                foreach (byte b in hashValue)
                {
                    hashedmessage += $"{b:X2}";
                }
            }
            return hashedmessage;
        }
    }
}
