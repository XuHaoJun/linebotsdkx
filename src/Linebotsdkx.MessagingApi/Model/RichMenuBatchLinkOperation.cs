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
    /// Replace the rich menu with the rich menu specified in the &#x60;to&#x60; property for all users linked to the rich menu specified in the &#x60;from&#x60; property.
    /// </summary>
    [DataContract(Name = "RichMenuBatchLinkOperation")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class RichMenuBatchLinkOperation : RichMenuBatchOperation, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RichMenuBatchLinkOperation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RichMenuBatchLinkOperation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RichMenuBatchLinkOperation" /> class.
        /// </summary>
        /// <param name="from">from (required).</param>
        /// <param name="to">to (required).</param>
        /// <param name="type">The type of operation to the rich menu linked to the user. One of link, unlink, or unlinkAll. (required) (default to &quot;RichMenuBatchLinkOperation&quot;).</param>
        public RichMenuBatchLinkOperation(string from = default(string), string to = default(string), string type = @"RichMenuBatchLinkOperation") : base(type)
        {
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new ArgumentNullException("from is a required property for RichMenuBatchLinkOperation and cannot be null");
            }
            this.From = from;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for RichMenuBatchLinkOperation and cannot be null");
            }
            this.To = to;
        }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public string To { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RichMenuBatchLinkOperation {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
