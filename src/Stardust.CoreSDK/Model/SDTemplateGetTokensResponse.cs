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
    /// Token data
    /// </summary>
    [DataContract]
        public partial class SDTemplateGetTokensResponse :  IEquatable<SDTemplateGetTokensResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SDTemplateGetTokensResponse" /> class.
        /// </summary>
        /// <param name="token">token (required).</param>
        /// <param name="player">player (required).</param>
        public SDTemplateGetTokensResponse(SDTemplateGetTokensResponseToken token = default(SDTemplateGetTokensResponseToken), SDTemplateGetTokensResponsePlayer player = default(SDTemplateGetTokensResponsePlayer))
        {
            // to ensure "token" is required (not null)
            if (token == null)
            {
                throw new InvalidDataException("token is a required property for SDTemplateGetTokensResponse and cannot be null");
            }
            else
            {
                this.Token = token;
            }
            // to ensure "player" is required (not null)
            if (player == null)
            {
                throw new InvalidDataException("player is a required property for SDTemplateGetTokensResponse and cannot be null");
            }
            else
            {
                this.Player = player;
            }
        }
        
        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public SDTemplateGetTokensResponseToken Token { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name="player", EmitDefaultValue=false)]
        public SDTemplateGetTokensResponsePlayer Player { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SDTemplateGetTokensResponse {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
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
            return this.Equals(input as SDTemplateGetTokensResponse);
        }

        /// <summary>
        /// Returns true if SDTemplateGetTokensResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SDTemplateGetTokensResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SDTemplateGetTokensResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.Player == input.Player ||
                    (this.Player != null &&
                    this.Player.Equals(input.Player))
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
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.Player != null)
                    hashCode = hashCode * 59 + this.Player.GetHashCode();
                return hashCode;
            }
        }
    }
}
