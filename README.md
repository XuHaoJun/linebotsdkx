# linebotsdkx

C# line bot sdk.

Code generated by [openapi-generator](https://github.com/OpenAPITools/openapi-generator), and spec from [line-openapi](https://github.com/line/line-openapi).

## QuickStart

```sh
dotnet add package Linebotsdkx.MessagingApi
```

```c#
using Linebotsdkx.MessagingApi.Api;

var client = new MessagingApiApi
(
    new Configuration()
    {
        DefaultHeaders = new Dictionary<string, string>
        {
            { "Authorization", "Bearer " + "<YOUR_CHANNEL_ACCESS_TOKEN>" },
        }
    }
);
var body = new BroadcastRequest
(
    new List<Message>
    {
      new TextMessage(type: "text", text: "hello"),
      new TextMessage(type: "text", text: "world!")
    },
);
await client.BroadcastAsync(body);
```

## webhook example

```sh
dotnet add package Linebotsdkx.Webhook
dotnet add package Linebotsdkx.MvcUtility
```

```c#
public class LineController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Linebotsdkx.Webhook.CallbackRequest body)
    {
        if (!Linebotsdkx.MvcUtility.SignatureValidation(this, yourChannelSecert))
        {
            // invalid
        }
        body.Events; // webhook event objects from LINE Platform
        body.Destination; // user ID of the bot
    }
}
```

## Issues

- [[csharp-netcore] Incorrect JsonConverter attribute added to polymorphic sub-classes](https://github.com/OpenAPITools/openapi-generator/issues/15302)
