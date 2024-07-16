# linebotsdkx

C# line bot sdk.

Code generated by [openapi-generator](https://github.com/OpenAPITools/openapi-generator), and spec from [line-openapi](https://github.com/line/line-openapi).

## QuickStart

```sh
dotnet add package Linebotsdkx.MessagingApi
```

```c#
using Linebotsdkx.MessagingApi.Api;
using Linebotsdkx.MessagingApi.Model;

var client = new MessagingApiApi
(
    new Linebotsdkx.MessagingApi.Client.Configuration()
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
var resp = await client.BroadcastAsync(body);




// Imagemap with PushMessageAsync example
// example image form https://github.com/isdaviddong/HOL-LineBotSDK/blob/master/basic/Lab%2003%3A%E5%A6%82%E4%BD%95%E7%99%BC%E9%80%81ImageMap%E8%A8%8A%E6%81%AF.md

var body2 = new PushMessageRequest(
    to: "<YOUR_LINE_USER_ID>",
    messages: new List<Message>
    {
        new ImagemapMessage(
            type: "imagemap",
            baseUrl: "https://i.imgur.com/leKztCj.png",
            altText: "test",
            baseSize: new ImagemapBaseSize(1040, 1040),
            actions:
              new List<ImagemapAction>
              {
                new URIImagemapAction(
                  type: "uri",
                  linkUri: "https://zh.wikipedia.org/wiki/%E9%B6%AF%E6%AD%8C%E5%8D%80",
                  area: new ImagemapArea(0, 0, 500, 1040)
                ),
                new URIImagemapAction(
                  type: "uri",
                  linkUri: "https://zh.wikipedia.org/wiki/%E5%85%AB%E5%BE%B7%E5%8D%80",
                  area: new ImagemapArea(0, 0, 1040, 1040)
                )
              }
        )
    }
);
var resp2 = await client.PushMessageAsync(body2);
```

## Webhook echo example

```sh
dotnet add package Linebotsdkx.Webhook
dotnet add package Linebotsdkx.MvcUtility
```

```c#
public class LineController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post()
    {
        if (!(await Linebotsdkx.MvcUtility.SignatureValidationAsync(this, "<YOUR_CHANNEL_SECRET>")))
        {
            // invalid
            return BadRequest();
        }
        var body = await Linebotsdkx.MvcUtility.WebhookResultDeserializeAsync(this);
        Console.WriteLine(body.Events); // webhook event objects from LINE Platform
        Console.WriteLine(body.Destination); // user ID of the bot
        foreach (var x in body.Events)
        {
            if (x is MessageEvent && x.Source is UserSource)
            {
                var messageEvent = x as MessageEvent;
                if (messageEvent.Message is TextMessageContent)
                {
                  var userSource = x.Source as UserSource;
                  var textMessageContent = messageEvent.Message as TextMessageContent;
                  var echoBody = new PushMessageRequest(
                      to: userSource.UserId,
                      messages: new List<Message>
                      {
                          new TextMessage(type: "text", text: textMessageContent.Text ),
                      }
                  );
                  await client.PushMessageAsync(echoBody);
                }
            }
        }
    }
}
```

## Development

exec `run.sh` that will use `openapi-generator` generate code.

## Issues

- [[csharp-netcore] Incorrect JsonConverter attribute added to polymorphic sub-classes](https://github.com/OpenAPITools/openapi-generator/issues/15302)
