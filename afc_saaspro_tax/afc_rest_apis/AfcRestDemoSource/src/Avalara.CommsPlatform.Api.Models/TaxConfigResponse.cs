using System.Collections.Generic;
using Avalara.CommsPlatform.Api.Models.Swagger;
using Newtonsoft.Json;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Data for an invoice or quote line item.
    /// </summary>
    public class TaxConfigResponse 
    {
        internal const string LastUpdateByAvaMask = "CommunicationSupport@avalara.com";

        /// <summary>
        /// Unique profile configuration id associated with configuration item
        /// </summary>
        [JsonProperty("ProfileConfigId", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProfileConfigId { get; set; }

        /// <summary>
        /// Profile id's associated with configuration item
        /// </summary>
        [JsonProperty("ProfileIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> ProfileIds { get; set; }

        /// <summary>
        /// Client id associated with configuration item
        /// </summary>
        [JsonProperty("ClientId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientId { get; set; }

        /// <summary>
        /// User who last updated the configuration item
        /// </summary>
        [JsonProperty("LastUpdateBy", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateBy { get; set; }

        /// <summary>
        /// Active status of the configuration item
        /// </summary>
        [JsonProperty("Active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        /// <summary>
        /// Configuration settings (as applicable)
        /// </summary>
        [JsonProperty("Settings", NullValueHandling = NullValueHandling.Ignore)]
        public TaxConfigurationSettings Settings { get; set; }

        /// <summary>
        /// Exclusions (as applicable)
        /// </summary>
        [JsonProperty("Exclusions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClientProfileExclusion> Exclusions { get; set; }

        /// <summary>
        /// Bundles (as applicable)
        /// </summary>
        [JsonProperty("Bundles", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClientProfileBundle> Bundles { get; set; }

        /// <summary>
        /// Nexus (as applicable)
        /// </summary>
        [JsonProperty("Nexus", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClientProfileNexus> Nexus { get; set; }

        /// <summary>
        /// Overrides (as applicable - raw data)
        /// </summary>
        [JsonProperty("Overrides", NullValueHandling = NullValueHandling.Ignore)]
        public ClientProfileOverride Overrides { get; set; }

        /// <summary>
        /// Description associated with this item
        /// </summary>
        [JsonProperty("Description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Error information.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }

        /// <summary>
        /// Item Type
        /// Examples:
        ///   Configuration, Bundle, Exclusion, Override, All
        /// </summary>
        [JsonProperty("ItemType", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemType { get; set; }

        /// <summary>
        /// Converts configuration into api response
        /// </summary>
        /// <param name="cpConfig"></param>
        /// <param name="includeInternal"></param>
        /// <returns>ProfileConfigResponse object</returns>
        public TaxConfigResponse Convert(TaxConfiguration cpConfig, bool includeInternal)
        {
            if (cpConfig == null)
            {
                return this;  // return empty object not null (as calling method expects either a valid object or exception)
            }

            ProfileConfigId = cpConfig.ProfileConfigId;
            ProfileIds = cpConfig.ProfileIds;
            if (ProfileIds != null && ProfileIds.Count > 1)
            {
                ProfileIds.Sort();
            }
            ClientId = cpConfig.ClientId;
            Active = cpConfig.Active;
            ItemType = cpConfig.ItemType.ToString("g");

            // If permitted to see internal data, always return LastUpdateBy
            // else if last update is avalarian, return defined default mask value (protect internal users from external clients)
            // else return LastUpdateBy (if not-avalarian, client can see who updated the configuration last)
             
            if (includeInternal)
            {
                LastUpdateBy = cpConfig.LastUpdateBy;
            }
            else
            {
                LastUpdateBy = cpConfig.LastUpdateBy.ToLower().Contains("avalara") ? LastUpdateByAvaMask : cpConfig.LastUpdateBy;
            }

            ProfileConfigId = cpConfig.ProfileConfigId;
            Description = cpConfig.ItemDescription;

            if (cpConfig.ItemType == ClientProfileItemTypes.Configuration)
            {
                Settings = cpConfig.ProcureConfigSettings(includeInternal);
            }
            else if (cpConfig.ItemType == ClientProfileItemTypes.Exclusion)
            {
                Exclusions = cpConfig.ProcureConfigExclusions();
            }
            else if (cpConfig.ItemType == ClientProfileItemTypes.Bundle)
            {
                Bundles = cpConfig.ProcureConfigBundles();
            }
            else if (cpConfig.ItemType == ClientProfileItemTypes.Nexus)
            {
                Nexus = cpConfig.ProcureConfigNexus();
            }
            else if (cpConfig.ItemType == ClientProfileItemTypes.Override)
            {
                Overrides = cpConfig.ProcureConfigOverrides();
            }
                    
            return this;
        }
    }

    /// <summary>
    /// Response for setting profile will have the updated profiles as well as applicable messages
    /// </summary>
    public class SetProfileConfigResponse
    {
        internal TaxConfiguration UpdatedProfileConfig;

        /// <summary>Set updated profile config for response for reference (as applicable)</summary>
        /// <param name="updatedConfig"></param>
        public void SetUpdatedProfileConfig(TaxConfiguration updatedConfig) { UpdatedProfileConfig = updatedConfig; }
        /// <summary>Get updated profile config for response</summary>
        public TaxConfiguration GetUpdatedProfileConfig() { return UpdatedProfileConfig; }

        /// <summary>
        /// Error information.
        /// </summary>
        [JsonProperty("Errors", NullValueHandling = NullValueHandling.Ignore)]
        public List<Error> Errors { get; set; }

        /// <summary>
        /// Warning information.
        /// </summary>
        [JsonProperty("Warnings", NullValueHandling = NullValueHandling.Ignore)]
        public List<Warning> Warnings { get; set; }

        /// <summary>
        /// Status information.
        /// </summary>
        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        public List<Status> Status { get; set; }

        /// <summary>
        /// Updated client profile objects
        /// </summary>
        [JsonProperty("UpdatedProfiles", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaxConfigResponse> UpdatedProfiles { get; set; }

        /// <summary>
        /// Response error code (as applicable)
        /// </summary>
        [SwaggerIgnore]
        [JsonProperty("ResponseErrorCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResponseErrorCode { get; set; }

        /// <summary>
        /// Handles creating and setting error message
        /// </summary>
        /// <param name="message"></param>
        public void AddError(string message)
        {
            if (Errors == null)
            {
                SetError(message);
            }
            else
            {
                Errors.Add(new Error(message));
            }
        }

        /// <summary>
        /// Handles creating and setting error message and response code
        /// </summary>
        /// <param name="message"></param>
        /// <param name="code"></param>
        public void SetError(string message, int code)
        {
            var errors = new List<Error> { new Error(message) };
            Errors = errors;
            ResponseErrorCode = code;
        }

        /// <summary>
        /// Handles creating and setting error message and response code
        /// </summary>
        /// <param name="message"></param>
        public void SetError(string message)
        {
            var errors = new List<Error> { new Error(message) };
            Errors = errors;
            ResponseErrorCode = new Error().Code;
        }
    }
}