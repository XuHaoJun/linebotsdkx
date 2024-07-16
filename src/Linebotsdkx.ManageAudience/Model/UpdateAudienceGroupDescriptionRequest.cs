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
    /// Rename an audience
    /// </summary>
    [DataContract(Name = "UpdateAudienceGroupDescriptionRequest")]
    public partial class UpdateAudienceGroupDescriptionRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAudienceGroupDescriptionRequest" /> class.
        /// </summary>
        /// <param name="description">The audience&#39;s name. This is case-insensitive, meaning AUDIENCE and audience are considered identical. Max character limit: 120 .</param>
        public UpdateAudienceGroupDescriptionRequest(string description = default(string))
        {
            this.Description = description;
        }

        /// <summary>
        /// The audience&#39;s name. This is case-insensitive, meaning AUDIENCE and audience are considered identical. Max character limit: 120 
        /// </summary>
        /// <value>The audience&#39;s name. This is case-insensitive, meaning AUDIENCE and audience are considered identical. Max character limit: 120 </value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateAudienceGroupDescriptionRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 120)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 120.", new [] { "Description" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Description, length must be greater than 1.", new [] { "Description" });
            }

            yield break;
        }
    }

}
