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
using OpenAPIDateConverter = Linebotsdkx.ManageAudience.Client.OpenAPIDateConverter;

namespace Linebotsdkx.ManageAudience.Model
{
    /// <summary>
    /// Create audience for click-based retargeting
    /// </summary>
    [DataContract(Name = "CreateClickBasedAudienceGroupResponse")]
    public partial class CreateClickBasedAudienceGroupResponse : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public AudienceGroupType? Type { get; set; }
        /// <summary>
        /// How the audience was created. &#x60;MESSAGING_API&#x60;: An audience created with Messaging API. 
        /// </summary>
        /// <value>How the audience was created. &#x60;MESSAGING_API&#x60;: An audience created with Messaging API. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CreateRouteEnum
        {
            /// <summary>
            /// Enum MESSAGINGAPI for value: MESSAGING_API
            /// </summary>
            [EnumMember(Value = "MESSAGING_API")]
            MESSAGINGAPI = 1
        }


        /// <summary>
        /// How the audience was created. &#x60;MESSAGING_API&#x60;: An audience created with Messaging API. 
        /// </summary>
        /// <value>How the audience was created. &#x60;MESSAGING_API&#x60;: An audience created with Messaging API. </value>
        [DataMember(Name = "createRoute", EmitDefaultValue = false)]
        public CreateRouteEnum? CreateRoute { get; set; }
        /// <summary>
        /// Audience&#39;s update permission. Audiences linked to the same channel will be READ_WRITE.  - &#x60;READ&#x60;: Can use only. - &#x60;READ_WRITE&#x60;: Can use and update. 
        /// </summary>
        /// <value>Audience&#39;s update permission. Audiences linked to the same channel will be READ_WRITE.  - &#x60;READ&#x60;: Can use only. - &#x60;READ_WRITE&#x60;: Can use and update. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PermissionEnum
        {
            /// <summary>
            /// Enum READ for value: READ
            /// </summary>
            [EnumMember(Value = "READ")]
            READ = 1,

            /// <summary>
            /// Enum READWRITE for value: READ_WRITE
            /// </summary>
            [EnumMember(Value = "READ_WRITE")]
            READWRITE = 2
        }


        /// <summary>
        /// Audience&#39;s update permission. Audiences linked to the same channel will be READ_WRITE.  - &#x60;READ&#x60;: Can use only. - &#x60;READ_WRITE&#x60;: Can use and update. 
        /// </summary>
        /// <value>Audience&#39;s update permission. Audiences linked to the same channel will be READ_WRITE.  - &#x60;READ&#x60;: Can use only. - &#x60;READ_WRITE&#x60;: Can use and update. </value>
        [DataMember(Name = "permission", EmitDefaultValue = false)]
        public PermissionEnum? Permission { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClickBasedAudienceGroupResponse" /> class.
        /// </summary>
        /// <param name="audienceGroupId">The audience ID..</param>
        /// <param name="type">type.</param>
        /// <param name="description">The audience&#39;s name..</param>
        /// <param name="created">When the audience was created (in UNIX time)..</param>
        /// <param name="requestId">The request ID that was specified when the audience was created..</param>
        /// <param name="clickUrl">The URL that was specified when the audience was created..</param>
        /// <param name="createRoute">How the audience was created. &#x60;MESSAGING_API&#x60;: An audience created with Messaging API. .</param>
        /// <param name="permission">Audience&#39;s update permission. Audiences linked to the same channel will be READ_WRITE.  - &#x60;READ&#x60;: Can use only. - &#x60;READ_WRITE&#x60;: Can use and update. .</param>
        /// <param name="expireTimestamp">Time of audience expiration. Only returned for specific audiences..</param>
        /// <param name="isIfaAudience">The value indicating the type of account to be sent, as specified when creating the audience for uploading user IDs. One of:  true: Accounts are specified with IFAs. false (default): Accounts are specified with user IDs.  (default to false).</param>
        public CreateClickBasedAudienceGroupResponse(long audienceGroupId = default(long), AudienceGroupType? type = default(AudienceGroupType?), string description = default(string), long created = default(long), string requestId = default(string), string clickUrl = default(string), CreateRouteEnum? createRoute = default(CreateRouteEnum?), PermissionEnum? permission = default(PermissionEnum?), long expireTimestamp = default(long), bool isIfaAudience = false)
        {
            this.AudienceGroupId = audienceGroupId;
            this.Type = type;
            this.Description = description;
            this.Created = created;
            this.RequestId = requestId;
            this.ClickUrl = clickUrl;
            this.CreateRoute = createRoute;
            this.Permission = permission;
            this.ExpireTimestamp = expireTimestamp;
            this.IsIfaAudience = isIfaAudience;
        }

        /// <summary>
        /// The audience ID.
        /// </summary>
        /// <value>The audience ID.</value>
        [DataMember(Name = "audienceGroupId", EmitDefaultValue = false)]
        public long AudienceGroupId { get; set; }

        /// <summary>
        /// The audience&#39;s name.
        /// </summary>
        /// <value>The audience&#39;s name.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// When the audience was created (in UNIX time).
        /// </summary>
        /// <value>When the audience was created (in UNIX time).</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public long Created { get; set; }

        /// <summary>
        /// The request ID that was specified when the audience was created.
        /// </summary>
        /// <value>The request ID that was specified when the audience was created.</value>
        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The URL that was specified when the audience was created.
        /// </summary>
        /// <value>The URL that was specified when the audience was created.</value>
        [DataMember(Name = "clickUrl", EmitDefaultValue = false)]
        public string ClickUrl { get; set; }

        /// <summary>
        /// Time of audience expiration. Only returned for specific audiences.
        /// </summary>
        /// <value>Time of audience expiration. Only returned for specific audiences.</value>
        [DataMember(Name = "expireTimestamp", EmitDefaultValue = false)]
        public long ExpireTimestamp { get; set; }

        /// <summary>
        /// The value indicating the type of account to be sent, as specified when creating the audience for uploading user IDs. One of:  true: Accounts are specified with IFAs. false (default): Accounts are specified with user IDs. 
        /// </summary>
        /// <value>The value indicating the type of account to be sent, as specified when creating the audience for uploading user IDs. One of:  true: Accounts are specified with IFAs. false (default): Accounts are specified with user IDs. </value>
        [DataMember(Name = "isIfaAudience", EmitDefaultValue = true)]
        public bool IsIfaAudience { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateClickBasedAudienceGroupResponse {\n");
            sb.Append("  AudienceGroupId: ").Append(AudienceGroupId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  ClickUrl: ").Append(ClickUrl).Append("\n");
            sb.Append("  CreateRoute: ").Append(CreateRoute).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  ExpireTimestamp: ").Append(ExpireTimestamp).Append("\n");
            sb.Append("  IsIfaAudience: ").Append(IsIfaAudience).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
