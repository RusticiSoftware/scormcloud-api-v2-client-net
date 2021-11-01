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
    /// UpdateApplicationSchema
    /// </summary>
    [DataContract]
    public partial class UpdateApplicationSchema :  IEquatable<UpdateApplicationSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApplicationSchema" /> class.
        /// </summary>
        /// <param name="name">The new name of the application..</param>
        /// <param name="allowDelete">Whether or not the application is allowed to perform deletion operations..</param>
        public UpdateApplicationSchema(string name = default(string), bool? allowDelete = default(bool?))
        {
            this.Name = name;
            this.AllowDelete = allowDelete;
        }
        
        /// <summary>
        /// The new name of the application.
        /// </summary>
        /// <value>The new name of the application.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Whether or not the application is allowed to perform deletion operations.
        /// </summary>
        /// <value>Whether or not the application is allowed to perform deletion operations.</value>
        [DataMember(Name="allowDelete", EmitDefaultValue=false)]
        public bool? AllowDelete { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateApplicationSchema {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AllowDelete: ").Append(AllowDelete).Append("\n");
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
            return this.Equals(input as UpdateApplicationSchema);
        }

        /// <summary>
        /// Returns true if UpdateApplicationSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateApplicationSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateApplicationSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AllowDelete == input.AllowDelete ||
                    (this.AllowDelete != null &&
                    this.AllowDelete.Equals(input.AllowDelete))
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
                if (this.AllowDelete != null)
                    hashCode = hashCode * 59 + this.AllowDelete.GetHashCode();
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