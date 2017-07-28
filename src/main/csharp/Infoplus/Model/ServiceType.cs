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
    public partial class ServiceType :  IEquatable<ServiceType>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceType" /> class.
        /// Initializes a new instance of the <see cref="ServiceType" />class.
        /// </summary>
        /// <param name="FullEntityClassName">FullEntityClassName.</param>

        public ServiceType(string FullEntityClassName = null)
        {
            this.FullEntityClassName = FullEntityClassName;
            
        }
        
    
        /// <summary>
        /// Gets or Sets ServiceType
        /// </summary>
        [DataMember(Name="serviceType", EmitDefaultValue=false)]
        public string ServiceType { get; private set; }
    
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; private set; }
    
        /// <summary>
        /// Gets or Sets FullEntityClassName
        /// </summary>
        [DataMember(Name="fullEntityClassName", EmitDefaultValue=false)]
        public string FullEntityClassName { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceType {\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  FullEntityClassName: ").Append(FullEntityClassName).Append("\n");
            
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
            return this.Equals(obj as ServiceType);
        }

        /// <summary>
        /// Returns true if ServiceType instances are equal
        /// </summary>
        /// <param name="other">Instance of ServiceType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceType other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ServiceType == other.ServiceType ||
                    this.ServiceType != null &&
                    this.ServiceType.Equals(other.ServiceType)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.FullEntityClassName == other.FullEntityClassName ||
                    this.FullEntityClassName != null &&
                    this.FullEntityClassName.Equals(other.FullEntityClassName)
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
                
                if (this.ServiceType != null)
                    hash = hash * 59 + this.ServiceType.GetHashCode();
                
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                
                if (this.FullEntityClassName != null)
                    hash = hash * 59 + this.FullEntityClassName.GetHashCode();
                
                return hash;
            }
        }

    }
}
