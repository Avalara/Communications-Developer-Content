using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Container class for json priperties assocated with v2.CalcTaxes request configuration options
    /// </summary>
    public class RequestConfig
    {
        /// <summary>
        /// Flag indicating non-billable taxes should be returned.
        /// If set, will override account setting
        /// Default if not provided is account setting value
        /// </summary>
        [JsonProperty("retnb", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnNonBillable { get; set; }

        /// <summary>
        /// Flag indicating extended tax information should be returned.
        /// Reference online documentation for more details 
        /// </summary>
        [JsonProperty("retext", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnExtendedData { get; set; }

        /// <summary>
        /// Flag indicating reporting information should be returned.
        /// Reference online documentation for more details 
        /// </summary>
        [JsonProperty("incrf", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeReportingInformation { get; set; }
    }
}