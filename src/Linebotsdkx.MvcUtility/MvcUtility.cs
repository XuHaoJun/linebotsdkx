namespace Linebotsdkx;

using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

public static class MvcUtility
{
    public static async Task<bool> SignatureValidationAsync(
        ControllerBase controller,
        string lineChannelSecret
    )
    {
        if (controller.Request.Headers.TryGetValue("X-Line-Signature", out var value))
        {
            string text = value.ToArray()[0];
            controller.Request.EnableBuffering();
            controller.Request.Body.Position = 0;
            string body = await new StreamReader(controller.Request.Body).ReadToEndAsync();
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

    public static async Task<Webhook.Model.CallbackRequest> WebhookResultDeserializeAsync(
        ControllerBase controller
    )
    {
        controller.Request.EnableBuffering();
        controller.Request.Body.Position = 0;
        string body = await new StreamReader(controller.Request.Body).ReadToEndAsync();
        return JsonConvert.DeserializeObject<Webhook.Model.CallbackRequest>(
            body,
            _serializerSettings
        );
    }
}
