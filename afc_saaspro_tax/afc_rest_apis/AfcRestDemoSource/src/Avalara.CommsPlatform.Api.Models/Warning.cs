
using Newtonsoft.Json;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Warning information.
    /// </summary>
    public class Warning
    {
        /// <summary>
        /// Warning code.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; } = 0;

        /// <summary>
        /// Warning message.
        /// </summary>
        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// Constructor. Defaults Code to 0.
        /// </summary>
        public Warning()
        {
        }

        /// <summary>
        /// Constructor. Defaults Code to 0.
        /// </summary>
        /// <param name="message">Warning message.</param>
        public Warning(string message)
        {
            Message = message;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="code">Warning code.</param>
        /// <param name="message">Warning message.</param>
        public Warning(int code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}