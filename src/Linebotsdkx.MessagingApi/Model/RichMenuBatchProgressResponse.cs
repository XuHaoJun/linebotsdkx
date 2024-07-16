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
    /// RichMenuBatchProgressResponse
    /// </summary>
    [DataContract(Name = "RichMenuBatchProgressResponse")]
    public partial class RichMenuBatchProgressResponse : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Phase
        /// </summary>
        [DataMember(Name = "phase", IsRequired = true, EmitDefaultValue = true)]
        public RichMenuBatchProgressPhase Phase { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RichMenuBatchProgressResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RichMenuBatchProgressResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RichMenuBatchProgressResponse" /> class.
        /// </summary>
        /// <param name="phase">phase (required).</param>
        /// <param name="acceptedTime">The accepted time in milliseconds of the request of batch control the rich menu.  Format: ISO 8601 (e.g. 2023-06-08T10:15:30.121Z) Timezone: UTC  (required).</param>
        /// <param name="completedTime">The completed time in milliseconds of rich menu batch control. Returned when the phase property is succeeded or failed.  Format: ISO 8601 (e.g. 2023-06-08T10:15:30.121Z) Timezone: UTC .</param>
        public RichMenuBatchProgressResponse(RichMenuBatchProgressPhase phase = default(RichMenuBatchProgressPhase), DateTime acceptedTime = default(DateTime), DateTime completedTime = default(DateTime))
        {
            this.Phase = phase;
            this.AcceptedTime = acceptedTime;
            this.CompletedTime = completedTime;
        }

        /// <summary>
        /// The accepted time in milliseconds of the request of batch control the rich menu.  Format: ISO 8601 (e.g. 2023-06-08T10:15:30.121Z) Timezone: UTC 
        /// </summary>
        /// <value>The accepted time in milliseconds of the request of batch control the rich menu.  Format: ISO 8601 (e.g. 2023-06-08T10:15:30.121Z) Timezone: UTC </value>
        [DataMember(Name = "acceptedTime", IsRequired = true, EmitDefaultValue = true)]
        public DateTime AcceptedTime { get; set; }

        /// <summary>
        /// The completed time in milliseconds of rich menu batch control. Returned when the phase property is succeeded or failed.  Format: ISO 8601 (e.g. 2023-06-08T10:15:30.121Z) Timezone: UTC 
        /// </summary>
        /// <value>The completed time in milliseconds of rich menu batch control. Returned when the phase property is succeeded or failed.  Format: ISO 8601 (e.g. 2023-06-08T10:15:30.121Z) Timezone: UTC </value>
        [DataMember(Name = "completedTime", EmitDefaultValue = false)]
        public DateTime CompletedTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RichMenuBatchProgressResponse {\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
            sb.Append("  AcceptedTime: ").Append(AcceptedTime).Append("\n");
            sb.Append("  CompletedTime: ").Append(CompletedTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
