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
    /// FlexMessage
    /// </summary>
    [DataContract(Name = "FlexMessage")]
    public partial class FlexMessage : Message, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlexMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlexMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlexMessage" /> class.
        /// </summary>
        /// <param name="altText">altText (required).</param>
        /// <param name="contents">contents (required).</param>
        /// <param name="type">Type of message (required) (default to &quot;FlexMessage&quot;).</param>
        /// <param name="quickReply">quickReply.</param>
        /// <param name="sender">sender.</param>
        public FlexMessage(string altText = default(string), FlexContainer contents = default(FlexContainer), string type = @"FlexMessage", QuickReply quickReply = default(QuickReply), Sender sender = default(Sender)) : base(type, quickReply, sender)
        {
            // to ensure "altText" is required (not null)
            if (altText == null)
            {
                throw new ArgumentNullException("altText is a required property for FlexMessage and cannot be null");
            }
            this.AltText = altText;
            // to ensure "contents" is required (not null)
            if (contents == null)
            {
                throw new ArgumentNullException("contents is a required property for FlexMessage and cannot be null");
            }
            this.Contents = contents;
        }

        /// <summary>
        /// Gets or Sets AltText
        /// </summary>
        [DataMember(Name = "altText", IsRequired = true, EmitDefaultValue = true)]
        public string AltText { get; set; }

        /// <summary>
        /// Gets or Sets Contents
        /// </summary>
        [DataMember(Name = "contents", IsRequired = true, EmitDefaultValue = true)]
        public FlexContainer Contents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlexMessage {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AltText: ").Append(AltText).Append("\n");
            sb.Append("  Contents: ").Append(Contents).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in base.BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }

}
