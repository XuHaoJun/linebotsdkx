/*
 * LINE Messaging API(Insight)
 *
 * This document describes LINE Messaging API(Insight).
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
using OpenAPIDateConverter = Linebotsdkx.Insight.Client.OpenAPIDateConverter;

namespace Linebotsdkx.Insight.Model
{
    /// <summary>
    /// Get number of message deliveries
    /// </summary>
    [DataContract(Name = "GetNumberOfMessageDeliveriesResponse")]
    public partial class GetNumberOfMessageDeliveriesResponse : IValidatableObject
    {
        /// <summary>
        /// Status of the counting process.
        /// </summary>
        /// <value>Status of the counting process.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Ready for value: ready
            /// </summary>
            [EnumMember(Value = "ready")]
            Ready = 1,

            /// <summary>
            /// Enum Unready for value: unready
            /// </summary>
            [EnumMember(Value = "unready")]
            Unready = 2,

            /// <summary>
            /// Enum OutOfService for value: out_of_service
            /// </summary>
            [EnumMember(Value = "out_of_service")]
            OutOfService = 3
        }


        /// <summary>
        /// Status of the counting process.
        /// </summary>
        /// <value>Status of the counting process.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetNumberOfMessageDeliveriesResponse" /> class.
        /// </summary>
        /// <param name="status">Status of the counting process..</param>
        /// <param name="broadcast">Number of messages sent to all of this LINE Official Account&#39;s friends (broadcast messages)..</param>
        /// <param name="targeting">Number of messages sent to some of this LINE Official Account&#39;s friends, based on specific attributes (targeted messages)..</param>
        /// <param name="autoResponse">Number of auto-response messages sent..</param>
        /// <param name="welcomeResponse">Number of greeting messages sent..</param>
        /// <param name="chat">Number of messages sent from LINE Official Account Manager [Chat screen](https://www.linebiz.com/jp/manual/OfficialAccountManager/chats/) (only available in Japanese)..</param>
        /// <param name="apiBroadcast">Number of broadcast messages sent with the &#x60;Send broadcast message&#x60; Messaging API operation..</param>
        /// <param name="apiPush">Number of push messages sent with the &#x60;Send push message&#x60; Messaging API operation..</param>
        /// <param name="apiMulticast">Number of multicast messages sent with the &#x60;Send multicast message&#x60; Messaging API operation..</param>
        /// <param name="apiNarrowcast">Number of narrowcast messages sent with the &#x60;Send narrowcast message&#x60; Messaging API operation..</param>
        /// <param name="apiReply">Number of replies sent with the &#x60;Send reply message&#x60; Messaging API operation..</param>
        public GetNumberOfMessageDeliveriesResponse(StatusEnum? status = default(StatusEnum?), long broadcast = default(long), long targeting = default(long), long autoResponse = default(long), long welcomeResponse = default(long), long chat = default(long), long apiBroadcast = default(long), long apiPush = default(long), long apiMulticast = default(long), long apiNarrowcast = default(long), long apiReply = default(long))
        {
            this.Status = status;
            this.Broadcast = broadcast;
            this.Targeting = targeting;
            this.AutoResponse = autoResponse;
            this.WelcomeResponse = welcomeResponse;
            this.Chat = chat;
            this.ApiBroadcast = apiBroadcast;
            this.ApiPush = apiPush;
            this.ApiMulticast = apiMulticast;
            this.ApiNarrowcast = apiNarrowcast;
            this.ApiReply = apiReply;
        }

        /// <summary>
        /// Number of messages sent to all of this LINE Official Account&#39;s friends (broadcast messages).
        /// </summary>
        /// <value>Number of messages sent to all of this LINE Official Account&#39;s friends (broadcast messages).</value>
        [DataMember(Name = "broadcast", EmitDefaultValue = false)]
        public long Broadcast { get; set; }

        /// <summary>
        /// Number of messages sent to some of this LINE Official Account&#39;s friends, based on specific attributes (targeted messages).
        /// </summary>
        /// <value>Number of messages sent to some of this LINE Official Account&#39;s friends, based on specific attributes (targeted messages).</value>
        [DataMember(Name = "targeting", EmitDefaultValue = false)]
        public long Targeting { get; set; }

        /// <summary>
        /// Number of auto-response messages sent.
        /// </summary>
        /// <value>Number of auto-response messages sent.</value>
        [DataMember(Name = "autoResponse", EmitDefaultValue = false)]
        public long AutoResponse { get; set; }

        /// <summary>
        /// Number of greeting messages sent.
        /// </summary>
        /// <value>Number of greeting messages sent.</value>
        [DataMember(Name = "welcomeResponse", EmitDefaultValue = false)]
        public long WelcomeResponse { get; set; }

        /// <summary>
        /// Number of messages sent from LINE Official Account Manager [Chat screen](https://www.linebiz.com/jp/manual/OfficialAccountManager/chats/) (only available in Japanese).
        /// </summary>
        /// <value>Number of messages sent from LINE Official Account Manager [Chat screen](https://www.linebiz.com/jp/manual/OfficialAccountManager/chats/) (only available in Japanese).</value>
        [DataMember(Name = "chat", EmitDefaultValue = false)]
        public long Chat { get; set; }

        /// <summary>
        /// Number of broadcast messages sent with the &#x60;Send broadcast message&#x60; Messaging API operation.
        /// </summary>
        /// <value>Number of broadcast messages sent with the &#x60;Send broadcast message&#x60; Messaging API operation.</value>
        [DataMember(Name = "apiBroadcast", EmitDefaultValue = false)]
        public long ApiBroadcast { get; set; }

        /// <summary>
        /// Number of push messages sent with the &#x60;Send push message&#x60; Messaging API operation.
        /// </summary>
        /// <value>Number of push messages sent with the &#x60;Send push message&#x60; Messaging API operation.</value>
        [DataMember(Name = "apiPush", EmitDefaultValue = false)]
        public long ApiPush { get; set; }

        /// <summary>
        /// Number of multicast messages sent with the &#x60;Send multicast message&#x60; Messaging API operation.
        /// </summary>
        /// <value>Number of multicast messages sent with the &#x60;Send multicast message&#x60; Messaging API operation.</value>
        [DataMember(Name = "apiMulticast", EmitDefaultValue = false)]
        public long ApiMulticast { get; set; }

        /// <summary>
        /// Number of narrowcast messages sent with the &#x60;Send narrowcast message&#x60; Messaging API operation.
        /// </summary>
        /// <value>Number of narrowcast messages sent with the &#x60;Send narrowcast message&#x60; Messaging API operation.</value>
        [DataMember(Name = "apiNarrowcast", EmitDefaultValue = false)]
        public long ApiNarrowcast { get; set; }

        /// <summary>
        /// Number of replies sent with the &#x60;Send reply message&#x60; Messaging API operation.
        /// </summary>
        /// <value>Number of replies sent with the &#x60;Send reply message&#x60; Messaging API operation.</value>
        [DataMember(Name = "apiReply", EmitDefaultValue = false)]
        public long ApiReply { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetNumberOfMessageDeliveriesResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Broadcast: ").Append(Broadcast).Append("\n");
            sb.Append("  Targeting: ").Append(Targeting).Append("\n");
            sb.Append("  AutoResponse: ").Append(AutoResponse).Append("\n");
            sb.Append("  WelcomeResponse: ").Append(WelcomeResponse).Append("\n");
            sb.Append("  Chat: ").Append(Chat).Append("\n");
            sb.Append("  ApiBroadcast: ").Append(ApiBroadcast).Append("\n");
            sb.Append("  ApiPush: ").Append(ApiPush).Append("\n");
            sb.Append("  ApiMulticast: ").Append(ApiMulticast).Append("\n");
            sb.Append("  ApiNarrowcast: ").Append(ApiNarrowcast).Append("\n");
            sb.Append("  ApiReply: ").Append(ApiReply).Append("\n");
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
