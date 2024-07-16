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
    /// FlexBlockStyle
    /// </summary>
    [DataContract(Name = "FlexBlockStyle")]
    public partial class FlexBlockStyle : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlexBlockStyle" /> class.
        /// </summary>
        /// <param name="backgroundColor">backgroundColor.</param>
        /// <param name="separator">separator.</param>
        /// <param name="separatorColor">separatorColor.</param>
        public FlexBlockStyle(string backgroundColor = default(string), bool separator = default(bool), string separatorColor = default(string))
        {
            this.BackgroundColor = backgroundColor;
            this.Separator = separator;
            this.SeparatorColor = separatorColor;
        }

        /// <summary>
        /// Gets or Sets BackgroundColor
        /// </summary>
        [DataMember(Name = "backgroundColor", EmitDefaultValue = false)]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Gets or Sets Separator
        /// </summary>
        [DataMember(Name = "separator", EmitDefaultValue = true)]
        public bool Separator { get; set; }

        /// <summary>
        /// Gets or Sets SeparatorColor
        /// </summary>
        [DataMember(Name = "separatorColor", EmitDefaultValue = false)]
        public string SeparatorColor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlexBlockStyle {\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  Separator: ").Append(Separator).Append("\n");
            sb.Append("  SeparatorColor: ").Append(SeparatorColor).Append("\n");
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
