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
using OpenAPIDateConverter = Linebotsdkx.Module.Client.OpenAPIDateConverter;

namespace Linebotsdkx.Module.Model
{
    /// <summary>
    /// List of bots to which the module is attached
    /// </summary>
    [DataContract(Name = "GetModulesResponse")]
    public partial class GetModulesResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetModulesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetModulesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetModulesResponse" /> class.
        /// </summary>
        /// <param name="bots">Array of Bot list Item objects representing basic information about the bot. (required).</param>
        /// <param name="next">Continuation token. Used to get the next array of basic bot information. This property is only returned if there are more unreturned results. .</param>
        public GetModulesResponse(List<ModuleBot> bots = default(List<ModuleBot>), string next = default(string))
        {
            // to ensure "bots" is required (not null)
            if (bots == null)
            {
                throw new ArgumentNullException("bots is a required property for GetModulesResponse and cannot be null");
            }
            this.Bots = bots;
            this.Next = next;
        }

        /// <summary>
        /// Array of Bot list Item objects representing basic information about the bot.
        /// </summary>
        /// <value>Array of Bot list Item objects representing basic information about the bot.</value>
        [DataMember(Name = "bots", IsRequired = true, EmitDefaultValue = true)]
        public List<ModuleBot> Bots { get; set; }

        /// <summary>
        /// Continuation token. Used to get the next array of basic bot information. This property is only returned if there are more unreturned results. 
        /// </summary>
        /// <value>Continuation token. Used to get the next array of basic bot information. This property is only returned if there are more unreturned results. </value>
        [DataMember(Name = "next", EmitDefaultValue = false)]
        public string Next { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetModulesResponse {\n");
            sb.Append("  Bots: ").Append(Bots).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
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
