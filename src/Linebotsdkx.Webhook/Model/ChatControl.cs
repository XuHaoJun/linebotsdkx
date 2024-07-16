/*
 * Webhook Type Definition
 *
 * Webhook event definition of the LINE Messaging API
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
using OpenAPIDateConverter = Linebotsdkx.Webhook.Client.OpenAPIDateConverter;

namespace Linebotsdkx.Webhook.Model
{
    /// <summary>
    /// ChatControl
    /// </summary>
    [DataContract(Name = "ChatControl")]
    public partial class ChatControl : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatControl" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChatControl() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatControl" /> class.
        /// </summary>
        /// <param name="expireAt">expireAt (required).</param>
        public ChatControl(long expireAt = default(long))
        {
            this.ExpireAt = expireAt;
        }

        /// <summary>
        /// Gets or Sets ExpireAt
        /// </summary>
        [DataMember(Name = "expireAt", IsRequired = true, EmitDefaultValue = true)]
        public long ExpireAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChatControl {\n");
            sb.Append("  ExpireAt: ").Append(ExpireAt).Append("\n");
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
