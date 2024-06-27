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
    /// Create audience for impression-based retargeting
    /// </summary>
    [DataContract(Name = "CreateImpBasedAudienceGroupRequest")]
    public partial class CreateImpBasedAudienceGroupRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImpBasedAudienceGroupRequest" /> class.
        /// </summary>
        /// <param name="description">The audience&#39;s name. This is case-insensitive, meaning &#x60;AUDIENCE&#x60; and &#x60;audience&#x60; are considered identical. Max character limit: 120 .</param>
        /// <param name="requestId">The request ID of a broadcast or narrowcast message sent in the past 60 days. Each Messaging API request has a request ID. .</param>
        public CreateImpBasedAudienceGroupRequest(string description = default(string), string requestId = default(string))
        {
            this.Description = description;
            this.RequestId = requestId;
        }

        /// <summary>
        /// The audience&#39;s name. This is case-insensitive, meaning &#x60;AUDIENCE&#x60; and &#x60;audience&#x60; are considered identical. Max character limit: 120 
        /// </summary>
        /// <value>The audience&#39;s name. This is case-insensitive, meaning &#x60;AUDIENCE&#x60; and &#x60;audience&#x60; are considered identical. Max character limit: 120 </value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The request ID of a broadcast or narrowcast message sent in the past 60 days. Each Messaging API request has a request ID. 
        /// </summary>
        /// <value>The request ID of a broadcast or narrowcast message sent in the past 60 days. Each Messaging API request has a request ID. </value>
        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateImpBasedAudienceGroupRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 1.", new [] { "Description" });
            }

            yield break;
        }
    }

}
