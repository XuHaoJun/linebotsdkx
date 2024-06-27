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
    /// Event object for when your LINE Official Account is blocked.
    /// </summary>
    [DataContract(Name = "UnfollowEvent")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class UnfollowEvent : Event, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnfollowEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnfollowEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnfollowEvent" /> class.
        /// </summary>
        /// <param name="type">Type of the event (required) (default to &quot;UnfollowEvent&quot;).</param>
        /// <param name="source">source.</param>
        /// <param name="timestamp">Time of the event in milliseconds. (required).</param>
        /// <param name="mode">mode (required).</param>
        /// <param name="webhookEventId">Webhook Event ID. An ID that uniquely identifies a webhook event. This is a string in ULID format. (required).</param>
        /// <param name="deliveryContext">deliveryContext (required).</param>
        public UnfollowEvent(string type = @"UnfollowEvent", Source source = default(Source), long timestamp = default(long), EventMode mode = default(EventMode), string webhookEventId = default(string), DeliveryContext deliveryContext = default(DeliveryContext)) : base(type, source, timestamp, mode, webhookEventId, deliveryContext)
        {
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UnfollowEvent {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
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
