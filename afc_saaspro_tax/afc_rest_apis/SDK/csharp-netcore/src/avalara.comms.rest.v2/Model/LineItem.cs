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
    /// Data for an invoice or quote line item.
    /// </summary>
    [DataContract]
    public partial class LineItem :  IEquatable<LineItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItem" /> class.
        /// </summary>
        /// <param name="_ref">Reference ID for line item..</param>
        /// <param name="from">from.</param>
        /// <param name="to">to.</param>
        /// <param name="chg">Charge amount.  Default: 0..</param>
        /// <param name="line">Number of lines.  Default: 0..</param>
        /// <param name="loc">Number of locations.  Default: 0..</param>
        /// <param name="min">Number of minutes.  Default: 0..</param>
        /// <param name="sale">0 - Wholesale : Indicates that the item was sold to a wholeseller.  1 - Retail : Indicates that the item was sold to an end user - a retail sale.  2 - Consumed : Indicates that the item was consumed directly (SAU products only).  3 - VendorUse : Indicates that the item is subject to vendor use tax (SAU products only)..</param>
        /// <param name="plsp">Split for private-line transactions..</param>
        /// <param name="incl">Indicates if the charge for this line item is tax-inclusive..</param>
        /// <param name="pror">For pro-rated tax calculations. Percentage to pro-rate..</param>
        /// <param name="proadj">For pro-rated credit or adjustment calculations.  0 &#x3D; default  1 &#x3D; do not return non-proratable fixed taxes in response  2 &#x3D; return non-proratable fixed taxes in response.</param>
        /// <param name="tran">Transaction type ID..</param>
        /// <param name="serv">Service type ID..</param>
        /// <param name="dbt">Indicates if this line item is a debit card transaction.  Default: false..</param>
        /// <param name="adj">Indicates if this line item is an adjustment.  Default: false..</param>
        /// <param name="adjm">Adjustment method..</param>
        /// <param name="disc">Discount type for adjustments..</param>
        /// <param name="opt">Optional values for line item. Maximum of 5. Keys must be numeric from 5 to 10..</param>
        /// <param name="prop">Attribute/property value for sales and use transaction/service pairs..</param>
        /// <param name="bill">bill.</param>
        /// <param name="cust">Customer type..</param>
        /// <param name="lfln">Indicates if customer is a Lifeline participant.  Default: false..</param>
        /// <param name="date">Invoice date..</param>
        /// <param name="qty">Quantity to be applied to the item - taxation is equivalent to repeating the item the number of times of the quantity.</param>
        /// <param name="glref">General Ledger reference to be used in reporting.</param>
        public LineItem(string _ref = default(string), Location from = default(Location), Location to = default(Location), double? chg = default(double?), int? line = default(int?), int? loc = default(int?), double? min = default(double?), int? sale = default(int?), double? plsp = default(double?), bool? incl = default(bool?), double? pror = default(double?), int proadj = default(int), int? tran = default(int?), int? serv = default(int?), bool? dbt = default(bool?), bool? adj = default(bool?), int? adjm = default(int?), int? disc = default(int?), List<KeyValuePair> opt = default(List<KeyValuePair>), int? prop = default(int?), Location bill = default(Location), int? cust = default(int?), bool? lfln = default(bool?), DateTime? date = default(DateTime?), int? qty = default(int?), string glref = default(string))
        {
            this.Ref = _ref;
            this.From = from;
            this.To = to;
            this.Chg = chg;
            this.Line = line;
            this.Loc = loc;
            this.Min = min;
            this.Sale = sale;
            this.Plsp = plsp;
            this.Incl = incl;
            this.Pror = pror;
            this.Proadj = proadj;
            this.Tran = tran;
            this.Serv = serv;
            this.Dbt = dbt;
            this.Adj = adj;
            this.Adjm = adjm;
            this.Disc = disc;
            this.Opt = opt;
            this.Prop = prop;
            this.Bill = bill;
            this.Cust = cust;
            this.Lfln = lfln;
            this.Date = date;
            this.Qty = qty;
            this.Glref = glref;
        }
        
        /// <summary>
        /// Reference ID for line item.
        /// </summary>
        /// <value>Reference ID for line item.</value>
        [DataMember(Name="ref", EmitDefaultValue=true)]
        public string Ref { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public Location From { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public Location To { get; set; }

        /// <summary>
        /// Charge amount.  Default: 0.
        /// </summary>
        /// <value>Charge amount.  Default: 0.</value>
        [DataMember(Name="chg", EmitDefaultValue=true)]
        public double? Chg { get; set; }

        /// <summary>
        /// Number of lines.  Default: 0.
        /// </summary>
        /// <value>Number of lines.  Default: 0.</value>
        [DataMember(Name="line", EmitDefaultValue=true)]
        public int? Line { get; set; }

        /// <summary>
        /// Number of locations.  Default: 0.
        /// </summary>
        /// <value>Number of locations.  Default: 0.</value>
        [DataMember(Name="loc", EmitDefaultValue=true)]
        public int? Loc { get; set; }

        /// <summary>
        /// Number of minutes.  Default: 0.
        /// </summary>
        /// <value>Number of minutes.  Default: 0.</value>
        [DataMember(Name="min", EmitDefaultValue=true)]
        public double? Min { get; set; }

        /// <summary>
        /// 0 - Wholesale : Indicates that the item was sold to a wholeseller.  1 - Retail : Indicates that the item was sold to an end user - a retail sale.  2 - Consumed : Indicates that the item was consumed directly (SAU products only).  3 - VendorUse : Indicates that the item is subject to vendor use tax (SAU products only).
        /// </summary>
        /// <value>0 - Wholesale : Indicates that the item was sold to a wholeseller.  1 - Retail : Indicates that the item was sold to an end user - a retail sale.  2 - Consumed : Indicates that the item was consumed directly (SAU products only).  3 - VendorUse : Indicates that the item is subject to vendor use tax (SAU products only).</value>
        [DataMember(Name="sale", EmitDefaultValue=true)]
        public int? Sale { get; set; }

        /// <summary>
        /// Split for private-line transactions.
        /// </summary>
        /// <value>Split for private-line transactions.</value>
        [DataMember(Name="plsp", EmitDefaultValue=true)]
        public double? Plsp { get; set; }

        /// <summary>
        /// Indicates if the charge for this line item is tax-inclusive.
        /// </summary>
        /// <value>Indicates if the charge for this line item is tax-inclusive.</value>
        [DataMember(Name="incl", EmitDefaultValue=true)]
        public bool? Incl { get; set; }

        /// <summary>
        /// For pro-rated tax calculations. Percentage to pro-rate.
        /// </summary>
        /// <value>For pro-rated tax calculations. Percentage to pro-rate.</value>
        [DataMember(Name="pror", EmitDefaultValue=true)]
        public double? Pror { get; set; }

        /// <summary>
        /// For pro-rated credit or adjustment calculations.  0 &#x3D; default  1 &#x3D; do not return non-proratable fixed taxes in response  2 &#x3D; return non-proratable fixed taxes in response
        /// </summary>
        /// <value>For pro-rated credit or adjustment calculations.  0 &#x3D; default  1 &#x3D; do not return non-proratable fixed taxes in response  2 &#x3D; return non-proratable fixed taxes in response</value>
        [DataMember(Name="proadj", EmitDefaultValue=false)]
        public int Proadj { get; set; }

        /// <summary>
        /// Transaction type ID.
        /// </summary>
        /// <value>Transaction type ID.</value>
        [DataMember(Name="tran", EmitDefaultValue=true)]
        public int? Tran { get; set; }

        /// <summary>
        /// Service type ID.
        /// </summary>
        /// <value>Service type ID.</value>
        [DataMember(Name="serv", EmitDefaultValue=true)]
        public int? Serv { get; set; }

        /// <summary>
        /// Indicates if this line item is a debit card transaction.  Default: false.
        /// </summary>
        /// <value>Indicates if this line item is a debit card transaction.  Default: false.</value>
        [DataMember(Name="dbt", EmitDefaultValue=true)]
        public bool? Dbt { get; set; }

        /// <summary>
        /// Indicates if this line item is an adjustment.  Default: false.
        /// </summary>
        /// <value>Indicates if this line item is an adjustment.  Default: false.</value>
        [DataMember(Name="adj", EmitDefaultValue=true)]
        public bool? Adj { get; set; }

        /// <summary>
        /// Adjustment method.
        /// </summary>
        /// <value>Adjustment method.</value>
        [DataMember(Name="adjm", EmitDefaultValue=true)]
        public int? Adjm { get; set; }

        /// <summary>
        /// Discount type for adjustments.
        /// </summary>
        /// <value>Discount type for adjustments.</value>
        [DataMember(Name="disc", EmitDefaultValue=true)]
        public int? Disc { get; set; }

        /// <summary>
        /// Optional values for line item. Maximum of 5. Keys must be numeric from 5 to 10.
        /// </summary>
        /// <value>Optional values for line item. Maximum of 5. Keys must be numeric from 5 to 10.</value>
        [DataMember(Name="opt", EmitDefaultValue=true)]
        public List<KeyValuePair> Opt { get; set; }

        /// <summary>
        /// Attribute/property value for sales and use transaction/service pairs.
        /// </summary>
        /// <value>Attribute/property value for sales and use transaction/service pairs.</value>
        [DataMember(Name="prop", EmitDefaultValue=true)]
        public int? Prop { get; set; }

        /// <summary>
        /// Gets or Sets Bill
        /// </summary>
        [DataMember(Name="bill", EmitDefaultValue=false)]
        public Location Bill { get; set; }

        /// <summary>
        /// Customer type.
        /// </summary>
        /// <value>Customer type.</value>
        [DataMember(Name="cust", EmitDefaultValue=true)]
        public int? Cust { get; set; }

        /// <summary>
        /// Indicates if customer is a Lifeline participant.  Default: false.
        /// </summary>
        /// <value>Indicates if customer is a Lifeline participant.  Default: false.</value>
        [DataMember(Name="lfln", EmitDefaultValue=true)]
        public bool? Lfln { get; set; }

        /// <summary>
        /// Invoice date.
        /// </summary>
        /// <value>Invoice date.</value>
        [DataMember(Name="date", EmitDefaultValue=true)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Quantity to be applied to the item - taxation is equivalent to repeating the item the number of times of the quantity
        /// </summary>
        /// <value>Quantity to be applied to the item - taxation is equivalent to repeating the item the number of times of the quantity</value>
        [DataMember(Name="qty", EmitDefaultValue=true)]
        public int? Qty { get; set; }

        /// <summary>
        /// General Ledger reference to be used in reporting
        /// </summary>
        /// <value>General Ledger reference to be used in reporting</value>
        [DataMember(Name="glref", EmitDefaultValue=true)]
        public string Glref { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineItem {\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Chg: ").Append(Chg).Append("\n");
            sb.Append("  Line: ").Append(Line).Append("\n");
            sb.Append("  Loc: ").Append(Loc).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Sale: ").Append(Sale).Append("\n");
            sb.Append("  Plsp: ").Append(Plsp).Append("\n");
            sb.Append("  Incl: ").Append(Incl).Append("\n");
            sb.Append("  Pror: ").Append(Pror).Append("\n");
            sb.Append("  Proadj: ").Append(Proadj).Append("\n");
            sb.Append("  Tran: ").Append(Tran).Append("\n");
            sb.Append("  Serv: ").Append(Serv).Append("\n");
            sb.Append("  Dbt: ").Append(Dbt).Append("\n");
            sb.Append("  Adj: ").Append(Adj).Append("\n");
            sb.Append("  Adjm: ").Append(Adjm).Append("\n");
            sb.Append("  Disc: ").Append(Disc).Append("\n");
            sb.Append("  Opt: ").Append(Opt).Append("\n");
            sb.Append("  Prop: ").Append(Prop).Append("\n");
            sb.Append("  Bill: ").Append(Bill).Append("\n");
            sb.Append("  Cust: ").Append(Cust).Append("\n");
            sb.Append("  Lfln: ").Append(Lfln).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  Glref: ").Append(Glref).Append("\n");
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
            return this.Equals(input as LineItem);
        }

        /// <summary>
        /// Returns true if LineItem instances are equal
        /// </summary>
        /// <param name="input">Instance of LineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItem input)
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
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Chg == input.Chg ||
                    (this.Chg != null &&
                    this.Chg.Equals(input.Chg))
                ) && 
                (
                    this.Line == input.Line ||
                    (this.Line != null &&
                    this.Line.Equals(input.Line))
                ) && 
                (
                    this.Loc == input.Loc ||
                    (this.Loc != null &&
                    this.Loc.Equals(input.Loc))
                ) && 
                (
                    this.Min == input.Min ||
                    (this.Min != null &&
                    this.Min.Equals(input.Min))
                ) && 
                (
                    this.Sale == input.Sale ||
                    (this.Sale != null &&
                    this.Sale.Equals(input.Sale))
                ) && 
                (
                    this.Plsp == input.Plsp ||
                    (this.Plsp != null &&
                    this.Plsp.Equals(input.Plsp))
                ) && 
                (
                    this.Incl == input.Incl ||
                    (this.Incl != null &&
                    this.Incl.Equals(input.Incl))
                ) && 
                (
                    this.Pror == input.Pror ||
                    (this.Pror != null &&
                    this.Pror.Equals(input.Pror))
                ) && 
                (
                    this.Proadj == input.Proadj ||
                    this.Proadj.Equals(input.Proadj)
                ) && 
                (
                    this.Tran == input.Tran ||
                    (this.Tran != null &&
                    this.Tran.Equals(input.Tran))
                ) && 
                (
                    this.Serv == input.Serv ||
                    (this.Serv != null &&
                    this.Serv.Equals(input.Serv))
                ) && 
                (
                    this.Dbt == input.Dbt ||
                    (this.Dbt != null &&
                    this.Dbt.Equals(input.Dbt))
                ) && 
                (
                    this.Adj == input.Adj ||
                    (this.Adj != null &&
                    this.Adj.Equals(input.Adj))
                ) && 
                (
                    this.Adjm == input.Adjm ||
                    (this.Adjm != null &&
                    this.Adjm.Equals(input.Adjm))
                ) && 
                (
                    this.Disc == input.Disc ||
                    (this.Disc != null &&
                    this.Disc.Equals(input.Disc))
                ) && 
                (
                    this.Opt == input.Opt ||
                    this.Opt != null &&
                    input.Opt != null &&
                    this.Opt.SequenceEqual(input.Opt)
                ) && 
                (
                    this.Prop == input.Prop ||
                    (this.Prop != null &&
                    this.Prop.Equals(input.Prop))
                ) && 
                (
                    this.Bill == input.Bill ||
                    (this.Bill != null &&
                    this.Bill.Equals(input.Bill))
                ) && 
                (
                    this.Cust == input.Cust ||
                    (this.Cust != null &&
                    this.Cust.Equals(input.Cust))
                ) && 
                (
                    this.Lfln == input.Lfln ||
                    (this.Lfln != null &&
                    this.Lfln.Equals(input.Lfln))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && 
                (
                    this.Glref == input.Glref ||
                    (this.Glref != null &&
                    this.Glref.Equals(input.Glref))
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
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Chg != null)
                    hashCode = hashCode * 59 + this.Chg.GetHashCode();
                if (this.Line != null)
                    hashCode = hashCode * 59 + this.Line.GetHashCode();
                if (this.Loc != null)
                    hashCode = hashCode * 59 + this.Loc.GetHashCode();
                if (this.Min != null)
                    hashCode = hashCode * 59 + this.Min.GetHashCode();
                if (this.Sale != null)
                    hashCode = hashCode * 59 + this.Sale.GetHashCode();
                if (this.Plsp != null)
                    hashCode = hashCode * 59 + this.Plsp.GetHashCode();
                if (this.Incl != null)
                    hashCode = hashCode * 59 + this.Incl.GetHashCode();
                if (this.Pror != null)
                    hashCode = hashCode * 59 + this.Pror.GetHashCode();
                hashCode = hashCode * 59 + this.Proadj.GetHashCode();
                if (this.Tran != null)
                    hashCode = hashCode * 59 + this.Tran.GetHashCode();
                if (this.Serv != null)
                    hashCode = hashCode * 59 + this.Serv.GetHashCode();
                if (this.Dbt != null)
                    hashCode = hashCode * 59 + this.Dbt.GetHashCode();
                if (this.Adj != null)
                    hashCode = hashCode * 59 + this.Adj.GetHashCode();
                if (this.Adjm != null)
                    hashCode = hashCode * 59 + this.Adjm.GetHashCode();
                if (this.Disc != null)
                    hashCode = hashCode * 59 + this.Disc.GetHashCode();
                if (this.Opt != null)
                    hashCode = hashCode * 59 + this.Opt.GetHashCode();
                if (this.Prop != null)
                    hashCode = hashCode * 59 + this.Prop.GetHashCode();
                if (this.Bill != null)
                    hashCode = hashCode * 59 + this.Bill.GetHashCode();
                if (this.Cust != null)
                    hashCode = hashCode * 59 + this.Cust.GetHashCode();
                if (this.Lfln != null)
                    hashCode = hashCode * 59 + this.Lfln.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.Glref != null)
                    hashCode = hashCode * 59 + this.Glref.GetHashCode();
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
