using System.Collections.Generic;

namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class TaxConfigurationDomainObject
    {
        /// <summary>
        /// Gets or sets the client profile configuration mappings.
        /// </summary>
        /// <value>
        /// The client profile configuration mappings.
        /// </value>
        public IEnumerable<TaxConfigMapping> ClientProfileConfigMappings { get; set; }
        /// <summary>
        /// Gets or sets the client profile configuration.
        /// </summary>
        /// <value>
        /// The client profile configuration.
        /// </value>
        public TaxConfiguration TaxConfiguration { get; set; }

    }

    /// <summary>
    /// Class for handling comparison of tax configurations
    /// </summary>
    public class TaxConfigurationDomainObjectComparer : IEqualityComparer<TaxConfigurationDomainObject>
    {
        /// <summary>
        /// Test whether TaxConfiguration object refers to same profile item object passed in
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>bool</returns>
        public bool Equals(TaxConfigurationDomainObject x, TaxConfigurationDomainObject y)
        {
            // Check whether the compared objects reference the same data.
            if (ReferenceEquals(x, y))
            {
                return true;
            }

            // Check whether either of the compared objects are null.
            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
            {
                return false;
            }

            // Check whether either of the tax configuration objects are null.
            if (x.TaxConfiguration == null || y.TaxConfiguration == null)
            {
                // If either are null, the comparison is invalid.
                // No need to check if both are null (still invalid)
                return false;
            }

            // Hand off the comparison logic to the TaxConfiguration object
            return x.TaxConfiguration.Equals(y.TaxConfiguration);
        }

        /// <summary>
        /// If Equals() returns true for a pair of objects then GetHashCode() 
        /// must return the same value for these objects. 
        /// </summary>
        /// <param name="taxConfigurationDomainObject"></param>
        /// <returns>int</returns>
        public int GetHashCode(TaxConfigurationDomainObject taxConfigurationDomainObject)
        {
            return taxConfigurationDomainObject.TaxConfiguration == null ? 0 : taxConfigurationDomainObject.TaxConfiguration.GetHashCode();
        }
    }
}