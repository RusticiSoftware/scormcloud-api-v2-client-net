/* 
 * SCORM Cloud Rest API
 *
 * REST API used for SCORM Cloud integrations.
 *
 * OpenAPI spec version: 2.0 beta
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Com.RusticiSoftware.Cloud.V2.Model
{
    /// <summary>
    /// PostBackSchema
    /// </summary>
    [DataContract]
    public partial class PostBackSchema :  IEquatable<PostBackSchema>
    {
        /// <summary>
        /// Optional parameter to specify how to authorize against the given postbackurl, can be 'form' or 'httpbasic'. If form authentication, the username and password for authentication are submitted as form fields 'username' and 'password', and the registration data as the form field 'data'. If httpbasic authentication is used, the username and password are placed in the standard Authorization HTTP header, and the registration data is the body of the message (sent as text/xml content type). This field is set to 'form' by default.
        /// </summary>
        /// <value>Optional parameter to specify how to authorize against the given postbackurl, can be 'form' or 'httpbasic'. If form authentication, the username and password for authentication are submitted as form fields 'username' and 'password', and the registration data as the form field 'data'. If httpbasic authentication is used, the username and password are placed in the standard Authorization HTTP header, and the registration data is the body of the message (sent as text/xml content type). This field is set to 'form' by default.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthTypeEnum
        {
            
            /// <summary>
            /// Enum UNDEFINED for "UNDEFINED"
            /// </summary>
            [EnumMember(Value = "UNDEFINED")]
            UNDEFINED,
            
            /// <summary>
            /// Enum FORM for "FORM"
            /// </summary>
            [EnumMember(Value = "FORM")]
            FORM,
            
            /// <summary>
            /// Enum HTTPBASIC for "HTTPBASIC"
            /// </summary>
            [EnumMember(Value = "HTTPBASIC")]
            HTTPBASIC
        }

        /// <summary>
        /// This parameter allows you to specify a level of detail in the information that is posted back while the course is being taken. It may be one of three values: 'course' (course summary), 'activity' (activity summary, or 'full' (full detail), and is set to 'course' by default. The information will be posted as xml, and the format of that xml is specified below under the method 'getRegistrationResult'
        /// </summary>
        /// <value>This parameter allows you to specify a level of detail in the information that is posted back while the course is being taken. It may be one of three values: 'course' (course summary), 'activity' (activity summary, or 'full' (full detail), and is set to 'course' by default. The information will be posted as xml, and the format of that xml is specified below under the method 'getRegistrationResult'</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultsFormatEnum
        {
            
            /// <summary>
            /// Enum COURSE for "COURSE"
            /// </summary>
            [EnumMember(Value = "COURSE")]
            COURSE,
            
            /// <summary>
            /// Enum ACTIVITY for "ACTIVITY"
            /// </summary>
            [EnumMember(Value = "ACTIVITY")]
            ACTIVITY,
            
            /// <summary>
            /// Enum FULL for "FULL"
            /// </summary>
            [EnumMember(Value = "FULL")]
            FULL
        }

        /// <summary>
        /// Optional parameter to specify how to authorize against the given postbackurl, can be 'form' or 'httpbasic'. If form authentication, the username and password for authentication are submitted as form fields 'username' and 'password', and the registration data as the form field 'data'. If httpbasic authentication is used, the username and password are placed in the standard Authorization HTTP header, and the registration data is the body of the message (sent as text/xml content type). This field is set to 'form' by default.
        /// </summary>
        /// <value>Optional parameter to specify how to authorize against the given postbackurl, can be 'form' or 'httpbasic'. If form authentication, the username and password for authentication are submitted as form fields 'username' and 'password', and the registration data as the form field 'data'. If httpbasic authentication is used, the username and password are placed in the standard Authorization HTTP header, and the registration data is the body of the message (sent as text/xml content type). This field is set to 'form' by default.</value>
        [DataMember(Name="authType", EmitDefaultValue=false)]
        public AuthTypeEnum? AuthType { get; set; }
        /// <summary>
        /// This parameter allows you to specify a level of detail in the information that is posted back while the course is being taken. It may be one of three values: 'course' (course summary), 'activity' (activity summary, or 'full' (full detail), and is set to 'course' by default. The information will be posted as xml, and the format of that xml is specified below under the method 'getRegistrationResult'
        /// </summary>
        /// <value>This parameter allows you to specify a level of detail in the information that is posted back while the course is being taken. It may be one of three values: 'course' (course summary), 'activity' (activity summary, or 'full' (full detail), and is set to 'course' by default. The information will be posted as xml, and the format of that xml is specified below under the method 'getRegistrationResult'</value>
        [DataMember(Name="resultsFormat", EmitDefaultValue=false)]
        public ResultsFormatEnum? ResultsFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostBackSchema" /> class.
        /// </summary>
        /// <param name="Url">Url.</param>
        /// <param name="AuthType">Optional parameter to specify how to authorize against the given postbackurl, can be &#39;form&#39; or &#39;httpbasic&#39;. If form authentication, the username and password for authentication are submitted as form fields &#39;username&#39; and &#39;password&#39;, and the registration data as the form field &#39;data&#39;. If httpbasic authentication is used, the username and password are placed in the standard Authorization HTTP header, and the registration data is the body of the message (sent as text/xml content type). This field is set to &#39;form&#39; by default. (default to &quot;UNDEFINED&quot;).</param>
        /// <param name="UserName">The user name to be used in authorizing the postback of data to the URL specified by postback url..</param>
        /// <param name="Password">The password to be used in authorizing the postback of data to the URL specified by postback url..</param>
        /// <param name="ResultsFormat">This parameter allows you to specify a level of detail in the information that is posted back while the course is being taken. It may be one of three values: &#39;course&#39; (course summary), &#39;activity&#39; (activity summary, or &#39;full&#39; (full detail), and is set to &#39;course&#39; by default. The information will be posted as xml, and the format of that xml is specified below under the method &#39;getRegistrationResult&#39; (default to &quot;COURSE&quot;).</param>
        public PostBackSchema(string Url = null, AuthTypeEnum? AuthType = null, string UserName = null, string Password = null, ResultsFormatEnum? ResultsFormat = null)
        {
            this.Url = Url;
            // use default value if no "AuthType" provided
            if (AuthType == null)
            {
                this.AuthType = "UNDEFINED";
            }
            else
            {
                this.AuthType = AuthType;
            }
            this.UserName = UserName;
            this.Password = Password;
            // use default value if no "ResultsFormat" provided
            if (ResultsFormat == null)
            {
                this.ResultsFormat = "COURSE";
            }
            else
            {
                this.ResultsFormat = ResultsFormat;
            }
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
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PostBackSchema);
        }

        /// <summary>
        /// Returns true if PostBackSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of PostBackSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostBackSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.AuthType == other.AuthType ||
                    this.AuthType != null &&
                    this.AuthType.Equals(other.AuthType)
                ) && 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.ResultsFormat == other.ResultsFormat ||
                    this.ResultsFormat != null &&
                    this.ResultsFormat.Equals(other.ResultsFormat)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.AuthType != null)
                    hash = hash * 59 + this.AuthType.GetHashCode();
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.ResultsFormat != null)
                    hash = hash * 59 + this.ResultsFormat.GetHashCode();
                return hash;
            }
        }
    }

}