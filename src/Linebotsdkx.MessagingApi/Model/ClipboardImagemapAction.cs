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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Linebotsdkx.MessagingApi.Client.OpenAPIDateConverter;

namespace Linebotsdkx.MessagingApi.Model
{
    /// <summary>
    /// ClipboardImagemapAction
    /// </summary>
    [DataContract(Name = "ClipboardImagemapAction")]
    public partial class ClipboardImagemapAction : ImagemapAction, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClipboardImagemapAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClipboardImagemapAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClipboardImagemapAction" /> class.
        /// </summary>
        /// <param name="clipboardText">Text that is copied to the clipboard. Max character limit: 1000  (required).</param>
        /// <param name="label">label.</param>
        /// <param name="type">type (required) (default to &quot;ClipboardImagemapAction&quot;).</param>
        /// <param name="area">area (required).</param>
        public ClipboardImagemapAction(string clipboardText = default(string), string label = default(string), string type = @"ClipboardImagemapAction", ImagemapArea area = default(ImagemapArea)) : base(type, area)
        {
            // to ensure "clipboardText" is required (not null)
            if (clipboardText == null)
            {
                throw new ArgumentNullException("clipboardText is a required property for ClipboardImagemapAction and cannot be null");
            }
            this.ClipboardText = clipboardText;
            this.Label = label;
        }

        /// <summary>
        /// Text that is copied to the clipboard. Max character limit: 1000 
        /// </summary>
        /// <value>Text that is copied to the clipboard. Max character limit: 1000 </value>
        [DataMember(Name = "clipboardText", IsRequired = true, EmitDefaultValue = true)]
        public string ClipboardText { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClipboardImagemapAction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ClipboardText: ").Append(ClipboardText).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            // ClipboardText (string) maxLength
            if (this.ClipboardText != null && this.ClipboardText.Length > 1000)
            {
                yield return new ValidationResult("Invalid value for ClipboardText, length must be less than 1000.", new [] { "ClipboardText" });
            }

            // ClipboardText (string) minLength
            if (this.ClipboardText != null && this.ClipboardText.Length < 1)
            {
                yield return new ValidationResult("Invalid value for ClipboardText, length must be greater than 1.", new [] { "ClipboardText" });
            }

            yield break;
        }
    }

}
