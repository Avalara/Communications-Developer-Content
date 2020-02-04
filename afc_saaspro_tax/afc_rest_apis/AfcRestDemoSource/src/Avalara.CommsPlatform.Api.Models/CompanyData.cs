using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Container class for json priperties assocated with v2.CalcTaxes company data
    /// </summary>
    public class CompanyData
    {
        /// <summary>
        /// Business class. 0 = ILEC, 1 = CLEC.
        /// </summary>
        [JsonProperty("bscl", NullValueHandling = NullValueHandling.Ignore)]
        public short? BusinessClass { get; set; }

        /// <summary>
        /// Service class. 0 = Primary Local, 1 = Primary Long Distance.
        /// </summary>
        [JsonProperty("svcl", NullValueHandling = NullValueHandling.Ignore)]
        public short? ServiceClass { get; set; }

        /// <summary>
        /// Specifies if the carrier delivering the service has company owned facilities to provide the service.
        /// </summary>
        [JsonProperty("fclt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Facilities { get; set; }

        /// <summary>
        /// Indicates if the company provides services sold pursuant to a franchise agreement between the carrier and jurisdiction.
        /// </summary>
        [JsonProperty("frch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Franchise { get; set; }

        /// <summary>
        /// Indicates if company is regulated.
        /// </summary>
        [JsonProperty("reg", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Regulated { get; set; }

        /// <summary>
        /// Exclusion list.
        /// </summary>
        [JsonProperty("excl", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Exclusion> Exclusions { get; set; }

        /// <summary>
        /// An optional company identifier for reporting
        /// </summary>
        [JsonProperty("idnt", NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyIdentifier { get; set; }
    }
}