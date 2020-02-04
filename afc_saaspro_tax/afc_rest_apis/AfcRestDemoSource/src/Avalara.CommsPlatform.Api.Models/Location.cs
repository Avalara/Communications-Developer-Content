using Newtonsoft.Json;
using System;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Location data used to determine taxing jurisdiction.
    /// </summary>
    public class Location : Address, IEquatable<Location>
    {
        /// <summary>
        /// County name.
        /// </summary>
        [JsonProperty("cnty", NullValueHandling = NullValueHandling.Ignore)]
        public string County { get; set; }

        /// <summary>
        /// Country ISO code.
        /// </summary>
        [JsonProperty("ctry", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// Indicates if the location is within city limits.
        /// Default: true.
        /// </summary>
        [JsonProperty("int", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incorporated { get; set; }

        /// <summary>
        /// Indicates if this address should be geocoded in order to obtain taxing jurisdiction.
        /// Default: false.
        /// </summary>
        [JsonProperty("geo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Geocode { get; set; }

        /// <summary>
        /// PCode for taxing jurisdiction.
        /// </summary>
        [JsonProperty("pcd", NullValueHandling = NullValueHandling.Ignore)]
        public uint? PCode { get; set; }

        /// <summary>
        /// NPANXX number.
        /// </summary>
        [JsonProperty("npa", NullValueHandling = NullValueHandling.Ignore)]
        public uint? NpaNxx { get; set; }

        /// <summary>
        /// FIPS code for taxing jurisdiction.
        /// </summary>
        [JsonProperty("fips", NullValueHandling = NullValueHandling.Ignore)]
        public string FipsCode { get; set; }

        /// <summary>
        /// Equality operator
        /// </summary>
        public bool Equals(Location location)
        {
            if (location is null)
            {
                return false;
            }

            if (ReferenceEquals(this, location))
            {
                return true;
            }

            if (GetType() != location.GetType())
            {
                return false;
            }

            if (PCode.HasValue && PCode != 0 || location.PCode.HasValue && location.PCode != 0)
            {
                return PCode == location.PCode;
            }

            if ((NpaNxx.HasValue || location.NpaNxx.HasValue) && NpaNxx != location.NpaNxx)
            {
                return false;
            }

            if ((Incorporated.HasValue || location.Incorporated.HasValue) && Incorporated != location.Incorporated)
            {
                return false;
            }

            return Country == location.Country &&
                State == location.State &&
                County == location.County &&
                StreetAddress == location.StreetAddress &&
                PostalCode == location.PostalCode &&
                City == location.City &&
                FipsCode == location.FipsCode;
        }

        /// <summary>
        /// Creates HashCode for use in equality comparison
        /// </summary>
        public override int GetHashCode()
        {
            string location = $"{Country ?? ""}{State ?? ""}{County ?? ""}{City ?? ""}{PostalCode ?? ""}{StreetAddress ?? ""}{FipsCode ?? ""}{PCode.GetHashCode()}{NpaNxx.GetHashCode()}";
            return location.GetHashCode();
        }

        /// <summary>
        /// Equality operator
        /// </summary>
        public static bool operator ==(Location x, Location y)
        {
            return y?.Equals(x) ?? x is null;
        }

        /// <summary>
        /// Inequality operator
        /// </summary>
        public static bool operator !=(Location x, Location y)
        {
            return !(x == y);
        }
    }
}