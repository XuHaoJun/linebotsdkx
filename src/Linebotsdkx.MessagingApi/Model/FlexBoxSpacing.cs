/*
 * LINE Messaging API
 *
 * This document describes LINE Messaging API.
 *
 * The version of the OpenAPI document: 0.0.1
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
using OpenAPIDateConverter = Linebotsdkx.MessagingApi.Client.OpenAPIDateConverter;

namespace Linebotsdkx.MessagingApi.Model
{
    /// <summary>
    /// You can specify the minimum space between two components with the &#x60;spacing&#x60; property of the parent box component, in pixels or with a keyword.  FlexBoxSpacing just provides only keywords. 
    /// </summary>
    /// <value>You can specify the minimum space between two components with the &#x60;spacing&#x60; property of the parent box component, in pixels or with a keyword.  FlexBoxSpacing just provides only keywords. </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FlexBoxSpacing
    {
        /// <summary>
        /// Enum None for value: none
        /// </summary>
        [EnumMember(Value = "none")]
        None = 1,

        /// <summary>
        /// Enum Xs for value: xs
        /// </summary>
        [EnumMember(Value = "xs")]
        Xs = 2,

        /// <summary>
        /// Enum Sm for value: sm
        /// </summary>
        [EnumMember(Value = "sm")]
        Sm = 3,

        /// <summary>
        /// Enum Md for value: md
        /// </summary>
        [EnumMember(Value = "md")]
        Md = 4,

        /// <summary>
        /// Enum Lg for value: lg
        /// </summary>
        [EnumMember(Value = "lg")]
        Lg = 5,

        /// <summary>
        /// Enum Xl for value: xl
        /// </summary>
        [EnumMember(Value = "xl")]
        Xl = 6,

        /// <summary>
        /// Enum Xxl for value: xxl
        /// </summary>
        [EnumMember(Value = "xxl")]
        Xxl = 7
    }

}
