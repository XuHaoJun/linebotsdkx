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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Linebotsdkx.Webhook.Client.OpenAPIDateConverter;

namespace Linebotsdkx.Webhook.Model
{
    /// <summary>
    /// ImageMessageContent
    /// </summary>
    [DataContract(Name = "ImageMessageContent")]
    public partial class ImageMessageContent : MessageContent, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageMessageContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageMessageContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageMessageContent" /> class.
        /// </summary>
        /// <param name="contentProvider">contentProvider (required).</param>
        /// <param name="imageSet">imageSet.</param>
        /// <param name="quoteToken">Quote token to quote this message.  (required).</param>
        /// <param name="type">Type (required) (default to &quot;ImageMessageContent&quot;).</param>
        /// <param name="id">Message ID (required).</param>
        public ImageMessageContent(ContentProvider contentProvider = default(ContentProvider), ImageSet imageSet = default(ImageSet), string quoteToken = default(string), string type = @"ImageMessageContent", string id = default(string)) : base(type, id)
        {
            // to ensure "contentProvider" is required (not null)
            if (contentProvider == null)
            {
                throw new ArgumentNullException("contentProvider is a required property for ImageMessageContent and cannot be null");
            }
            this.ContentProvider = contentProvider;
            // to ensure "quoteToken" is required (not null)
            if (quoteToken == null)
            {
                throw new ArgumentNullException("quoteToken is a required property for ImageMessageContent and cannot be null");
            }
            this.QuoteToken = quoteToken;
            this.ImageSet = imageSet;
        }

        /// <summary>
        /// Gets or Sets ContentProvider
        /// </summary>
        [DataMember(Name = "contentProvider", IsRequired = true, EmitDefaultValue = true)]
        public ContentProvider ContentProvider { get; set; }

        /// <summary>
        /// Gets or Sets ImageSet
        /// </summary>
        [DataMember(Name = "imageSet", EmitDefaultValue = false)]
        public ImageSet ImageSet { get; set; }

        /// <summary>
        /// Quote token to quote this message. 
        /// </summary>
        /// <value>Quote token to quote this message. </value>
        [DataMember(Name = "quoteToken", IsRequired = true, EmitDefaultValue = true)]
        public string QuoteToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImageMessageContent {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ContentProvider: ").Append(ContentProvider).Append("\n");
            sb.Append("  ImageSet: ").Append(ImageSet).Append("\n");
            sb.Append("  QuoteToken: ").Append(QuoteToken).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in base.BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }

}
