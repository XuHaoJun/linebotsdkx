/*
 * Webhook Type Definition
 *
 * Webhook event definition of the LINE Messaging API
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
using OpenAPIDateConverter = Linebotsdkx.Webhook.Client.OpenAPIDateConverter;

namespace Linebotsdkx.Webhook.Model
{
    /// <summary>
    /// VideoPlayComplete
    /// </summary>
    [DataContract(Name = "VideoPlayComplete")]
    public partial class VideoPlayComplete : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoPlayComplete" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VideoPlayComplete() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoPlayComplete" /> class.
        /// </summary>
        /// <param name="trackingId">ID used to identify a video. Returns the same value as the trackingId assigned to the video message. (required).</param>
        public VideoPlayComplete(string trackingId = default(string))
        {
            // to ensure "trackingId" is required (not null)
            if (trackingId == null)
            {
                throw new ArgumentNullException("trackingId is a required property for VideoPlayComplete and cannot be null");
            }
            this.TrackingId = trackingId;
        }

        /// <summary>
        /// ID used to identify a video. Returns the same value as the trackingId assigned to the video message.
        /// </summary>
        /// <value>ID used to identify a video. Returns the same value as the trackingId assigned to the video message.</value>
        [DataMember(Name = "trackingId", IsRequired = true, EmitDefaultValue = true)]
        public string TrackingId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VideoPlayComplete {\n");
            sb.Append("  TrackingId: ").Append(TrackingId).Append("\n");
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
