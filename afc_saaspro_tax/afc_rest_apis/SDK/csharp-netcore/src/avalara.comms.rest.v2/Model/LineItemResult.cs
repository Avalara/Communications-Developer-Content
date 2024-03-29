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
    /// Tax calculation results for a single line item.
    /// </summary>
    [DataContract(Name = "LineItemResult")]
    public partial class LineItemResult : IEquatable<LineItemResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemResult" /> class.
        /// </summary>
        /// <param name="_ref">Reference ID for line item..</param>
        /// <param name="_base">Base sale amount for tax-inclusive line items..</param>
        /// <param name="txs">Taxes generated for line item..</param>
        /// <param name="err">Error description (as applicable)..</param>
        public LineItemResult(string _ref = default(string), double? _base = default(double?), List<Tax> txs = default(List<Tax>), List<Error> err = default(List<Error>))
        {
            this.Ref = _ref;
            this.Base = _base;
            this.Txs = txs;
            this.Err = err;
        }

        /// <summary>
        /// Reference ID for line item.
        /// </summary>
        /// <value>Reference ID for line item.</value>
        [DataMember(Name = "ref", EmitDefaultValue = true)]
        public string Ref { get; set; }

        /// <summary>
        /// Base sale amount for tax-inclusive line items.
        /// </summary>
        /// <value>Base sale amount for tax-inclusive line items.</value>
        [DataMember(Name = "base", EmitDefaultValue = true)]
        public double? Base { get; set; }

        /// <summary>
        /// Taxes generated for line item.
        /// </summary>
        /// <value>Taxes generated for line item.</value>
        [DataMember(Name = "txs", EmitDefaultValue = true)]
        public List<Tax> Txs { get; set; }

        /// <summary>
        /// Error description (as applicable).
        /// </summary>
        /// <value>Error description (as applicable).</value>
        [DataMember(Name = "err", EmitDefaultValue = true)]
        public List<Error> Err { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineItemResult {\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
            sb.Append("  Base: ").Append(Base).Append("\n");
            sb.Append("  Txs: ").Append(Txs).Append("\n");
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
            return this.Equals(input as LineItemResult);
        }

        /// <summary>
        /// Returns true if LineItemResult instances are equal
        /// </summary>
        /// <param name="input">Instance of LineItemResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItemResult input)
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
                    this.Base == input.Base ||
                    (this.Base != null &&
                    this.Base.Equals(input.Base))
                ) && 
                (
                    this.Txs == input.Txs ||
                    this.Txs != null &&
                    input.Txs != null &&
                    this.Txs.SequenceEqual(input.Txs)
                ) && 
                (
                    this.Err == input.Err ||
                    this.Err != null &&
                    input.Err != null &&
                    this.Err.SequenceEqual(input.Err)
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
                if (this.Base != null)
                    hashCode = hashCode * 59 + this.Base.GetHashCode();
                if (this.Txs != null)
                    hashCode = hashCode * 59 + this.Txs.GetHashCode();
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
