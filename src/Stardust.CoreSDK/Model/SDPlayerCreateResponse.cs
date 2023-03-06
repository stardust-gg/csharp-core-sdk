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
    /// The id of the player created
    /// </summary>
    [DataContract]
        public partial class SDPlayerCreateResponse :  IEquatable<SDPlayerCreateResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SDPlayerCreateResponse" /> class.
        /// </summary>
        /// <param name="playerId">Player&#x27;s ID in UUID format (required).</param>
        public SDPlayerCreateResponse(string playerId = default(string))
        {
            // to ensure "playerId" is required (not null)
            if (playerId == null)
            {
                throw new InvalidDataException("playerId is a required property for SDPlayerCreateResponse and cannot be null");
            }
            else
            {
                this.PlayerId = playerId;
            }
        }
        
        /// <summary>
        /// Player&#x27;s ID in UUID format
        /// </summary>
        /// <value>Player&#x27;s ID in UUID format</value>
        [DataMember(Name="playerId", EmitDefaultValue=false)]
        public string PlayerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SDPlayerCreateResponse {\n");
            sb.Append("  PlayerId: ").Append(PlayerId).Append("\n");
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
            return this.Equals(input as SDPlayerCreateResponse);
        }

        /// <summary>
        /// Returns true if SDPlayerCreateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SDPlayerCreateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SDPlayerCreateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlayerId == input.PlayerId ||
                    (this.PlayerId != null &&
                    this.PlayerId.Equals(input.PlayerId))
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
                if (this.PlayerId != null)
                    hashCode = hashCode * 59 + this.PlayerId.GetHashCode();
                return hashCode;
            }
        }
    }
}