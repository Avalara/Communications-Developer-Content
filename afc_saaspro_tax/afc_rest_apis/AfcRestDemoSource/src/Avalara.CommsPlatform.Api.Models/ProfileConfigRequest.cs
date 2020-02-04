using System;
using System.Collections.Generic;
using Avalara.CommsPlatform.Api.Models.Swagger;
using Newtonsoft.Json;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Data for an invoice or quote line item.
    /// </summary>
    public class GetTaxConfigItemRequest
    {
        /// <summary>
        /// Client id associated with profile(s) to be fetched
        /// Null value will use client id submitting the request or default client id as applicable
        /// </summary>
        [JsonProperty("ClientId", NullValueHandling = NullValueHandling.Ignore)]
        public int? RequestedClientId { get; set; }

        /// <summary>
        /// Configuration profile id to be fetched
        /// Use 0 to indicate all profiles
        /// Null value will use profile id from request or 0 if not set.
        /// </summary>
        [JsonProperty("ProfileId", NullValueHandling = NullValueHandling.Ignore)]
        public short? RequestedProfileId { get; set; }

        /// <summary>
        /// Item Type
        /// Examples:
        /// Configuration, Bundle, Exclusion, Override, All
        /// </summary>
        [JsonProperty("ItemType", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ClientProfileItemTypesConverter))]
        public ClientProfileItemTypes? ItemType { get; set; } = ClientProfileItemTypes.All;
    }

    /// <summary>
    /// Configuration settings for update
    /// </summary>
    public class SetTaxConfigBaseRequest
    {
        /// <summary>
        /// Profile configuration id to be used when updating an existing profile
        /// Use null for new configuration
        /// </summary>
        [JsonProperty("ProfileConfigId", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProfileConfigId { get; set; }

        /// <summary>
        /// Profile(s) to be added to configuration
        /// Leave null to not change profiles associated with configuration settings
        /// </summary>
        [JsonProperty("LinkProfileIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<short> LinkProfileIds { get; set; }

        /// <summary>
        /// Profile(s) to be added to configuration
        /// Leave null to not change profiles associated with configuration settings
        /// </summary>
        [JsonProperty("UnlinkProfileIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<short> UnlinkProfileIds { get; set; }

        /// <summary>
        /// Client id associated with configuration
        /// Will use default id for user if null
        /// </summary>
        [JsonProperty("ClientId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientId { get; set; }

        /// <summary>
        /// True = Deactivate the configuration
        /// Requires ProfileConfigId to be provided and valid.
        /// Automatically removes any profile mappings associated with the configuration.
        /// </summary>
        [JsonProperty("Deactivate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deactivate { get; set; }

        /// <summary>
        /// Description to be applied to requested configuration
        /// </summary>
        [JsonProperty("Description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Flag indicating existing configuration links to profile should be replaced
        /// This only applies when one or more profiles have been specified to be linked.
        ///  - If true, mapping conflicts will be resolved by removing other links.
        ///  - If false, mapping conflicts will cause the request to fail with an error returned.
        /// </summary>
        [JsonProperty("ReplaceExistingLinks", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReplaceExistingLinks { get; set; }

    }

    /// <summary>
    /// Configuration settings for update request
    /// </summary>
    public class SetTaxConfigRequest : SetTaxConfigBaseRequest
    {
        /// <summary>
        /// Configuration settings (required)
        /// </summary>
        [JsonProperty("Settings", NullValueHandling = NullValueHandling.Ignore)]
        public TaxConfigurationSettings Settings { get; set; }

        /// <summary>Placeholder for disallowed field.</summary>
        [SwaggerIgnore]
        [JsonProperty("Bundles", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClientProfileBundle> Bundles { set => throw new Exception("Invalid request - bundles cannot be included in SetConfig requests"); }

        /// <summary>Placeholder for disallowed field.</summary>
        [SwaggerIgnore]
        [JsonProperty("Overrides", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Overrides { set => throw new Exception("Invalid request - overrides cannot be included in SetConfig requests"); }

        /// <summary>Placeholder for disallowed field.</summary>
        [SwaggerIgnore]
        [JsonProperty("Exclusions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClientProfileExclusion> Exclusions { set => throw new Exception("Invalid request - exclusions cannot be included in SetConfig requests"); }
    }

    /// <summary>
    /// Exclusions for update request
    /// </summary>
    public class SetTaxExclusionRequest : SetTaxConfigBaseRequest
    {
        /// <summary>
        /// List of exclusions
        /// </summary>
        [JsonProperty("Exclusions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClientProfileExclusion> Exclusions { get; set; }

        /// <summary>Placeholder for disallowed field.</summary>
        [SwaggerIgnore]
        [JsonProperty("Bundles", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClientProfileBundle> Bundles { set => throw new Exception("Invalid request - bundles cannot be included in SetExclusions requests"); }
        /// <summary>Placeholder for disallowed field.</summary>
        [SwaggerIgnore]
        [JsonProperty("Overrides", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Overrides { set => throw new Exception("Invalid request - overrides cannot be included in SetExclusions requests"); }

        /// <summary>Placeholder for disallowed field.</summary>
        [SwaggerIgnore]
        [JsonProperty("Settings", NullValueHandling = NullValueHandling.Ignore)]
        public TaxConfigurationSettings Settings { set => throw new Exception("Invalid request - configuration settings cannot be included in SetExclusions requests"); }
    }

    /// <summary>
    /// Bundles for update request
    /// </summary>
    public class SetTaxBundleRequest : SetTaxConfigBaseRequest
    {
        /// <summary>
        /// List of bundles
        /// </summary>
        [JsonProperty("Bundles", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClientProfileBundle> Bundles { get; set; }

        /// <summary>Placeholder for disallowed field.</summary>
        [SwaggerIgnore]
        [JsonProperty("Exclusions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClientProfileExclusion> Exclusions { set => throw new Exception("Invalid request - exclusions cannot be included in SetBundles requests"); }

        /// <summary>Placeholder for disallowed field.</summary>
        [SwaggerIgnore]
        [JsonProperty("Overrides", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Overrides { set => throw new Exception("Invalid request - overrides cannot be included in SetBundles requests"); }

        /// <summary>Placeholder for disallowed field.</summary>
        [SwaggerIgnore]
        [JsonProperty("Settings", NullValueHandling = NullValueHandling.Ignore)]
        public TaxConfigurationSettings Settings { set => throw new Exception("Invalid request - configuration settings cannot be included in SetBundles requests"); }
    }

    /// <summary>
    /// Nexus values for update request
    /// </summary>
    public class SetTaxNexusRequest : SetTaxConfigBaseRequest
    {
        /// <summary>
        /// List of nexus
        /// </summary>
        [JsonProperty("Nexus", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClientProfileNexus> Nexus { get; set; }
    }

    /// <summary>
    /// Overrides for update request
    /// </summary>
    public class SetTaxOverridesRequest : SetTaxConfigBaseRequest
    {
        /// <summary>
        /// Overrides
        /// </summary>
        [JsonProperty("Overrides", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Overrides { get; set; }

        /// <summary>Placeholder for disallowed field.</summary>
        [SwaggerIgnore]
        [JsonProperty("Exclusions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClientProfileExclusion> Exclusions { set => throw new Exception("Invalid request - exclusions cannot be included in SetOverrides requests"); }

        /// <summary>Placeholder for disallowed field.</summary>
        [SwaggerIgnore]
        [JsonProperty("Bundles", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClientProfileBundle> Bundles { set => throw new Exception("Invalid request - bundles cannot be included in SetOverrides requests"); }

        /// <summary>Placeholder for disallowed field.</summary>
        [SwaggerIgnore]
        [JsonProperty("Settings", NullValueHandling = NullValueHandling.Ignore)]
        public TaxConfigurationSettings Settings { set => throw new Exception("Invalid request - configuration settings cannot be included in SetOverrides requests"); }
    }
}