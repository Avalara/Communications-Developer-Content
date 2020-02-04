using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Avalara.CommsPlatform.Api.Models.Swagger;
using Avalara.CommsPlatform.DataAccessService.Models;
using Newtonsoft.Json;

namespace Avalara.CommsPlatform.Api.Models
{

    /// <summary>
    /// Choice of Configuration item types
    /// - New entries should be added to table ClientProfileConfigXRef also 
    /// - Use caution in changes to existing entries as it may impact 
    ///   references in ClientProfileConfig.ItemType
    /// </summary>
    public enum ClientProfileItemTypes
    {
        /// <summary>All items</summary>
        All,
        /// <summary>Configuration setting item</summary>
        Configuration,
        /// <summary>Bundle item</summary>
        Bundle,
        /// <summary>Exclusion Item</summary>
        Exclusion,
        /// <summary>Override item</summary>
        Override,
        /// <summary>Nexus item</summary>
        Nexus,
        /// <summary>Exemption item</summary>
        Exemption


        ////// Add new entries to the end of the list - do not insert into list //////
    }

    /// <summary>
    /// Json converter implementation for ClientProfileItemTypes enum
    /// </summary>
    public class ClientProfileItemTypesConverter : JsonConverter
    {
        /// <summary>
        /// Conversion of enum deserialization
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            try
            {
                writer.WriteValue(((ClientProfileItemTypes)value).ToString("g"));
            }
            catch
            {
                writer.WriteValue("Undefined");
            }
        }

        /// <summary>
        /// Conversion of enum serialization
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            object parse;
            try
            {
                parse = Enum.Parse(typeof(ClientProfileItemTypes), (string)reader.Value, true);
            }
            catch
            {
                // Set to undefined so appropriate error handling can occur 
                // (this is not a good place to throw an exception - can result in a 500 error on a request)
                parse = null;
            }
            return parse;
        }

        /// <summary>
        /// Testing convertability
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(ClientProfileItemTypes);
        }
    }

    /// <summary>
    /// Choice of algorithms for Tax-On-Tax calculations
    /// </summary>
    public enum TaxOnTaxAlgorithms
    {
        /// <summary>Tax-on-tax is calculated in a single pass.</summary>
        SinglePass,
        /// <summary>Tax-on-tax iterates until the difference in the tax-on-tax calculated tax amount is less than 0.005</summary>
        IterateOnTaxAmount,
        /// <summary>Tax-on-tax iterates until the difference in the tax-on-tax calculated taxable measure is less than 0.005</summary>
        IterateOnTaxableMeasure
    }

    /// <summary>
    /// Choice of algorithms for Self-Tax calculations
    /// </summary>
    public enum SelfTaxAlgorithms
    {
        /// <summary>Each self-tax is calculated independently</summary>
        Individual,
        /// <summary>All self-tax taxes for calculation are calculated as an aggregate</summary>
        Aggregate
    }

    /// <summary>
    /// Safe Harbor default Federal percentages
    /// </summary>
    public class AfcSafeHarborValues
    {
        /// <summary>Cellular safe harbor value</summary>
        public const double Cellular = 0.371;
        /// <summary>VoIP safe harbor value</summary>
        public const double VoIP = 0.649;
        /// <summary>Paging safe harbor value</summary>
        public const double Paging = 0.12;
    }

    /// <summary>
    /// Specifies a traffic study override
    /// </summary>
    public class AfcTrafficStudyOverride
    {
        internal const double RATE_EPSILON = 0.00000001;

        /// <summary>Defines which transaction type the traffic study override applies to.  Ref enum SafeHarborType for list.</summary>
        [JsonProperty("TrafficStudyType", NullValueHandling = NullValueHandling.Ignore)]
        public short TrafficStudyType { get; set; }

        /// <summary>Safe harbor value to be overriden.  Ref class AfcSafeHarborValues for default values.</summary>
        [SwaggerIgnore]
        [JsonProperty("SafeHarborFedPcnt", NullValueHandling = NullValueHandling.Ignore)]
        public double? SafeHarborFedPcnt { get; set; }

        /// <summary>Client provided traffic study percent (Federal) to be used instead of safe harbor.</summary>
        [JsonProperty("TrafficStudyFedPcnt", NullValueHandling = NullValueHandling.Ignore)]
        public double TrafficStudyFedPcnt { get; set; }

        /// <summary>Instantiate empty object</summary>
        public AfcTrafficStudyOverride() { }

        /// <summary>Instantiate using default safe harbor percent</summary>
        public AfcTrafficStudyOverride(SafeHarborType type, double trafficStudy)
        {
            SetData(type, 0.0, trafficStudy);
        }

        /// <summary>Instantiate using provided safe harbor percent</summary>
        public AfcTrafficStudyOverride(SafeHarborType type, double safeHarbor, double trafficStudy)
        {
            SetData(type, safeHarbor, trafficStudy);
        }

        internal void SetData(SafeHarborType type, double safeHarbor, double trafficStudy)
        {
            TrafficStudyType = (short)type;
            TrafficStudyFedPcnt = trafficStudy;
            if (safeHarbor < RATE_EPSILON)
            {
                switch (type)
                {
                    case SafeHarborType.Cellular:
                        SafeHarborFedPcnt = AfcSafeHarborValues.Cellular;
                        break;
                    case SafeHarborType.VoIP:
                        SafeHarborFedPcnt = AfcSafeHarborValues.VoIP;
                        break;
                    case SafeHarborType.Paging:
                        SafeHarborFedPcnt = AfcSafeHarborValues.Paging;
                        break;
                }
            }
            else
            {
                SafeHarborFedPcnt = safeHarbor;
            }
        }
    }

    /// <summary>
    /// Settings associated with a client profile override
    /// Maybe associated with 0 to many profiles
    /// </summary>
    public class ClientProfileOverride
    {
        /// <summary>
        /// Raw data
        /// </summary>
        [JsonProperty("RawData", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RawData { get; set; }
    }

    /// <summary>
    /// Settings associated with a client profile exclusions
    /// Maybe associated with 0 to many profiles
    /// </summary>
    public class ClientProfileExclusion
    {
        /// <summary>
        /// Country ISO value
        /// </summary>
        [JsonProperty("CountryIso", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryIso { get; set; }

        /// <summary>
        /// State abbreviation
        /// </summary>
        [JsonProperty("State", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }
    }

    /// <summary>
    /// Settings associated with a client profile nexus
    /// Maybe associated with 0 to many profiles
    /// </summary>
    public class ClientProfileNexus
    {
        /// <summary>
        /// State abbreviation
        /// </summary>
        [JsonProperty("State", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }
    }

    /// <summary>
    /// Bundled items associated with a bundle package
    /// </summary>
    public class ClientProfileBundleItem
    {
        /// <summary>
        /// Transaction id for item
        /// </summary>
        [JsonProperty("TransactionId", NullValueHandling = NullValueHandling.Ignore)]
        public short TransactionId { get; set; }

        /// <summary>
        /// Service id for item
        /// </summary>
        [JsonProperty("ServiceId", NullValueHandling = NullValueHandling.Ignore)]
        public short ServiceId { get; set; }

        /// <summary>
        /// Percentage of package charge to be applied to item
        /// </summary>
        [JsonProperty("Percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? Percentage { get; set; }

        /// <summary>
        /// Fixed charge to be applied to item
        /// </summary>
        [JsonProperty("FixedAmount", NullValueHandling = NullValueHandling.Ignore)]
        public double? FixedAmount { get; set; }

        /// <summary>
        /// Fixed lines to be applied to item
        /// </summary>
        [JsonProperty("Lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? Lines { get; set; }

        /// <summary>
        /// Fixed minutes to be applied to item
        /// </summary>
        [JsonProperty("Minutes", NullValueHandling = NullValueHandling.Ignore)]
        public double? Minutes { get; set; }

        /// <summary>
        /// Transaction id for item
        /// </summary>
        [SwaggerIgnore]
        [JsonProperty("TransactionDesc", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionDesc { get; set; }

        /// <summary>
        /// Service id for item
        /// </summary>
        [SwaggerIgnore]
        [JsonProperty("ServiceDesc", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceDesc { get; set; }

    }

    /// <summary>
    /// Bundles associated with a client profile configuration
    /// Maybe associated with 0 to many profiles
    /// </summary>
    public class ClientProfileBundle
    {
        /// <summary>
        /// Bundle Package - example:  20000
        /// </summary>
        [JsonProperty("BundlePackage", NullValueHandling = NullValueHandling.Ignore)]
        public short BundlePackage { get; set; }

        /// <summary>
        /// Bundle Id - example:  20001
        /// </summary>
        [JsonProperty("BundleId", NullValueHandling = NullValueHandling.Ignore)]
        public short BundleId { get; set; }

        /// <summary>
        /// Bundle Description
        /// </summary>
        [JsonProperty("Description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Bundled items - percentage should add up to 100% (as applicable)
        /// </summary>
        [JsonProperty("BundleItems", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClientProfileBundleItem> BundleItems { get; set; }

        /// <summary>
        /// Version for bundle - intended to allow changes to format 
        /// without having to perform expensive SQL updates on existing bundles
        /// </summary>
        [SwaggerIgnore]
        [JsonProperty("Version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    /// <summary>
    /// Settings associated with a client profile configuration
    /// Maybe associated with 0 to many profiles
    /// </summary>
    public class TaxConfigurationSettings
    {
        /// <summary>
        /// List of Traffic Study Overrides
        /// </summary>
        [JsonProperty("TrafficStudyOverrides", NullValueHandling = NullValueHandling.Ignore)]
        public List<AfcTrafficStudyOverride> TrafficStudyOverrides { get; set; }

        /// <summary>
        /// true : Return both non-billable and billable taxes in taxation response
        /// false (default) : Return billable taxes only in taxation response
        /// Default: false
        /// </summary>
        [JsonProperty("ReturnNonBillable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnNonBillable { get; set; }

        /// <summary>
        /// Tax-on-tax algorithm to be used in tax calculations
        /// 0 : Single pass
        /// 1 (default) : IterateOnTaxAmount
        /// 2 : IterateOnTaxableMeasure
        /// </summary>
        [JsonProperty("TaxOnTaxAlgorithm", NullValueHandling = NullValueHandling.Ignore)]
        public short? TaxOnTaxAlgorithm { get; set; }

        /// <summary>
        /// Self-tax algorithm to be used in tax calculations
        /// 0 (default) : Calculate tax on individual self-taxing taxes
        /// 1 : Calculate tax on aggregate of self-taxing taxes
        /// </summary>
        [JsonProperty("SelfTaxAlgorithm", NullValueHandling = NullValueHandling.Ignore)]
        public short? SelfTaxAlgorithm { get; set; }

        /// <summary>
        /// Internal configuration settings
        /// </summary>
        [SwaggerIgnore]
        [JsonProperty("InternalProfileConfig", NullValueHandling = NullValueHandling.Ignore)]
        public InternalProfileConfig Internal { get; set; }
    }

    /// <summary>
    /// Settings associated with a internal configuration settings
    /// </summary>
    public class InternalProfileConfig
    {
        /// <summary>
        /// Integer value to increase memory allocated for loading override file
        /// </summary>
        [SwaggerIgnore]
        [JsonProperty("CustomerOverrideMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public short? CustomerOverrideMultiplier { get; set; }

        /// <summary>
        /// Flag to output status file to working directory
        /// </summary>
        [SwaggerIgnore]
        [JsonProperty("EnableStatusFile", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableStatusFile { get; set; }

        /// <summary>
        /// Flag to disable initialization of tax inclusive session construction on session construction
        ///</summary>
        [SwaggerIgnore]
        [JsonProperty("DisableTaxInclusiveSessionInit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableTaxInclusiveSessionInit { get; set; }

        /// <summary>
        /// Flag for session to abort if warnings occur during initialization
        /// </summary>
        [SwaggerIgnore]
        [JsonProperty("AbortOnInitWarning", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AbortOnInitWarning { get; set; }
    }

    /// <summary>ClientProfileConfig</summary>
    public class TaxConfiguration
    {
        /// <summary>ProcureConfigSettings</summary>
        public TaxConfigurationSettings ProcureConfigSettings(bool includeInternal)
        {
            TaxConfigurationSettings taxConfigurationSettings = null;

            if (!string.IsNullOrEmpty(ItemData))
            {
                taxConfigurationSettings = JsonConvert.DeserializeObject<TaxConfigurationSettings>(ItemData);
            }

            if (!includeInternal)
            {
                taxConfigurationSettings.Internal = null;
            }

            return taxConfigurationSettings;
        }

        /// <summary>ProcureConfigExclusions - returns list of exclusions associated with client/profile</summary>
        public List<ClientProfileExclusion> ProcureConfigExclusions()
        {
            List<ClientProfileExclusion> exclusions = null;

            if (!string.IsNullOrEmpty(ItemData))
            {
                exclusions = JsonConvert.DeserializeObject<List<ClientProfileExclusion>>(ItemData);
            }

            return exclusions;
        }

        /// <summary>ProcureConfigBundles - returns list of bundles associated with client/profile</summary>
        public List<ClientProfileBundle> ProcureConfigBundles()
        {
            List<ClientProfileBundle> bundles = null;

            if (!string.IsNullOrEmpty(ItemData))
            {
                bundles = JsonConvert.DeserializeObject<List<ClientProfileBundle>>(ItemData);
            }

            return bundles;
        }

        /// <summary>ProcureConfigNexus - returns list of nexus values associated with client/profile</summary>
        public List<ClientProfileNexus> ProcureConfigNexus()
        {
            List<ClientProfileNexus> nexus = null;

            if (!string.IsNullOrEmpty(ItemData))
            {
                nexus = JsonConvert.DeserializeObject<List<ClientProfileNexus>>(ItemData);
            }

            return nexus;
        }

        /// <summary>ProcureConfigNexus - returns list of nexus values associated with client/profile</summary>
        public ClientProfileOverride ProcureConfigOverrides()
        {
            ClientProfileOverride profileOverride = null;

            if (!string.IsNullOrEmpty(ItemData))
            {
                profileOverride = new ClientProfileOverride
                {
                    RawData = JsonConvert.DeserializeObject<List<string>>(ItemData)
                };
            }

            return profileOverride;
        }

        /// <summary>
        /// The profile ids.
        /// </summary>
        [NotMapped]
        public List<int> ProfileIds { get; set; } = new List<int>();

        /// <summary>ProfileConfigId</summary>
        public long? ProfileConfigId { get; set; }

        /// <summary>Client Id</summary>
        public int? ClientId { get; set; }
        /// <summary>UserName</summary>
        public string LastUpdateBy { get; set; }
        /// <summary>Active</summary>
        public bool? Active { get; set; }
        /// <summary>Type associated with item</summary>
        public ClientProfileItemTypes ItemType { get; set; }
        /// <summary>Data associated with item</summary>
        public string ItemData { get; set; }
        /// <summary>Description associated with item</summary>
        public string ItemDescription { get; set; }

        /// <summary>Date item created</summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>Date item updated</summary>
        public DateTime LastUpdateDate { get; set; }

        /// <summary>SetProfileIds</summary>
        public void AddProfileId(int profileId)
        {
            ProfileIds.Add(profileId);
        }

        /// <summary>ProcureAfcEngineConfiguration</summary>
        public AfcEngineConfiguration ProcureAfcEngineConfiguration()
        {
            TaxConfigurationSettings settings = ProcureConfigSettings(true);
            AfcEngineConfiguration engCfg = null;
            if (settings != null)
            {
                engCfg = new AfcEngineConfiguration
                {
                    ReturnNonbillable = settings.ReturnNonBillable ?? false
                };

                if (settings.TrafficStudyOverrides != null && settings.TrafficStudyOverrides.Count > 0)
                {
                    foreach (AfcTrafficStudyOverride trafficStudyOverride in settings.TrafficStudyOverrides)
                    {
                        engCfg.AfcTrafficStudy = new DataAccessService.Models.AfcTrafficStudyOverride(
                            (SafeHarborType) trafficStudyOverride.TrafficStudyType,
                            trafficStudyOverride.TrafficStudyFedPcnt);
                        break;
                    }
                }

                if (settings.TaxOnTaxAlgorithm.HasValue)
                {
                    engCfg.TaxOnTaxAlgorithm = (DataAccessService.Models.TaxOnTaxAlgorithms)settings.TaxOnTaxAlgorithm;
                }

                if (settings.SelfTaxAlgorithm.HasValue)
                {
                    engCfg.SelfTaxAlgorithm = (DataAccessService.Models.SelfTaxAlgorithms)settings.SelfTaxAlgorithm;
                }

                InternalProfileConfig internalProfileConfig = settings.Internal;
                if (internalProfileConfig != null)
                {
                    engCfg.InternalUsage = new ConfigurationInternalUsage
                    {
                        CustomerOverrideMultiplier = internalProfileConfig.CustomerOverrideMultiplier ?? 1,
                        EnableStatusFile = internalProfileConfig.EnableStatusFile ?? false,
                        DisableTaxInclusiveSessionInit = internalProfileConfig.DisableTaxInclusiveSessionInit ?? false,
                        AbortOnInitWarning = internalProfileConfig.AbortOnInitWarning ?? false
                    };
                }
            }
            return engCfg;
        }

        /// <summary>Overload to copy select data for database updates</summary>
        /// <param name="from"></param>
        public void CopyForDb(TaxConfiguration from)
        {
            ClientId = from.ClientId;
            LastUpdateBy = from.LastUpdateBy;
            Active = from.Active;
            ItemType = from.ItemType;
            ItemData = from.ItemData;
            ItemDescription = from.ItemDescription;
            LastUpdateDate = from.LastUpdateDate;
        }

        /// <summary>
        /// Test whether TaxConfiguration object refers to same profile item object passed in
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(TaxConfiguration other)
        {
            // Check whether the compared object is null. 
            if (ReferenceEquals(other, null))
            {
                return false;
            }

            // Check whether the compared object references the same data. 
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return ProfileConfigId == other.ProfileConfigId;
        }


        /// <summary>
        /// If Equals() returns true for a pair of objects then GetHashCode() 
        /// must return the same value for these objects. 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            // Get hash code for the Name field if it is not null. 
            int hashProfileConfigId = ProfileConfigId == null ? 0 : ProfileConfigId.GetHashCode();

            // Calculate the hash code for the product. 
            return hashProfileConfigId;
        }
    }

    /// <summary>ClientProfileConfigMapping</summary>
    public class TaxConfigMapping
    {
        /// <summary>ProfileConfigMappingId</summary>
        public long ProfileConfigMappingId { get; set; }
        /// <summary>ProfileConfigId</summary>
        public long ProfileConfigId { get; set; }
        /// <summary>ProfileId</summary>
        public int ProfileId { get; set; }
    }
}