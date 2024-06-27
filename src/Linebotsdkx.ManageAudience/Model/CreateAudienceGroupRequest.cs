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
    /// Create audience for uploading user IDs (by JSON)
    /// </summary>
    [DataContract(Name = "CreateAudienceGroupRequest")]
    public partial class CreateAudienceGroupRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudienceGroupRequest" /> class.
        /// </summary>
        /// <param name="description">The audience&#39;s name. This is case-insensitive, meaning AUDIENCE and audience are considered identical. Max character limit: 120 .</param>
        /// <param name="isIfaAudience">To specify recipients by IFAs: set true. To specify recipients by user IDs: set false or omit isIfaAudience property. .</param>
        /// <param name="uploadDescription">The description to register for the job (in jobs[].description). .</param>
        /// <param name="audiences">An array of user IDs or IFAs. Max number: 10,000 .</param>
        public CreateAudienceGroupRequest(string description = default(string), bool isIfaAudience = default(bool), string uploadDescription = default(string), List<Audience> audiences = default(List<Audience>))
        {
            this.Description = description;
            this.IsIfaAudience = isIfaAudience;
            this.UploadDescription = uploadDescription;
            this.Audiences = audiences;
        }

        /// <summary>
        /// The audience&#39;s name. This is case-insensitive, meaning AUDIENCE and audience are considered identical. Max character limit: 120 
        /// </summary>
        /// <value>The audience&#39;s name. This is case-insensitive, meaning AUDIENCE and audience are considered identical. Max character limit: 120 </value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// To specify recipients by IFAs: set true. To specify recipients by user IDs: set false or omit isIfaAudience property. 
        /// </summary>
        /// <value>To specify recipients by IFAs: set true. To specify recipients by user IDs: set false or omit isIfaAudience property. </value>
        [DataMember(Name = "isIfaAudience", EmitDefaultValue = true)]
        public bool IsIfaAudience { get; set; }

        /// <summary>
        /// The description to register for the job (in jobs[].description). 
        /// </summary>
        /// <value>The description to register for the job (in jobs[].description). </value>
        [DataMember(Name = "uploadDescription", EmitDefaultValue = false)]
        public string UploadDescription { get; set; }

        /// <summary>
        /// An array of user IDs or IFAs. Max number: 10,000 
        /// </summary>
        /// <value>An array of user IDs or IFAs. Max number: 10,000 </value>
        [DataMember(Name = "audiences", EmitDefaultValue = false)]
        public List<Audience> Audiences { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateAudienceGroupRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsIfaAudience: ").Append(IsIfaAudience).Append("\n");
            sb.Append("  UploadDescription: ").Append(UploadDescription).Append("\n");
            sb.Append("  Audiences: ").Append(Audiences).Append("\n");
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

            yield break;
        }
    }

}
