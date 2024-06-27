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
    /// ImageCarouselColumn
    /// </summary>
    [DataContract(Name = "ImageCarouselColumn")]
    public partial class ImageCarouselColumn : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCarouselColumn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageCarouselColumn() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCarouselColumn" /> class.
        /// </summary>
        /// <param name="imageUrl">imageUrl (required).</param>
        /// <param name="action">action (required).</param>
        public ImageCarouselColumn(string imageUrl = default(string), Action action = default(Action))
        {
            // to ensure "imageUrl" is required (not null)
            if (imageUrl == null)
            {
                throw new ArgumentNullException("imageUrl is a required property for ImageCarouselColumn and cannot be null");
            }
            this.ImageUrl = imageUrl;
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new ArgumentNullException("action is a required property for ImageCarouselColumn and cannot be null");
            }
            this.Action = action;
        }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", IsRequired = true, EmitDefaultValue = true)]
        public Action Action { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImageCarouselColumn {\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
