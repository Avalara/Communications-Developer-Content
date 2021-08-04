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
    /// Tax data for individual line item.
    /// </summary>
    [DataContract]
    public partial class Tax :  IEquatable<Tax>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tax" /> class.
        /// </summary>
        /// <param name="bill">Indicates if tax is billable to customer..</param>
        /// <param name="cmpl">Indicates if the tax is to be reported to jurisdiction..</param>
        /// <param name="tm">Taxable measure..</param>
        /// <param name="calc">Calculation type..</param>
        /// <param name="cat">Tax category name..</param>
        /// <param name="cid">Tax category ID..</param>
        /// <param name="name">Tax name..</param>
        /// <param name="exm">Exempt sale amount..</param>
        /// <param name="lns">Lines..</param>
        /// <param name="min">Minutes..</param>
        /// <param name="pcd">PCode for reporting jurisdiction..</param>
        /// <param name="taxpcd">PCode for taxing jurisdiction.  Only returned if return extended tax data flag is true.</param>
        /// <param name="rate">Tax rate..</param>
        /// <param name="sur">Indicates if this tax is a surcharge..</param>
        /// <param name="tax">Tax amount..</param>
        /// <param name="lvl">Tax level ID..</param>
        /// <param name="tid">Tax type ID..</param>
        /// <param name="usexm">Flag indicating if tax was user exempted  Only returned if return extended tax data flag is true.</param>
        /// <param name="notax">Flag indicating the item is a no tax entry  There were no taxes generated, this entry is to convey back the taxing jurisdiction that was used in the response  Only returned if return extended tax data flag is true.</param>
        /// <param name="trans">Transaction type used to calculate tax  For bundles will be specific bundled item transaction type  Only returned if return extended tax data flag is true.</param>
        /// <param name="svc">Service type used to calculate tax  For bundles will be specific bundled item service type  Only returned if return extended tax data flag is true.</param>
        /// <param name="chg">Charge used to calculate tax  For bundles will be the percentage of charge applied to bundled item  For tax inclusive calls will be the calculated charge  Only returned if return extended tax data flag is true.</param>
        public Tax(bool? bill = default(bool?), bool? cmpl = default(bool?), double? tm = default(double?), int? calc = default(int?), string cat = default(string), int? cid = default(int?), string name = default(string), double? exm = default(double?), int? lns = default(int?), double? min = default(double?), int? pcd = default(int?), int? taxpcd = default(int?), double? rate = default(double?), bool? sur = default(bool?), double? tax = default(double?), int? lvl = default(int?), int? tid = default(int?), bool? usexm = default(bool?), bool? notax = default(bool?), int? trans = default(int?), int? svc = default(int?), double? chg = default(double?))
        {
            this.Bill = bill;
            this.Cmpl = cmpl;
            this.Tm = tm;
            this.Calc = calc;
            this.Cat = cat;
            this.Cid = cid;
            this.Name = name;
            this.Exm = exm;
            this.Lns = lns;
            this.Min = min;
            this.Pcd = pcd;
            this.Taxpcd = taxpcd;
            this.Rate = rate;
            this.Sur = sur;
            this._Tax = tax;
            this.Lvl = lvl;
            this.Tid = tid;
            this.Usexm = usexm;
            this.Notax = notax;
            this.Trans = trans;
            this.Svc = svc;
            this.Chg = chg;
        }
        
        /// <summary>
        /// Indicates if tax is billable to customer.
        /// </summary>
        /// <value>Indicates if tax is billable to customer.</value>
        [DataMember(Name="bill", EmitDefaultValue=true)]
        public bool? Bill { get; set; }

        /// <summary>
        /// Indicates if the tax is to be reported to jurisdiction.
        /// </summary>
        /// <value>Indicates if the tax is to be reported to jurisdiction.</value>
        [DataMember(Name="cmpl", EmitDefaultValue=true)]
        public bool? Cmpl { get; set; }

        /// <summary>
        /// Taxable measure.
        /// </summary>
        /// <value>Taxable measure.</value>
        [DataMember(Name="tm", EmitDefaultValue=true)]
        public double? Tm { get; set; }

        /// <summary>
        /// Calculation type.
        /// </summary>
        /// <value>Calculation type.</value>
        [DataMember(Name="calc", EmitDefaultValue=true)]
        public int? Calc { get; set; }

        /// <summary>
        /// Tax category name.
        /// </summary>
        /// <value>Tax category name.</value>
        [DataMember(Name="cat", EmitDefaultValue=true)]
        public string Cat { get; set; }

        /// <summary>
        /// Tax category ID.
        /// </summary>
        /// <value>Tax category ID.</value>
        [DataMember(Name="cid", EmitDefaultValue=true)]
        public int? Cid { get; set; }

        /// <summary>
        /// Tax name.
        /// </summary>
        /// <value>Tax name.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Exempt sale amount.
        /// </summary>
        /// <value>Exempt sale amount.</value>
        [DataMember(Name="exm", EmitDefaultValue=true)]
        public double? Exm { get; set; }

        /// <summary>
        /// Lines.
        /// </summary>
        /// <value>Lines.</value>
        [DataMember(Name="lns", EmitDefaultValue=true)]
        public int? Lns { get; set; }

        /// <summary>
        /// Minutes.
        /// </summary>
        /// <value>Minutes.</value>
        [DataMember(Name="min", EmitDefaultValue=true)]
        public double? Min { get; set; }

        /// <summary>
        /// PCode for reporting jurisdiction.
        /// </summary>
        /// <value>PCode for reporting jurisdiction.</value>
        [DataMember(Name="pcd", EmitDefaultValue=true)]
        public int? Pcd { get; set; }

        /// <summary>
        /// PCode for taxing jurisdiction.  Only returned if return extended tax data flag is true
        /// </summary>
        /// <value>PCode for taxing jurisdiction.  Only returned if return extended tax data flag is true</value>
        [DataMember(Name="taxpcd", EmitDefaultValue=true)]
        public int? Taxpcd { get; set; }

        /// <summary>
        /// Tax rate.
        /// </summary>
        /// <value>Tax rate.</value>
        [DataMember(Name="rate", EmitDefaultValue=true)]
        public double? Rate { get; set; }

        /// <summary>
        /// Indicates if this tax is a surcharge.
        /// </summary>
        /// <value>Indicates if this tax is a surcharge.</value>
        [DataMember(Name="sur", EmitDefaultValue=true)]
        public bool? Sur { get; set; }

        /// <summary>
        /// Tax amount.
        /// </summary>
        /// <value>Tax amount.</value>
        [DataMember(Name="tax", EmitDefaultValue=true)]
        public double? _Tax { get; set; }

        /// <summary>
        /// Tax level ID.
        /// </summary>
        /// <value>Tax level ID.</value>
        [DataMember(Name="lvl", EmitDefaultValue=true)]
        public int? Lvl { get; set; }

        /// <summary>
        /// Tax type ID.
        /// </summary>
        /// <value>Tax type ID.</value>
        [DataMember(Name="tid", EmitDefaultValue=true)]
        public int? Tid { get; set; }

        /// <summary>
        /// Flag indicating if tax was user exempted  Only returned if return extended tax data flag is true
        /// </summary>
        /// <value>Flag indicating if tax was user exempted  Only returned if return extended tax data flag is true</value>
        [DataMember(Name="usexm", EmitDefaultValue=true)]
        public bool? Usexm { get; set; }

        /// <summary>
        /// Flag indicating the item is a no tax entry  There were no taxes generated, this entry is to convey back the taxing jurisdiction that was used in the response  Only returned if return extended tax data flag is true
        /// </summary>
        /// <value>Flag indicating the item is a no tax entry  There were no taxes generated, this entry is to convey back the taxing jurisdiction that was used in the response  Only returned if return extended tax data flag is true</value>
        [DataMember(Name="notax", EmitDefaultValue=true)]
        public bool? Notax { get; set; }

        /// <summary>
        /// Transaction type used to calculate tax  For bundles will be specific bundled item transaction type  Only returned if return extended tax data flag is true
        /// </summary>
        /// <value>Transaction type used to calculate tax  For bundles will be specific bundled item transaction type  Only returned if return extended tax data flag is true</value>
        [DataMember(Name="trans", EmitDefaultValue=true)]
        public int? Trans { get; set; }

        /// <summary>
        /// Service type used to calculate tax  For bundles will be specific bundled item service type  Only returned if return extended tax data flag is true
        /// </summary>
        /// <value>Service type used to calculate tax  For bundles will be specific bundled item service type  Only returned if return extended tax data flag is true</value>
        [DataMember(Name="svc", EmitDefaultValue=true)]
        public int? Svc { get; set; }

        /// <summary>
        /// Charge used to calculate tax  For bundles will be the percentage of charge applied to bundled item  For tax inclusive calls will be the calculated charge  Only returned if return extended tax data flag is true
        /// </summary>
        /// <value>Charge used to calculate tax  For bundles will be the percentage of charge applied to bundled item  For tax inclusive calls will be the calculated charge  Only returned if return extended tax data flag is true</value>
        [DataMember(Name="chg", EmitDefaultValue=true)]
        public double? Chg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tax {\n");
            sb.Append("  Bill: ").Append(Bill).Append("\n");
            sb.Append("  Cmpl: ").Append(Cmpl).Append("\n");
            sb.Append("  Tm: ").Append(Tm).Append("\n");
            sb.Append("  Calc: ").Append(Calc).Append("\n");
            sb.Append("  Cat: ").Append(Cat).Append("\n");
            sb.Append("  Cid: ").Append(Cid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Exm: ").Append(Exm).Append("\n");
            sb.Append("  Lns: ").Append(Lns).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Pcd: ").Append(Pcd).Append("\n");
            sb.Append("  Taxpcd: ").Append(Taxpcd).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Sur: ").Append(Sur).Append("\n");
            sb.Append("  _Tax: ").Append(_Tax).Append("\n");
            sb.Append("  Lvl: ").Append(Lvl).Append("\n");
            sb.Append("  Tid: ").Append(Tid).Append("\n");
            sb.Append("  Usexm: ").Append(Usexm).Append("\n");
            sb.Append("  Notax: ").Append(Notax).Append("\n");
            sb.Append("  Trans: ").Append(Trans).Append("\n");
            sb.Append("  Svc: ").Append(Svc).Append("\n");
            sb.Append("  Chg: ").Append(Chg).Append("\n");
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
            return this.Equals(input as Tax);
        }

        /// <summary>
        /// Returns true if Tax instances are equal
        /// </summary>
        /// <param name="input">Instance of Tax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tax input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bill == input.Bill ||
                    (this.Bill != null &&
                    this.Bill.Equals(input.Bill))
                ) && 
                (
                    this.Cmpl == input.Cmpl ||
                    (this.Cmpl != null &&
                    this.Cmpl.Equals(input.Cmpl))
                ) && 
                (
                    this.Tm == input.Tm ||
                    (this.Tm != null &&
                    this.Tm.Equals(input.Tm))
                ) && 
                (
                    this.Calc == input.Calc ||
                    (this.Calc != null &&
                    this.Calc.Equals(input.Calc))
                ) && 
                (
                    this.Cat == input.Cat ||
                    (this.Cat != null &&
                    this.Cat.Equals(input.Cat))
                ) && 
                (
                    this.Cid == input.Cid ||
                    (this.Cid != null &&
                    this.Cid.Equals(input.Cid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Exm == input.Exm ||
                    (this.Exm != null &&
                    this.Exm.Equals(input.Exm))
                ) && 
                (
                    this.Lns == input.Lns ||
                    (this.Lns != null &&
                    this.Lns.Equals(input.Lns))
                ) && 
                (
                    this.Min == input.Min ||
                    (this.Min != null &&
                    this.Min.Equals(input.Min))
                ) && 
                (
                    this.Pcd == input.Pcd ||
                    (this.Pcd != null &&
                    this.Pcd.Equals(input.Pcd))
                ) && 
                (
                    this.Taxpcd == input.Taxpcd ||
                    (this.Taxpcd != null &&
                    this.Taxpcd.Equals(input.Taxpcd))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.Sur == input.Sur ||
                    (this.Sur != null &&
                    this.Sur.Equals(input.Sur))
                ) && 
                (
                    this._Tax == input._Tax ||
                    (this._Tax != null &&
                    this._Tax.Equals(input._Tax))
                ) && 
                (
                    this.Lvl == input.Lvl ||
                    (this.Lvl != null &&
                    this.Lvl.Equals(input.Lvl))
                ) && 
                (
                    this.Tid == input.Tid ||
                    (this.Tid != null &&
                    this.Tid.Equals(input.Tid))
                ) && 
                (
                    this.Usexm == input.Usexm ||
                    (this.Usexm != null &&
                    this.Usexm.Equals(input.Usexm))
                ) && 
                (
                    this.Notax == input.Notax ||
                    (this.Notax != null &&
                    this.Notax.Equals(input.Notax))
                ) && 
                (
                    this.Trans == input.Trans ||
                    (this.Trans != null &&
                    this.Trans.Equals(input.Trans))
                ) && 
                (
                    this.Svc == input.Svc ||
                    (this.Svc != null &&
                    this.Svc.Equals(input.Svc))
                ) && 
                (
                    this.Chg == input.Chg ||
                    (this.Chg != null &&
                    this.Chg.Equals(input.Chg))
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
                if (this.Bill != null)
                    hashCode = hashCode * 59 + this.Bill.GetHashCode();
                if (this.Cmpl != null)
                    hashCode = hashCode * 59 + this.Cmpl.GetHashCode();
                if (this.Tm != null)
                    hashCode = hashCode * 59 + this.Tm.GetHashCode();
                if (this.Calc != null)
                    hashCode = hashCode * 59 + this.Calc.GetHashCode();
                if (this.Cat != null)
                    hashCode = hashCode * 59 + this.Cat.GetHashCode();
                if (this.Cid != null)
                    hashCode = hashCode * 59 + this.Cid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Exm != null)
                    hashCode = hashCode * 59 + this.Exm.GetHashCode();
                if (this.Lns != null)
                    hashCode = hashCode * 59 + this.Lns.GetHashCode();
                if (this.Min != null)
                    hashCode = hashCode * 59 + this.Min.GetHashCode();
                if (this.Pcd != null)
                    hashCode = hashCode * 59 + this.Pcd.GetHashCode();
                if (this.Taxpcd != null)
                    hashCode = hashCode * 59 + this.Taxpcd.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
                if (this.Sur != null)
                    hashCode = hashCode * 59 + this.Sur.GetHashCode();
                if (this._Tax != null)
                    hashCode = hashCode * 59 + this._Tax.GetHashCode();
                if (this.Lvl != null)
                    hashCode = hashCode * 59 + this.Lvl.GetHashCode();
                if (this.Tid != null)
                    hashCode = hashCode * 59 + this.Tid.GetHashCode();
                if (this.Usexm != null)
                    hashCode = hashCode * 59 + this.Usexm.GetHashCode();
                if (this.Notax != null)
                    hashCode = hashCode * 59 + this.Notax.GetHashCode();
                if (this.Trans != null)
                    hashCode = hashCode * 59 + this.Trans.GetHashCode();
                if (this.Svc != null)
                    hashCode = hashCode * 59 + this.Svc.GetHashCode();
                if (this.Chg != null)
                    hashCode = hashCode * 59 + this.Chg.GetHashCode();
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
