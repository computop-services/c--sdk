
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

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// EmailSender model.
    /// </summary>
    [DataContract]
    public partial class EmailSender :  IEquatable<EmailSender>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailSender" /> class.
        /// </summary>
        /// <param name="DefaultSender">The default email sender is used whenever not different sender is specified in the space.</param>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="LinkedSpaceId">The linked space id holds the ID of the space to which the entity belongs to.</param>
        /// <param name="PlannedPurgeDate">The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</param>
        /// <param name="SenderAddress">The sender address is the email address from which you want to send the email to the customer.</param>
        /// <param name="SenderName">The sender name is shown in the email. Choose an appropriate name as it will be displayed to your customer.</param>
        /// <param name="State">State</param>
        /// <param name="Type">Type</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</param>
        public EmailSender(bool? DefaultSender = default(bool?), long? Id = default(long?), long? LinkedSpaceId = default(long?), DateTime? PlannedPurgeDate = default(DateTime?), string SenderAddress = default(string), DatabaseTranslatedString SenderName = default(DatabaseTranslatedString), CreationEntityState State = default(CreationEntityState), long? Type = default(long?), int? Version = default(int?))
        {
            this.DefaultSender = DefaultSender;
            this.Id = Id;
            this.LinkedSpaceId = LinkedSpaceId;
            this.PlannedPurgeDate = PlannedPurgeDate;
            this.SenderAddress = SenderAddress;
            this.SenderName = SenderName;
            this.State = State;
            this.Type = Type;
            this.Version = Version;
        }

        /// <summary>
        /// The default email sender is used whenever not different sender is specified in the space.
        /// </summary>
        /// <value>The default email sender is used whenever not different sender is specified in the space.</value>
        [DataMember(Name="defaultSender", EmitDefaultValue=false)]
        public bool? DefaultSender { get; set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; set; }

        /// <summary>
        /// The sender address is the email address from which you want to send the email to the customer.
        /// </summary>
        /// <value>The sender address is the email address from which you want to send the email to the customer.</value>
        [DataMember(Name="senderAddress", EmitDefaultValue=false)]
        public string SenderAddress { get; set; }

        /// <summary>
        /// The sender name is shown in the email. Choose an appropriate name as it will be displayed to your customer.
        /// </summary>
        /// <value>The sender name is shown in the email. Choose an appropriate name as it will be displayed to your customer.</value>
        [DataMember(Name="senderName", EmitDefaultValue=false)]
        public DatabaseTranslatedString SenderName { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState State { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public long? Type { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailSender {\n");
            sb.Append("  DefaultSender: ").Append(DefaultSender).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  SenderAddress: ").Append(SenderAddress).Append("\n");
            sb.Append("  SenderName: ").Append(SenderName).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as EmailSender);
        }

        /// <summary>
        /// Returns true if EmailSender instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailSender to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailSender other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.DefaultSender == other.DefaultSender ||
                    this.DefaultSender != null &&
                    this.DefaultSender.Equals(other.DefaultSender)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.SenderAddress == other.SenderAddress ||
                    this.SenderAddress != null &&
                    this.SenderAddress.Equals(other.SenderAddress)
                ) && 
                (
                    this.SenderName == other.SenderName ||
                    this.SenderName != null &&
                    this.SenderName.Equals(other.SenderName)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.DefaultSender != null)
                    hash = hash * 59 + this.DefaultSender.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.SenderAddress != null)
                    hash = hash * 59 + this.SenderAddress.GetHashCode();
                if (this.SenderName != null)
                    hash = hash * 59 + this.SenderName.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

    }

}
