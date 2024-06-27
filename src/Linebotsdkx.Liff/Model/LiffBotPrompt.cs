/*
 * LIFF server API
 *
 * LIFF Server API.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Linebotsdkx.Liff.Client.OpenAPIDateConverter;

namespace Linebotsdkx.Liff.Model
{
    /// <summary>
    /// Specify the setting for bot link feature with one of the following values:  &#x60;normal&#x60;: Display the option to add the LINE Official Account as a friend in the channel consent screen. &#x60;aggressive&#x60;: Display a screen with the option to add the LINE Official Account as a friend after the channel consent screen. &#x60;none&#x60;: Don&#39;t display the option to add the LINE Official Account as a friend.   The default value is none. 
    /// </summary>
    /// <value>Specify the setting for bot link feature with one of the following values:  &#x60;normal&#x60;: Display the option to add the LINE Official Account as a friend in the channel consent screen. &#x60;aggressive&#x60;: Display a screen with the option to add the LINE Official Account as a friend after the channel consent screen. &#x60;none&#x60;: Don&#39;t display the option to add the LINE Official Account as a friend.   The default value is none. </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LiffBotPrompt
    {
        /// <summary>
        /// Enum Normal for value: normal
        /// </summary>
        [EnumMember(Value = "normal")]
        Normal = 1,

        /// <summary>
        /// Enum Aggressive for value: aggressive
        /// </summary>
        [EnumMember(Value = "aggressive")]
        Aggressive = 2,

        /// <summary>
        /// Enum None for value: none
        /// </summary>
        [EnumMember(Value = "none")]
        None = 3
    }

}
