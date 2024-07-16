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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Linebotsdkx.Webhook.Client.OpenAPIDateConverter;

namespace Linebotsdkx.Webhook.Model
{
    /// <summary>
    /// GroupSource
    /// </summary>
    [DataContract(Name = "GroupSource")]
    public partial class GroupSource : Source, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSource" /> class.
        /// </summary>
        /// <param name="groupId">Group ID of the source group chat (required).</param>
        /// <param name="userId">ID of the source user. Only included in message events. Only users of LINE for iOS and LINE for Android are included in userId..</param>
        /// <param name="type">source type (required) (default to &quot;GroupSource&quot;).</param>
        public GroupSource(string groupId = default(string), string userId = default(string), string type = @"GroupSource") : base(type)
        {
            // to ensure "groupId" is required (not null)
            if (groupId == null)
            {
                throw new ArgumentNullException("groupId is a required property for GroupSource and cannot be null");
            }
            this.GroupId = groupId;
            this.UserId = userId;
        }

        /// <summary>
        /// Group ID of the source group chat
        /// </summary>
        /// <value>Group ID of the source group chat</value>
        [DataMember(Name = "groupId", IsRequired = true, EmitDefaultValue = true)]
        public string GroupId { get; set; }

        /// <summary>
        /// ID of the source user. Only included in message events. Only users of LINE for iOS and LINE for Android are included in userId.
        /// </summary>
        /// <value>ID of the source user. Only included in message events. Only users of LINE for iOS and LINE for Android are included in userId.</value>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupSource {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
