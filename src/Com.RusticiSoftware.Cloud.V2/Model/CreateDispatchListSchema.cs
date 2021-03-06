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
    /// CreateDispatchListSchema
    /// </summary>
    [DataContract]
    public partial class CreateDispatchListSchema :  IEquatable<CreateDispatchListSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDispatchListSchema" /> class.
        /// </summary>
        /// <param name="dispatches">dispatches.</param>
        public CreateDispatchListSchema(List<CreateDispatchIdSchema> dispatches = default(List<CreateDispatchIdSchema>))
        {
            this.Dispatches = dispatches;
        }
        
        /// <summary>
        /// Gets or Sets Dispatches
        /// </summary>
        [DataMember(Name="dispatches", EmitDefaultValue=false)]
        public List<CreateDispatchIdSchema> Dispatches { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDispatchListSchema {\n");
            sb.Append("  Dispatches: ").Append(Dispatches).Append("\n");
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
            return this.Equals(input as CreateDispatchListSchema);
        }

        /// <summary>
        /// Returns true if CreateDispatchListSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDispatchListSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDispatchListSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dispatches == input.Dispatches ||
                    this.Dispatches != null &&
                    this.Dispatches.SequenceEqual(input.Dispatches)
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
                if (this.Dispatches != null)
                    hashCode = hashCode * 59 + this.Dispatches.GetHashCode();
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
