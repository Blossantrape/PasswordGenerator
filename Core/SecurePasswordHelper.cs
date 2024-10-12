using System.Security.Cryptography;

namespace Core;

public static class SecurePasswordHelper
{
    public static string GenerateSecurePassword(int length, string validChars)
    {
        char[] password = new char[length];
        using (var rng = new RNGCryptoServiceProvider())
        {
            byte[] uintBuffer = new byte[sizeof(uint)];
            for (int i = 0; i < length; i++)
            {
                rng.GetBytes(uintBuffer);
                uint num = BitConverter.ToUInt32(uintBuffer, 0);
                password[i] = validChars[(int)(num % (uint)validChars.Length)];
            }
        }
        return new string(password);
    }

    public static async Task<string> GenerateSecurePasswordAsync(int length, string validChars)
    {
        return await Task.Run(() => GenerateSecurePassword(length, validChars));
    }
}