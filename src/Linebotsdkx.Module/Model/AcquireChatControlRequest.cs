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
using OpenAPIDateConverter = Linebotsdkx.Module.Client.OpenAPIDateConverter;

namespace Linebotsdkx.Module.Model
{
    /// <summary>
    /// Request entity of the Acquire Control API
    /// </summary>
    [DataContract(Name = "AcquireChatControlRequest")]
    public partial class AcquireChatControlRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcquireChatControlRequest" /> class.
        /// </summary>
        /// <param name="expired">&#x60;True&#x60;: After the time limit (ttl) has passed, the initiative (Chat Control) will return to the Primary Channel. (Default) &#x60;False&#x60;: There&#39;s no time limit and the initiative (Chat Control) doesn&#39;t change over time. .</param>
        /// <param name="ttl">The time it takes for initiative (Chat Control) to return to the Primary Channel (the time that the module channel stays on the Active Channel). The value is specified in seconds. The maximum value is one year (3600 * 24 * 365). The default value is 3600 (1 hour).  * Ignored if the value of expired is false. .</param>
        public AcquireChatControlRequest(bool expired = default(bool), int ttl = default(int))
        {
            this.Expired = expired;
            this.Ttl = ttl;
        }

        /// <summary>
        /// &#x60;True&#x60;: After the time limit (ttl) has passed, the initiative (Chat Control) will return to the Primary Channel. (Default) &#x60;False&#x60;: There&#39;s no time limit and the initiative (Chat Control) doesn&#39;t change over time. 
        /// </summary>
        /// <value>&#x60;True&#x60;: After the time limit (ttl) has passed, the initiative (Chat Control) will return to the Primary Channel. (Default) &#x60;False&#x60;: There&#39;s no time limit and the initiative (Chat Control) doesn&#39;t change over time. </value>
        /// <example>true</example>
        [DataMember(Name = "expired", EmitDefaultValue = true)]
        public bool Expired { get; set; }

        /// <summary>
        /// The time it takes for initiative (Chat Control) to return to the Primary Channel (the time that the module channel stays on the Active Channel). The value is specified in seconds. The maximum value is one year (3600 * 24 * 365). The default value is 3600 (1 hour).  * Ignored if the value of expired is false. 
        /// </summary>
        /// <value>The time it takes for initiative (Chat Control) to return to the Primary Channel (the time that the module channel stays on the Active Channel). The value is specified in seconds. The maximum value is one year (3600 * 24 * 365). The default value is 3600 (1 hour).  * Ignored if the value of expired is false. </value>
        /// <example>3600</example>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]
        public int Ttl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AcquireChatControlRequest {\n");
            sb.Append("  Expired: ").Append(Expired).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
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
            // Ttl (int) maximum
            if (this.Ttl > (int)31536000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ttl, must be a value less than or equal to 31536000.", new [] { "Ttl" });
            }

            yield break;
        }
    }

}
