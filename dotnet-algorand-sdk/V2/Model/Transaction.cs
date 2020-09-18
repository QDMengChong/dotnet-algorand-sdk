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
using SwaggerDateConverter = Algorand.V2.Client.SwaggerDateConverter;

namespace Algorand.V2.Model
{
    /// <summary>
    /// Contains all fields common to all transactions and serves as an envelope to all transactions type.  Definition: data/transactions/signedtxn.go : SignedTxn data/transactions/transaction.go : Transaction 
    /// </summary>
    [DataContract]
        public partial class Transaction :  IEquatable<Transaction>, IValidatableObject
    {
        /// <summary>
        /// \\[type\\] Indicates what type of transaction this is. Different types have different fields.  Valid types, and where their fields are stored: * \\[pay\\] payment-transaction * \\[keyreg\\] keyreg-transaction * \\[acfg\\] asset-config-transaction * \\[axfer\\] asset-transfer-transaction * \\[afrz\\] asset-freeze-transaction * \\[appl\\] application-transaction
        /// </summary>
        /// <value>\\[type\\] Indicates what type of transaction this is. Different types have different fields.  Valid types, and where their fields are stored: * \\[pay\\] payment-transaction * \\[keyreg\\] keyreg-transaction * \\[acfg\\] asset-config-transaction * \\[axfer\\] asset-transfer-transaction * \\[afrz\\] asset-freeze-transaction * \\[appl\\] application-transaction</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TxTypeEnum
        {
            /// <summary>
            /// Enum Pay for value: pay
            /// </summary>
            [EnumMember(Value = "pay")]
            Pay = 1,
            /// <summary>
            /// Enum Keyreg for value: keyreg
            /// </summary>
            [EnumMember(Value = "keyreg")]
            Keyreg = 2,
            /// <summary>
            /// Enum Acfg for value: acfg
            /// </summary>
            [EnumMember(Value = "acfg")]
            Acfg = 3,
            /// <summary>
            /// Enum Axfer for value: axfer
            /// </summary>
            [EnumMember(Value = "axfer")]
            Axfer = 4,
            /// <summary>
            /// Enum Afrz for value: afrz
            /// </summary>
            [EnumMember(Value = "afrz")]
            Afrz = 5,
            /// <summary>
            /// Enum Appl for value: appl
            /// </summary>
            [EnumMember(Value = "appl")]
            Appl = 6        }
        /// <summary>
        /// \\[type\\] Indicates what type of transaction this is. Different types have different fields.  Valid types, and where their fields are stored: * \\[pay\\] payment-transaction * \\[keyreg\\] keyreg-transaction * \\[acfg\\] asset-config-transaction * \\[axfer\\] asset-transfer-transaction * \\[afrz\\] asset-freeze-transaction * \\[appl\\] application-transaction
        /// </summary>
        /// <value>\\[type\\] Indicates what type of transaction this is. Different types have different fields.  Valid types, and where their fields are stored: * \\[pay\\] payment-transaction * \\[keyreg\\] keyreg-transaction * \\[acfg\\] asset-config-transaction * \\[axfer\\] asset-transfer-transaction * \\[afrz\\] asset-freeze-transaction * \\[appl\\] application-transaction</value>
        [DataMember(Name="tx-type", EmitDefaultValue=false)]
        public TxTypeEnum TxType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction" /> class.
        /// </summary>
        /// <param name="applicationTransaction">applicationTransaction.</param>
        /// <param name="assetConfigTransaction">assetConfigTransaction.</param>
        /// <param name="assetFreezeTransaction">assetFreezeTransaction.</param>
        /// <param name="assetTransferTransaction">assetTransferTransaction.</param>
        /// <param name="authAddr">\\[sgnr\\] The address used to sign the transaction. This is used for rekeyed accounts to indicate that the sender address did not sign the transaction..</param>
        /// <param name="closeRewards">\\[rc\\] rewards applied to close-remainder-to account..</param>
        /// <param name="closingAmount">\\[ca\\] closing amount for transaction..</param>
        /// <param name="confirmedRound">Round when the transaction was confirmed..</param>
        /// <param name="createdApplicationIndex">Specifies an application index (ID) if an application was created with this transaction..</param>
        /// <param name="createdAssetIndex">Specifies an asset index (ID) if an asset was created with this transaction..</param>
        /// <param name="fee">\\[fee\\] Transaction fee. (required).</param>
        /// <param name="firstValid">\\[fv\\] First valid round for this transaction. (required).</param>
        /// <param name="genesisHash">\\[gh\\] Hash of genesis block..</param>
        /// <param name="genesisId">\\[gen\\] genesis block ID..</param>
        /// <param name="globalStateDelta">globalStateDelta.</param>
        /// <param name="group">\\[grp\\] Base64 encoded byte array of a sha512/256 digest. When present indicates that this transaction is part of a transaction group and the value is the sha512/256 hash of the transactions in that group..</param>
        /// <param name="id">Transaction ID (required).</param>
        /// <param name="intraRoundOffset">Offset into the round where this transaction was confirmed..</param>
        /// <param name="keyregTransaction">keyregTransaction.</param>
        /// <param name="lastValid">\\[lv\\] Last valid round for this transaction. (required).</param>
        /// <param name="lease">\\[lx\\] Base64 encoded 32-byte array. Lease enforces mutual exclusion of transactions.  If this field is nonzero, then once the transaction is confirmed, it acquires the lease identified by the (Sender, Lease) pair of the transaction until the LastValid round passes.  While this transaction possesses the lease, no other transaction specifying this lease can be confirmed..</param>
        /// <param name="localStateDelta">\\[ld\\] Local state key/value changes for the application being executed by this transaction..</param>
        /// <param name="note">\\[note\\] Free form data..</param>
        /// <param name="paymentTransaction">paymentTransaction.</param>
        /// <param name="receiverRewards">\\[rr\\] rewards applied to receiver account..</param>
        /// <param name="rekeyTo">\\[rekey\\] when included in a valid transaction, the accounts auth addr will be updated with this value and future signatures must be signed with the key represented by this address..</param>
        /// <param name="roundTime">Time when the block this transaction is in was confirmed..</param>
        /// <param name="sender">\\[snd\\] Sender&#x27;s address. (required).</param>
        /// <param name="senderRewards">\\[rs\\] rewards applied to sender account..</param>
        /// <param name="signature">signature (required).</param>
        /// <param name="txType">\\[type\\] Indicates what type of transaction this is. Different types have different fields.  Valid types, and where their fields are stored: * \\[pay\\] payment-transaction * \\[keyreg\\] keyreg-transaction * \\[acfg\\] asset-config-transaction * \\[axfer\\] asset-transfer-transaction * \\[afrz\\] asset-freeze-transaction * \\[appl\\] application-transaction (required).</param>
        public Transaction(TransactionApplication applicationTransaction = default(TransactionApplication), TransactionAssetConfig assetConfigTransaction = default(TransactionAssetConfig), TransactionAssetFreeze assetFreezeTransaction = default(TransactionAssetFreeze), TransactionAssetTransfer assetTransferTransaction = default(TransactionAssetTransfer), string authAddr = default(string), int? closeRewards = default(int?), int? closingAmount = default(int?), int? confirmedRound = default(int?), int? createdApplicationIndex = default(int?), int? createdAssetIndex = default(int?), int? fee = default(int?), int? firstValid = default(int?), byte[] genesisHash = default(byte[]), string genesisId = default(string), StateDelta globalStateDelta = default, byte[] group = default(byte[]), string id = default(string), int? intraRoundOffset = default(int?), TransactionKeyreg keyregTransaction = default(TransactionKeyreg), int? lastValid = default(int?), byte[] lease = default(byte[]), List<AccountStateDelta> localStateDelta = default(List<AccountStateDelta>), byte[] note = default(byte[]), TransactionPayment paymentTransaction = default(TransactionPayment), int? receiverRewards = default(int?), string rekeyTo = default(string), int? roundTime = default(int?), string sender = default(string), int? senderRewards = default(int?), TransactionSignature signature = default(TransactionSignature), TxTypeEnum txType = default(TxTypeEnum))
        {
            // to ensure "fee" is required (not null)
            if (fee == null)
            {
                throw new InvalidDataException("fee is a required property for Transaction and cannot be null");
            }
            else
            {
                this.Fee = fee;
            }
            // to ensure "firstValid" is required (not null)
            if (firstValid == null)
            {
                throw new InvalidDataException("firstValid is a required property for Transaction and cannot be null");
            }
            else
            {
                this.FirstValid = firstValid;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Transaction and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "lastValid" is required (not null)
            if (lastValid == null)
            {
                throw new InvalidDataException("lastValid is a required property for Transaction and cannot be null");
            }
            else
            {
                this.LastValid = lastValid;
            }
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new InvalidDataException("sender is a required property for Transaction and cannot be null");
            }
            else
            {
                this.Sender = sender;
            }
            // to ensure "signature" is required (not null)
            if (signature == null)
            {
                throw new InvalidDataException("signature is a required property for Transaction and cannot be null");
            }
            else
            {
                this.Signature = signature;
            }
            // to ensure "txType" is required (not null)
            if (txType == null)
            {
                throw new InvalidDataException("txType is a required property for Transaction and cannot be null");
            }
            else
            {
                this.TxType = txType;
            }
            this.ApplicationTransaction = applicationTransaction;
            this.AssetConfigTransaction = assetConfigTransaction;
            this.AssetFreezeTransaction = assetFreezeTransaction;
            this.AssetTransferTransaction = assetTransferTransaction;
            this.AuthAddr = authAddr;
            this.CloseRewards = closeRewards;
            this.ClosingAmount = closingAmount;
            this.ConfirmedRound = confirmedRound;
            this.CreatedApplicationIndex = createdApplicationIndex;
            this.CreatedAssetIndex = createdAssetIndex;
            this.GenesisHash = genesisHash;
            this.GenesisId = genesisId;
            this.GlobalStateDelta = globalStateDelta;
            this.Group = group;
            this.IntraRoundOffset = intraRoundOffset;
            this.KeyregTransaction = keyregTransaction;
            this.Lease = lease;
            this.LocalStateDelta = localStateDelta;
            this.Note = note;
            this.PaymentTransaction = paymentTransaction;
            this.ReceiverRewards = receiverRewards;
            this.RekeyTo = rekeyTo;
            this.RoundTime = roundTime;
            this.SenderRewards = senderRewards;
        }
        
        /// <summary>
        /// Gets or Sets ApplicationTransaction
        /// </summary>
        [DataMember(Name="application-transaction", EmitDefaultValue=false)]
        public TransactionApplication ApplicationTransaction { get; set; }

        /// <summary>
        /// Gets or Sets AssetConfigTransaction
        /// </summary>
        [DataMember(Name="asset-config-transaction", EmitDefaultValue=false)]
        public TransactionAssetConfig AssetConfigTransaction { get; set; }

        /// <summary>
        /// Gets or Sets AssetFreezeTransaction
        /// </summary>
        [DataMember(Name="asset-freeze-transaction", EmitDefaultValue=false)]
        public TransactionAssetFreeze AssetFreezeTransaction { get; set; }

        /// <summary>
        /// Gets or Sets AssetTransferTransaction
        /// </summary>
        [DataMember(Name="asset-transfer-transaction", EmitDefaultValue=false)]
        public TransactionAssetTransfer AssetTransferTransaction { get; set; }

        /// <summary>
        /// \\[sgnr\\] The address used to sign the transaction. This is used for rekeyed accounts to indicate that the sender address did not sign the transaction.
        /// </summary>
        /// <value>\\[sgnr\\] The address used to sign the transaction. This is used for rekeyed accounts to indicate that the sender address did not sign the transaction.</value>
        [DataMember(Name="auth-addr", EmitDefaultValue=false)]
        public string AuthAddr { get; set; }

        /// <summary>
        /// \\[rc\\] rewards applied to close-remainder-to account.
        /// </summary>
        /// <value>\\[rc\\] rewards applied to close-remainder-to account.</value>
        [DataMember(Name="close-rewards", EmitDefaultValue=false)]
        public int? CloseRewards { get; set; }

        /// <summary>
        /// \\[ca\\] closing amount for transaction.
        /// </summary>
        /// <value>\\[ca\\] closing amount for transaction.</value>
        [DataMember(Name="closing-amount", EmitDefaultValue=false)]
        public int? ClosingAmount { get; set; }

        /// <summary>
        /// Round when the transaction was confirmed.
        /// </summary>
        /// <value>Round when the transaction was confirmed.</value>
        [DataMember(Name="confirmed-round", EmitDefaultValue=false)]
        public int? ConfirmedRound { get; set; }

        /// <summary>
        /// Specifies an application index (ID) if an application was created with this transaction.
        /// </summary>
        /// <value>Specifies an application index (ID) if an application was created with this transaction.</value>
        [DataMember(Name="created-application-index", EmitDefaultValue=false)]
        public int? CreatedApplicationIndex { get; set; }

        /// <summary>
        /// Specifies an asset index (ID) if an asset was created with this transaction.
        /// </summary>
        /// <value>Specifies an asset index (ID) if an asset was created with this transaction.</value>
        [DataMember(Name="created-asset-index", EmitDefaultValue=false)]
        public int? CreatedAssetIndex { get; set; }

        /// <summary>
        /// \\[fee\\] Transaction fee.
        /// </summary>
        /// <value>\\[fee\\] Transaction fee.</value>
        [DataMember(Name="fee", EmitDefaultValue=false)]
        public int? Fee { get; set; }

        /// <summary>
        /// \\[fv\\] First valid round for this transaction.
        /// </summary>
        /// <value>\\[fv\\] First valid round for this transaction.</value>
        [DataMember(Name="first-valid", EmitDefaultValue=false)]
        public int? FirstValid { get; set; }

        /// <summary>
        /// \\[gh\\] Hash of genesis block.
        /// </summary>
        /// <value>\\[gh\\] Hash of genesis block.</value>
        [DataMember(Name="genesis-hash", EmitDefaultValue=false)]
        public byte[] GenesisHash { get; set; }

        /// <summary>
        /// \\[gen\\] genesis block ID.
        /// </summary>
        /// <value>\\[gen\\] genesis block ID.</value>
        [DataMember(Name="genesis-id", EmitDefaultValue=false)]
        public string GenesisId { get; set; }

        /// <summary>
        /// Gets or Sets GlobalStateDelta
        /// </summary>
        [DataMember(Name="global-state-delta", EmitDefaultValue=false)]
        public StateDelta GlobalStateDelta { get; set; }

        /// <summary>
        /// \\[grp\\] Base64 encoded byte array of a sha512/256 digest. When present indicates that this transaction is part of a transaction group and the value is the sha512/256 hash of the transactions in that group.
        /// </summary>
        /// <value>\\[grp\\] Base64 encoded byte array of a sha512/256 digest. When present indicates that this transaction is part of a transaction group and the value is the sha512/256 hash of the transactions in that group.</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public byte[] Group { get; set; }

        /// <summary>
        /// Transaction ID
        /// </summary>
        /// <value>Transaction ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Offset into the round where this transaction was confirmed.
        /// </summary>
        /// <value>Offset into the round where this transaction was confirmed.</value>
        [DataMember(Name="intra-round-offset", EmitDefaultValue=false)]
        public int? IntraRoundOffset { get; set; }

        /// <summary>
        /// Gets or Sets KeyregTransaction
        /// </summary>
        [DataMember(Name="keyreg-transaction", EmitDefaultValue=false)]
        public TransactionKeyreg KeyregTransaction { get; set; }

        /// <summary>
        /// \\[lv\\] Last valid round for this transaction.
        /// </summary>
        /// <value>\\[lv\\] Last valid round for this transaction.</value>
        [DataMember(Name="last-valid", EmitDefaultValue=false)]
        public int? LastValid { get; set; }

        /// <summary>
        /// \\[lx\\] Base64 encoded 32-byte array. Lease enforces mutual exclusion of transactions.  If this field is nonzero, then once the transaction is confirmed, it acquires the lease identified by the (Sender, Lease) pair of the transaction until the LastValid round passes.  While this transaction possesses the lease, no other transaction specifying this lease can be confirmed.
        /// </summary>
        /// <value>\\[lx\\] Base64 encoded 32-byte array. Lease enforces mutual exclusion of transactions.  If this field is nonzero, then once the transaction is confirmed, it acquires the lease identified by the (Sender, Lease) pair of the transaction until the LastValid round passes.  While this transaction possesses the lease, no other transaction specifying this lease can be confirmed.</value>
        [DataMember(Name="lease", EmitDefaultValue=false)]
        public byte[] Lease { get; set; }

        /// <summary>
        /// \\[ld\\] Local state key/value changes for the application being executed by this transaction.
        /// </summary>
        /// <value>\\[ld\\] Local state key/value changes for the application being executed by this transaction.</value>
        [DataMember(Name="local-state-delta", EmitDefaultValue=false)]
        public List<AccountStateDelta> LocalStateDelta { get; set; }

        /// <summary>
        /// \\[note\\] Free form data.
        /// </summary>
        /// <value>\\[note\\] Free form data.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public byte[] Note { get; set; }

        /// <summary>
        /// Gets or Sets PaymentTransaction
        /// </summary>
        [DataMember(Name="payment-transaction", EmitDefaultValue=false)]
        public TransactionPayment PaymentTransaction { get; set; }

        /// <summary>
        /// \\[rr\\] rewards applied to receiver account.
        /// </summary>
        /// <value>\\[rr\\] rewards applied to receiver account.</value>
        [DataMember(Name="receiver-rewards", EmitDefaultValue=false)]
        public int? ReceiverRewards { get; set; }

        /// <summary>
        /// \\[rekey\\] when included in a valid transaction, the accounts auth addr will be updated with this value and future signatures must be signed with the key represented by this address.
        /// </summary>
        /// <value>\\[rekey\\] when included in a valid transaction, the accounts auth addr will be updated with this value and future signatures must be signed with the key represented by this address.</value>
        [DataMember(Name="rekey-to", EmitDefaultValue=false)]
        public string RekeyTo { get; set; }

        /// <summary>
        /// Time when the block this transaction is in was confirmed.
        /// </summary>
        /// <value>Time when the block this transaction is in was confirmed.</value>
        [DataMember(Name="round-time", EmitDefaultValue=false)]
        public int? RoundTime { get; set; }

        /// <summary>
        /// \\[snd\\] Sender&#x27;s address.
        /// </summary>
        /// <value>\\[snd\\] Sender&#x27;s address.</value>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public string Sender { get; set; }

        /// <summary>
        /// \\[rs\\] rewards applied to sender account.
        /// </summary>
        /// <value>\\[rs\\] rewards applied to sender account.</value>
        [DataMember(Name="sender-rewards", EmitDefaultValue=false)]
        public int? SenderRewards { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name="signature", EmitDefaultValue=false)]
        public TransactionSignature Signature { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Transaction {\n");
            sb.Append("  ApplicationTransaction: ").Append(ApplicationTransaction).Append("\n");
            sb.Append("  AssetConfigTransaction: ").Append(AssetConfigTransaction).Append("\n");
            sb.Append("  AssetFreezeTransaction: ").Append(AssetFreezeTransaction).Append("\n");
            sb.Append("  AssetTransferTransaction: ").Append(AssetTransferTransaction).Append("\n");
            sb.Append("  AuthAddr: ").Append(AuthAddr).Append("\n");
            sb.Append("  CloseRewards: ").Append(CloseRewards).Append("\n");
            sb.Append("  ClosingAmount: ").Append(ClosingAmount).Append("\n");
            sb.Append("  ConfirmedRound: ").Append(ConfirmedRound).Append("\n");
            sb.Append("  CreatedApplicationIndex: ").Append(CreatedApplicationIndex).Append("\n");
            sb.Append("  CreatedAssetIndex: ").Append(CreatedAssetIndex).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  FirstValid: ").Append(FirstValid).Append("\n");
            sb.Append("  GenesisHash: ").Append(GenesisHash).Append("\n");
            sb.Append("  GenesisId: ").Append(GenesisId).Append("\n");
            sb.Append("  GlobalStateDelta: ").Append(GlobalStateDelta).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IntraRoundOffset: ").Append(IntraRoundOffset).Append("\n");
            sb.Append("  KeyregTransaction: ").Append(KeyregTransaction).Append("\n");
            sb.Append("  LastValid: ").Append(LastValid).Append("\n");
            sb.Append("  Lease: ").Append(Lease).Append("\n");
            sb.Append("  LocalStateDelta: ").Append(LocalStateDelta).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  PaymentTransaction: ").Append(PaymentTransaction).Append("\n");
            sb.Append("  ReceiverRewards: ").Append(ReceiverRewards).Append("\n");
            sb.Append("  RekeyTo: ").Append(RekeyTo).Append("\n");
            sb.Append("  RoundTime: ").Append(RoundTime).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  SenderRewards: ").Append(SenderRewards).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  TxType: ").Append(TxType).Append("\n");
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
            return this.Equals(input as Transaction);
        }

        /// <summary>
        /// Returns true if Transaction instances are equal
        /// </summary>
        /// <param name="input">Instance of Transaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationTransaction == input.ApplicationTransaction ||
                    (this.ApplicationTransaction != null &&
                    this.ApplicationTransaction.Equals(input.ApplicationTransaction))
                ) && 
                (
                    this.AssetConfigTransaction == input.AssetConfigTransaction ||
                    (this.AssetConfigTransaction != null &&
                    this.AssetConfigTransaction.Equals(input.AssetConfigTransaction))
                ) && 
                (
                    this.AssetFreezeTransaction == input.AssetFreezeTransaction ||
                    (this.AssetFreezeTransaction != null &&
                    this.AssetFreezeTransaction.Equals(input.AssetFreezeTransaction))
                ) && 
                (
                    this.AssetTransferTransaction == input.AssetTransferTransaction ||
                    (this.AssetTransferTransaction != null &&
                    this.AssetTransferTransaction.Equals(input.AssetTransferTransaction))
                ) && 
                (
                    this.AuthAddr == input.AuthAddr ||
                    (this.AuthAddr != null &&
                    this.AuthAddr.Equals(input.AuthAddr))
                ) && 
                (
                    this.CloseRewards == input.CloseRewards ||
                    (this.CloseRewards != null &&
                    this.CloseRewards.Equals(input.CloseRewards))
                ) && 
                (
                    this.ClosingAmount == input.ClosingAmount ||
                    (this.ClosingAmount != null &&
                    this.ClosingAmount.Equals(input.ClosingAmount))
                ) && 
                (
                    this.ConfirmedRound == input.ConfirmedRound ||
                    (this.ConfirmedRound != null &&
                    this.ConfirmedRound.Equals(input.ConfirmedRound))
                ) && 
                (
                    this.CreatedApplicationIndex == input.CreatedApplicationIndex ||
                    (this.CreatedApplicationIndex != null &&
                    this.CreatedApplicationIndex.Equals(input.CreatedApplicationIndex))
                ) && 
                (
                    this.CreatedAssetIndex == input.CreatedAssetIndex ||
                    (this.CreatedAssetIndex != null &&
                    this.CreatedAssetIndex.Equals(input.CreatedAssetIndex))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.FirstValid == input.FirstValid ||
                    (this.FirstValid != null &&
                    this.FirstValid.Equals(input.FirstValid))
                ) && 
                (
                    this.GenesisHash == input.GenesisHash ||
                    (this.GenesisHash != null &&
                    this.GenesisHash.Equals(input.GenesisHash))
                ) && 
                (
                    this.GenesisId == input.GenesisId ||
                    (this.GenesisId != null &&
                    this.GenesisId.Equals(input.GenesisId))
                ) && 
                (
                    this.GlobalStateDelta == input.GlobalStateDelta ||
                    (this.GlobalStateDelta != null &&
                    this.GlobalStateDelta.Equals(input.GlobalStateDelta))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IntraRoundOffset == input.IntraRoundOffset ||
                    (this.IntraRoundOffset != null &&
                    this.IntraRoundOffset.Equals(input.IntraRoundOffset))
                ) && 
                (
                    this.KeyregTransaction == input.KeyregTransaction ||
                    (this.KeyregTransaction != null &&
                    this.KeyregTransaction.Equals(input.KeyregTransaction))
                ) && 
                (
                    this.LastValid == input.LastValid ||
                    (this.LastValid != null &&
                    this.LastValid.Equals(input.LastValid))
                ) && 
                (
                    this.Lease == input.Lease ||
                    (this.Lease != null &&
                    this.Lease.Equals(input.Lease))
                ) && 
                (
                    this.LocalStateDelta == input.LocalStateDelta ||
                    this.LocalStateDelta != null &&
                    input.LocalStateDelta != null &&
                    this.LocalStateDelta.SequenceEqual(input.LocalStateDelta)
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.PaymentTransaction == input.PaymentTransaction ||
                    (this.PaymentTransaction != null &&
                    this.PaymentTransaction.Equals(input.PaymentTransaction))
                ) && 
                (
                    this.ReceiverRewards == input.ReceiverRewards ||
                    (this.ReceiverRewards != null &&
                    this.ReceiverRewards.Equals(input.ReceiverRewards))
                ) && 
                (
                    this.RekeyTo == input.RekeyTo ||
                    (this.RekeyTo != null &&
                    this.RekeyTo.Equals(input.RekeyTo))
                ) && 
                (
                    this.RoundTime == input.RoundTime ||
                    (this.RoundTime != null &&
                    this.RoundTime.Equals(input.RoundTime))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.SenderRewards == input.SenderRewards ||
                    (this.SenderRewards != null &&
                    this.SenderRewards.Equals(input.SenderRewards))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
                (
                    this.TxType == input.TxType ||
                    (this.TxType != null &&
                    this.TxType.Equals(input.TxType))
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
                if (this.ApplicationTransaction != null)
                    hashCode = hashCode * 59 + this.ApplicationTransaction.GetHashCode();
                if (this.AssetConfigTransaction != null)
                    hashCode = hashCode * 59 + this.AssetConfigTransaction.GetHashCode();
                if (this.AssetFreezeTransaction != null)
                    hashCode = hashCode * 59 + this.AssetFreezeTransaction.GetHashCode();
                if (this.AssetTransferTransaction != null)
                    hashCode = hashCode * 59 + this.AssetTransferTransaction.GetHashCode();
                if (this.AuthAddr != null)
                    hashCode = hashCode * 59 + this.AuthAddr.GetHashCode();
                if (this.CloseRewards != null)
                    hashCode = hashCode * 59 + this.CloseRewards.GetHashCode();
                if (this.ClosingAmount != null)
                    hashCode = hashCode * 59 + this.ClosingAmount.GetHashCode();
                if (this.ConfirmedRound != null)
                    hashCode = hashCode * 59 + this.ConfirmedRound.GetHashCode();
                if (this.CreatedApplicationIndex != null)
                    hashCode = hashCode * 59 + this.CreatedApplicationIndex.GetHashCode();
                if (this.CreatedAssetIndex != null)
                    hashCode = hashCode * 59 + this.CreatedAssetIndex.GetHashCode();
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                if (this.FirstValid != null)
                    hashCode = hashCode * 59 + this.FirstValid.GetHashCode();
                if (this.GenesisHash != null)
                    hashCode = hashCode * 59 + this.GenesisHash.GetHashCode();
                if (this.GenesisId != null)
                    hashCode = hashCode * 59 + this.GenesisId.GetHashCode();
                if (this.GlobalStateDelta != null)
                    hashCode = hashCode * 59 + this.GlobalStateDelta.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IntraRoundOffset != null)
                    hashCode = hashCode * 59 + this.IntraRoundOffset.GetHashCode();
                if (this.KeyregTransaction != null)
                    hashCode = hashCode * 59 + this.KeyregTransaction.GetHashCode();
                if (this.LastValid != null)
                    hashCode = hashCode * 59 + this.LastValid.GetHashCode();
                if (this.Lease != null)
                    hashCode = hashCode * 59 + this.Lease.GetHashCode();
                if (this.LocalStateDelta != null)
                    hashCode = hashCode * 59 + this.LocalStateDelta.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.PaymentTransaction != null)
                    hashCode = hashCode * 59 + this.PaymentTransaction.GetHashCode();
                if (this.ReceiverRewards != null)
                    hashCode = hashCode * 59 + this.ReceiverRewards.GetHashCode();
                if (this.RekeyTo != null)
                    hashCode = hashCode * 59 + this.RekeyTo.GetHashCode();
                if (this.RoundTime != null)
                    hashCode = hashCode * 59 + this.RoundTime.GetHashCode();
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.SenderRewards != null)
                    hashCode = hashCode * 59 + this.SenderRewards.GetHashCode();
                if (this.Signature != null)
                    hashCode = hashCode * 59 + this.Signature.GetHashCode();
                if (this.TxType != null)
                    hashCode = hashCode * 59 + this.TxType.GetHashCode();
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