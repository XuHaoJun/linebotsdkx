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
    /// GetAggregationUnitNameListResponse
    /// </summary>
    [DataContract(Name = "GetAggregationUnitNameListResponse")]
    public partial class GetAggregationUnitNameListResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAggregationUnitNameListResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAggregationUnitNameListResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAggregationUnitNameListResponse" /> class.
        /// </summary>
        /// <param name="customAggregationUnits">An array of strings indicating the names of aggregation units used this month. (required).</param>
        /// <param name="next">A continuation token to get the next array of unit names. Returned only when there are remaining aggregation units that weren&#39;t returned in customAggregationUnits in the original request.  .</param>
        public GetAggregationUnitNameListResponse(List<string> customAggregationUnits = default(List<string>), string next = default(string))
        {
            // to ensure "customAggregationUnits" is required (not null)
            if (customAggregationUnits == null)
            {
                throw new ArgumentNullException("customAggregationUnits is a required property for GetAggregationUnitNameListResponse and cannot be null");
            }
            this.CustomAggregationUnits = customAggregationUnits;
            this.Next = next;
        }

        /// <summary>
        /// An array of strings indicating the names of aggregation units used this month.
        /// </summary>
        /// <value>An array of strings indicating the names of aggregation units used this month.</value>
        [DataMember(Name = "customAggregationUnits", IsRequired = true, EmitDefaultValue = true)]
        public List<string> CustomAggregationUnits { get; set; }

        /// <summary>
        /// A continuation token to get the next array of unit names. Returned only when there are remaining aggregation units that weren&#39;t returned in customAggregationUnits in the original request.  
        /// </summary>
        /// <value>A continuation token to get the next array of unit names. Returned only when there are remaining aggregation units that weren&#39;t returned in customAggregationUnits in the original request.  </value>
        [DataMember(Name = "next", EmitDefaultValue = false)]
        public string Next { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAggregationUnitNameListResponse {\n");
            sb.Append("  CustomAggregationUnits: ").Append(CustomAggregationUnits).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
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
