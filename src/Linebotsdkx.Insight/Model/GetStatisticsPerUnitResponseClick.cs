/*
 * LINE Messaging API(Insight)
 *
 * This document describes LINE Messaging API(Insight).
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
using OpenAPIDateConverter = Linebotsdkx.Insight.Client.OpenAPIDateConverter;

namespace Linebotsdkx.Insight.Model
{
    /// <summary>
    /// GetStatisticsPerUnitResponseClick
    /// </summary>
    [DataContract(Name = "GetStatisticsPerUnitResponseClick")]
    public partial class GetStatisticsPerUnitResponseClick : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticsPerUnitResponseClick" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetStatisticsPerUnitResponseClick() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticsPerUnitResponseClick" /> class.
        /// </summary>
        /// <param name="seq">The URL&#39;s serial number. (required).</param>
        /// <param name="url">URL. (required).</param>
        /// <param name="click">Number of times the URL in the bubble was opened..</param>
        /// <param name="uniqueClick">Number of users that opened the URL in the bubble..</param>
        /// <param name="uniqueClickOfRequest">Number of users who opened this url through any link in the message. If another message bubble contains the same URL and a user opens both links, it&#39;s counted only once. .</param>
        public GetStatisticsPerUnitResponseClick(long seq = default(long), string url = default(string), long? click = default(long?), long? uniqueClick = default(long?), long? uniqueClickOfRequest = default(long?))
        {
            this.Seq = seq;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for GetStatisticsPerUnitResponseClick and cannot be null");
            }
            this.Url = url;
            this.Click = click;
            this.UniqueClick = uniqueClick;
            this.UniqueClickOfRequest = uniqueClickOfRequest;
        }

        /// <summary>
        /// The URL&#39;s serial number.
        /// </summary>
        /// <value>The URL&#39;s serial number.</value>
        [DataMember(Name = "seq", IsRequired = true, EmitDefaultValue = true)]
        public long Seq { get; set; }

        /// <summary>
        /// URL.
        /// </summary>
        /// <value>URL.</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Number of times the URL in the bubble was opened.
        /// </summary>
        /// <value>Number of times the URL in the bubble was opened.</value>
        [DataMember(Name = "click", EmitDefaultValue = true)]
        public long? Click { get; set; }

        /// <summary>
        /// Number of users that opened the URL in the bubble.
        /// </summary>
        /// <value>Number of users that opened the URL in the bubble.</value>
        [DataMember(Name = "uniqueClick", EmitDefaultValue = true)]
        public long? UniqueClick { get; set; }

        /// <summary>
        /// Number of users who opened this url through any link in the message. If another message bubble contains the same URL and a user opens both links, it&#39;s counted only once. 
        /// </summary>
        /// <value>Number of users who opened this url through any link in the message. If another message bubble contains the same URL and a user opens both links, it&#39;s counted only once. </value>
        [DataMember(Name = "uniqueClickOfRequest", EmitDefaultValue = true)]
        public long? UniqueClickOfRequest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetStatisticsPerUnitResponseClick {\n");
            sb.Append("  Seq: ").Append(Seq).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Click: ").Append(Click).Append("\n");
            sb.Append("  UniqueClick: ").Append(UniqueClick).Append("\n");
            sb.Append("  UniqueClickOfRequest: ").Append(UniqueClickOfRequest).Append("\n");
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
