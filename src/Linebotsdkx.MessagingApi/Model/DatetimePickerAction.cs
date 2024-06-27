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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Linebotsdkx.MessagingApi.Client.OpenAPIDateConverter;

namespace Linebotsdkx.MessagingApi.Model
{
    /// <summary>
    /// DatetimePickerAction
    /// </summary>
    [DataContract(Name = "DatetimePickerAction")]
    public partial class DatetimePickerAction : Action, IValidatableObject
    {
        /// <summary>
        /// Defines Mode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Enum Date for value: date
            /// </summary>
            [EnumMember(Value = "date")]
            Date = 1,

            /// <summary>
            /// Enum Time for value: time
            /// </summary>
            [EnumMember(Value = "time")]
            Time = 2,

            /// <summary>
            /// Enum Datetime for value: datetime
            /// </summary>
            [EnumMember(Value = "datetime")]
            Datetime = 3
        }


        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DatetimePickerAction" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="mode">mode.</param>
        /// <param name="initial">initial.</param>
        /// <param name="max">max.</param>
        /// <param name="min">min.</param>
        /// <param name="type">Type of action (default to &quot;DatetimePickerAction&quot;).</param>
        /// <param name="label">Label for the action..</param>
        public DatetimePickerAction(string data = default(string), ModeEnum? mode = default(ModeEnum?), string initial = default(string), string max = default(string), string min = default(string), string type = @"DatetimePickerAction", string label = default(string)) : base(type, label)
        {
            this.Data = data;
            this.Mode = mode;
            this.Initial = initial;
            this.Max = max;
            this.Min = min;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public string Data { get; set; }

        /// <summary>
        /// Gets or Sets Initial
        /// </summary>
        [DataMember(Name = "initial", EmitDefaultValue = false)]
        public string Initial { get; set; }

        /// <summary>
        /// Gets or Sets Max
        /// </summary>
        [DataMember(Name = "max", EmitDefaultValue = false)]
        public string Max { get; set; }

        /// <summary>
        /// Gets or Sets Min
        /// </summary>
        [DataMember(Name = "min", EmitDefaultValue = false)]
        public string Min { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatetimePickerAction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Initial: ").Append(Initial).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in base.BaseValidate(validationContext))
            {
                yield return x;
            }
            // Data (string) maxLength
            if (this.Data != null && this.Data.Length > 300)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Data, length must be less than 300.", new [] { "Data" });
            }

            // Data (string) minLength
            if (this.Data != null && this.Data.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Data, length must be greater than 0.", new [] { "Data" });
            }

            yield break;
        }
    }

}
