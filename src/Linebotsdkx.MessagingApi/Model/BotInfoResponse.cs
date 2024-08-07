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
using OpenAPIDateConverter = Linebotsdkx.MessagingApi.Client.OpenAPIDateConverter;

namespace Linebotsdkx.MessagingApi.Model
{
    /// <summary>
    /// BotInfoResponse
    /// </summary>
    [DataContract(Name = "BotInfoResponse")]
    public partial class BotInfoResponse : IValidatableObject
    {
        /// <summary>
        /// Chat settings set in the LINE Official Account Manager. One of:  &#x60;chat&#x60;: Chat is set to \&quot;On\&quot;. &#x60;bot&#x60;: Chat is set to \&quot;Off\&quot;. 
        /// </summary>
        /// <value>Chat settings set in the LINE Official Account Manager. One of:  &#x60;chat&#x60;: Chat is set to \&quot;On\&quot;. &#x60;bot&#x60;: Chat is set to \&quot;Off\&quot;. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChatModeEnum
        {
            /// <summary>
            /// Enum Chat for value: chat
            /// </summary>
            [EnumMember(Value = "chat")]
            Chat = 1,

            /// <summary>
            /// Enum Bot for value: bot
            /// </summary>
            [EnumMember(Value = "bot")]
            Bot = 2
        }


        /// <summary>
        /// Chat settings set in the LINE Official Account Manager. One of:  &#x60;chat&#x60;: Chat is set to \&quot;On\&quot;. &#x60;bot&#x60;: Chat is set to \&quot;Off\&quot;. 
        /// </summary>
        /// <value>Chat settings set in the LINE Official Account Manager. One of:  &#x60;chat&#x60;: Chat is set to \&quot;On\&quot;. &#x60;bot&#x60;: Chat is set to \&quot;Off\&quot;. </value>
        [DataMember(Name = "chatMode", IsRequired = true, EmitDefaultValue = true)]
        public ChatModeEnum ChatMode { get; set; }
        /// <summary>
        /// Automatic read setting for messages. If the chat is set to \&quot;Off\&quot;, auto is returned. If the chat is set to \&quot;On\&quot;, manual is returned.  &#x60;auto&#x60;: Auto read setting is enabled. &#x60;manual&#x60;: Auto read setting is disabled.  
        /// </summary>
        /// <value>Automatic read setting for messages. If the chat is set to \&quot;Off\&quot;, auto is returned. If the chat is set to \&quot;On\&quot;, manual is returned.  &#x60;auto&#x60;: Auto read setting is enabled. &#x60;manual&#x60;: Auto read setting is disabled.  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MarkAsReadModeEnum
        {
            /// <summary>
            /// Enum Auto for value: auto
            /// </summary>
            [EnumMember(Value = "auto")]
            Auto = 1,

            /// <summary>
            /// Enum Manual for value: manual
            /// </summary>
            [EnumMember(Value = "manual")]
            Manual = 2
        }


        /// <summary>
        /// Automatic read setting for messages. If the chat is set to \&quot;Off\&quot;, auto is returned. If the chat is set to \&quot;On\&quot;, manual is returned.  &#x60;auto&#x60;: Auto read setting is enabled. &#x60;manual&#x60;: Auto read setting is disabled.  
        /// </summary>
        /// <value>Automatic read setting for messages. If the chat is set to \&quot;Off\&quot;, auto is returned. If the chat is set to \&quot;On\&quot;, manual is returned.  &#x60;auto&#x60;: Auto read setting is enabled. &#x60;manual&#x60;: Auto read setting is disabled.  </value>
        [DataMember(Name = "markAsReadMode", IsRequired = true, EmitDefaultValue = true)]
        public MarkAsReadModeEnum MarkAsReadMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BotInfoResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BotInfoResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BotInfoResponse" /> class.
        /// </summary>
        /// <param name="userId">Bot&#39;s user ID (required).</param>
        /// <param name="basicId">Bot&#39;s basic ID (required).</param>
        /// <param name="premiumId">Bot&#39;s premium ID. Not included in the response if the premium ID isn&#39;t set..</param>
        /// <param name="displayName">Bot&#39;s display name (required).</param>
        /// <param name="pictureUrl">Profile image URL. &#x60;https&#x60; image URL. Not included in the response if the bot doesn&#39;t have a profile image..</param>
        /// <param name="chatMode">Chat settings set in the LINE Official Account Manager. One of:  &#x60;chat&#x60;: Chat is set to \&quot;On\&quot;. &#x60;bot&#x60;: Chat is set to \&quot;Off\&quot;.  (required).</param>
        /// <param name="markAsReadMode">Automatic read setting for messages. If the chat is set to \&quot;Off\&quot;, auto is returned. If the chat is set to \&quot;On\&quot;, manual is returned.  &#x60;auto&#x60;: Auto read setting is enabled. &#x60;manual&#x60;: Auto read setting is disabled.   (required).</param>
        public BotInfoResponse(string userId = default(string), string basicId = default(string), string premiumId = default(string), string displayName = default(string), string pictureUrl = default(string), ChatModeEnum chatMode = default(ChatModeEnum), MarkAsReadModeEnum markAsReadMode = default(MarkAsReadModeEnum))
        {
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new ArgumentNullException("userId is a required property for BotInfoResponse and cannot be null");
            }
            this.UserId = userId;
            // to ensure "basicId" is required (not null)
            if (basicId == null)
            {
                throw new ArgumentNullException("basicId is a required property for BotInfoResponse and cannot be null");
            }
            this.BasicId = basicId;
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for BotInfoResponse and cannot be null");
            }
            this.DisplayName = displayName;
            this.ChatMode = chatMode;
            this.MarkAsReadMode = markAsReadMode;
            this.PremiumId = premiumId;
            this.PictureUrl = pictureUrl;
        }

        /// <summary>
        /// Bot&#39;s user ID
        /// </summary>
        /// <value>Bot&#39;s user ID</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Bot&#39;s basic ID
        /// </summary>
        /// <value>Bot&#39;s basic ID</value>
        [DataMember(Name = "basicId", IsRequired = true, EmitDefaultValue = true)]
        public string BasicId { get; set; }

        /// <summary>
        /// Bot&#39;s premium ID. Not included in the response if the premium ID isn&#39;t set.
        /// </summary>
        /// <value>Bot&#39;s premium ID. Not included in the response if the premium ID isn&#39;t set.</value>
        [DataMember(Name = "premiumId", EmitDefaultValue = false)]
        public string PremiumId { get; set; }

        /// <summary>
        /// Bot&#39;s display name
        /// </summary>
        /// <value>Bot&#39;s display name</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Profile image URL. &#x60;https&#x60; image URL. Not included in the response if the bot doesn&#39;t have a profile image.
        /// </summary>
        /// <value>Profile image URL. &#x60;https&#x60; image URL. Not included in the response if the bot doesn&#39;t have a profile image.</value>
        [DataMember(Name = "pictureUrl", EmitDefaultValue = false)]
        public string PictureUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BotInfoResponse {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  BasicId: ").Append(BasicId).Append("\n");
            sb.Append("  PremiumId: ").Append(PremiumId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  PictureUrl: ").Append(PictureUrl).Append("\n");
            sb.Append("  ChatMode: ").Append(ChatMode).Append("\n");
            sb.Append("  MarkAsReadMode: ").Append(MarkAsReadMode).Append("\n");
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
