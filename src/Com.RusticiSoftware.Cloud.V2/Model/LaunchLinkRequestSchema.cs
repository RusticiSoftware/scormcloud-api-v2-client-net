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
    /// LaunchLinkRequestSchema
    /// </summary>
    [DataContract]
    public partial class LaunchLinkRequestSchema :  IEquatable<LaunchLinkRequestSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LaunchLinkRequestSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LaunchLinkRequestSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LaunchLinkRequestSchema" /> class.
        /// </summary>
        /// <param name="expiry">Number of seconds from now this link will expire in. Defaults to 120s. Range 10s:300s (default to 120).</param>
        /// <param name="redirectOnExitUrl">The URL the application should redirect to when the learner exits a course.  Alternatively one of the following keywords can be used to redirect to: - &#x60;closer&#x60; - A page that automatically tries to close the browser tab/window - &#x60;blank&#x60; - A blank page - &#x60;message&#x60; - A page with a message about the course being complete  If an empty string is specified, the configured setting will be used (default www.scorm.com). If an invalid url is specified, the Message.html page will be loaded.  (required).</param>
        /// <param name="tracking">Should this launch be tracked? If false, SCORM Cloud will avoid tracking to the extent possible for the standard being used. (default to true).</param>
        /// <param name="startSco">For SCORM, SCO identifier to override launch, overriding the normal sequencing..</param>
        /// <param name="culture">This parameter should specify a culture code. If specified, and supported, the navigation and alerts in the player will be displayed in the associated language. If not specified, the locale of the user’s browser will be used..</param>
        /// <param name="cssUrl">A Url pointing to custom css for the player to use..</param>
        /// <param name="learnerTags">learnerTags.</param>
        /// <param name="courseTags">courseTags.</param>
        /// <param name="registrationTags">registrationTags.</param>
        /// <param name="additionalvalues">additionalvalues.</param>
        /// <param name="launchAuth">launchAuth.</param>
        public LaunchLinkRequestSchema(int? expiry = 120, string redirectOnExitUrl = default(string), bool? tracking = true, string startSco = default(string), string culture = default(string), string cssUrl = default(string), List<string> learnerTags = default(List<string>), List<string> courseTags = default(List<string>), List<string> registrationTags = default(List<string>), List<ItemValuePairSchema> additionalvalues = default(List<ItemValuePairSchema>), LaunchAuthSchema launchAuth = default(LaunchAuthSchema))
        {
            // to ensure "redirectOnExitUrl" is required (not null)
            if (redirectOnExitUrl == null)
            {
                throw new InvalidDataException("redirectOnExitUrl is a required property for LaunchLinkRequestSchema and cannot be null");
            }
            else
            {
                this.RedirectOnExitUrl = redirectOnExitUrl;
            }
            // use default value if no "expiry" provided
            if (expiry == null)
            {
                this.Expiry = 120;
            }
            else
            {
                this.Expiry = expiry;
            }
            // use default value if no "tracking" provided
            if (tracking == null)
            {
                this.Tracking = true;
            }
            else
            {
                this.Tracking = tracking;
            }
            this.StartSco = startSco;
            this.Culture = culture;
            this.CssUrl = cssUrl;
            this.LearnerTags = learnerTags;
            this.CourseTags = courseTags;
            this.RegistrationTags = registrationTags;
            this.Additionalvalues = additionalvalues;
            this.LaunchAuth = launchAuth;
        }
        
        /// <summary>
        /// Number of seconds from now this link will expire in. Defaults to 120s. Range 10s:300s
        /// </summary>
        /// <value>Number of seconds from now this link will expire in. Defaults to 120s. Range 10s:300s</value>
        [DataMember(Name="expiry", EmitDefaultValue=false)]
        public int? Expiry { get; set; }

        /// <summary>
        /// The URL the application should redirect to when the learner exits a course.  Alternatively one of the following keywords can be used to redirect to: - &#x60;closer&#x60; - A page that automatically tries to close the browser tab/window - &#x60;blank&#x60; - A blank page - &#x60;message&#x60; - A page with a message about the course being complete  If an empty string is specified, the configured setting will be used (default www.scorm.com). If an invalid url is specified, the Message.html page will be loaded. 
        /// </summary>
        /// <value>The URL the application should redirect to when the learner exits a course.  Alternatively one of the following keywords can be used to redirect to: - &#x60;closer&#x60; - A page that automatically tries to close the browser tab/window - &#x60;blank&#x60; - A blank page - &#x60;message&#x60; - A page with a message about the course being complete  If an empty string is specified, the configured setting will be used (default www.scorm.com). If an invalid url is specified, the Message.html page will be loaded. </value>
        [DataMember(Name="redirectOnExitUrl", EmitDefaultValue=false)]
        public string RedirectOnExitUrl { get; set; }

        /// <summary>
        /// Should this launch be tracked? If false, SCORM Cloud will avoid tracking to the extent possible for the standard being used.
        /// </summary>
        /// <value>Should this launch be tracked? If false, SCORM Cloud will avoid tracking to the extent possible for the standard being used.</value>
        [DataMember(Name="tracking", EmitDefaultValue=false)]
        public bool? Tracking { get; set; }

        /// <summary>
        /// For SCORM, SCO identifier to override launch, overriding the normal sequencing.
        /// </summary>
        /// <value>For SCORM, SCO identifier to override launch, overriding the normal sequencing.</value>
        [DataMember(Name="startSco", EmitDefaultValue=false)]
        public string StartSco { get; set; }

        /// <summary>
        /// This parameter should specify a culture code. If specified, and supported, the navigation and alerts in the player will be displayed in the associated language. If not specified, the locale of the user’s browser will be used.
        /// </summary>
        /// <value>This parameter should specify a culture code. If specified, and supported, the navigation and alerts in the player will be displayed in the associated language. If not specified, the locale of the user’s browser will be used.</value>
        [DataMember(Name="culture", EmitDefaultValue=false)]
        public string Culture { get; set; }

        /// <summary>
        /// A Url pointing to custom css for the player to use.
        /// </summary>
        /// <value>A Url pointing to custom css for the player to use.</value>
        [DataMember(Name="cssUrl", EmitDefaultValue=false)]
        public string CssUrl { get; set; }

        /// <summary>
        /// Gets or Sets LearnerTags
        /// </summary>
        [DataMember(Name="learnerTags", EmitDefaultValue=false)]
        public List<string> LearnerTags { get; set; }

        /// <summary>
        /// Gets or Sets CourseTags
        /// </summary>
        [DataMember(Name="courseTags", EmitDefaultValue=false)]
        public List<string> CourseTags { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationTags
        /// </summary>
        [DataMember(Name="registrationTags", EmitDefaultValue=false)]
        public List<string> RegistrationTags { get; set; }

        /// <summary>
        /// Gets or Sets Additionalvalues
        /// </summary>
        [DataMember(Name="additionalvalues", EmitDefaultValue=false)]
        public List<ItemValuePairSchema> Additionalvalues { get; set; }

        /// <summary>
        /// Gets or Sets LaunchAuth
        /// </summary>
        [DataMember(Name="launchAuth", EmitDefaultValue=false)]
        public LaunchAuthSchema LaunchAuth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LaunchLinkRequestSchema {\n");
            sb.Append("  Expiry: ").Append(Expiry).Append("\n");
            sb.Append("  RedirectOnExitUrl: ").Append(RedirectOnExitUrl).Append("\n");
            sb.Append("  Tracking: ").Append(Tracking).Append("\n");
            sb.Append("  StartSco: ").Append(StartSco).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
            sb.Append("  CssUrl: ").Append(CssUrl).Append("\n");
            sb.Append("  LearnerTags: ").Append(LearnerTags).Append("\n");
            sb.Append("  CourseTags: ").Append(CourseTags).Append("\n");
            sb.Append("  RegistrationTags: ").Append(RegistrationTags).Append("\n");
            sb.Append("  Additionalvalues: ").Append(Additionalvalues).Append("\n");
            sb.Append("  LaunchAuth: ").Append(LaunchAuth).Append("\n");
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
            return this.Equals(input as LaunchLinkRequestSchema);
        }

        /// <summary>
        /// Returns true if LaunchLinkRequestSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of LaunchLinkRequestSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LaunchLinkRequestSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Expiry == input.Expiry ||
                    (this.Expiry != null &&
                    this.Expiry.Equals(input.Expiry))
                ) && 
                (
                    this.RedirectOnExitUrl == input.RedirectOnExitUrl ||
                    (this.RedirectOnExitUrl != null &&
                    this.RedirectOnExitUrl.Equals(input.RedirectOnExitUrl))
                ) && 
                (
                    this.Tracking == input.Tracking ||
                    (this.Tracking != null &&
                    this.Tracking.Equals(input.Tracking))
                ) && 
                (
                    this.StartSco == input.StartSco ||
                    (this.StartSco != null &&
                    this.StartSco.Equals(input.StartSco))
                ) && 
                (
                    this.Culture == input.Culture ||
                    (this.Culture != null &&
                    this.Culture.Equals(input.Culture))
                ) && 
                (
                    this.CssUrl == input.CssUrl ||
                    (this.CssUrl != null &&
                    this.CssUrl.Equals(input.CssUrl))
                ) && 
                (
                    this.LearnerTags == input.LearnerTags ||
                    this.LearnerTags != null &&
                    this.LearnerTags.SequenceEqual(input.LearnerTags)
                ) && 
                (
                    this.CourseTags == input.CourseTags ||
                    this.CourseTags != null &&
                    this.CourseTags.SequenceEqual(input.CourseTags)
                ) && 
                (
                    this.RegistrationTags == input.RegistrationTags ||
                    this.RegistrationTags != null &&
                    this.RegistrationTags.SequenceEqual(input.RegistrationTags)
                ) && 
                (
                    this.Additionalvalues == input.Additionalvalues ||
                    this.Additionalvalues != null &&
                    this.Additionalvalues.SequenceEqual(input.Additionalvalues)
                ) && 
                (
                    this.LaunchAuth == input.LaunchAuth ||
                    (this.LaunchAuth != null &&
                    this.LaunchAuth.Equals(input.LaunchAuth))
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
                if (this.Expiry != null)
                    hashCode = hashCode * 59 + this.Expiry.GetHashCode();
                if (this.RedirectOnExitUrl != null)
                    hashCode = hashCode * 59 + this.RedirectOnExitUrl.GetHashCode();
                if (this.Tracking != null)
                    hashCode = hashCode * 59 + this.Tracking.GetHashCode();
                if (this.StartSco != null)
                    hashCode = hashCode * 59 + this.StartSco.GetHashCode();
                if (this.Culture != null)
                    hashCode = hashCode * 59 + this.Culture.GetHashCode();
                if (this.CssUrl != null)
                    hashCode = hashCode * 59 + this.CssUrl.GetHashCode();
                if (this.LearnerTags != null)
                    hashCode = hashCode * 59 + this.LearnerTags.GetHashCode();
                if (this.CourseTags != null)
                    hashCode = hashCode * 59 + this.CourseTags.GetHashCode();
                if (this.RegistrationTags != null)
                    hashCode = hashCode * 59 + this.RegistrationTags.GetHashCode();
                if (this.Additionalvalues != null)
                    hashCode = hashCode * 59 + this.Additionalvalues.GetHashCode();
                if (this.LaunchAuth != null)
                    hashCode = hashCode * 59 + this.LaunchAuth.GetHashCode();
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
