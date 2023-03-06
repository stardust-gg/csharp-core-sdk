/* 
 * Stardust API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2023-02-22T22:32:07Z
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = Stardust.CoreSDK.Client.SwaggerDateConverter;

namespace Stardust.CoreSDK.Model
{
    /// <summary>
    /// This is the data output json model
    /// </summary>
    [DataContract]
        public partial class SDPlayerGetResponse : Dictionary<String, string>,  IEquatable<SDPlayerGetResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SDPlayerGetResponse" /> class.
        /// </summary>
        public SDPlayerGetResponse() : base()
        {
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SDPlayerGetResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as SDPlayerGetResponse);
        }

        /// <summary>
        /// Returns true if SDPlayerGetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SDPlayerGetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SDPlayerGetResponse input)
        {
            if (input == null)
                return false;

            return base.Equals(input);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                return hashCode;
            }
        }
    }
}
