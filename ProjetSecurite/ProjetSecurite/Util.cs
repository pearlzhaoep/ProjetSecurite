using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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

        public static bool checkInputAlphbet(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }
        public static bool checkInputAlphNum(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z0-9]+$");
        }
        public static bool checkEmail(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$");
        }
        public static bool checkPassword(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z0-9 !""#$%&'()*+,./:;<=>?@[\]^_`{|}~-]+$");
        }
    }
}
