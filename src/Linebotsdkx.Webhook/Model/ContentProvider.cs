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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Linebotsdkx.Webhook.Client.OpenAPIDateConverter;

namespace Linebotsdkx.Webhook.Model
{
    /// <summary>
    /// Provider of the media file.
    /// </summary>
    [DataContract(Name = "ContentProvider")]
    public partial class ContentProvider : IValidatableObject
    {
        /// <summary>
        /// Provider of the image file.
        /// </summary>
        /// <value>Provider of the image file.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Line for value: line
            /// </summary>
            [EnumMember(Value = "line")]
            Line = 1,

            /// <summary>
            /// Enum External for value: external
            /// </summary>
            [EnumMember(Value = "external")]
            External = 2
        }


        /// <summary>
        /// Provider of the image file.
        /// </summary>
        /// <value>Provider of the image file.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentProvider" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContentProvider() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentProvider" /> class.
        /// </summary>
        /// <param name="type">Provider of the image file. (required).</param>
        /// <param name="originalContentUrl">URL of the image file. Only included when contentProvider.type is external..</param>
        /// <param name="previewImageUrl">URL of the preview image. Only included when contentProvider.type is external..</param>
        public ContentProvider(TypeEnum type = default(TypeEnum), string originalContentUrl = default(string), string previewImageUrl = default(string))
        {
            this.Type = type;
            this.OriginalContentUrl = originalContentUrl;
            this.PreviewImageUrl = previewImageUrl;
        }

        /// <summary>
        /// URL of the image file. Only included when contentProvider.type is external.
        /// </summary>
        /// <value>URL of the image file. Only included when contentProvider.type is external.</value>
        [DataMember(Name = "originalContentUrl", EmitDefaultValue = false)]
        public string OriginalContentUrl { get; set; }

        /// <summary>
        /// URL of the preview image. Only included when contentProvider.type is external.
        /// </summary>
        /// <value>URL of the preview image. Only included when contentProvider.type is external.</value>
        [DataMember(Name = "previewImageUrl", EmitDefaultValue = false)]
        public string PreviewImageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContentProvider {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  OriginalContentUrl: ").Append(OriginalContentUrl).Append("\n");
            sb.Append("  PreviewImageUrl: ").Append(PreviewImageUrl).Append("\n");
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
