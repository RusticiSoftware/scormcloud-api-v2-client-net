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
    /// PreviewLaunchLinkRequestSchema
    /// </summary>
    [DataContract]
    public partial class PreviewLaunchLinkRequestSchema :  IEquatable<PreviewLaunchLinkRequestSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewLaunchLinkRequestSchema" /> class.
        /// </summary>
        /// <param name="expiry">Number of seconds from now this link will expire in. Defaults to 120s. Range 10s:300s (default to 120).</param>
        /// <param name="redirectOnExitUrl">The URL the application should redirect to when the learner exits a course.  Alternatively one of the following keywords can be used to redirect to: - &#x60;closer&#x60; - A page that automatically tries to close the browser tab/window - &#x60;blank&#x60; - A blank page - &#x60;message&#x60; - A page with a message about the course being complete  If an empty string is specified, the configured setting will be used (default www.scorm.com). If an invalid url is specified, the Message.html page will be loaded. .</param>
        /// <param name="startSco">For SCORM, SCO identifier to override launch, overriding the normal sequencing..</param>
        /// <param name="culture">This parameter should specify a culture code. If specified, and supported, the navigation and alerts in the player will be displayed in the associated language. If not specified, the locale of the user’s browser will be used..</param>
        /// <param name="cssUrl">A url pointing to custom CSS for the player to use..</param>
        /// <param name="additionalvalues">additionalvalues.</param>
        public PreviewLaunchLinkRequestSchema(int? expiry = 120, string redirectOnExitUrl = default(string), string startSco = default(string), string culture = default(string), string cssUrl = default(string), List<ItemValuePairSchema> additionalvalues = default(List<ItemValuePairSchema>))
        {
            // use default value if no "expiry" provided
            if (expiry == null)
            {
                this.Expiry = 120;
            }
            else
            {
                this.Expiry = expiry;
            }
            this.RedirectOnExitUrl = redirectOnExitUrl;
            this.StartSco = startSco;
            this.Culture = culture;
            this.CssUrl = cssUrl;
            this.Additionalvalues = additionalvalues;
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
        /// A url pointing to custom CSS for the player to use.
        /// </summary>
        /// <value>A url pointing to custom CSS for the player to use.</value>
        [DataMember(Name="cssUrl", EmitDefaultValue=false)]
        public string CssUrl { get; set; }

        /// <summary>
        /// Gets or Sets Additionalvalues
        /// </summary>
        [DataMember(Name="additionalvalues", EmitDefaultValue=false)]
        public List<ItemValuePairSchema> Additionalvalues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreviewLaunchLinkRequestSchema {\n");
            sb.Append("  Expiry: ").Append(Expiry).Append("\n");
            sb.Append("  RedirectOnExitUrl: ").Append(RedirectOnExitUrl).Append("\n");
            sb.Append("  StartSco: ").Append(StartSco).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
            sb.Append("  CssUrl: ").Append(CssUrl).Append("\n");
            sb.Append("  Additionalvalues: ").Append(Additionalvalues).Append("\n");
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
            return this.Equals(input as PreviewLaunchLinkRequestSchema);
        }

        /// <summary>
        /// Returns true if PreviewLaunchLinkRequestSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of PreviewLaunchLinkRequestSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreviewLaunchLinkRequestSchema input)
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
                    this.Additionalvalues == input.Additionalvalues ||
                    this.Additionalvalues != null &&
                    this.Additionalvalues.SequenceEqual(input.Additionalvalues)
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
                if (this.StartSco != null)
                    hashCode = hashCode * 59 + this.StartSco.GetHashCode();
                if (this.Culture != null)
                    hashCode = hashCode * 59 + this.Culture.GetHashCode();
                if (this.CssUrl != null)
                    hashCode = hashCode * 59 + this.CssUrl.GetHashCode();
                if (this.Additionalvalues != null)
                    hashCode = hashCode * 59 + this.Additionalvalues.GetHashCode();
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