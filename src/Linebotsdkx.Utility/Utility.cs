namespace Linebotsdkx;

using System;
using System.Security.Cryptography;
using System.Text;

public static class Utility
{
    public static bool SignatureValidation(string signature, string body, string channelSecret)
    {
        byte[] channelSecretBytes = Encoding.UTF8.GetBytes(channelSecret);
        byte[] bodyBytes = Encoding.UTF8.GetBytes(body);
        string mySignature = Convert.ToBase64String(
            new HMACSHA256(channelSecretBytes).ComputeHash(bodyBytes)
        );
        return signature == mySignature;
    }
}
