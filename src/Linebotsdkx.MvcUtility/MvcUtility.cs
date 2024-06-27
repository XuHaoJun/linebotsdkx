namespace Linebotsdkx;

using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

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

    private static readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
    {
        // OpenAPI generated types generally hide default constructors.
        ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy { OverrideSpecifiedNames = false }
        }
    };

    public static Webhook.Model.CallbackRequest WebhookResultDeserialize(ControllerBase controller)
    {
        string body = "";
        controller.Request.EnableBuffering();
        controller.Request.Body.Position = 0;
        using (StreamReader streamReader = new(controller.Request.Body))
        {
            body = streamReader.ReadToEnd();
        }
        return JsonConvert.DeserializeObject<Webhook.Model.CallbackRequest>(
            body,
            _serializerSettings
        );
    }
}
