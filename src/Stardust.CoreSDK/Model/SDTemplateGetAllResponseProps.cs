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
    /// SDTemplateGetAllResponseProps
    /// </summary>
    [DataContract]
        public partial class SDTemplateGetAllResponseProps :  IEquatable<SDTemplateGetAllResponseProps>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SDTemplateGetAllResponseProps" /> class.
        /// </summary>
        /// <param name="immutable">immutable (required).</param>
        /// <param name="mutable">mutable (required).</param>
        /// <param name="mutable">mutable (required).</param>
        public SDTemplateGetAllResponseProps(Object immutable = default(Object), Object mutable = default(Object), Object mutable = default(Object))
        {
            // to ensure "immutable" is required (not null)
            if (immutable == null)
            {
                throw new InvalidDataException("immutable is a required property for SDTemplateGetAllResponseProps and cannot be null");
            }
            else
            {
                this.Immutable = immutable;
            }
            // to ensure "mutable" is required (not null)
            if (mutable == null)
            {
                throw new InvalidDataException("mutable is a required property for SDTemplateGetAllResponseProps and cannot be null");
            }
            else
            {
                this.Mutable = mutable;
            }
            // to ensure "mutable" is required (not null)
            if (mutable == null)
            {
                throw new InvalidDataException("mutable is a required property for SDTemplateGetAllResponseProps and cannot be null");
            }
            else
            {
                this.Mutable = mutable;
            }
        }
        
        /// <summary>
        /// Gets or Sets Immutable
        /// </summary>
        [DataMember(Name="immutable", EmitDefaultValue=false)]
        public Object Immutable { get; set; }

        /// <summary>
        /// Gets or Sets Mutable
        /// </summary>
        [DataMember(Name="mutable", EmitDefaultValue=false)]
        public Object Mutable { get; set; }

        /// <summary>
        /// Gets or Sets Mutable
        /// </summary>
        [DataMember(Name="$mutable", EmitDefaultValue=false)]
        public Object Mutable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SDTemplateGetAllResponseProps {\n");
            sb.Append("  Immutable: ").Append(Immutable).Append("\n");
            sb.Append("  Mutable: ").Append(Mutable).Append("\n");
            sb.Append("  Mutable: ").Append(Mutable).Append("\n");
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
            return this.Equals(input as SDTemplateGetAllResponseProps);
        }

        /// <summary>
        /// Returns true if SDTemplateGetAllResponseProps instances are equal
        /// </summary>
        /// <param name="input">Instance of SDTemplateGetAllResponseProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SDTemplateGetAllResponseProps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Immutable == input.Immutable ||
                    (this.Immutable != null &&
                    this.Immutable.Equals(input.Immutable))
                ) && 
                (
                    this.Mutable == input.Mutable ||
                    (this.Mutable != null &&
                    this.Mutable.Equals(input.Mutable))
                ) && 
                (
                    this.Mutable == input.Mutable ||
                    (this.Mutable != null &&
                    this.Mutable.Equals(input.Mutable))
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
                if (this.Immutable != null)
                    hashCode = hashCode * 59 + this.Immutable.GetHashCode();
                if (this.Mutable != null)
                    hashCode = hashCode * 59 + this.Mutable.GetHashCode();
                if (this.Mutable != null)
                    hashCode = hashCode * 59 + this.Mutable.GetHashCode();
                return hashCode;
            }
        }
    }
}
