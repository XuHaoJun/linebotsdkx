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
    /// An array of memberships.
    /// </summary>
    [DataContract(Name = "Subscription")]
    public partial class Subscription : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Subscription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        /// <param name="membership">membership (required).</param>
        /// <param name="user">user (required).</param>
        public Subscription(SubscribedMembershipPlan membership = default(SubscribedMembershipPlan), SubscribedMembershipUser user = default(SubscribedMembershipUser))
        {
            // to ensure "membership" is required (not null)
            if (membership == null)
            {
                throw new ArgumentNullException("membership is a required property for Subscription and cannot be null");
            }
            this.Membership = membership;
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new ArgumentNullException("user is a required property for Subscription and cannot be null");
            }
            this.User = user;
        }

        /// <summary>
        /// Gets or Sets Membership
        /// </summary>
        [DataMember(Name = "membership", IsRequired = true, EmitDefaultValue = true)]
        public SubscribedMembershipPlan Membership { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", IsRequired = true, EmitDefaultValue = true)]
        public SubscribedMembershipUser User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Subscription {\n");
            sb.Append("  Membership: ").Append(Membership).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
