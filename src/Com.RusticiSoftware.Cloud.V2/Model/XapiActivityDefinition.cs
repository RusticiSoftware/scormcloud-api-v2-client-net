/* 
 * SCORM Cloud Rest API
 *
 * REST API used for SCORM Cloud integrations.
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Com.RusticiSoftware.Cloud.V2.Client.SwaggerDateConverter;

namespace Com.RusticiSoftware.Cloud.V2.Model
{
    /// <summary>
    /// https://github.com/adlnet/xAPI-Spec/blob/1.0.2/xAPI.md#activity-definition
    /// </summary>
    [DataContract]
    public partial class XapiActivityDefinition :  IEquatable<XapiActivityDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XapiActivityDefinition" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="type">type.</param>
        /// <param name="moreInfo">moreInfo.</param>
        /// <param name="interactionType">interactionType.</param>
        /// <param name="correctResponsesPattern">correctResponsesPattern.</param>
        /// <param name="choices">choices.</param>
        /// <param name="scale">scale.</param>
        /// <param name="source">source.</param>
        /// <param name="target">target.</param>
        /// <param name="steps">steps.</param>
        /// <param name="extensions">extensions.</param>
        public XapiActivityDefinition(Dictionary<string, string> name = default(Dictionary<string, string>), Dictionary<string, string> description = default(Dictionary<string, string>), string type = default(string), string moreInfo = default(string), string interactionType = default(string), List<string> correctResponsesPattern = default(List<string>), List<XapiInteractionComponent> choices = default(List<XapiInteractionComponent>), List<XapiInteractionComponent> scale = default(List<XapiInteractionComponent>), List<XapiInteractionComponent> source = default(List<XapiInteractionComponent>), List<XapiInteractionComponent> target = default(List<XapiInteractionComponent>), List<XapiInteractionComponent> steps = default(List<XapiInteractionComponent>), Dictionary<string, Object> extensions = default(Dictionary<string, Object>))
        {
            this.Name = name;
            this.Description = description;
            this.Type = type;
            this.MoreInfo = moreInfo;
            this.InteractionType = interactionType;
            this.CorrectResponsesPattern = correctResponsesPattern;
            this.Choices = choices;
            this.Scale = scale;
            this.Source = source;
            this.Target = target;
            this.Steps = steps;
            this.Extensions = extensions;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public Dictionary<string, string> Description { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets MoreInfo
        /// </summary>
        [DataMember(Name="moreInfo", EmitDefaultValue=false)]
        public string MoreInfo { get; set; }

        /// <summary>
        /// Gets or Sets InteractionType
        /// </summary>
        [DataMember(Name="interactionType", EmitDefaultValue=false)]
        public string InteractionType { get; set; }

        /// <summary>
        /// Gets or Sets CorrectResponsesPattern
        /// </summary>
        [DataMember(Name="correctResponsesPattern", EmitDefaultValue=false)]
        public List<string> CorrectResponsesPattern { get; set; }

        /// <summary>
        /// Gets or Sets Choices
        /// </summary>
        [DataMember(Name="choices", EmitDefaultValue=false)]
        public List<XapiInteractionComponent> Choices { get; set; }

        /// <summary>
        /// Gets or Sets Scale
        /// </summary>
        [DataMember(Name="scale", EmitDefaultValue=false)]
        public List<XapiInteractionComponent> Scale { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public List<XapiInteractionComponent> Source { get; set; }

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public List<XapiInteractionComponent> Target { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name="steps", EmitDefaultValue=false)]
        public List<XapiInteractionComponent> Steps { get; set; }

        /// <summary>
        /// Gets or Sets Extensions
        /// </summary>
        [DataMember(Name="extensions", EmitDefaultValue=false)]
        public Dictionary<string, Object> Extensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XapiActivityDefinition {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MoreInfo: ").Append(MoreInfo).Append("\n");
            sb.Append("  InteractionType: ").Append(InteractionType).Append("\n");
            sb.Append("  CorrectResponsesPattern: ").Append(CorrectResponsesPattern).Append("\n");
            sb.Append("  Choices: ").Append(Choices).Append("\n");
            sb.Append("  Scale: ").Append(Scale).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  Extensions: ").Append(Extensions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as XapiActivityDefinition);
        }

        /// <summary>
        /// Returns true if XapiActivityDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of XapiActivityDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XapiActivityDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.MoreInfo == input.MoreInfo ||
                    (this.MoreInfo != null &&
                    this.MoreInfo.Equals(input.MoreInfo))
                ) && 
                (
                    this.InteractionType == input.InteractionType ||
                    (this.InteractionType != null &&
                    this.InteractionType.Equals(input.InteractionType))
                ) && 
                (
                    this.CorrectResponsesPattern == input.CorrectResponsesPattern ||
                    this.CorrectResponsesPattern != null &&
                    this.CorrectResponsesPattern.SequenceEqual(input.CorrectResponsesPattern)
                ) && 
                (
                    this.Choices == input.Choices ||
                    this.Choices != null &&
                    this.Choices.SequenceEqual(input.Choices)
                ) && 
                (
                    this.Scale == input.Scale ||
                    this.Scale != null &&
                    this.Scale.SequenceEqual(input.Scale)
                ) && 
                (
                    this.Source == input.Source ||
                    this.Source != null &&
                    this.Source.SequenceEqual(input.Source)
                ) && 
                (
                    this.Target == input.Target ||
                    this.Target != null &&
                    this.Target.SequenceEqual(input.Target)
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
                ) && 
                (
                    this.Extensions == input.Extensions ||
                    this.Extensions != null &&
                    this.Extensions.SequenceEqual(input.Extensions)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.MoreInfo != null)
                    hashCode = hashCode * 59 + this.MoreInfo.GetHashCode();
                if (this.InteractionType != null)
                    hashCode = hashCode * 59 + this.InteractionType.GetHashCode();
                if (this.CorrectResponsesPattern != null)
                    hashCode = hashCode * 59 + this.CorrectResponsesPattern.GetHashCode();
                if (this.Choices != null)
                    hashCode = hashCode * 59 + this.Choices.GetHashCode();
                if (this.Scale != null)
                    hashCode = hashCode * 59 + this.Scale.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.Steps != null)
                    hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.Extensions != null)
                    hashCode = hashCode * 59 + this.Extensions.GetHashCode();
                return hashCode;
            }
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
