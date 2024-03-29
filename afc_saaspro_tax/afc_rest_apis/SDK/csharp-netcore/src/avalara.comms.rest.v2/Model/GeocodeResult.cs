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
    /// Results for geocoding request.
    /// </summary>
    [DataContract(Name = "GeocodeResult")]
    public partial class GeocodeResult : IEquatable<GeocodeResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeocodeResult" /> class.
        /// </summary>
        /// <param name="_ref">Reference Id from geocode request input..</param>
        /// <param name="cass">cass.</param>
        /// <param name="cBlk">Census block..</param>
        /// <param name="cTrc">Census tract..</param>
        /// <param name="cnty">County.</param>
        /// <param name="feat">Feature ID..</param>
        /// <param name="fips">FIPS Code..</param>
        /// <param name="inc">Indicates if address is within city limits..</param>
        /// <param name="jur">Tax jurisdiction name..</param>
        /// <param name="lat">Latitude..</param>
        /// <param name="_long">Longitude..</param>
        /// <param name="pcd">PCode for tax jurisdiction..</param>
        /// <param name="scr">Score indicating accuracy of address match in mapping database..</param>
        /// <param name="err">Error message..</param>
        public GeocodeResult(string _ref = default(string), Address cass = default(Address), int? cBlk = default(int?), int? cTrc = default(int?), string cnty = default(string), int? feat = default(int?), string fips = default(string), bool? inc = default(bool?), string jur = default(string), double? lat = default(double?), double? _long = default(double?), int? pcd = default(int?), double? scr = default(double?), string err = default(string))
        {
            this.Ref = _ref;
            this.Cass = cass;
            this.CBlk = cBlk;
            this.CTrc = cTrc;
            this.Cnty = cnty;
            this.Feat = feat;
            this.Fips = fips;
            this.Inc = inc;
            this.Jur = jur;
            this.Lat = lat;
            this.Long = _long;
            this.Pcd = pcd;
            this.Scr = scr;
            this.Err = err;
        }

        /// <summary>
        /// Reference Id from geocode request input.
        /// </summary>
        /// <value>Reference Id from geocode request input.</value>
        [DataMember(Name = "ref", EmitDefaultValue = true)]
        public string Ref { get; set; }

        /// <summary>
        /// Gets or Sets Cass
        /// </summary>
        [DataMember(Name = "cass", EmitDefaultValue = false)]
        public Address Cass { get; set; }

        /// <summary>
        /// Census block.
        /// </summary>
        /// <value>Census block.</value>
        [DataMember(Name = "cBlk", EmitDefaultValue = true)]
        public int? CBlk { get; set; }

        /// <summary>
        /// Census tract.
        /// </summary>
        /// <value>Census tract.</value>
        [DataMember(Name = "cTrc", EmitDefaultValue = true)]
        public int? CTrc { get; set; }

        /// <summary>
        /// County
        /// </summary>
        /// <value>County</value>
        [DataMember(Name = "cnty", EmitDefaultValue = true)]
        public string Cnty { get; set; }

        /// <summary>
        /// Feature ID.
        /// </summary>
        /// <value>Feature ID.</value>
        [DataMember(Name = "feat", EmitDefaultValue = true)]
        public int? Feat { get; set; }

        /// <summary>
        /// FIPS Code.
        /// </summary>
        /// <value>FIPS Code.</value>
        [DataMember(Name = "fips", EmitDefaultValue = true)]
        public string Fips { get; set; }

        /// <summary>
        /// Indicates if address is within city limits.
        /// </summary>
        /// <value>Indicates if address is within city limits.</value>
        [DataMember(Name = "inc", EmitDefaultValue = true)]
        public bool? Inc { get; set; }

        /// <summary>
        /// Tax jurisdiction name.
        /// </summary>
        /// <value>Tax jurisdiction name.</value>
        [DataMember(Name = "jur", EmitDefaultValue = true)]
        public string Jur { get; set; }

        /// <summary>
        /// Latitude.
        /// </summary>
        /// <value>Latitude.</value>
        [DataMember(Name = "lat", EmitDefaultValue = true)]
        public double? Lat { get; set; }

        /// <summary>
        /// Longitude.
        /// </summary>
        /// <value>Longitude.</value>
        [DataMember(Name = "long", EmitDefaultValue = true)]
        public double? Long { get; set; }

        /// <summary>
        /// PCode for tax jurisdiction.
        /// </summary>
        /// <value>PCode for tax jurisdiction.</value>
        [DataMember(Name = "pcd", EmitDefaultValue = true)]
        public int? Pcd { get; set; }

        /// <summary>
        /// Score indicating accuracy of address match in mapping database.
        /// </summary>
        /// <value>Score indicating accuracy of address match in mapping database.</value>
        [DataMember(Name = "scr", EmitDefaultValue = true)]
        public double? Scr { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        /// <value>Error message.</value>
        [DataMember(Name = "err", EmitDefaultValue = true)]
        public string Err { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeocodeResult {\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
            sb.Append("  Cass: ").Append(Cass).Append("\n");
            sb.Append("  CBlk: ").Append(CBlk).Append("\n");
            sb.Append("  CTrc: ").Append(CTrc).Append("\n");
            sb.Append("  Cnty: ").Append(Cnty).Append("\n");
            sb.Append("  Feat: ").Append(Feat).Append("\n");
            sb.Append("  Fips: ").Append(Fips).Append("\n");
            sb.Append("  Inc: ").Append(Inc).Append("\n");
            sb.Append("  Jur: ").Append(Jur).Append("\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  Long: ").Append(Long).Append("\n");
            sb.Append("  Pcd: ").Append(Pcd).Append("\n");
            sb.Append("  Scr: ").Append(Scr).Append("\n");
            sb.Append("  Err: ").Append(Err).Append("\n");
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
            return this.Equals(input as GeocodeResult);
        }

        /// <summary>
        /// Returns true if GeocodeResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GeocodeResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeocodeResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ref == input.Ref ||
                    (this.Ref != null &&
                    this.Ref.Equals(input.Ref))
                ) && 
                (
                    this.Cass == input.Cass ||
                    (this.Cass != null &&
                    this.Cass.Equals(input.Cass))
                ) && 
                (
                    this.CBlk == input.CBlk ||
                    (this.CBlk != null &&
                    this.CBlk.Equals(input.CBlk))
                ) && 
                (
                    this.CTrc == input.CTrc ||
                    (this.CTrc != null &&
                    this.CTrc.Equals(input.CTrc))
                ) && 
                (
                    this.Cnty == input.Cnty ||
                    (this.Cnty != null &&
                    this.Cnty.Equals(input.Cnty))
                ) && 
                (
                    this.Feat == input.Feat ||
                    (this.Feat != null &&
                    this.Feat.Equals(input.Feat))
                ) && 
                (
                    this.Fips == input.Fips ||
                    (this.Fips != null &&
                    this.Fips.Equals(input.Fips))
                ) && 
                (
                    this.Inc == input.Inc ||
                    (this.Inc != null &&
                    this.Inc.Equals(input.Inc))
                ) && 
                (
                    this.Jur == input.Jur ||
                    (this.Jur != null &&
                    this.Jur.Equals(input.Jur))
                ) && 
                (
                    this.Lat == input.Lat ||
                    (this.Lat != null &&
                    this.Lat.Equals(input.Lat))
                ) && 
                (
                    this.Long == input.Long ||
                    (this.Long != null &&
                    this.Long.Equals(input.Long))
                ) && 
                (
                    this.Pcd == input.Pcd ||
                    (this.Pcd != null &&
                    this.Pcd.Equals(input.Pcd))
                ) && 
                (
                    this.Scr == input.Scr ||
                    (this.Scr != null &&
                    this.Scr.Equals(input.Scr))
                ) && 
                (
                    this.Err == input.Err ||
                    (this.Err != null &&
                    this.Err.Equals(input.Err))
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
                if (this.Ref != null)
                    hashCode = hashCode * 59 + this.Ref.GetHashCode();
                if (this.Cass != null)
                    hashCode = hashCode * 59 + this.Cass.GetHashCode();
                if (this.CBlk != null)
                    hashCode = hashCode * 59 + this.CBlk.GetHashCode();
                if (this.CTrc != null)
                    hashCode = hashCode * 59 + this.CTrc.GetHashCode();
                if (this.Cnty != null)
                    hashCode = hashCode * 59 + this.Cnty.GetHashCode();
                if (this.Feat != null)
                    hashCode = hashCode * 59 + this.Feat.GetHashCode();
                if (this.Fips != null)
                    hashCode = hashCode * 59 + this.Fips.GetHashCode();
                if (this.Inc != null)
                    hashCode = hashCode * 59 + this.Inc.GetHashCode();
                if (this.Jur != null)
                    hashCode = hashCode * 59 + this.Jur.GetHashCode();
                if (this.Lat != null)
                    hashCode = hashCode * 59 + this.Lat.GetHashCode();
                if (this.Long != null)
                    hashCode = hashCode * 59 + this.Long.GetHashCode();
                if (this.Pcd != null)
                    hashCode = hashCode * 59 + this.Pcd.GetHashCode();
                if (this.Scr != null)
                    hashCode = hashCode * 59 + this.Scr.GetHashCode();
                if (this.Err != null)
                    hashCode = hashCode * 59 + this.Err.GetHashCode();
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
