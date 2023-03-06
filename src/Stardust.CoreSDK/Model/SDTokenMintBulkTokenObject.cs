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
    /// SDTokenMintBulkTokenObject
    /// </summary>
    [DataContract]
        public partial class SDTokenMintBulkTokenObject :  IEquatable<SDTokenMintBulkTokenObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SDTokenMintBulkTokenObject" /> class.
        /// </summary>
        /// <param name="templateId">Specifies which Template you are creating an instance of (ex. 3) (required).</param>
        /// <param name="amount">u64 Number as String, min: 0, max: 9223372036854775807 (ex. \&quot;6\&quot;) (required).</param>
        /// <param name="props">props.</param>
        /// <param name="publicMetadata">Returned to marketplaces as token metadata.</param>
        public SDTokenMintBulkTokenObject(int? templateId = default(int?), string amount = default(string), SDTokenMintBulkTokenObjectProps props = default(SDTokenMintBulkTokenObjectProps), Object publicMetadata = default(Object))
        {
            // to ensure "templateId" is required (not null)
            if (templateId == null)
            {
                throw new InvalidDataException("templateId is a required property for SDTokenMintBulkTokenObject and cannot be null");
            }
            else
            {
                this.TemplateId = templateId;
            }
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for SDTokenMintBulkTokenObject and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            this.Props = props;
            this.PublicMetadata = publicMetadata;
        }
        
        /// <summary>
        /// Specifies which Template you are creating an instance of (ex. 3)
        /// </summary>
        /// <value>Specifies which Template you are creating an instance of (ex. 3)</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public int? TemplateId { get; set; }

        /// <summary>
        /// u64 Number as String, min: 0, max: 9223372036854775807 (ex. \&quot;6\&quot;)
        /// </summary>
        /// <value>u64 Number as String, min: 0, max: 9223372036854775807 (ex. \&quot;6\&quot;)</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets Props
        /// </summary>
        [DataMember(Name="props", EmitDefaultValue=false)]
        public SDTokenMintBulkTokenObjectProps Props { get; set; }

        /// <summary>
        /// Returned to marketplaces as token metadata
        /// </summary>
        /// <value>Returned to marketplaces as token metadata</value>
        [DataMember(Name="publicMetadata", EmitDefaultValue=false)]
        public Object PublicMetadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SDTokenMintBulkTokenObject {\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Props: ").Append(Props).Append("\n");
            sb.Append("  PublicMetadata: ").Append(PublicMetadata).Append("\n");
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
            return this.Equals(input as SDTokenMintBulkTokenObject);
        }

        /// <summary>
        /// Returns true if SDTokenMintBulkTokenObject instances are equal
        /// </summary>
        /// <param name="input">Instance of SDTokenMintBulkTokenObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SDTokenMintBulkTokenObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Props == input.Props ||
                    (this.Props != null &&
                    this.Props.Equals(input.Props))
                ) && 
                (
                    this.PublicMetadata == input.PublicMetadata ||
                    (this.PublicMetadata != null &&
                    this.PublicMetadata.Equals(input.PublicMetadata))
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
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Props != null)
                    hashCode = hashCode * 59 + this.Props.GetHashCode();
                if (this.PublicMetadata != null)
                    hashCode = hashCode * 59 + this.PublicMetadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
