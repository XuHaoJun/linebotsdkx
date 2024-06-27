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
    /// Response object for &#x60;get statistics per unit&#x60;
    /// </summary>
    [DataContract(Name = "GetStatisticsPerUnitResponse")]
    public partial class GetStatisticsPerUnitResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticsPerUnitResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetStatisticsPerUnitResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticsPerUnitResponse" /> class.
        /// </summary>
        /// <param name="overview">overview (required).</param>
        /// <param name="messages">Array of information about individual message bubbles. (required).</param>
        /// <param name="clicks">Array of information about opened URLs in the message. (required).</param>
        public GetStatisticsPerUnitResponse(GetStatisticsPerUnitResponseOverview overview = default(GetStatisticsPerUnitResponseOverview), List<GetStatisticsPerUnitResponseMessage> messages = default(List<GetStatisticsPerUnitResponseMessage>), List<GetStatisticsPerUnitResponseClick> clicks = default(List<GetStatisticsPerUnitResponseClick>))
        {
            // to ensure "overview" is required (not null)
            if (overview == null)
            {
                throw new ArgumentNullException("overview is a required property for GetStatisticsPerUnitResponse and cannot be null");
            }
            this.Overview = overview;
            // to ensure "messages" is required (not null)
            if (messages == null)
            {
                throw new ArgumentNullException("messages is a required property for GetStatisticsPerUnitResponse and cannot be null");
            }
            this.Messages = messages;
            // to ensure "clicks" is required (not null)
            if (clicks == null)
            {
                throw new ArgumentNullException("clicks is a required property for GetStatisticsPerUnitResponse and cannot be null");
            }
            this.Clicks = clicks;
        }

        /// <summary>
        /// Gets or Sets Overview
        /// </summary>
        [DataMember(Name = "overview", IsRequired = true, EmitDefaultValue = true)]
        public GetStatisticsPerUnitResponseOverview Overview { get; set; }

        /// <summary>
        /// Array of information about individual message bubbles.
        /// </summary>
        /// <value>Array of information about individual message bubbles.</value>
        [DataMember(Name = "messages", IsRequired = true, EmitDefaultValue = true)]
        public List<GetStatisticsPerUnitResponseMessage> Messages { get; set; }

        /// <summary>
        /// Array of information about opened URLs in the message.
        /// </summary>
        /// <value>Array of information about opened URLs in the message.</value>
        [DataMember(Name = "clicks", IsRequired = true, EmitDefaultValue = true)]
        public List<GetStatisticsPerUnitResponseClick> Clicks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetStatisticsPerUnitResponse {\n");
            sb.Append("  Overview: ").Append(Overview).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Clicks: ").Append(Clicks).Append("\n");
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
