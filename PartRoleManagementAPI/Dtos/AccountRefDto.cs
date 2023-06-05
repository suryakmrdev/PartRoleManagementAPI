/*
 * Party Role Management
 *
 * This is Swagger UI environment generated for the TMF Party Role Management specification
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
global using System.Text.Json.Serialization;
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PartRoleManagementAPI.Dto
{ 
    /// <summary>
    /// Account reference. A account may be a party account or a financial account.
    /// </summary>
    [DataContract]
    public partial class AccountRefDto : IEquatable<AccountRefDto>
    {
        /// <summary>
        /// Unique identifier of the account
        /// </summary>
        /// <value>Unique identifier of the account</value>

        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Reference of the account
        /// </summary>
        /// <value>Reference of the account</value>

        [JsonPropertyName("href")]
        public string Href { get; set; }

        /// <summary>
        /// Detailed description of the account
        /// </summary>
        /// <value>Detailed description of the account</value>

        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Name of the account
        /// </summary>
        /// <value>Name of the account</value>
        [Required]

        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// When sub-classing, this defines the super-class
        /// </summary>
        /// <value>When sub-classing, this defines the super-class</value>

        [JsonPropertyName("@baseType")] 
        public string BaseType { get; set; } = string.Empty;

        /// <summary>
        /// A URI to a JSON-Schema file that defines additional attributes and relationships
        /// </summary>
        /// <value>A URI to a JSON-Schema file that defines additional attributes and relationships</value>

        [JsonPropertyName("@schemaLocation")] 
        public string SchemaLocation { get; set; } = string.Empty;

        /// <summary>
        /// When sub-classing, this defines the sub-class entity name
        /// </summary>
        /// <value>When sub-classing, this defines the sub-class entity name</value>

        [JsonPropertyName("@type")] 
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// The actual type of the target instance when needed for disambiguation.
        /// </summary>
        /// <value>The actual type of the target instance when needed for disambiguation.</value>

        [JsonPropertyName("@referredType")]
        public string ReferredType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountRef {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BaseType: ").Append(BaseType).Append("\n");
            sb.Append("  SchemaLocation: ").Append(SchemaLocation).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ReferredType: ").Append(ReferredType).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((AccountRefDto)obj);
        }

        /// <summary>
        /// Returns true if AccountRefDto instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountRefDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountRefDto other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) &&
                (
                    Href == other.Href ||
                    Href != null &&
                    Href.Equals(other.Href)
                ) &&
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) &&
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) &&
                (
                    BaseType == other.BaseType ||
                    BaseType != null &&
                    BaseType.Equals(other.BaseType)
                ) &&
                (
                    SchemaLocation == other.SchemaLocation ||
                    SchemaLocation != null &&
                    SchemaLocation.Equals(other.SchemaLocation)
                ) &&
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) &&
                (
                    ReferredType == other.ReferredType ||
                    ReferredType != null &&
                    ReferredType.Equals(other.ReferredType)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Href != null)
                    hashCode = hashCode * 59 + Href.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (BaseType != null)
                    hashCode = hashCode * 59 + BaseType.GetHashCode();
                if (SchemaLocation != null)
                    hashCode = hashCode * 59 + SchemaLocation.GetHashCode();
                if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                if (ReferredType != null)
                    hashCode = hashCode * 59 + ReferredType.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(AccountRefDto left, AccountRefDto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AccountRefDto left, AccountRefDto right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
