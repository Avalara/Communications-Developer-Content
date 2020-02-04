using Newtonsoft.Json;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Response body for Commit API.
    /// </summary>
    public class CommitResponse
    {
        /// <summary>
        /// Indicates if document code's commit status was updated successfully.
        /// </summary>
        [JsonProperty("ok", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; }

        /// <summary>
        /// Error description (as applicable).
        /// </summary>
        [JsonProperty("err", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Error> Errors { get; set; }
    }
}
