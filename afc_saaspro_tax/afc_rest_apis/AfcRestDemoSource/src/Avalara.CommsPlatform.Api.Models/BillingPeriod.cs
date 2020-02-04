using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Optional object for passing in billing period
    /// </summary>
    public class BillingPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("month", NullValueHandling = NullValueHandling.Ignore)]
        public int BillingPeriodMonth { get; set; } 
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("year", NullValueHandling = NullValueHandling.Ignore)]
        public int BillingPeriodYear { get; set; }
    }
}