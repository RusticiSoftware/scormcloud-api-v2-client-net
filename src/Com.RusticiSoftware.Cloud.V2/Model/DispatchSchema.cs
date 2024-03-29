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
    /// DispatchSchema
    /// </summary>
    [DataContract]
    public partial class DispatchSchema :  IEquatable<DispatchSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DispatchSchema" /> class.
        /// </summary>
        /// <param name="destinationId">Destination ID..</param>
        /// <param name="destinationName">Name of the destination housing this dispatch.</param>
        /// <param name="courseId">Serialized external package ID..</param>
        /// <param name="courseTitle">Title of this dispatched course.</param>
        /// <param name="updated">updated.</param>
        /// <param name="created">created.</param>
        /// <param name="allowNewRegistrations">If true, then new registrations can be created for this dispatch. .</param>
        /// <param name="enabled">If false, the dispatch can not be launched..</param>
        /// <param name="instanced">If true, then a new registration instance will be created if the client LMS doesn&#39;t provide launch data for an existing one. Otherwise, the same instance will always be used for the given cmi.learner_id. .</param>
        /// <param name="registrationCap">The maximum number of registrations that can be created for this dispatch, where &#39;0&#39; means &#39;unlimited registrations&#39;. .</param>
        /// <param name="registrationCount">The current number of registrations that have been created for this dispatch. .</param>
        /// <param name="expirationDate">The ISO 8601 TimeStamp (defaults to UTC) after which this dispatch will be disabled. An empty value will represent no expiration date. .</param>
        /// <param name="tags">The tags to associate with this Dispatch..</param>
        /// <param name="email">SCORM Cloud user e-mail associated with this dispatch. If this is not provided, it will default to the owner of the Realm. .</param>
        /// <param name="notes">Any provided notes about this dispatch..</param>
        public DispatchSchema(string destinationId = default(string), string destinationName = default(string), string courseId = default(string), string courseTitle = default(string), DateTime? updated = default(DateTime?), DateTime? created = default(DateTime?), bool? allowNewRegistrations = default(bool?), bool? enabled = default(bool?), bool? instanced = default(bool?), int? registrationCap = default(int?), int? registrationCount = default(int?), DateTime? expirationDate = default(DateTime?), List<string> tags = default(List<string>), string email = default(string), string notes = default(string))
        {
            this.DestinationId = destinationId;
            this.DestinationName = destinationName;
            this.CourseId = courseId;
            this.CourseTitle = courseTitle;
            this.Updated = updated;
            this.Created = created;
            this.AllowNewRegistrations = allowNewRegistrations;
            this.Enabled = enabled;
            this.Instanced = instanced;
            this.RegistrationCap = registrationCap;
            this.RegistrationCount = registrationCount;
            this.ExpirationDate = expirationDate;
            this.Tags = tags;
            this.Email = email;
            this.Notes = notes;
        }
        
        /// <summary>
        /// Destination ID.
        /// </summary>
        /// <value>Destination ID.</value>
        [DataMember(Name="destinationId", EmitDefaultValue=false)]
        public string DestinationId { get; set; }

        /// <summary>
        /// Name of the destination housing this dispatch
        /// </summary>
        /// <value>Name of the destination housing this dispatch</value>
        [DataMember(Name="destinationName", EmitDefaultValue=false)]
        public string DestinationName { get; set; }

        /// <summary>
        /// Serialized external package ID.
        /// </summary>
        /// <value>Serialized external package ID.</value>
        [DataMember(Name="courseId", EmitDefaultValue=false)]
        public string CourseId { get; set; }

        /// <summary>
        /// Title of this dispatched course
        /// </summary>
        /// <value>Title of this dispatched course</value>
        [DataMember(Name="courseTitle", EmitDefaultValue=false)]
        public string CourseTitle { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// If true, then new registrations can be created for this dispatch. 
        /// </summary>
        /// <value>If true, then new registrations can be created for this dispatch. </value>
        [DataMember(Name="allowNewRegistrations", EmitDefaultValue=false)]
        public bool? AllowNewRegistrations { get; set; }

        /// <summary>
        /// If false, the dispatch can not be launched.
        /// </summary>
        /// <value>If false, the dispatch can not be launched.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// If true, then a new registration instance will be created if the client LMS doesn&#39;t provide launch data for an existing one. Otherwise, the same instance will always be used for the given cmi.learner_id. 
        /// </summary>
        /// <value>If true, then a new registration instance will be created if the client LMS doesn&#39;t provide launch data for an existing one. Otherwise, the same instance will always be used for the given cmi.learner_id. </value>
        [DataMember(Name="instanced", EmitDefaultValue=false)]
        public bool? Instanced { get; set; }

        /// <summary>
        /// The maximum number of registrations that can be created for this dispatch, where &#39;0&#39; means &#39;unlimited registrations&#39;. 
        /// </summary>
        /// <value>The maximum number of registrations that can be created for this dispatch, where &#39;0&#39; means &#39;unlimited registrations&#39;. </value>
        [DataMember(Name="registrationCap", EmitDefaultValue=false)]
        public int? RegistrationCap { get; set; }

        /// <summary>
        /// The current number of registrations that have been created for this dispatch. 
        /// </summary>
        /// <value>The current number of registrations that have been created for this dispatch. </value>
        [DataMember(Name="registrationCount", EmitDefaultValue=false)]
        public int? RegistrationCount { get; set; }

        /// <summary>
        /// The ISO 8601 TimeStamp (defaults to UTC) after which this dispatch will be disabled. An empty value will represent no expiration date. 
        /// </summary>
        /// <value>The ISO 8601 TimeStamp (defaults to UTC) after which this dispatch will be disabled. An empty value will represent no expiration date. </value>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The tags to associate with this Dispatch.
        /// </summary>
        /// <value>The tags to associate with this Dispatch.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// SCORM Cloud user e-mail associated with this dispatch. If this is not provided, it will default to the owner of the Realm. 
        /// </summary>
        /// <value>SCORM Cloud user e-mail associated with this dispatch. If this is not provided, it will default to the owner of the Realm. </value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Any provided notes about this dispatch.
        /// </summary>
        /// <value>Any provided notes about this dispatch.</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DispatchSchema {\n");
            sb.Append("  DestinationId: ").Append(DestinationId).Append("\n");
            sb.Append("  DestinationName: ").Append(DestinationName).Append("\n");
            sb.Append("  CourseId: ").Append(CourseId).Append("\n");
            sb.Append("  CourseTitle: ").Append(CourseTitle).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  AllowNewRegistrations: ").Append(AllowNewRegistrations).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Instanced: ").Append(Instanced).Append("\n");
            sb.Append("  RegistrationCap: ").Append(RegistrationCap).Append("\n");
            sb.Append("  RegistrationCount: ").Append(RegistrationCount).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(input as DispatchSchema);
        }

        /// <summary>
        /// Returns true if DispatchSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of DispatchSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DispatchSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DestinationId == input.DestinationId ||
                    (this.DestinationId != null &&
                    this.DestinationId.Equals(input.DestinationId))
                ) && 
                (
                    this.DestinationName == input.DestinationName ||
                    (this.DestinationName != null &&
                    this.DestinationName.Equals(input.DestinationName))
                ) && 
                (
                    this.CourseId == input.CourseId ||
                    (this.CourseId != null &&
                    this.CourseId.Equals(input.CourseId))
                ) && 
                (
                    this.CourseTitle == input.CourseTitle ||
                    (this.CourseTitle != null &&
                    this.CourseTitle.Equals(input.CourseTitle))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.AllowNewRegistrations == input.AllowNewRegistrations ||
                    (this.AllowNewRegistrations != null &&
                    this.AllowNewRegistrations.Equals(input.AllowNewRegistrations))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Instanced == input.Instanced ||
                    (this.Instanced != null &&
                    this.Instanced.Equals(input.Instanced))
                ) && 
                (
                    this.RegistrationCap == input.RegistrationCap ||
                    (this.RegistrationCap != null &&
                    this.RegistrationCap.Equals(input.RegistrationCap))
                ) && 
                (
                    this.RegistrationCount == input.RegistrationCount ||
                    (this.RegistrationCount != null &&
                    this.RegistrationCount.Equals(input.RegistrationCount))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
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
                if (this.DestinationId != null)
                    hashCode = hashCode * 59 + this.DestinationId.GetHashCode();
                if (this.DestinationName != null)
                    hashCode = hashCode * 59 + this.DestinationName.GetHashCode();
                if (this.CourseId != null)
                    hashCode = hashCode * 59 + this.CourseId.GetHashCode();
                if (this.CourseTitle != null)
                    hashCode = hashCode * 59 + this.CourseTitle.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.AllowNewRegistrations != null)
                    hashCode = hashCode * 59 + this.AllowNewRegistrations.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Instanced != null)
                    hashCode = hashCode * 59 + this.Instanced.GetHashCode();
                if (this.RegistrationCap != null)
                    hashCode = hashCode * 59 + this.RegistrationCap.GetHashCode();
                if (this.RegistrationCount != null)
                    hashCode = hashCode * 59 + this.RegistrationCount.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
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
