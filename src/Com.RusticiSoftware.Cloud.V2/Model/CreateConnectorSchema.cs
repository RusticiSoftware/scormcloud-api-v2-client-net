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
    /// CreateConnectorSchema
    /// </summary>
    [DataContract]
    public partial class CreateConnectorSchema :  IEquatable<CreateConnectorSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateConnectorSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorSchema" /> class.
        /// </summary>
        /// <param name="contentConnectorType">type of this content connector (required).</param>
        /// <param name="configuration">configuration for this content connector, format is implementation specific (required).</param>
        /// <param name="enabled">is this connector enabled (default to true).</param>
        public CreateConnectorSchema(string contentConnectorType = default(string), Object configuration = default(Object), bool? enabled = true)
        {
            // to ensure "contentConnectorType" is required (not null)
            if (contentConnectorType == null)
            {
                throw new InvalidDataException("contentConnectorType is a required property for CreateConnectorSchema and cannot be null");
            }
            else
            {
                this.ContentConnectorType = contentConnectorType;
            }
            // to ensure "configuration" is required (not null)
            if (configuration == null)
            {
                throw new InvalidDataException("configuration is a required property for CreateConnectorSchema and cannot be null");
            }
            else
            {
                this.Configuration = configuration;
            }
            // use default value if no "enabled" provided
            if (enabled == null)
            {
                this.Enabled = true;
            }
            else
            {
                this.Enabled = enabled;
            }
        }
        
        /// <summary>
        /// type of this content connector
        /// </summary>
        /// <value>type of this content connector</value>
        [DataMember(Name="contentConnectorType", EmitDefaultValue=false)]
        public string ContentConnectorType { get; set; }

        /// <summary>
        /// configuration for this content connector, format is implementation specific
        /// </summary>
        /// <value>configuration for this content connector, format is implementation specific</value>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public Object Configuration { get; set; }

        /// <summary>
        /// is this connector enabled
        /// </summary>
        /// <value>is this connector enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateConnectorSchema {\n");
            sb.Append("  ContentConnectorType: ").Append(ContentConnectorType).Append("\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as CreateConnectorSchema);
        }

        /// <summary>
        /// Returns true if CreateConnectorSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateConnectorSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateConnectorSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContentConnectorType == input.ContentConnectorType ||
                    (this.ContentConnectorType != null &&
                    this.ContentConnectorType.Equals(input.ContentConnectorType))
                ) && 
                (
                    this.Configuration == input.Configuration ||
                    (this.Configuration != null &&
                    this.Configuration.Equals(input.Configuration))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
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
                if (this.ContentConnectorType != null)
                    hashCode = hashCode * 59 + this.ContentConnectorType.GetHashCode();
                if (this.Configuration != null)
                    hashCode = hashCode * 59 + this.Configuration.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
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
