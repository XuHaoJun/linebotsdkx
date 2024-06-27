namespace Linebotsdkx;

using System.IO;
using Microsoft.AspNetCore.Mvc;

public static class MvcUtility
{
    public static bool SignatureValidation(ControllerBase ApiController, string lineChannelSecret)
    {
        if (ApiController.Request.Headers.TryGetValue("X-Line-Signature", out var value))
        {
            string text = value.ToArray()[0];
            string body = "";
            using (StreamReader streamReader = new StreamReader(ApiController.Request.Body))
            {
                body = streamReader.ReadToEnd();
            }
            return Utility.SignatureValidation(signature: text, body: body, lineChannelSecret);
        }
        return false;
    }
}
