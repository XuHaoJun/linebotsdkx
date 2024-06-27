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
    /// URIImagemapAction
    /// </summary>
    [DataContract(Name = "URIImagemapAction")]
    public partial class URIImagemapAction : ImagemapAction, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="URIImagemapAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected URIImagemapAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="URIImagemapAction" /> class.
        /// </summary>
        /// <param name="linkUri">linkUri (required).</param>
        /// <param name="label">label.</param>
        /// <param name="type">type (required) (default to &quot;URIImagemapAction&quot;).</param>
        /// <param name="area">area (required).</param>
        public URIImagemapAction(string linkUri = default(string), string label = default(string), string type = @"URIImagemapAction", ImagemapArea area = default(ImagemapArea)) : base(type, area)
        {
            // to ensure "linkUri" is required (not null)
            if (linkUri == null)
            {
                throw new ArgumentNullException("linkUri is a required property for URIImagemapAction and cannot be null");
            }
            this.LinkUri = linkUri;
            this.Label = label;
        }

        /// <summary>
        /// Gets or Sets LinkUri
        /// </summary>
        [DataMember(Name = "linkUri", IsRequired = true, EmitDefaultValue = true)]
        public string LinkUri { get; set; }

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
            sb.Append("class URIImagemapAction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  LinkUri: ").Append(LinkUri).Append("\n");
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
