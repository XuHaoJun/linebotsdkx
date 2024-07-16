/*
 * LIFF server API
 *
 * LIFF Server API.
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
using OpenAPIDateConverter = Linebotsdkx.Liff.Client.OpenAPIDateConverter;

namespace Linebotsdkx.Liff.Model
{
    /// <summary>
    /// LiffView
    /// </summary>
    [DataContract(Name = "LiffView")]
    public partial class LiffView : IValidatableObject
    {
        /// <summary>
        /// Size of the LIFF app view. Specify one of these values: - compact - tall - full 
        /// </summary>
        /// <value>Size of the LIFF app view. Specify one of these values: - compact - tall - full </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Compact for value: compact
            /// </summary>
            [EnumMember(Value = "compact")]
            Compact = 1,

            /// <summary>
            /// Enum Tall for value: tall
            /// </summary>
            [EnumMember(Value = "tall")]
            Tall = 2,

            /// <summary>
            /// Enum Full for value: full
            /// </summary>
            [EnumMember(Value = "full")]
            Full = 3
        }


        /// <summary>
        /// Size of the LIFF app view. Specify one of these values: - compact - tall - full 
        /// </summary>
        /// <value>Size of the LIFF app view. Specify one of these values: - compact - tall - full </value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LiffView" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LiffView() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LiffView" /> class.
        /// </summary>
        /// <param name="type">Size of the LIFF app view. Specify one of these values: - compact - tall - full  (required).</param>
        /// <param name="url">Endpoint URL. This is the URL of the web app that implements the LIFF app (e.g. https://example.com). Used when the LIFF app is launched using the LIFF URL. The URL scheme must be https. URL fragments (#URL-fragment) can&#39;t be specified.  (required).</param>
        /// <param name="moduleMode">&#x60;true&#x60; to use the LIFF app in modular mode. When in modular mode, the action button in the header is not displayed. .</param>
        public LiffView(TypeEnum type = default(TypeEnum), string url = default(string), bool moduleMode = default(bool))
        {
            this.Type = type;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for LiffView and cannot be null");
            }
            this.Url = url;
            this.ModuleMode = moduleMode;
        }

        /// <summary>
        /// Endpoint URL. This is the URL of the web app that implements the LIFF app (e.g. https://example.com). Used when the LIFF app is launched using the LIFF URL. The URL scheme must be https. URL fragments (#URL-fragment) can&#39;t be specified. 
        /// </summary>
        /// <value>Endpoint URL. This is the URL of the web app that implements the LIFF app (e.g. https://example.com). Used when the LIFF app is launched using the LIFF URL. The URL scheme must be https. URL fragments (#URL-fragment) can&#39;t be specified. </value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// &#x60;true&#x60; to use the LIFF app in modular mode. When in modular mode, the action button in the header is not displayed. 
        /// </summary>
        /// <value>&#x60;true&#x60; to use the LIFF app in modular mode. When in modular mode, the action button in the header is not displayed. </value>
        [DataMember(Name = "moduleMode", EmitDefaultValue = true)]
        public bool ModuleMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LiffView {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ModuleMode: ").Append(ModuleMode).Append("\n");
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
