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
    /// PostbackAction
    /// </summary>
    [DataContract(Name = "PostbackAction")]
    public partial class PostbackAction : Action, IValidatableObject
    {
        /// <summary>
        /// Defines InputOption
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InputOptionEnum
        {
            /// <summary>
            /// Enum CloseRichMenu for value: closeRichMenu
            /// </summary>
            [EnumMember(Value = "closeRichMenu")]
            CloseRichMenu = 1,

            /// <summary>
            /// Enum OpenRichMenu for value: openRichMenu
            /// </summary>
            [EnumMember(Value = "openRichMenu")]
            OpenRichMenu = 2,

            /// <summary>
            /// Enum OpenKeyboard for value: openKeyboard
            /// </summary>
            [EnumMember(Value = "openKeyboard")]
            OpenKeyboard = 3,

            /// <summary>
            /// Enum OpenVoice for value: openVoice
            /// </summary>
            [EnumMember(Value = "openVoice")]
            OpenVoice = 4
        }


        /// <summary>
        /// Gets or Sets InputOption
        /// </summary>
        [DataMember(Name = "inputOption", EmitDefaultValue = false)]
        public InputOptionEnum? InputOption { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostbackAction" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="displayText">displayText.</param>
        /// <param name="text">text.</param>
        /// <param name="inputOption">inputOption.</param>
        /// <param name="fillInText">fillInText.</param>
        /// <param name="type">Type of action (default to &quot;PostbackAction&quot;).</param>
        /// <param name="label">Label for the action..</param>
        public PostbackAction(string data = default(string), string displayText = default(string), string text = default(string), InputOptionEnum? inputOption = default(InputOptionEnum?), string fillInText = default(string), string type = @"PostbackAction", string label = default(string)) : base(type, label)
        {
            this.Data = data;
            this.DisplayText = displayText;
            this.Text = text;
            this.InputOption = inputOption;
            this.FillInText = fillInText;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public string Data { get; set; }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name = "displayText", EmitDefaultValue = false)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets FillInText
        /// </summary>
        [DataMember(Name = "fillInText", EmitDefaultValue = false)]
        public string FillInText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostbackAction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  InputOption: ").Append(InputOption).Append("\n");
            sb.Append("  FillInText: ").Append(FillInText).Append("\n");
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
