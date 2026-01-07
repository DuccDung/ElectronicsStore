using System.Security.Cryptography;
using System.Text;

namespace ElectronicsStoreSystem.Utils
{
    internal class HashHelper
    {
        public static byte[] Sha256(string input)
        {
            using var sha = SHA256.Create();
            return sha.ComputeHash(Encoding.UTF8.GetBytes(input));
        }
    }
}
