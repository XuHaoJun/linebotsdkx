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
    /// NumberOfMessagesResponse
    /// </summary>
    [DataContract(Name = "NumberOfMessagesResponse")]
    public partial class NumberOfMessagesResponse : IValidatableObject
    {
        /// <summary>
        /// Aggregation process status. One of:  &#x60;ready&#x60;: The number of messages can be obtained. &#x60;unready&#x60;: We haven&#39;t finished calculating the number of sent messages for the specified in date. For example, this property is returned when the delivery date or a future date is specified. Calculation usually takes about a day. &#x60;unavailable_for_privacy&#x60;: The total number of messages on the specified day is less than 20. &#x60;out_of_service&#x60;: The specified date is earlier than the date on which we first started calculating sent messages (March 31, 2018). 
        /// </summary>
        /// <value>Aggregation process status. One of:  &#x60;ready&#x60;: The number of messages can be obtained. &#x60;unready&#x60;: We haven&#39;t finished calculating the number of sent messages for the specified in date. For example, this property is returned when the delivery date or a future date is specified. Calculation usually takes about a day. &#x60;unavailable_for_privacy&#x60;: The total number of messages on the specified day is less than 20. &#x60;out_of_service&#x60;: The specified date is earlier than the date on which we first started calculating sent messages (March 31, 2018). </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Ready for value: ready
            /// </summary>
            [EnumMember(Value = "ready")]
            Ready = 1,

            /// <summary>
            /// Enum Unready for value: unready
            /// </summary>
            [EnumMember(Value = "unready")]
            Unready = 2,

            /// <summary>
            /// Enum UnavailableForPrivacy for value: unavailable_for_privacy
            /// </summary>
            [EnumMember(Value = "unavailable_for_privacy")]
            UnavailableForPrivacy = 3,

            /// <summary>
            /// Enum OutOfService for value: out_of_service
            /// </summary>
            [EnumMember(Value = "out_of_service")]
            OutOfService = 4
        }


        /// <summary>
        /// Aggregation process status. One of:  &#x60;ready&#x60;: The number of messages can be obtained. &#x60;unready&#x60;: We haven&#39;t finished calculating the number of sent messages for the specified in date. For example, this property is returned when the delivery date or a future date is specified. Calculation usually takes about a day. &#x60;unavailable_for_privacy&#x60;: The total number of messages on the specified day is less than 20. &#x60;out_of_service&#x60;: The specified date is earlier than the date on which we first started calculating sent messages (March 31, 2018). 
        /// </summary>
        /// <value>Aggregation process status. One of:  &#x60;ready&#x60;: The number of messages can be obtained. &#x60;unready&#x60;: We haven&#39;t finished calculating the number of sent messages for the specified in date. For example, this property is returned when the delivery date or a future date is specified. Calculation usually takes about a day. &#x60;unavailable_for_privacy&#x60;: The total number of messages on the specified day is less than 20. &#x60;out_of_service&#x60;: The specified date is earlier than the date on which we first started calculating sent messages (March 31, 2018). </value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberOfMessagesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NumberOfMessagesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberOfMessagesResponse" /> class.
        /// </summary>
        /// <param name="status">Aggregation process status. One of:  &#x60;ready&#x60;: The number of messages can be obtained. &#x60;unready&#x60;: We haven&#39;t finished calculating the number of sent messages for the specified in date. For example, this property is returned when the delivery date or a future date is specified. Calculation usually takes about a day. &#x60;unavailable_for_privacy&#x60;: The total number of messages on the specified day is less than 20. &#x60;out_of_service&#x60;: The specified date is earlier than the date on which we first started calculating sent messages (March 31, 2018).  (required).</param>
        /// <param name="success">The number of messages delivered using the phone number on the date specified in &#x60;date&#x60;. The response has this property only when the value of &#x60;status&#x60; is &#x60;ready&#x60;.  .</param>
        public NumberOfMessagesResponse(StatusEnum status = default(StatusEnum), long success = default(long))
        {
            this.Status = status;
            this.Success = success;
        }

        /// <summary>
        /// The number of messages delivered using the phone number on the date specified in &#x60;date&#x60;. The response has this property only when the value of &#x60;status&#x60; is &#x60;ready&#x60;.  
        /// </summary>
        /// <value>The number of messages delivered using the phone number on the date specified in &#x60;date&#x60;. The response has this property only when the value of &#x60;status&#x60; is &#x60;ready&#x60;.  </value>
        [DataMember(Name = "success", EmitDefaultValue = false)]
        public long Success { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NumberOfMessagesResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
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
