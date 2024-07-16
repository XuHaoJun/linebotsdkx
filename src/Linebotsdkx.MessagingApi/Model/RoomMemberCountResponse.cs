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
    /// RoomMemberCountResponse
    /// </summary>
    [DataContract(Name = "RoomMemberCountResponse")]
    public partial class RoomMemberCountResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomMemberCountResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoomMemberCountResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomMemberCountResponse" /> class.
        /// </summary>
        /// <param name="count">The count of members in the multi-person chat. The number returned excludes the LINE Official Account. (required).</param>
        public RoomMemberCountResponse(int count = default(int))
        {
            this.Count = count;
        }

        /// <summary>
        /// The count of members in the multi-person chat. The number returned excludes the LINE Official Account.
        /// </summary>
        /// <value>The count of members in the multi-person chat. The number returned excludes the LINE Official Account.</value>
        [DataMember(Name = "count", IsRequired = true, EmitDefaultValue = true)]
        public int Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RoomMemberCountResponse {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
