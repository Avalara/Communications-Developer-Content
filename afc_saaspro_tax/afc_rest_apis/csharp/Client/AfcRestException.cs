using System;
using System.Net;

namespace Avalara.Comms.Rest.Sample.Client
{
    /// <summary>
    /// Exception class for errors thrown by the AfcRestClient.
    /// </summary>
    public class AfcRestException: Exception
    {
        /// <summary>
        /// HTTP status code returned by call to AFC REST service.
        /// </summary>
        public HttpStatusCode HttpStatusCode { get; protected set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="httpCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="innerException">Inner exception.</param>
        public AfcRestException(HttpStatusCode httpCode, string message, Exception innerException = null) :
            base(string.IsNullOrWhiteSpace(message) ? $"Request returned an error code: {httpCode}" : message, innerException)
        {
            HttpStatusCode = httpCode;
        }
    }
}
