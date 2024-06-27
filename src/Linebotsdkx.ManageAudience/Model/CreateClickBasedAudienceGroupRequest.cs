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
    [DataContract(Name = "CreateClickBasedAudienceGroupRequest")]
    public partial class CreateClickBasedAudienceGroupRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClickBasedAudienceGroupRequest" /> class.
        /// </summary>
        /// <param name="description">The audience&#39;s name. This is case-insensitive, meaning AUDIENCE and audience are considered identical. Max character limit: 120 .</param>
        /// <param name="requestId">The request ID of a broadcast or narrowcast message sent in the past 60 days. Each Messaging API request has a request ID. .</param>
        /// <param name="clickUrl">The URL clicked by the user. If empty, users who clicked any URL in the message are added to the list of recipients. Max character limit: 2,000 .</param>
        public CreateClickBasedAudienceGroupRequest(string description = default(string), string requestId = default(string), string clickUrl = default(string))
        {
            this.Description = description;
            this.RequestId = requestId;
            this.ClickUrl = clickUrl;
        }

        /// <summary>
        /// The audience&#39;s name. This is case-insensitive, meaning AUDIENCE and audience are considered identical. Max character limit: 120 
        /// </summary>
        /// <value>The audience&#39;s name. This is case-insensitive, meaning AUDIENCE and audience are considered identical. Max character limit: 120 </value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The request ID of a broadcast or narrowcast message sent in the past 60 days. Each Messaging API request has a request ID. 
        /// </summary>
        /// <value>The request ID of a broadcast or narrowcast message sent in the past 60 days. Each Messaging API request has a request ID. </value>
        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The URL clicked by the user. If empty, users who clicked any URL in the message are added to the list of recipients. Max character limit: 2,000 
        /// </summary>
        /// <value>The URL clicked by the user. If empty, users who clicked any URL in the message are added to the list of recipients. Max character limit: 2,000 </value>
        [DataMember(Name = "clickUrl", EmitDefaultValue = false)]
        public string ClickUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateClickBasedAudienceGroupRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  ClickUrl: ").Append(ClickUrl).Append("\n");
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 120)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 120.", new [] { "Description" });
            }

            // ClickUrl (string) maxLength
            if (this.ClickUrl != null && this.ClickUrl.Length > 2000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClickUrl, length must be less than 2000.", new [] { "ClickUrl" });
            }

            yield break;
        }
    }

}
