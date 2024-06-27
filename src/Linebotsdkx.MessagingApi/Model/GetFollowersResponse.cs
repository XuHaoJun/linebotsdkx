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
    /// GetFollowersResponse
    /// </summary>
    [DataContract(Name = "GetFollowersResponse")]
    public partial class GetFollowersResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFollowersResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetFollowersResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFollowersResponse" /> class.
        /// </summary>
        /// <param name="userIds">An array of strings indicating user IDs of users that have added the LINE Official Account as a friend. Only users of LINE for iOS and LINE for Android are included in &#x60;userIds&#x60;.  (required).</param>
        /// <param name="next">A continuation token to get the next array of user IDs. Returned only when there are remaining user IDs that weren&#39;t returned in &#x60;userIds&#x60; in the original request. The number of user IDs in the &#x60;userIds&#x60; element doesn&#39;t have to reach the maximum number specified by &#x60;limit&#x60; for the &#x60;next&#x60; property to be included in the response.  .</param>
        public GetFollowersResponse(List<string> userIds = default(List<string>), string next = default(string))
        {
            // to ensure "userIds" is required (not null)
            if (userIds == null)
            {
                throw new ArgumentNullException("userIds is a required property for GetFollowersResponse and cannot be null");
            }
            this.UserIds = userIds;
            this.Next = next;
        }

        /// <summary>
        /// An array of strings indicating user IDs of users that have added the LINE Official Account as a friend. Only users of LINE for iOS and LINE for Android are included in &#x60;userIds&#x60;. 
        /// </summary>
        /// <value>An array of strings indicating user IDs of users that have added the LINE Official Account as a friend. Only users of LINE for iOS and LINE for Android are included in &#x60;userIds&#x60;. </value>
        [DataMember(Name = "userIds", IsRequired = true, EmitDefaultValue = true)]
        public List<string> UserIds { get; set; }

        /// <summary>
        /// A continuation token to get the next array of user IDs. Returned only when there are remaining user IDs that weren&#39;t returned in &#x60;userIds&#x60; in the original request. The number of user IDs in the &#x60;userIds&#x60; element doesn&#39;t have to reach the maximum number specified by &#x60;limit&#x60; for the &#x60;next&#x60; property to be included in the response.  
        /// </summary>
        /// <value>A continuation token to get the next array of user IDs. Returned only when there are remaining user IDs that weren&#39;t returned in &#x60;userIds&#x60; in the original request. The number of user IDs in the &#x60;userIds&#x60; element doesn&#39;t have to reach the maximum number specified by &#x60;limit&#x60; for the &#x60;next&#x60; property to be included in the response.  </value>
        [DataMember(Name = "next", EmitDefaultValue = false)]
        public string Next { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetFollowersResponse {\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
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
