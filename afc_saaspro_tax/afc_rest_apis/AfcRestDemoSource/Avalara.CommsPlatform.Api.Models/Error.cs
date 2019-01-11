
using Newtonsoft.Json;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Error information.
    /// </summary>
    public class Error
    {
        /// <summary>
        /// Error code.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; } = -2000;

        /// <summary>
        /// Error message.
        /// </summary>
        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// Constructor. Defaults Code to -2000.
        /// </summary>
        public Error()
        {
        }

        /// <summary>
        /// Constructor. Defaults Code to -2000.
        /// </summary>
        /// <param name="message">Error message.</param>
        public Error(string message)
        {
            Message = message;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="code">Error code.</param>
        /// <param name="message">Error message.</param>
        public Error(int code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}