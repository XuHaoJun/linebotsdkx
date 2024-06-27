namespace Linebotsdkx;

using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

public static class MvcUtility
{
    public static bool SignatureValidation(ControllerBase controller, string lineChannelSecret)
    {
        if (controller.Request.Headers.TryGetValue("X-Line-Signature", out var value))
        {
            string text = value.ToArray()[0];
            string body = "";
            controller.Request.EnableBuffering();
            controller.Request.Body.Position = 0;
            using (StreamReader streamReader = new(controller.Request.Body))
            {
                body = streamReader.ReadToEnd();
            }
            return Utility.SignatureValidation(signature: text, body: body, lineChannelSecret);
        }
        return false;
    }
}
