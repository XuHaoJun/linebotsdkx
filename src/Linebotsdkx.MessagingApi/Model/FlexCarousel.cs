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
    /// FlexCarousel
    /// </summary>
    [DataContract(Name = "FlexCarousel")]
    public partial class FlexCarousel : FlexContainer, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlexCarousel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlexCarousel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlexCarousel" /> class.
        /// </summary>
        /// <param name="contents">contents (required).</param>
        /// <param name="type">type (required) (default to &quot;FlexCarousel&quot;).</param>
        public FlexCarousel(List<FlexBubble> contents = default(List<FlexBubble>), string type = @"FlexCarousel") : base(type)
        {
            // to ensure "contents" is required (not null)
            if (contents == null)
            {
                throw new ArgumentNullException("contents is a required property for FlexCarousel and cannot be null");
            }
            this.Contents = contents;
        }

        /// <summary>
        /// Gets or Sets Contents
        /// </summary>
        [DataMember(Name = "contents", IsRequired = true, EmitDefaultValue = true)]
        public List<FlexBubble> Contents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlexCarousel {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Contents: ").Append(Contents).Append("\n");
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
            yield break;
        }
    }

}
