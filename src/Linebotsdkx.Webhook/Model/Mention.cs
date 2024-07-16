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
    /// Mention
    /// </summary>
    [DataContract(Name = "Mention")]
    public partial class Mention : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mention" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Mention() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Mention" /> class.
        /// </summary>
        /// <param name="mentionees">Array of one or more mention objects. Max: 20 mentions (required).</param>
        public Mention(List<Mentionee> mentionees = default(List<Mentionee>))
        {
            // to ensure "mentionees" is required (not null)
            if (mentionees == null)
            {
                throw new ArgumentNullException("mentionees is a required property for Mention and cannot be null");
            }
            this.Mentionees = mentionees;
        }

        /// <summary>
        /// Array of one or more mention objects. Max: 20 mentions
        /// </summary>
        /// <value>Array of one or more mention objects. Max: 20 mentions</value>
        [DataMember(Name = "mentionees", IsRequired = true, EmitDefaultValue = true)]
        public List<Mentionee> Mentionees { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Mention {\n");
            sb.Append("  Mentionees: ").Append(Mentionees).Append("\n");
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
