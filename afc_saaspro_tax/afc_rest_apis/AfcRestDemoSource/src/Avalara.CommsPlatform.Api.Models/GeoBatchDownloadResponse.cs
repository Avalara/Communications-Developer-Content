using Newtonsoft.Json;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Response body for Geo Batch Submit File API.
    /// </summary>
    public class GeoBatchDownloadResponse
    {
        /// <summary>
        /// Input File Name.
        /// </summary>
        [JsonProperty("InputFile", NullValueHandling = NullValueHandling.Ignore)]
        public string InputFileName { get; set; }

        /// <summary>
        /// Input File Download.
        /// </summary>
        [JsonProperty("InputFileDownload", NullValueHandling = NullValueHandling.Ignore)]
        public string InputFileDownload { get; set; }

        /// <summary>
        /// Output File Name.
        /// </summary>
        [JsonProperty("OutputFile", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputFileName { get; set; }

        /// <summary>
        /// Output File Name.
        /// </summary>
        [JsonProperty("OutputFileDownload", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputFileDownload { get; set; }
    }
}
