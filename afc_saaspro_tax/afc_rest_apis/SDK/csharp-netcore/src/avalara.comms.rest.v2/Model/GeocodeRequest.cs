/* 
 * SaasPro
 *
 * APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.<br /><br />Effective January 1st, 2022 all Avalara products will be enforcing TLS 1.2 server-side. Please ensure that your implementation sets a minimal of TLS 1.2 encryption when making web requests to Avalara APIs.
 *
 * The version of the OpenAPI document: v2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = avalara.comms.rest.v2.Client.OpenAPIDateConverter;

namespace avalara.comms.rest.v2.Model
{
    /// <summary>
    /// Input data for Geocoding API.
    /// </summary>
    [DataContract]
    public partial class GeocodeRequest :  IEquatable<GeocodeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeocodeRequest" /> class.
        /// </summary>
        /// <param name="_ref">Optional reference Id for geocode request.   Only address information or latitude/longitude should be provided in request body but not both..</param>
        /// <param name="cass">Indicates if the CASS validated address is desired in the results..</param>
        /// <param name="lat">Latitude for geocoding based on lat/long coordinates..</param>
        /// <param name="_long">Longitude for geocoding based on lat/long coordinates..</param>
        /// <param name="addr">Street address..</param>
        /// <param name="city">City name..</param>
        /// <param name="st">State name or abbreviation..</param>
        /// <param name="zip">Postal code..</param>
        public GeocodeRequest(string _ref = default(string), bool? cass = default(bool?), double? lat = default(double?), double? _long = default(double?), string addr = default(string), string city = default(string), string st = default(string), string zip = default(string))
        {
            this.Ref = _ref;
            this.Cass = cass;
            this.Lat = lat;
            this.Long = _long;
            this.Addr = addr;
            this.City = city;
            this.St = st;
            this.Zip = zip;
        }
        
        /// <summary>
        /// Optional reference Id for geocode request.   Only address information or latitude/longitude should be provided in request body but not both.
        /// </summary>
        /// <value>Optional reference Id for geocode request.   Only address information or latitude/longitude should be provided in request body but not both.</value>
        [DataMember(Name="ref", EmitDefaultValue=true)]
        public string Ref { get; set; }

        /// <summary>
        /// Indicates if the CASS validated address is desired in the results.
        /// </summary>
        /// <value>Indicates if the CASS validated address is desired in the results.</value>
        [DataMember(Name="cass", EmitDefaultValue=true)]
        public bool? Cass { get; set; }

        /// <summary>
        /// Latitude for geocoding based on lat/long coordinates.
        /// </summary>
        /// <value>Latitude for geocoding based on lat/long coordinates.</value>
        [DataMember(Name="lat", EmitDefaultValue=true)]
        public double? Lat { get; set; }

        /// <summary>
        /// Longitude for geocoding based on lat/long coordinates.
        /// </summary>
        /// <value>Longitude for geocoding based on lat/long coordinates.</value>
        [DataMember(Name="long", EmitDefaultValue=true)]
        public double? Long { get; set; }

        /// <summary>
        /// Street address.
        /// </summary>
        /// <value>Street address.</value>
        [DataMember(Name="addr", EmitDefaultValue=true)]
        public string Addr { get; set; }

        /// <summary>
        /// City name.
        /// </summary>
        /// <value>City name.</value>
        [DataMember(Name="city", EmitDefaultValue=true)]
        public string City { get; set; }

        /// <summary>
        /// State name or abbreviation.
        /// </summary>
        /// <value>State name or abbreviation.</value>
        [DataMember(Name="st", EmitDefaultValue=true)]
        public string St { get; set; }

        /// <summary>
        /// Postal code.
        /// </summary>
        /// <value>Postal code.</value>
        [DataMember(Name="zip", EmitDefaultValue=true)]
        public string Zip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeocodeRequest {\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
            sb.Append("  Cass: ").Append(Cass).Append("\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  Long: ").Append(Long).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GeocodeRequest);
        }

        /// <summary>
        /// Returns true if GeocodeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GeocodeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeocodeRequest input)
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
                if (this.Ref != null)
                    hashCode = hashCode * 59 + this.Ref.GetHashCode();
                if (this.Cass != null)
                    hashCode = hashCode * 59 + this.Cass.GetHashCode();
                if (this.Lat != null)
                    hashCode = hashCode * 59 + this.Lat.GetHashCode();
                if (this.Long != null)
                    hashCode = hashCode * 59 + this.Long.GetHashCode();
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
