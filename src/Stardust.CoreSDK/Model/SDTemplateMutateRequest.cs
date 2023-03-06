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
    /// SDTemplateMutateRequest
    /// </summary>
    [DataContract]
        public partial class SDTemplateMutateRequest :  IEquatable<SDTemplateMutateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SDTemplateMutateRequest" /> class.
        /// </summary>
        /// <param name="templateId">This is the templateId returned from template/create (ex. 5) (required).</param>
        /// <param name="props">Specifies which properties you want to change (ex. {prop1: 5, prop2: 6, prop3: 7}).</param>
        public SDTemplateMutateRequest(int? templateId = default(int?), Object props = default(Object))
        {
            // to ensure "templateId" is required (not null)
            if (templateId == null)
            {
                throw new InvalidDataException("templateId is a required property for SDTemplateMutateRequest and cannot be null");
            }
            else
            {
                this.TemplateId = templateId;
            }
            this.Props = props;
        }
        
        /// <summary>
        /// This is the templateId returned from template/create (ex. 5)
        /// </summary>
        /// <value>This is the templateId returned from template/create (ex. 5)</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public int? TemplateId { get; set; }

        /// <summary>
        /// Specifies which properties you want to change (ex. {prop1: 5, prop2: 6, prop3: 7})
        /// </summary>
        /// <value>Specifies which properties you want to change (ex. {prop1: 5, prop2: 6, prop3: 7})</value>
        [DataMember(Name="props", EmitDefaultValue=false)]
        public Object Props { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SDTemplateMutateRequest {\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Props: ").Append(Props).Append("\n");
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
            return this.Equals(input as SDTemplateMutateRequest);
        }

        /// <summary>
        /// Returns true if SDTemplateMutateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SDTemplateMutateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SDTemplateMutateRequest input)
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
                    this.Props == input.Props ||
                    (this.Props != null &&
                    this.Props.Equals(input.Props))
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
                if (this.Props != null)
                    hashCode = hashCode * 59 + this.Props.GetHashCode();
                return hashCode;
            }
        }
    }
}