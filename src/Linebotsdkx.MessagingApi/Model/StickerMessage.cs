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
    /// StickerMessage
    /// </summary>
    [DataContract(Name = "StickerMessage")]
    public partial class StickerMessage : Message, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StickerMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StickerMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StickerMessage" /> class.
        /// </summary>
        /// <param name="packageId">packageId (required).</param>
        /// <param name="stickerId">stickerId (required).</param>
        /// <param name="quoteToken">Quote token of the message you want to quote..</param>
        /// <param name="type">Type of message (required) (default to &quot;StickerMessage&quot;).</param>
        /// <param name="quickReply">quickReply.</param>
        /// <param name="sender">sender.</param>
        public StickerMessage(string packageId = default(string), string stickerId = default(string), string quoteToken = default(string), string type = @"StickerMessage", QuickReply quickReply = default(QuickReply), Sender sender = default(Sender)) : base(type, quickReply, sender)
        {
            // to ensure "packageId" is required (not null)
            if (packageId == null)
            {
                throw new ArgumentNullException("packageId is a required property for StickerMessage and cannot be null");
            }
            this.PackageId = packageId;
            // to ensure "stickerId" is required (not null)
            if (stickerId == null)
            {
                throw new ArgumentNullException("stickerId is a required property for StickerMessage and cannot be null");
            }
            this.StickerId = stickerId;
            this.QuoteToken = quoteToken;
        }

        /// <summary>
        /// Gets or Sets PackageId
        /// </summary>
        [DataMember(Name = "packageId", IsRequired = true, EmitDefaultValue = true)]
        public string PackageId { get; set; }

        /// <summary>
        /// Gets or Sets StickerId
        /// </summary>
        [DataMember(Name = "stickerId", IsRequired = true, EmitDefaultValue = true)]
        public string StickerId { get; set; }

        /// <summary>
        /// Quote token of the message you want to quote.
        /// </summary>
        /// <value>Quote token of the message you want to quote.</value>
        [DataMember(Name = "quoteToken", EmitDefaultValue = false)]
        public string QuoteToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StickerMessage {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  PackageId: ").Append(PackageId).Append("\n");
            sb.Append("  StickerId: ").Append(StickerId).Append("\n");
            sb.Append("  QuoteToken: ").Append(QuoteToken).Append("\n");
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
