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
    /// MetadataSchema
    /// </summary>
    [DataContract]
    public partial class MetadataSchema :  IEquatable<MetadataSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSchema" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="titleLanguage">titleLanguage.</param>
        /// <param name="description">description.</param>
        /// <param name="descriptionLanguage">descriptionLanguage.</param>
        /// <param name="duration">duration.</param>
        /// <param name="typicalTime">typicalTime.</param>
        /// <param name="keywords">keywords.</param>
        public MetadataSchema(string title = default(string), string titleLanguage = default(string), string description = default(string), string descriptionLanguage = default(string), string duration = default(string), string typicalTime = default(string), List<string> keywords = default(List<string>))
        {
            this.Title = title;
            this.TitleLanguage = titleLanguage;
            this.Description = description;
            this.DescriptionLanguage = descriptionLanguage;
            this.Duration = duration;
            this.TypicalTime = typicalTime;
            this.Keywords = keywords;
        }
        
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets TitleLanguage
        /// </summary>
        [DataMember(Name="titleLanguage", EmitDefaultValue=false)]
        public string TitleLanguage { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DescriptionLanguage
        /// </summary>
        [DataMember(Name="descriptionLanguage", EmitDefaultValue=false)]
        public string DescriptionLanguage { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public string Duration { get; set; }

        /// <summary>
        /// Gets or Sets TypicalTime
        /// </summary>
        [DataMember(Name="typicalTime", EmitDefaultValue=false)]
        public string TypicalTime { get; set; }

        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetadataSchema {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TitleLanguage: ").Append(TitleLanguage).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DescriptionLanguage: ").Append(DescriptionLanguage).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  TypicalTime: ").Append(TypicalTime).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
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
            return this.Equals(input as MetadataSchema);
        }

        /// <summary>
        /// Returns true if MetadataSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of MetadataSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetadataSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.TitleLanguage == input.TitleLanguage ||
                    (this.TitleLanguage != null &&
                    this.TitleLanguage.Equals(input.TitleLanguage))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DescriptionLanguage == input.DescriptionLanguage ||
                    (this.DescriptionLanguage != null &&
                    this.DescriptionLanguage.Equals(input.DescriptionLanguage))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.TypicalTime == input.TypicalTime ||
                    (this.TypicalTime != null &&
                    this.TypicalTime.Equals(input.TypicalTime))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.TitleLanguage != null)
                    hashCode = hashCode * 59 + this.TitleLanguage.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DescriptionLanguage != null)
                    hashCode = hashCode * 59 + this.DescriptionLanguage.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.TypicalTime != null)
                    hashCode = hashCode * 59 + this.TypicalTime.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
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
