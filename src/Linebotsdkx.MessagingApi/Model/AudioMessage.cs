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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Linebotsdkx.MessagingApi.Client.OpenAPIDateConverter;

namespace Linebotsdkx.MessagingApi.Model
{
    /// <summary>
    /// AudioMessage
    /// </summary>
    [DataContract(Name = "AudioMessage")]
    public partial class AudioMessage : Message, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AudioMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioMessage" /> class.
        /// </summary>
        /// <param name="originalContentUrl">originalContentUrl (required).</param>
        /// <param name="duration">duration (required).</param>
        /// <param name="type">Type of message (required) (default to &quot;AudioMessage&quot;).</param>
        /// <param name="quickReply">quickReply.</param>
        /// <param name="sender">sender.</param>
        public AudioMessage(string originalContentUrl = default(string), long duration = default(long), string type = @"AudioMessage", QuickReply quickReply = default(QuickReply), Sender sender = default(Sender)) : base(type, quickReply, sender)
        {
            // to ensure "originalContentUrl" is required (not null)
            if (originalContentUrl == null)
            {
                throw new ArgumentNullException("originalContentUrl is a required property for AudioMessage and cannot be null");
            }
            this.OriginalContentUrl = originalContentUrl;
            this.Duration = duration;
        }

        /// <summary>
        /// Gets or Sets OriginalContentUrl
        /// </summary>
        [DataMember(Name = "originalContentUrl", IsRequired = true, EmitDefaultValue = true)]
        public string OriginalContentUrl { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", IsRequired = true, EmitDefaultValue = true)]
        public long Duration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AudioMessage {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  OriginalContentUrl: ").Append(OriginalContentUrl).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in base.BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }

}
