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
    /// Event object for when a user enters the range of a LINE Beacon. You can reply to beacon events.
    /// </summary>
    [DataContract(Name = "BeaconEvent")]
    public partial class BeaconEvent : Event, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeaconEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BeaconEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BeaconEvent" /> class.
        /// </summary>
        /// <param name="replyToken">Reply token used to send reply message to this event (required).</param>
        /// <param name="beacon">beacon (required).</param>
        /// <param name="type">Type of the event (required) (default to &quot;BeaconEvent&quot;).</param>
        /// <param name="source">source.</param>
        /// <param name="timestamp">Time of the event in milliseconds. (required).</param>
        /// <param name="mode">mode (required).</param>
        /// <param name="webhookEventId">Webhook Event ID. An ID that uniquely identifies a webhook event. This is a string in ULID format. (required).</param>
        /// <param name="deliveryContext">deliveryContext (required).</param>
        public BeaconEvent(string replyToken = default(string), BeaconContent beacon = default(BeaconContent), string type = @"BeaconEvent", Source source = default(Source), long timestamp = default(long), EventMode mode = default(EventMode), string webhookEventId = default(string), DeliveryContext deliveryContext = default(DeliveryContext)) : base(type, source, timestamp, mode, webhookEventId, deliveryContext)
        {
            // to ensure "replyToken" is required (not null)
            if (replyToken == null)
            {
                throw new ArgumentNullException("replyToken is a required property for BeaconEvent and cannot be null");
            }
            this.ReplyToken = replyToken;
            // to ensure "beacon" is required (not null)
            if (beacon == null)
            {
                throw new ArgumentNullException("beacon is a required property for BeaconEvent and cannot be null");
            }
            this.Beacon = beacon;
        }

        /// <summary>
        /// Reply token used to send reply message to this event
        /// </summary>
        /// <value>Reply token used to send reply message to this event</value>
        [DataMember(Name = "replyToken", IsRequired = true, EmitDefaultValue = true)]
        public string ReplyToken { get; set; }

        /// <summary>
        /// Gets or Sets Beacon
        /// </summary>
        [DataMember(Name = "beacon", IsRequired = true, EmitDefaultValue = true)]
        public BeaconContent Beacon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BeaconEvent {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ReplyToken: ").Append(ReplyToken).Append("\n");
            sb.Append("  Beacon: ").Append(Beacon).Append("\n");
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
