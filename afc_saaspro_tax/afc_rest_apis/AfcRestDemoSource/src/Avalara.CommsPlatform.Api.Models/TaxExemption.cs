using Newtonsoft.Json;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Tax exemption data.
    /// </summary>
    public class TaxExemption
    {
        /// <summary>
        /// Override level exempt flag on wildcard tax type exemptions.
        /// </summary>
        /// <remarks>True (Default) - Tax type wildcard exemptions will exempt taxes tagged not level exemptible
        /// False - Tax type wildcard exemptions will exclude taxes tagged not level exemptible from consideration</remarks>
        [JsonProperty("frc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force { get; set; }

        /// <summary>
        /// Jurisdiction for exemption
        /// </summary>
        /// <remarks>Match occurs at level specified by domain setting.</remarks>
        [JsonProperty("loc", NullValueHandling = NullValueHandling.Ignore)]
        public Location Location { get; set; }

        /// <summary>
        /// Tax type to exempt.  Tax type exemptions and Category exemptions are mutually exclusive.
        /// </summary>
        /// <remarks>0 Indicates wildcard - exempts all tax types</remarks>
        [JsonProperty("tpe", NullValueHandling = NullValueHandling.Ignore)]
        public short? TaxType { get; set; }

        /// <summary>
        /// Tax level ID.
        /// </summary>
        /// <remarks>Obsolete - provided for legacy support.  Use Domain and Scope instead.</remarks>
        [JsonProperty("lvl", NullValueHandling = NullValueHandling.Ignore)]
        public short? TaxLevel { get; set; }

        /// <summary>
        /// Tax category to exempt. Tax type exemptions and Category exemptions are mutually exclusive.
        /// </summary>
        /// <remarks>0 Indicates wildcard - exempts all categories</remarks>
        [JsonProperty("cat", NullValueHandling = NullValueHandling.Ignore)]
        public short? TaxCategory { get; set; }

        /// <summary>
        /// Exemption Domain.  This is the jurisdiction level in which the
        /// exemption jurisdiction must match the taxing jurisdiction.
        /// </summary>
        /// <remarks>0=Federal  1=State  2=County  3=City</remarks>
        [JsonProperty("dom", NullValueHandling = NullValueHandling.Ignore)]
        public short? Domain { get; set; }

        /// <summary>
        /// Exemption Scope.  This defines the tax levels in which the
        /// taxes will be considered as candidates for exemption.
        /// </summary>
        /// <remarks>Combination of (128=Federal  256=State  512=County  1024=Local)
        /// Example:  1920=All (Federal+State+County+Local)</remarks>
        [JsonProperty("scp", NullValueHandling = NullValueHandling.Ignore)]
        public short? Scope { get; set; }

        /// <summary>
        /// Exempt non-billable flag.  Determines if non-billable taxes are
        /// to be considered as candidates for exemption.
        /// </summary>
        /// <remarks>True - nonbillable taxes can be exempted
        /// False (Default)- nonbillable taxes will not be exempted</remarks>
        [JsonProperty("exnb", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExemptNonbillable { get; set; }

    }
}