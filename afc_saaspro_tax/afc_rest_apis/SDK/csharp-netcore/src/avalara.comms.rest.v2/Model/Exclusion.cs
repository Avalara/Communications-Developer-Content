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
    /// Specifies a tax exclusion by state.
    /// </summary>
    [DataContract(Name = "Exclusion")]
    public partial class Exclusion : IEquatable<Exclusion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Exclusion" /> class.
        /// </summary>
        /// <param name="ctry">Country ISO code..</param>
        /// <param name="st">State abbreviation..</param>
        /// <param name="excl">Indicates if exclusion applies to the specified state..</param>
        public Exclusion(string ctry = default(string), string st = default(string), bool? excl = default(bool?))
        {
            this.Ctry = ctry;
            this.St = st;
            this.Excl = excl;
        }

        /// <summary>
        /// Country ISO code.
        /// </summary>
        /// <value>Country ISO code.</value>
        [DataMember(Name = "ctry", EmitDefaultValue = true)]
        public string Ctry { get; set; }

        /// <summary>
        /// State abbreviation.
        /// </summary>
        /// <value>State abbreviation.</value>
        [DataMember(Name = "st", EmitDefaultValue = true)]
        public string St { get; set; }

        /// <summary>
        /// Indicates if exclusion applies to the specified state.
        /// </summary>
        /// <value>Indicates if exclusion applies to the specified state.</value>
        [DataMember(Name = "excl", EmitDefaultValue = true)]
        public bool? Excl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Exclusion {\n");
            sb.Append("  Ctry: ").Append(Ctry).Append("\n");
            sb.Append("  St: ").Append(St).Append("\n");
            sb.Append("  Excl: ").Append(Excl).Append("\n");
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
            return this.Equals(input as Exclusion);
        }

        /// <summary>
        /// Returns true if Exclusion instances are equal
        /// </summary>
        /// <param name="input">Instance of Exclusion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Exclusion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ctry == input.Ctry ||
                    (this.Ctry != null &&
                    this.Ctry.Equals(input.Ctry))
                ) && 
                (
                    this.St == input.St ||
                    (this.St != null &&
                    this.St.Equals(input.St))
                ) && 
                (
                    this.Excl == input.Excl ||
                    (this.Excl != null &&
                    this.Excl.Equals(input.Excl))
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
                if (this.Ctry != null)
                    hashCode = hashCode * 59 + this.Ctry.GetHashCode();
                if (this.St != null)
                    hashCode = hashCode * 59 + this.St.GetHashCode();
                if (this.Excl != null)
                    hashCode = hashCode * 59 + this.Excl.GetHashCode();
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
