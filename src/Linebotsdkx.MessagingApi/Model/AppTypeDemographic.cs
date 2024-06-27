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
    /// Defines AppTypeDemographic
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AppTypeDemographic
    {
        /// <summary>
        /// Enum Ios for value: ios
        /// </summary>
        [EnumMember(Value = "ios")]
        Ios = 1,

        /// <summary>
        /// Enum Android for value: android
        /// </summary>
        [EnumMember(Value = "android")]
        Android = 2
    }

}
