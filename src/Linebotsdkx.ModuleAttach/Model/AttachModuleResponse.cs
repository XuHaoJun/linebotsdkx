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
using OpenAPIDateConverter = Linebotsdkx.ModuleAttach.Client.OpenAPIDateConverter;

namespace Linebotsdkx.ModuleAttach.Model
{
    /// <summary>
    /// Attach by operation of the module channel provider
    /// </summary>
    [DataContract(Name = "AttachModuleResponse")]
    public partial class AttachModuleResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachModuleResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AttachModuleResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachModuleResponse" /> class.
        /// </summary>
        /// <param name="botId">User ID of the bot on the LINE Official Account. (required).</param>
        /// <param name="scopes">Permissions (scope) granted by the LINE Official Account admin. (required).</param>
        public AttachModuleResponse(string botId = default(string), List<string> scopes = default(List<string>))
        {
            // to ensure "botId" is required (not null)
            if (botId == null)
            {
                throw new ArgumentNullException("botId is a required property for AttachModuleResponse and cannot be null");
            }
            this.BotId = botId;
            // to ensure "scopes" is required (not null)
            if (scopes == null)
            {
                throw new ArgumentNullException("scopes is a required property for AttachModuleResponse and cannot be null");
            }
            this.Scopes = scopes;
        }

        /// <summary>
        /// User ID of the bot on the LINE Official Account.
        /// </summary>
        /// <value>User ID of the bot on the LINE Official Account.</value>
        [DataMember(Name = "bot_id", IsRequired = true, EmitDefaultValue = true)]
        public string BotId { get; set; }

        /// <summary>
        /// Permissions (scope) granted by the LINE Official Account admin.
        /// </summary>
        /// <value>Permissions (scope) granted by the LINE Official Account admin.</value>
        [DataMember(Name = "scopes", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Scopes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AttachModuleResponse {\n");
            sb.Append("  BotId: ").Append(BotId).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
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
