/*
 * Channel Access Token API
 *
 * This document describes Channel Access Token API.
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
using OpenAPIDateConverter = Linebotsdkx.ChannelAccessToken.Client.OpenAPIDateConverter;

namespace Linebotsdkx.ChannelAccessToken.Model
{
    /// <summary>
    /// Issued short-lived channel access token
    /// </summary>
    [DataContract(Name = "IssueShortLivedChannelAccessTokenResponse")]
    public partial class IssueShortLivedChannelAccessTokenResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueShortLivedChannelAccessTokenResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IssueShortLivedChannelAccessTokenResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueShortLivedChannelAccessTokenResponse" /> class.
        /// </summary>
        /// <param name="accessToken">A short-lived channel access token. Valid for 30 days. Note: Channel access tokens cannot be refreshed.  (required).</param>
        /// <param name="expiresIn">Time until channel access token expires in seconds from time the token is issued. (required).</param>
        /// <param name="tokenType">Token type. The value is always &#x60;Bearer&#x60;. (required) (default to &quot;Bearer&quot;).</param>
        public IssueShortLivedChannelAccessTokenResponse(string accessToken = default(string), int expiresIn = default(int), string tokenType = @"Bearer")
        {
            // to ensure "accessToken" is required (not null)
            if (accessToken == null)
            {
                throw new ArgumentNullException("accessToken is a required property for IssueShortLivedChannelAccessTokenResponse and cannot be null");
            }
            this.AccessToken = accessToken;
            this.ExpiresIn = expiresIn;
            // to ensure "tokenType" is required (not null)
            if (tokenType == null)
            {
                throw new ArgumentNullException("tokenType is a required property for IssueShortLivedChannelAccessTokenResponse and cannot be null");
            }
            this.TokenType = tokenType;
        }

        /// <summary>
        /// A short-lived channel access token. Valid for 30 days. Note: Channel access tokens cannot be refreshed. 
        /// </summary>
        /// <value>A short-lived channel access token. Valid for 30 days. Note: Channel access tokens cannot be refreshed. </value>
        [DataMember(Name = "access_token", IsRequired = true, EmitDefaultValue = true)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Time until channel access token expires in seconds from time the token is issued.
        /// </summary>
        /// <value>Time until channel access token expires in seconds from time the token is issued.</value>
        [DataMember(Name = "expires_in", IsRequired = true, EmitDefaultValue = true)]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Token type. The value is always &#x60;Bearer&#x60;.
        /// </summary>
        /// <value>Token type. The value is always &#x60;Bearer&#x60;.</value>
        [DataMember(Name = "token_type", IsRequired = true, EmitDefaultValue = true)]
        public string TokenType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssueShortLivedChannelAccessTokenResponse {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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
