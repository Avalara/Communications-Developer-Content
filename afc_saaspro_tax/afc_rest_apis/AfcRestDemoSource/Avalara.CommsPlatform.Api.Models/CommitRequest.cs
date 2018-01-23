using Newtonsoft.Json;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Parameter for CommitTransactions API.
    /// </summary>
    public class CommitRequest
    {
        /// <summary>
        /// Document code.
        /// </summary>
        [JsonProperty("doc", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentCode { get; set; }

        /// <summary>
        /// Indicates if transactions for the specified document code should be committed.
        /// </summary>
        [JsonProperty("cmmt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Commit { get; set; }

        /// <summary>
        /// Overrides value for OptionalFields field in reports.
        /// </summary>
        [JsonProperty("opt", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<KeyValuePair> OptionalFields { get; set; }
    }
}