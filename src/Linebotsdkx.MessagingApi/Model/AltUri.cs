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
    /// AltUri
    /// </summary>
    [DataContract(Name = "AltUri")]
    public partial class AltUri : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AltUri" /> class.
        /// </summary>
        /// <param name="desktop">desktop.</param>
        public AltUri(string desktop = default(string))
        {
            this.Desktop = desktop;
        }

        /// <summary>
        /// Gets or Sets Desktop
        /// </summary>
        [DataMember(Name = "desktop", EmitDefaultValue = false)]
        public string Desktop { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AltUri {\n");
            sb.Append("  Desktop: ").Append(Desktop).Append("\n");
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
            // Desktop (string) maxLength
            if (this.Desktop != null && this.Desktop.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Desktop, length must be less than 1000.", new [] { "Desktop" });
            }

            // Desktop (string) minLength
            if (this.Desktop != null && this.Desktop.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Desktop, length must be greater than 0.", new [] { "Desktop" });
            }

            yield break;
        }
    }

}
