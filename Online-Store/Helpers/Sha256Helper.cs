using System.Security.Cryptography;
using System.Text;

namespace Online_Store.Helpers
{
    public static class Sha256Helper
    {
        public static string ComputeHash(string codeVerifier)
        {
            using var sha256 = SHA256.Create();
            var challengeBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(codeVerifier));
            string codeChallenge = Convert.ToBase64String(challengeBytes)
            // Make it URL-safe
            .Replace('+', '-')
            .Replace('/', '_')
            // Remove any trailing '=' characters
            .TrimEnd('=');
            return codeChallenge;
        }
    }
}