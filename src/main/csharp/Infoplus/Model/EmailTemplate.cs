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

namespace Infoplus.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class EmailTemplate :  IEquatable<EmailTemplate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTemplate" /> class.
        /// Initializes a new instance of the <see cref="EmailTemplate" />class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="SubjectText">SubjectText.</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="FromName">FromName (required).</param>
        /// <param name="FromAddress">FromAddress (required).</param>
        /// <param name="EmailTemplateType">EmailTemplateType (required).</param>

        public EmailTemplate(int? LobId = null, string SubjectText = null, string Name = null, string FromName = null, string FromAddress = null, string EmailTemplateType = null, )
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for EmailTemplate and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for EmailTemplate and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "FromName" is required (not null)
            if (FromName == null)
            {
                throw new InvalidDataException("FromName is a required property for EmailTemplate and cannot be null");
            }
            else
            {
                this.FromName = FromName;
            }
            // to ensure "FromAddress" is required (not null)
            if (FromAddress == null)
            {
                throw new InvalidDataException("FromAddress is a required property for EmailTemplate and cannot be null");
            }
            else
            {
                this.FromAddress = FromAddress;
            }
            // to ensure "EmailTemplateType" is required (not null)
            if (EmailTemplateType == null)
            {
                throw new InvalidDataException("EmailTemplateType is a required property for EmailTemplate and cannot be null");
            }
            else
            {
                this.EmailTemplateType = EmailTemplateType;
            }
            this.SubjectText = SubjectText;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets SubjectText
        /// </summary>
        [DataMember(Name="subjectText", EmitDefaultValue=false)]
        public string SubjectText { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets FromName
        /// </summary>
        [DataMember(Name="fromName", EmitDefaultValue=false)]
        public string FromName { get; set; }
    
        /// <summary>
        /// Gets or Sets FromAddress
        /// </summary>
        [DataMember(Name="fromAddress", EmitDefaultValue=false)]
        public string FromAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets EmailTemplateType
        /// </summary>
        [DataMember(Name="emailTemplateType", EmitDefaultValue=false)]
        public string EmailTemplateType { get; set; }
    
        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; private set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailTemplate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  SubjectText: ").Append(SubjectText).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FromName: ").Append(FromName).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  EmailTemplateType: ").Append(EmailTemplateType).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as EmailTemplate);
        }

        /// <summary>
        /// Returns true if EmailTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailTemplate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.SubjectText == other.SubjectText ||
                    this.SubjectText != null &&
                    this.SubjectText.Equals(other.SubjectText)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.FromName == other.FromName ||
                    this.FromName != null &&
                    this.FromName.Equals(other.FromName)
                ) && 
                (
                    this.FromAddress == other.FromAddress ||
                    this.FromAddress != null &&
                    this.FromAddress.Equals(other.FromAddress)
                ) && 
                (
                    this.EmailTemplateType == other.EmailTemplateType ||
                    this.EmailTemplateType != null &&
                    this.EmailTemplateType.Equals(other.EmailTemplateType)
                ) && 
                (
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.SubjectText != null)
                    hash = hash * 59 + this.SubjectText.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.FromName != null)
                    hash = hash * 59 + this.FromName.GetHashCode();
                
                if (this.FromAddress != null)
                    hash = hash * 59 + this.FromAddress.GetHashCode();
                
                if (this.EmailTemplateType != null)
                    hash = hash * 59 + this.EmailTemplateType.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                return hash;
            }
        }

    }
}
