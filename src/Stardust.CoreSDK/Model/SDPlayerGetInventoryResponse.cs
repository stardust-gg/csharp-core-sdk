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
        public partial class SDPlayerGetInventoryResponse :  IEquatable<SDPlayerGetInventoryResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SDPlayerGetInventoryResponse" /> class.
        /// </summary>
        /// <param name="tokenId">Token ID (required).</param>
        /// <param name="amount">u64 Number as String, min: 0, max: 9223372036854775807 (required).</param>
        public SDPlayerGetInventoryResponse(int? tokenId = default(int?), string amount = default(string))
        {
            // to ensure "tokenId" is required (not null)
            if (tokenId == null)
            {
                throw new InvalidDataException("tokenId is a required property for SDPlayerGetInventoryResponse and cannot be null");
            }
            else
            {
                this.TokenId = tokenId;
            }
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for SDPlayerGetInventoryResponse and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
        }
        
        /// <summary>
        /// Token ID
        /// </summary>
        /// <value>Token ID</value>
        [DataMember(Name="tokenId", EmitDefaultValue=false)]
        public int? TokenId { get; set; }

        /// <summary>
        /// u64 Number as String, min: 0, max: 9223372036854775807
        /// </summary>
        /// <value>u64 Number as String, min: 0, max: 9223372036854775807</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SDPlayerGetInventoryResponse {\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as SDPlayerGetInventoryResponse);
        }

        /// <summary>
        /// Returns true if SDPlayerGetInventoryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SDPlayerGetInventoryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SDPlayerGetInventoryResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                if (this.TokenId != null)
                    hashCode = hashCode * 59 + this.TokenId.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                return hashCode;
            }
        }
    }
}
