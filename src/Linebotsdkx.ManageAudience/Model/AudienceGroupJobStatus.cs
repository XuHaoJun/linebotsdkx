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
using OpenAPIDateConverter = Linebotsdkx.ManageAudience.Client.OpenAPIDateConverter;

namespace Linebotsdkx.ManageAudience.Model
{
    /// <summary>
    /// Job status
    /// </summary>
    /// <value>Job status</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AudienceGroupJobStatus
    {
        /// <summary>
        /// Enum QUEUED for value: QUEUED
        /// </summary>
        [EnumMember(Value = "QUEUED")]
        QUEUED = 1,

        /// <summary>
        /// Enum WORKING for value: WORKING
        /// </summary>
        [EnumMember(Value = "WORKING")]
        WORKING = 2,

        /// <summary>
        /// Enum FINISHED for value: FINISHED
        /// </summary>
        [EnumMember(Value = "FINISHED")]
        FINISHED = 3,

        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED = 4
    }

}
