/*
 * SaasPro
 *
 * APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.<br /><br />Effective January 1st, 2022 all Avalara products will be enforcing TLS 1.2 server-side. Please ensure that your implementation sets a minimal of TLS 1.2 encryption when making web requests to Avalara APIs.
 *
 * The version of the OpenAPI document: v2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = avalara.comms.rest.v2.Client.OpenAPIDateConverter;

namespace avalara.comms.rest.v2.Model
{
    /// <summary>
    /// Location data used to determine taxing jurisdiction.
    /// </summary>
    [DataContract(Name = "Location")]
    public partial class Location : IEquatable<Location>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        /// <param name="cnty">County name..</param>
        /// <param name="ctry">Country ISO code..</param>
        /// <param name="_int">Indicates if the location is within city limits.  Default: true..</param>
        /// <param name="geo">Indicates if this address should be geocoded in order to obtain taxing jurisdiction.  Default: false..</param>
        /// <param name="pcd">PCode for taxing jurisdiction..</param>
        /// <param name="npa">NPANXX number..</param>
        /// <param name="fips">FIPS code for taxing jurisdiction..</param>
        /// <param name="addr">Street address..</param>
        /// <param name="city">City name..</param>
        /// <param name="st">State name or abbreviation..</param>
        /// <param name="zip">Postal code..</param>
        public Location(string cnty = default(string), string ctry = default(string), bool? _int = default(bool?), bool? geo = default(bool?), int? pcd = default(int?), int? npa = default(int?), string fips = default(string), string addr = default(string), string city = default(string), string st = default(string), string zip = default(string))
        {
            this.Cnty = cnty;
            this.Ctry = ctry;
            this.Int = _int;
            this.Geo = geo;
            this.Pcd = pcd;
            this.Npa = npa;
            this.Fips = fips;
            this.Addr = addr;
            this.City = city;
            this.St = st;
            this.Zip = zip;
        }

        /// <summary>
        /// County name.
        /// </summary>
        /// <value>County name.</value>
        [DataMember(Name = "cnty", EmitDefaultValue = true)]
        public string Cnty { get; set; }

        /// <summary>
        /// Country ISO code.
        /// </summary>
        /// <value>Country ISO code.</value>
        [DataMember(Name = "ctry", EmitDefaultValue = true)]
        public string Ctry { get; set; }

        /// <summary>
        /// Indicates if the location is within city limits.  Default: true.
        /// </summary>
        /// <value>Indicates if the location is within city limits.  Default: true.</value>
        [DataMember(Name = "int", EmitDefaultValue = true)]
        public bool? Int { get; set; }

        /// <summary>
        /// Indicates if this address should be geocoded in order to obtain taxing jurisdiction.  Default: false.
        /// </summary>
        /// <value>Indicates if this address should be geocoded in order to obtain taxing jurisdiction.  Default: false.</value>
        [DataMember(Name = "geo", EmitDefaultValue = true)]
        public bool? Geo { get; set; }

        /// <summary>
        /// PCode for taxing jurisdiction.
        /// </summary>
        /// <value>PCode for taxing jurisdiction.</value>
        [DataMember(Name = "pcd", EmitDefaultValue = true)]
        public int? Pcd { get; set; }

        /// <summary>
        /// NPANXX number.
        /// </summary>
        /// <value>NPANXX number.</value>
        [DataMember(Name = "npa", EmitDefaultValue = true)]
        public int? Npa { get; set; }

        /// <summary>
        /// FIPS code for taxing jurisdiction.
        /// </summary>
        /// <value>FIPS code for taxing jurisdiction.</value>
        [DataMember(Name = "fips", EmitDefaultValue = true)]
        public string Fips { get; set; }

        /// <summary>
        /// Street address.
        /// </summary>
        /// <value>Street address.</value>
        [DataMember(Name = "addr", EmitDefaultValue = true)]
        public string Addr { get; set; }

        /// <summary>
        /// City name.
        /// </summary>
        /// <value>City name.</value>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// State name or abbreviation.
        /// </summary>
        /// <value>State name or abbreviation.</value>
        [DataMember(Name = "st", EmitDefaultValue = true)]
        public string St { get; set; }

        /// <summary>
        /// Postal code.
        /// </summary>
        /// <value>Postal code.</value>
        [DataMember(Name = "zip", EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Location {\n");
            sb.Append("  Cnty: ").Append(Cnty).Append("\n");
            sb.Append("  Ctry: ").Append(Ctry).Append("\n");
            sb.Append("  Int: ").Append(Int).Append("\n");
            sb.Append("  Geo: ").Append(Geo).Append("\n");
            sb.Append("  Pcd: ").Append(Pcd).Append("\n");
            sb.Append("  Npa: ").Append(Npa).Append("\n");
            sb.Append("  Fips: ").Append(Fips).Append("\n");
            sb.Append("  Addr: ").Append(Addr).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  St: ").Append(St).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Location);
        }

        /// <summary>
        /// Returns true if Location instances are equal
        /// </summary>
        /// <param name="input">Instance of Location to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Location input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cnty == input.Cnty ||
                    (this.Cnty != null &&
                    this.Cnty.Equals(input.Cnty))
                ) && 
                (
                    this.Ctry == input.Ctry ||
                    (this.Ctry != null &&
                    this.Ctry.Equals(input.Ctry))
                ) && 
                (
                    this.Int == input.Int ||
                    (this.Int != null &&
                    this.Int.Equals(input.Int))
                ) && 
                (
                    this.Geo == input.Geo ||
                    (this.Geo != null &&
                    this.Geo.Equals(input.Geo))
                ) && 
                (
                    this.Pcd == input.Pcd ||
                    (this.Pcd != null &&
                    this.Pcd.Equals(input.Pcd))
                ) && 
                (
                    this.Npa == input.Npa ||
                    (this.Npa != null &&
                    this.Npa.Equals(input.Npa))
                ) && 
                (
                    this.Fips == input.Fips ||
                    (this.Fips != null &&
                    this.Fips.Equals(input.Fips))
                ) && 
                (
                    this.Addr == input.Addr ||
                    (this.Addr != null &&
                    this.Addr.Equals(input.Addr))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.St == input.St ||
                    (this.St != null &&
                    this.St.Equals(input.St))
                ) && 
                (
                    this.Zip == input.Zip ||
                    (this.Zip != null &&
                    this.Zip.Equals(input.Zip))
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
                if (this.Cnty != null)
                    hashCode = hashCode * 59 + this.Cnty.GetHashCode();
                if (this.Ctry != null)
                    hashCode = hashCode * 59 + this.Ctry.GetHashCode();
                if (this.Int != null)
                    hashCode = hashCode * 59 + this.Int.GetHashCode();
                if (this.Geo != null)
                    hashCode = hashCode * 59 + this.Geo.GetHashCode();
                if (this.Pcd != null)
                    hashCode = hashCode * 59 + this.Pcd.GetHashCode();
                if (this.Npa != null)
                    hashCode = hashCode * 59 + this.Npa.GetHashCode();
                if (this.Fips != null)
                    hashCode = hashCode * 59 + this.Fips.GetHashCode();
                if (this.Addr != null)
                    hashCode = hashCode * 59 + this.Addr.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.St != null)
                    hashCode = hashCode * 59 + this.St.GetHashCode();
                if (this.Zip != null)
                    hashCode = hashCode * 59 + this.Zip.GetHashCode();
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
