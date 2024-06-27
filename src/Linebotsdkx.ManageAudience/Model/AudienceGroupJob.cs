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
using OpenAPIDateConverter = Linebotsdkx.ManageAudience.Client.OpenAPIDateConverter;

namespace Linebotsdkx.ManageAudience.Model
{
    /// <summary>
    /// Audience group job
    /// </summary>
    [DataContract(Name = "AudienceGroupJob")]
    public partial class AudienceGroupJob : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public AudienceGroupJobType? Type { get; set; }

        /// <summary>
        /// Gets or Sets JobStatus
        /// </summary>
        [DataMember(Name = "jobStatus", EmitDefaultValue = false)]
        public AudienceGroupJobStatus? JobStatus { get; set; }

        /// <summary>
        /// Gets or Sets FailedType
        /// </summary>
        [DataMember(Name = "failedType", EmitDefaultValue = false)]
        public AudienceGroupJobFailedType? FailedType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AudienceGroupJob" /> class.
        /// </summary>
        /// <param name="audienceGroupJobId">A job ID..</param>
        /// <param name="audienceGroupId">An audience ID..</param>
        /// <param name="description">The job&#39;s description..</param>
        /// <param name="type">type.</param>
        /// <param name="jobStatus">jobStatus.</param>
        /// <param name="failedType">failedType.</param>
        /// <param name="audienceCount">The number of accounts (recipients) that were added or removed..</param>
        /// <param name="created">When the job was created (in UNIX time)..</param>
        public AudienceGroupJob(long audienceGroupJobId = default(long), long audienceGroupId = default(long), string description = default(string), AudienceGroupJobType? type = default(AudienceGroupJobType?), AudienceGroupJobStatus? jobStatus = default(AudienceGroupJobStatus?), AudienceGroupJobFailedType? failedType = default(AudienceGroupJobFailedType?), long audienceCount = default(long), long created = default(long))
        {
            this.AudienceGroupJobId = audienceGroupJobId;
            this.AudienceGroupId = audienceGroupId;
            this.Description = description;
            this.Type = type;
            this.JobStatus = jobStatus;
            this.FailedType = failedType;
            this.AudienceCount = audienceCount;
            this.Created = created;
        }

        /// <summary>
        /// A job ID.
        /// </summary>
        /// <value>A job ID.</value>
        [DataMember(Name = "audienceGroupJobId", EmitDefaultValue = false)]
        public long AudienceGroupJobId { get; set; }

        /// <summary>
        /// An audience ID.
        /// </summary>
        /// <value>An audience ID.</value>
        [DataMember(Name = "audienceGroupId", EmitDefaultValue = false)]
        public long AudienceGroupId { get; set; }

        /// <summary>
        /// The job&#39;s description.
        /// </summary>
        /// <value>The job&#39;s description.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The number of accounts (recipients) that were added or removed.
        /// </summary>
        /// <value>The number of accounts (recipients) that were added or removed.</value>
        [DataMember(Name = "audienceCount", EmitDefaultValue = false)]
        public long AudienceCount { get; set; }

        /// <summary>
        /// When the job was created (in UNIX time).
        /// </summary>
        /// <value>When the job was created (in UNIX time).</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public long Created { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AudienceGroupJob {\n");
            sb.Append("  AudienceGroupJobId: ").Append(AudienceGroupJobId).Append("\n");
            sb.Append("  AudienceGroupId: ").Append(AudienceGroupId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  FailedType: ").Append(FailedType).Append("\n");
            sb.Append("  AudienceCount: ").Append(AudienceCount).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
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
