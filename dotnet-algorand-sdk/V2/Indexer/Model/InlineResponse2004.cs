/* 
 * Indexer
 *
 * Algorand ledger analytics API.
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
using SwaggerDateConverter = Algorand.V2.Indexer.Client.SwaggerDateConverter;

namespace Algorand.V2.Indexer.Model
{
    /// <summary>
    /// InlineResponse2004
    /// </summary>
    [DataContract]
        public partial class InlineResponse2004 :  IEquatable<InlineResponse2004>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2004" /> class.
        /// </summary>
        /// <param name="application">application.</param>
        /// <param name="currentRound">Round at which the results were computed. (required).</param>
        public InlineResponse2004(Application application = default(Application), int? currentRound = default(int?))
        {
            // to ensure "currentRound" is required (not null)
            if (currentRound == null)
            {
                throw new InvalidDataException("currentRound is a required property for InlineResponse2004 and cannot be null");
            }
            else
            {
                this.CurrentRound = currentRound;
            }
            this.Application = application;
        }
        
        /// <summary>
        /// Gets or Sets Application
        /// </summary>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public Application Application { get; set; }

        /// <summary>
        /// Round at which the results were computed.
        /// </summary>
        /// <value>Round at which the results were computed.</value>
        [DataMember(Name="current-round", EmitDefaultValue=false)]
        public int? CurrentRound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2004 {\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  CurrentRound: ").Append(CurrentRound).Append("\n");
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
            return this.Equals(input as InlineResponse2004);
        }

        /// <summary>
        /// Returns true if InlineResponse2004 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2004 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2004 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Application == input.Application ||
                    (this.Application != null &&
                    this.Application.Equals(input.Application))
                ) && 
                (
                    this.CurrentRound == input.CurrentRound ||
                    (this.CurrentRound != null &&
                    this.CurrentRound.Equals(input.CurrentRound))
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
                if (this.Application != null)
                    hashCode = hashCode * 59 + this.Application.GetHashCode();
                if (this.CurrentRound != null)
                    hashCode = hashCode * 59 + this.CurrentRound.GetHashCode();
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