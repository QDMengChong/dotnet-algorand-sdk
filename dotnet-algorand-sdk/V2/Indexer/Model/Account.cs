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
    /// Account information at a given round.  Definition: data/basics/userBalance.go : AccountData 
    /// </summary>
    [DataContract]
        public partial class Account :  IEquatable<Account>, IValidatableObject
    {
        /// <summary>
        /// Indicates what type of signature is used by this account, must be one of: * sig * msig * lsig
        /// </summary>
        /// <value>Indicates what type of signature is used by this account, must be one of: * sig * msig * lsig</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SigTypeEnum
        {
            /// <summary>
            /// Enum Sig for value: sig
            /// </summary>
            [EnumMember(Value = "sig")]
            Sig = 1,
            /// <summary>
            /// Enum Msig for value: msig
            /// </summary>
            [EnumMember(Value = "msig")]
            Msig = 2,
            /// <summary>
            /// Enum Lsig for value: lsig
            /// </summary>
            [EnumMember(Value = "lsig")]
            Lsig = 3        }
        /// <summary>
        /// Indicates what type of signature is used by this account, must be one of: * sig * msig * lsig
        /// </summary>
        /// <value>Indicates what type of signature is used by this account, must be one of: * sig * msig * lsig</value>
        [DataMember(Name="sig-type", EmitDefaultValue=false)]
        public SigTypeEnum? SigType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="address">the account public key (required).</param>
        /// <param name="amount">\\[algo\\] total number of MicroAlgos in the account (required).</param>
        /// <param name="amountWithoutPendingRewards">specifies the amount of MicroAlgos in the account, without the pending rewards. (required).</param>
        /// <param name="appsLocalState">\\[appl\\] applications local data stored in this account.  Note the raw object uses &#x60;map[int] -&gt; AppLocalState&#x60; for this type..</param>
        /// <param name="appsTotalSchema">appsTotalSchema.</param>
        /// <param name="assets">\\[asset\\] assets held by this account.  Note the raw object uses &#x60;map[int] -&gt; AssetHolding&#x60; for this type..</param>
        /// <param name="authAddr">\\[spend\\] the address against which signing should be checked. If empty, the address of the current account is used. This field can be updated in any transaction by setting the RekeyTo field..</param>
        /// <param name="createdApps">\\[appp\\] parameters of applications created by this account including app global data.  Note: the raw account uses &#x60;map[int] -&gt; AppParams&#x60; for this type..</param>
        /// <param name="createdAssets">\\[apar\\] parameters of assets created by this account.  Note: the raw account uses &#x60;map[int] -&gt; Asset&#x60; for this type..</param>
        /// <param name="participation">participation.</param>
        /// <param name="pendingRewards">amount of MicroAlgos of pending rewards in this account. (required).</param>
        /// <param name="rewardBase">\\[ebase\\] used as part of the rewards computation. Only applicable to accounts which are participating..</param>
        /// <param name="rewards">\\[ern\\] total rewards of MicroAlgos the account has received, including pending rewards. (required).</param>
        /// <param name="round">The round for which this information is relevant. (required).</param>
        /// <param name="sigType">Indicates what type of signature is used by this account, must be one of: * sig * msig * lsig.</param>
        /// <param name="status">\\[onl\\] delegation status of the account&#x27;s MicroAlgos * Offline - indicates that the associated account is delegated. *  Online  - indicates that the associated account used as part of the delegation pool. *   NotParticipating - indicates that the associated account is neither a delegator nor a delegate. (required).</param>
        public Account(string address = default(string), int? amount = default(int?), int? amountWithoutPendingRewards = default(int?), List<ApplicationLocalState> appsLocalState = default(List<ApplicationLocalState>), ApplicationStateSchema appsTotalSchema = default(ApplicationStateSchema), List<AssetHolding> assets = default(List<AssetHolding>), string authAddr = default(string), List<Application> createdApps = default(List<Application>), List<Asset> createdAssets = default(List<Asset>), AccountParticipation participation = default(AccountParticipation), int? pendingRewards = default(int?), int? rewardBase = default(int?), int? rewards = default(int?), int? round = default(int?), SigTypeEnum? sigType = default(SigTypeEnum?), string status = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for Account and cannot be null");
            }
            else
            {
                this.Address = address;
            }
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for Account and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "amountWithoutPendingRewards" is required (not null)
            if (amountWithoutPendingRewards == null)
            {
                throw new InvalidDataException("amountWithoutPendingRewards is a required property for Account and cannot be null");
            }
            else
            {
                this.AmountWithoutPendingRewards = amountWithoutPendingRewards;
            }
            // to ensure "pendingRewards" is required (not null)
            if (pendingRewards == null)
            {
                throw new InvalidDataException("pendingRewards is a required property for Account and cannot be null");
            }
            else
            {
                this.PendingRewards = pendingRewards;
            }
            // to ensure "rewards" is required (not null)
            if (rewards == null)
            {
                throw new InvalidDataException("rewards is a required property for Account and cannot be null");
            }
            else
            {
                this.Rewards = rewards;
            }
            // to ensure "round" is required (not null)
            if (round == null)
            {
                throw new InvalidDataException("round is a required property for Account and cannot be null");
            }
            else
            {
                this.Round = round;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for Account and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            this.AppsLocalState = appsLocalState;
            this.AppsTotalSchema = appsTotalSchema;
            this.Assets = assets;
            this.AuthAddr = authAddr;
            this.CreatedApps = createdApps;
            this.CreatedAssets = createdAssets;
            this.Participation = participation;
            this.RewardBase = rewardBase;
            this.SigType = sigType;
        }
        
        /// <summary>
        /// the account public key
        /// </summary>
        /// <value>the account public key</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// \\[algo\\] total number of MicroAlgos in the account
        /// </summary>
        /// <value>\\[algo\\] total number of MicroAlgos in the account</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// specifies the amount of MicroAlgos in the account, without the pending rewards.
        /// </summary>
        /// <value>specifies the amount of MicroAlgos in the account, without the pending rewards.</value>
        [DataMember(Name="amount-without-pending-rewards", EmitDefaultValue=false)]
        public int? AmountWithoutPendingRewards { get; set; }

        /// <summary>
        /// \\[appl\\] applications local data stored in this account.  Note the raw object uses &#x60;map[int] -&gt; AppLocalState&#x60; for this type.
        /// </summary>
        /// <value>\\[appl\\] applications local data stored in this account.  Note the raw object uses &#x60;map[int] -&gt; AppLocalState&#x60; for this type.</value>
        [DataMember(Name="apps-local-state", EmitDefaultValue=false)]
        public List<ApplicationLocalState> AppsLocalState { get; set; }

        /// <summary>
        /// Gets or Sets AppsTotalSchema
        /// </summary>
        [DataMember(Name="apps-total-schema", EmitDefaultValue=false)]
        public ApplicationStateSchema AppsTotalSchema { get; set; }

        /// <summary>
        /// \\[asset\\] assets held by this account.  Note the raw object uses &#x60;map[int] -&gt; AssetHolding&#x60; for this type.
        /// </summary>
        /// <value>\\[asset\\] assets held by this account.  Note the raw object uses &#x60;map[int] -&gt; AssetHolding&#x60; for this type.</value>
        [DataMember(Name="assets", EmitDefaultValue=false)]
        public List<AssetHolding> Assets { get; set; }

        /// <summary>
        /// \\[spend\\] the address against which signing should be checked. If empty, the address of the current account is used. This field can be updated in any transaction by setting the RekeyTo field.
        /// </summary>
        /// <value>\\[spend\\] the address against which signing should be checked. If empty, the address of the current account is used. This field can be updated in any transaction by setting the RekeyTo field.</value>
        [DataMember(Name="auth-addr", EmitDefaultValue=false)]
        public string AuthAddr { get; set; }

        /// <summary>
        /// \\[appp\\] parameters of applications created by this account including app global data.  Note: the raw account uses &#x60;map[int] -&gt; AppParams&#x60; for this type.
        /// </summary>
        /// <value>\\[appp\\] parameters of applications created by this account including app global data.  Note: the raw account uses &#x60;map[int] -&gt; AppParams&#x60; for this type.</value>
        [DataMember(Name="created-apps", EmitDefaultValue=false)]
        public List<Application> CreatedApps { get; set; }

        /// <summary>
        /// \\[apar\\] parameters of assets created by this account.  Note: the raw account uses &#x60;map[int] -&gt; Asset&#x60; for this type.
        /// </summary>
        /// <value>\\[apar\\] parameters of assets created by this account.  Note: the raw account uses &#x60;map[int] -&gt; Asset&#x60; for this type.</value>
        [DataMember(Name="created-assets", EmitDefaultValue=false)]
        public List<Asset> CreatedAssets { get; set; }

        /// <summary>
        /// Gets or Sets Participation
        /// </summary>
        [DataMember(Name="participation", EmitDefaultValue=false)]
        public AccountParticipation Participation { get; set; }

        /// <summary>
        /// amount of MicroAlgos of pending rewards in this account.
        /// </summary>
        /// <value>amount of MicroAlgos of pending rewards in this account.</value>
        [DataMember(Name="pending-rewards", EmitDefaultValue=false)]
        public int? PendingRewards { get; set; }

        /// <summary>
        /// \\[ebase\\] used as part of the rewards computation. Only applicable to accounts which are participating.
        /// </summary>
        /// <value>\\[ebase\\] used as part of the rewards computation. Only applicable to accounts which are participating.</value>
        [DataMember(Name="reward-base", EmitDefaultValue=false)]
        public int? RewardBase { get; set; }

        /// <summary>
        /// \\[ern\\] total rewards of MicroAlgos the account has received, including pending rewards.
        /// </summary>
        /// <value>\\[ern\\] total rewards of MicroAlgos the account has received, including pending rewards.</value>
        [DataMember(Name="rewards", EmitDefaultValue=false)]
        public int? Rewards { get; set; }

        /// <summary>
        /// The round for which this information is relevant.
        /// </summary>
        /// <value>The round for which this information is relevant.</value>
        [DataMember(Name="round", EmitDefaultValue=false)]
        public int? Round { get; set; }


        /// <summary>
        /// \\[onl\\] delegation status of the account&#x27;s MicroAlgos * Offline - indicates that the associated account is delegated. *  Online  - indicates that the associated account used as part of the delegation pool. *   NotParticipating - indicates that the associated account is neither a delegator nor a delegate.
        /// </summary>
        /// <value>\\[onl\\] delegation status of the account&#x27;s MicroAlgos * Offline - indicates that the associated account is delegated. *  Online  - indicates that the associated account used as part of the delegation pool. *   NotParticipating - indicates that the associated account is neither a delegator nor a delegate.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Account {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AmountWithoutPendingRewards: ").Append(AmountWithoutPendingRewards).Append("\n");
            sb.Append("  AppsLocalState: ").Append(AppsLocalState).Append("\n");
            sb.Append("  AppsTotalSchema: ").Append(AppsTotalSchema).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  AuthAddr: ").Append(AuthAddr).Append("\n");
            sb.Append("  CreatedApps: ").Append(CreatedApps).Append("\n");
            sb.Append("  CreatedAssets: ").Append(CreatedAssets).Append("\n");
            sb.Append("  Participation: ").Append(Participation).Append("\n");
            sb.Append("  PendingRewards: ").Append(PendingRewards).Append("\n");
            sb.Append("  RewardBase: ").Append(RewardBase).Append("\n");
            sb.Append("  Rewards: ").Append(Rewards).Append("\n");
            sb.Append("  Round: ").Append(Round).Append("\n");
            sb.Append("  SigType: ").Append(SigType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="input">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.AmountWithoutPendingRewards == input.AmountWithoutPendingRewards ||
                    (this.AmountWithoutPendingRewards != null &&
                    this.AmountWithoutPendingRewards.Equals(input.AmountWithoutPendingRewards))
                ) && 
                (
                    this.AppsLocalState == input.AppsLocalState ||
                    this.AppsLocalState != null &&
                    input.AppsLocalState != null &&
                    this.AppsLocalState.SequenceEqual(input.AppsLocalState)
                ) && 
                (
                    this.AppsTotalSchema == input.AppsTotalSchema ||
                    (this.AppsTotalSchema != null &&
                    this.AppsTotalSchema.Equals(input.AppsTotalSchema))
                ) && 
                (
                    this.Assets == input.Assets ||
                    this.Assets != null &&
                    input.Assets != null &&
                    this.Assets.SequenceEqual(input.Assets)
                ) && 
                (
                    this.AuthAddr == input.AuthAddr ||
                    (this.AuthAddr != null &&
                    this.AuthAddr.Equals(input.AuthAddr))
                ) && 
                (
                    this.CreatedApps == input.CreatedApps ||
                    this.CreatedApps != null &&
                    input.CreatedApps != null &&
                    this.CreatedApps.SequenceEqual(input.CreatedApps)
                ) && 
                (
                    this.CreatedAssets == input.CreatedAssets ||
                    this.CreatedAssets != null &&
                    input.CreatedAssets != null &&
                    this.CreatedAssets.SequenceEqual(input.CreatedAssets)
                ) && 
                (
                    this.Participation == input.Participation ||
                    (this.Participation != null &&
                    this.Participation.Equals(input.Participation))
                ) && 
                (
                    this.PendingRewards == input.PendingRewards ||
                    (this.PendingRewards != null &&
                    this.PendingRewards.Equals(input.PendingRewards))
                ) && 
                (
                    this.RewardBase == input.RewardBase ||
                    (this.RewardBase != null &&
                    this.RewardBase.Equals(input.RewardBase))
                ) && 
                (
                    this.Rewards == input.Rewards ||
                    (this.Rewards != null &&
                    this.Rewards.Equals(input.Rewards))
                ) && 
                (
                    this.Round == input.Round ||
                    (this.Round != null &&
                    this.Round.Equals(input.Round))
                ) && 
                (
                    this.SigType == input.SigType ||
                    (this.SigType != null &&
                    this.SigType.Equals(input.SigType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.AmountWithoutPendingRewards != null)
                    hashCode = hashCode * 59 + this.AmountWithoutPendingRewards.GetHashCode();
                if (this.AppsLocalState != null)
                    hashCode = hashCode * 59 + this.AppsLocalState.GetHashCode();
                if (this.AppsTotalSchema != null)
                    hashCode = hashCode * 59 + this.AppsTotalSchema.GetHashCode();
                if (this.Assets != null)
                    hashCode = hashCode * 59 + this.Assets.GetHashCode();
                if (this.AuthAddr != null)
                    hashCode = hashCode * 59 + this.AuthAddr.GetHashCode();
                if (this.CreatedApps != null)
                    hashCode = hashCode * 59 + this.CreatedApps.GetHashCode();
                if (this.CreatedAssets != null)
                    hashCode = hashCode * 59 + this.CreatedAssets.GetHashCode();
                if (this.Participation != null)
                    hashCode = hashCode * 59 + this.Participation.GetHashCode();
                if (this.PendingRewards != null)
                    hashCode = hashCode * 59 + this.PendingRewards.GetHashCode();
                if (this.RewardBase != null)
                    hashCode = hashCode * 59 + this.RewardBase.GetHashCode();
                if (this.Rewards != null)
                    hashCode = hashCode * 59 + this.Rewards.GetHashCode();
                if (this.Round != null)
                    hashCode = hashCode * 59 + this.Round.GetHashCode();
                if (this.SigType != null)
                    hashCode = hashCode * 59 + this.SigType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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