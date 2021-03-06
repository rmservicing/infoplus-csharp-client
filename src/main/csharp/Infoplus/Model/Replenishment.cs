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
    public partial class Replenishment :  IEquatable<Replenishment>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Replenishment" /> class.
        /// Initializes a new instance of the <see cref="Replenishment" />class.
        /// </summary>
        /// <param name="LocationId">LocationId (required).</param>
        /// <param name="CustomFields">CustomFields.</param>
        /// <param name="Sku">Sku.</param>

        public Replenishment(int? LocationId = null, Dictionary<string, Object> CustomFields = null, string Sku = null)
        {
            // to ensure "LocationId" is required (not null)
            if (LocationId == null)
            {
                throw new InvalidDataException("LocationId is a required property for Replenishment and cannot be null");
            }
            else
            {
                this.LocationId = LocationId;
            }
            this.CustomFields = CustomFields;
            this.Sku = Sku;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
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
        /// Gets or Sets ReplenishmentProcess
        /// </summary>
        [DataMember(Name="replenishmentProcess", EmitDefaultValue=false)]
        public int? ReplenishmentProcess { get; private set; }
    
        /// <summary>
        /// Gets or Sets PickFaceAssignment
        /// </summary>
        [DataMember(Name="pickFaceAssignment", EmitDefaultValue=false)]
        public int? PickFaceAssignment { get; private set; }
    
        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name="locationId", EmitDefaultValue=false)]
        public int? LocationId { get; set; }
    
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; private set; }
    
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomFields { get; set; }
    
        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Replenishment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  ReplenishmentProcess: ").Append(ReplenishmentProcess).Append("\n");
            sb.Append("  PickFaceAssignment: ").Append(PickFaceAssignment).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            
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
            return this.Equals(obj as Replenishment);
        }

        /// <summary>
        /// Returns true if Replenishment instances are equal
        /// </summary>
        /// <param name="other">Instance of Replenishment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Replenishment other)
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
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
                ) && 
                (
                    this.ReplenishmentProcess == other.ReplenishmentProcess ||
                    this.ReplenishmentProcess != null &&
                    this.ReplenishmentProcess.Equals(other.ReplenishmentProcess)
                ) && 
                (
                    this.PickFaceAssignment == other.PickFaceAssignment ||
                    this.PickFaceAssignment != null &&
                    this.PickFaceAssignment.Equals(other.PickFaceAssignment)
                ) && 
                (
                    this.LocationId == other.LocationId ||
                    this.LocationId != null &&
                    this.LocationId.Equals(other.LocationId)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
                ) && 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
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
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.ReplenishmentProcess != null)
                    hash = hash * 59 + this.ReplenishmentProcess.GetHashCode();
                
                if (this.PickFaceAssignment != null)
                    hash = hash * 59 + this.PickFaceAssignment.GetHashCode();
                
                if (this.LocationId != null)
                    hash = hash * 59 + this.LocationId.GetHashCode();
                
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                
                return hash;
            }
        }

    }
}
