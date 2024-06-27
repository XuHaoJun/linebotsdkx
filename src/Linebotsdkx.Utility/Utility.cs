namespace Linebotsdkx;

using System;
using System.Security.Cryptography;
using System.Text;

public static class Utility
{
    public static bool SignatureValidation(string signature, string body, string token)
    {
        byte[] tokenBytes = Encoding.UTF8.GetBytes(token);
        byte[] signatureBytes = Encoding.UTF8.GetBytes(signature);
        return Convert.ToBase64String(new HMACSHA256(tokenBytes).ComputeHash(signatureBytes)) == body;
    }
}
