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
    /// PostBackSchema
    /// </summary>
    [DataContract]
    public partial class PostBackSchema :  IEquatable<PostBackSchema>, IValidatableObject
    {
        /// <summary>
        /// Optional parameter to specify how to authorize against the given postbackurl, can be &#39;form&#39; or &#39;httpbasic&#39;. If form authentication, the username and password for authentication are submitted as form fields &#39;username&#39; and &#39;password&#39;, and the registration data as the form field &#39;data&#39;. If httpbasic authentication is used, the username and password are placed in the standard Authorization HTTP header, and the registration data is the body of the message (sent as text/xml content type). This field is set to &#39;form&#39; by default.
        /// </summary>
        /// <value>Optional parameter to specify how to authorize against the given postbackurl, can be &#39;form&#39; or &#39;httpbasic&#39;. If form authentication, the username and password for authentication are submitted as form fields &#39;username&#39; and &#39;password&#39;, and the registration data as the form field &#39;data&#39;. If httpbasic authentication is used, the username and password are placed in the standard Authorization HTTP header, and the registration data is the body of the message (sent as text/xml content type). This field is set to &#39;form&#39; by default.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthTypeEnum
        {
            
            /// <summary>
            /// Enum UNDEFINED for value: UNDEFINED
            /// </summary>
            [EnumMember(Value = "UNDEFINED")]
            UNDEFINED = 1,
            
            /// <summary>
            /// Enum FORM for value: FORM
            /// </summary>
            [EnumMember(Value = "FORM")]
            FORM = 2,
            
            /// <summary>
            /// Enum HTTPBASIC for value: HTTPBASIC
            /// </summary>
            [EnumMember(Value = "HTTPBASIC")]
            HTTPBASIC = 3
        }

        /// <summary>
        /// Optional parameter to specify how to authorize against the given postbackurl, can be &#39;form&#39; or &#39;httpbasic&#39;. If form authentication, the username and password for authentication are submitted as form fields &#39;username&#39; and &#39;password&#39;, and the registration data as the form field &#39;data&#39;. If httpbasic authentication is used, the username and password are placed in the standard Authorization HTTP header, and the registration data is the body of the message (sent as text/xml content type). This field is set to &#39;form&#39; by default.
        /// </summary>
        /// <value>Optional parameter to specify how to authorize against the given postbackurl, can be &#39;form&#39; or &#39;httpbasic&#39;. If form authentication, the username and password for authentication are submitted as form fields &#39;username&#39; and &#39;password&#39;, and the registration data as the form field &#39;data&#39;. If httpbasic authentication is used, the username and password are placed in the standard Authorization HTTP header, and the registration data is the body of the message (sent as text/xml content type). This field is set to &#39;form&#39; by default.</value>
        [DataMember(Name="authType", EmitDefaultValue=false)]
        public AuthTypeEnum? AuthType { get; set; }
        /// <summary>
        /// This parameter allows you to specify a level of detail in the information that is posted back while the course is being taken. It may be one of three values: &#39;course&#39; (course summary), &#39;activity&#39; (activity summary, or &#39;full&#39; (full detail), and is set to &#39;course&#39; by default. The information will be posted as xml, and the format of that xml is specified below under the method &#39;getRegistrationResult&#39;
        /// </summary>
        /// <value>This parameter allows you to specify a level of detail in the information that is posted back while the course is being taken. It may be one of three values: &#39;course&#39; (course summary), &#39;activity&#39; (activity summary, or &#39;full&#39; (full detail), and is set to &#39;course&#39; by default. The information will be posted as xml, and the format of that xml is specified below under the method &#39;getRegistrationResult&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultsFormatEnum
        {
            
            /// <summary>
            /// Enum UNDEFINED for value: UNDEFINED
            /// </summary>
            [EnumMember(Value = "UNDEFINED")]
            UNDEFINED = 1,
            
            /// <summary>
            /// Enum COURSE for value: COURSE
            /// </summary>
            [EnumMember(Value = "COURSE")]
            COURSE = 2,
            
            /// <summary>
            /// Enum ACTIVITY for value: ACTIVITY
            /// </summary>
            [EnumMember(Value = "ACTIVITY")]
            ACTIVITY = 3,
            
            /// <summary>
            /// Enum FULL for value: FULL
            /// </summary>
            [EnumMember(Value = "FULL")]
            FULL = 4
        }

        /// <summary>
        /// This parameter allows you to specify a level of detail in the information that is posted back while the course is being taken. It may be one of three values: &#39;course&#39; (course summary), &#39;activity&#39; (activity summary, or &#39;full&#39; (full detail), and is set to &#39;course&#39; by default. The information will be posted as xml, and the format of that xml is specified below under the method &#39;getRegistrationResult&#39;
        /// </summary>
        /// <value>This parameter allows you to specify a level of detail in the information that is posted back while the course is being taken. It may be one of three values: &#39;course&#39; (course summary), &#39;activity&#39; (activity summary, or &#39;full&#39; (full detail), and is set to &#39;course&#39; by default. The information will be posted as xml, and the format of that xml is specified below under the method &#39;getRegistrationResult&#39;</value>
        [DataMember(Name="resultsFormat", EmitDefaultValue=false)]
        public ResultsFormatEnum? ResultsFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostBackSchema" /> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="authType">Optional parameter to specify how to authorize against the given postbackurl, can be &#39;form&#39; or &#39;httpbasic&#39;. If form authentication, the username and password for authentication are submitted as form fields &#39;username&#39; and &#39;password&#39;, and the registration data as the form field &#39;data&#39;. If httpbasic authentication is used, the username and password are placed in the standard Authorization HTTP header, and the registration data is the body of the message (sent as text/xml content type). This field is set to &#39;form&#39; by default. (default to AuthTypeEnum.UNDEFINED).</param>
        /// <param name="userName">The user name to be used in authorizing the postback of data to the URL specified by postback url..</param>
        /// <param name="password">The password to be used in authorizing the postback of data to the URL specified by postback url..</param>
        /// <param name="resultsFormat">This parameter allows you to specify a level of detail in the information that is posted back while the course is being taken. It may be one of three values: &#39;course&#39; (course summary), &#39;activity&#39; (activity summary, or &#39;full&#39; (full detail), and is set to &#39;course&#39; by default. The information will be posted as xml, and the format of that xml is specified below under the method &#39;getRegistrationResult&#39; (default to ResultsFormatEnum.UNDEFINED).</param>
        /// <param name="legacy">This paramenter is ONLY used for backwards compatibility with XML postback implementations.  You probably shouldn&#39;t need to use this unless you&#39;re currently transitioning from the V1 api to the V2 api and already have existing XML postback logic in your application, but have not yet built out JSON postback logic.  If a registration is created with the V2 api we will assume that you&#39;re expecting JSON results unless otherwise specified. .</param>
        public PostBackSchema(string url = default(string), AuthTypeEnum? authType = AuthTypeEnum.UNDEFINED, string userName = default(string), string password = default(string), ResultsFormatEnum? resultsFormat = ResultsFormatEnum.UNDEFINED, bool? legacy = default(bool?))
        {
            this.Url = url;
            // use default value if no "authType" provided
            if (authType == null)
            {
                this.AuthType = AuthTypeEnum.UNDEFINED;
            }
            else
            {
                this.AuthType = authType;
            }
            this.UserName = userName;
            this.Password = password;
            // use default value if no "resultsFormat" provided
            if (resultsFormat == null)
            {
                this.ResultsFormat = ResultsFormatEnum.UNDEFINED;
            }
            else
            {
                this.ResultsFormat = resultsFormat;
            }
            this.Legacy = legacy;
        }
        
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }


        /// <summary>
        /// The user name to be used in authorizing the postback of data to the URL specified by postback url.
        /// </summary>
        /// <value>The user name to be used in authorizing the postback of data to the URL specified by postback url.</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// The password to be used in authorizing the postback of data to the URL specified by postback url.
        /// </summary>
        /// <value>The password to be used in authorizing the postback of data to the URL specified by postback url.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }


        /// <summary>
        /// This paramenter is ONLY used for backwards compatibility with XML postback implementations.  You probably shouldn&#39;t need to use this unless you&#39;re currently transitioning from the V1 api to the V2 api and already have existing XML postback logic in your application, but have not yet built out JSON postback logic.  If a registration is created with the V2 api we will assume that you&#39;re expecting JSON results unless otherwise specified. 
        /// </summary>
        /// <value>This paramenter is ONLY used for backwards compatibility with XML postback implementations.  You probably shouldn&#39;t need to use this unless you&#39;re currently transitioning from the V1 api to the V2 api and already have existing XML postback logic in your application, but have not yet built out JSON postback logic.  If a registration is created with the V2 api we will assume that you&#39;re expecting JSON results unless otherwise specified. </value>
        [DataMember(Name="legacy", EmitDefaultValue=false)]
        public bool? Legacy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostBackSchema {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  AuthType: ").Append(AuthType).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ResultsFormat: ").Append(ResultsFormat).Append("\n");
            sb.Append("  Legacy: ").Append(Legacy).Append("\n");
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
            return this.Equals(input as PostBackSchema);
        }

        /// <summary>
        /// Returns true if PostBackSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of PostBackSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostBackSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.AuthType == input.AuthType ||
                    (this.AuthType != null &&
                    this.AuthType.Equals(input.AuthType))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.ResultsFormat == input.ResultsFormat ||
                    (this.ResultsFormat != null &&
                    this.ResultsFormat.Equals(input.ResultsFormat))
                ) && 
                (
                    this.Legacy == input.Legacy ||
                    (this.Legacy != null &&
                    this.Legacy.Equals(input.Legacy))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.AuthType != null)
                    hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.ResultsFormat != null)
                    hashCode = hashCode * 59 + this.ResultsFormat.GetHashCode();
                if (this.Legacy != null)
                    hashCode = hashCode * 59 + this.Legacy.GetHashCode();
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
