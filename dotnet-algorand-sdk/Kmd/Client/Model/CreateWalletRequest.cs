/* 
 * for KMD HTTP API
 *
 * API for KMD (Key Management Daemon)
 *
 * OpenAPI spec version: 0.0.1
 * Contact: contact@algorand.com
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
using SwaggerDateConverter = Algorand.Kmd.Client.SwaggerDateConverter;

namespace Algorand.Kmd.Client.Model
{
    /// <summary>
    /// APIV1POSTWalletRequest is the request for &#x60;POST /v1/wallet&#x60;
    /// </summary>
    [DataContract]
        public partial class CreateWalletRequest :  IEquatable<CreateWalletRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWalletRequest" /> class.
        /// </summary>
        /// <param name="masterDerivationKey">masterDerivationKey.</param>
        /// <param name="walletDriverName">walletDriverName.</param>
        /// <param name="walletName">walletName.</param>
        /// <param name="walletPassword">walletPassword.</param>
        public CreateWalletRequest(MasterDerivationKey masterDerivationKey = default(MasterDerivationKey), string walletDriverName = default(string), string walletName = default(string), string walletPassword = default(string))
        {
            this.MasterDerivationKey = masterDerivationKey;
            this.WalletDriverName = walletDriverName;
            this.WalletName = walletName;
            this.WalletPassword = walletPassword;
        }
        
        /// <summary>
        /// Gets or Sets MasterDerivationKey
        /// </summary>
        [DataMember(Name="master_derivation_key", EmitDefaultValue=false)]
        public MasterDerivationKey MasterDerivationKey { get; set; }

        /// <summary>
        /// Gets or Sets WalletDriverName
        /// </summary>
        [DataMember(Name="wallet_driver_name", EmitDefaultValue=false)]
        public string WalletDriverName { get; set; }

        /// <summary>
        /// Gets or Sets WalletName
        /// </summary>
        [DataMember(Name="wallet_name", EmitDefaultValue=false)]
        public string WalletName { get; set; }

        /// <summary>
        /// Gets or Sets WalletPassword
        /// </summary>
        [DataMember(Name="wallet_password", EmitDefaultValue=false)]
        public string WalletPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWalletRequest {\n");
            sb.Append("  MasterDerivationKey: ").Append(MasterDerivationKey).Append("\n");
            sb.Append("  WalletDriverName: ").Append(WalletDriverName).Append("\n");
            sb.Append("  WalletName: ").Append(WalletName).Append("\n");
            sb.Append("  WalletPassword: ").Append(WalletPassword).Append("\n");
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
            return this.Equals(input as CreateWalletRequest);
        }

        /// <summary>
        /// Returns true if CreateWalletRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWalletRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWalletRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MasterDerivationKey == input.MasterDerivationKey ||
                    (this.MasterDerivationKey != null &&
                    this.MasterDerivationKey.Equals(input.MasterDerivationKey))
                ) && 
                (
                    this.WalletDriverName == input.WalletDriverName ||
                    (this.WalletDriverName != null &&
                    this.WalletDriverName.Equals(input.WalletDriverName))
                ) && 
                (
                    this.WalletName == input.WalletName ||
                    (this.WalletName != null &&
                    this.WalletName.Equals(input.WalletName))
                ) && 
                (
                    this.WalletPassword == input.WalletPassword ||
                    (this.WalletPassword != null &&
                    this.WalletPassword.Equals(input.WalletPassword))
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
                if (this.MasterDerivationKey != null)
                    hashCode = hashCode * 59 + this.MasterDerivationKey.GetHashCode();
                if (this.WalletDriverName != null)
                    hashCode = hashCode * 59 + this.WalletDriverName.GetHashCode();
                if (this.WalletName != null)
                    hashCode = hashCode * 59 + this.WalletName.GetHashCode();
                if (this.WalletPassword != null)
                    hashCode = hashCode * 59 + this.WalletPassword.GetHashCode();
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