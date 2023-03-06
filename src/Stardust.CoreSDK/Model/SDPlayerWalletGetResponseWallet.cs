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
    /// SDPlayerWalletGetResponseWallet
    /// </summary>
    [DataContract]
        public partial class SDPlayerWalletGetResponseWallet :  IEquatable<SDPlayerWalletGetResponseWallet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SDPlayerWalletGetResponseWallet" /> class.
        /// </summary>
        /// <param name="blockchain">The name of the blockchain (required).</param>
        /// <param name="address">The players blockchain Address (required).</param>
        /// <param name="monies">An array of the players balances on a given blockchain.</param>
        public SDPlayerWalletGetResponseWallet(string blockchain = default(string), string address = default(string), List<SDPlayerWalletGetResponseMonies> monies = default(List<SDPlayerWalletGetResponseMonies>))
        {
            // to ensure "blockchain" is required (not null)
            if (blockchain == null)
            {
                throw new InvalidDataException("blockchain is a required property for SDPlayerWalletGetResponseWallet and cannot be null");
            }
            else
            {
                this.Blockchain = blockchain;
            }
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for SDPlayerWalletGetResponseWallet and cannot be null");
            }
            else
            {
                this.Address = address;
            }
            this.Monies = monies;
        }
        
        /// <summary>
        /// The name of the blockchain
        /// </summary>
        /// <value>The name of the blockchain</value>
        [DataMember(Name="blockchain", EmitDefaultValue=false)]
        public string Blockchain { get; set; }

        /// <summary>
        /// The players blockchain Address
        /// </summary>
        /// <value>The players blockchain Address</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// An array of the players balances on a given blockchain
        /// </summary>
        /// <value>An array of the players balances on a given blockchain</value>
        [DataMember(Name="monies", EmitDefaultValue=false)]
        public List<SDPlayerWalletGetResponseMonies> Monies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SDPlayerWalletGetResponseWallet {\n");
            sb.Append("  Blockchain: ").Append(Blockchain).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Monies: ").Append(Monies).Append("\n");
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
            return this.Equals(input as SDPlayerWalletGetResponseWallet);
        }

        /// <summary>
        /// Returns true if SDPlayerWalletGetResponseWallet instances are equal
        /// </summary>
        /// <param name="input">Instance of SDPlayerWalletGetResponseWallet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SDPlayerWalletGetResponseWallet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Blockchain == input.Blockchain ||
                    (this.Blockchain != null &&
                    this.Blockchain.Equals(input.Blockchain))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Monies == input.Monies ||
                    this.Monies != null &&
                    input.Monies != null &&
                    this.Monies.SequenceEqual(input.Monies)
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
                if (this.Blockchain != null)
                    hashCode = hashCode * 59 + this.Blockchain.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Monies != null)
                    hashCode = hashCode * 59 + this.Monies.GetHashCode();
                return hashCode;
            }
        }
    }
}
