
using Newtonsoft.Json;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Status information.
    /// </summary>
    public class Status
    {
        /// <summary>
        /// Status code.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; } = 200;

        /// <summary>
        /// Status message.
        /// </summary>
        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// Constructor. Defaults Code to 200.
        /// </summary>
        public Status()
        {
        }

        /// <summary>
        /// Constructor. Defaults Code to 200.
        /// </summary>
        /// <param name="message">Status message.</param>
        public Status(string message)
        {
            Message = message;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="code">Status code.</param>
        /// <param name="message">Status message.</param>
        public Status(int code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}