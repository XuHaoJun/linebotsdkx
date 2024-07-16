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
    /// ErrorResponse
    /// </summary>
    [DataContract(Name = "ErrorResponse")]
    public partial class ErrorResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErrorResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        /// <param name="message">Message containing information about the error. (required).</param>
        /// <param name="details">An array of error details. If the array is empty, this property will not be included in the response..</param>
        /// <param name="sentMessages">Array of sent messages..</param>
        public ErrorResponse(string message = default(string), List<ErrorDetail> details = default(List<ErrorDetail>), List<SentMessage> sentMessages = default(List<SentMessage>))
        {
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for ErrorResponse and cannot be null");
            }
            this.Message = message;
            this.Details = details;
            this.SentMessages = sentMessages;
        }

        /// <summary>
        /// Message containing information about the error.
        /// </summary>
        /// <value>Message containing information about the error.</value>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// An array of error details. If the array is empty, this property will not be included in the response.
        /// </summary>
        /// <value>An array of error details. If the array is empty, this property will not be included in the response.</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public List<ErrorDetail> Details { get; set; }

        /// <summary>
        /// Array of sent messages.
        /// </summary>
        /// <value>Array of sent messages.</value>
        [DataMember(Name = "sentMessages", EmitDefaultValue = false)]
        public List<SentMessage> SentMessages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ErrorResponse {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  SentMessages: ").Append(SentMessages).Append("\n");
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
