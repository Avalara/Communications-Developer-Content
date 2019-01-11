
namespace Avalara.CommsPlatform.Api.Models
{
    /// <summary>
    /// Adjustment methods.
    /// </summary>
    public enum AdjustmentMethod
    {
        /// <summary>
        /// Default.
        /// </summary>
        Default = 0,
        /// <summary>
        /// Use least favorable rate.
        /// </summary>
        LeastFavorableRate,
        /// <summary>
        /// Use most favorable rate.
        /// </summary>
        MostFavorableRate
    }

    /// <summary>
    /// Business classes.
    /// </summary>
    public enum BusinessClass
    {
        /// <summary>
        /// An ILEC company is engaged in selling services over company owned lines and equipment.
        /// </summary>
        ILEC = 0,
        /// <summary>
        /// A CLEC company is engaged in selling services competing with an incumbent provider.
        /// </summary>
        CLEC
    };

    /// <summary>
    /// Calculation types.
    /// </summary>
    public enum CalculationType
    {
        /// <summary>
        /// Tax is calculated on a percentage rate.
        /// </summary>
        Rate = 1,
        /// <summary>
        /// Tax is a fixed amount set by the jurisdiction.
        /// </summary>
        Fixed,
        /// <summary>
        /// Tax is calculated by per minute.
        /// </summary>
        PerMinute,
        /// <summary>
        /// Tax is calculated at tiered rate per access line.
        /// </summary>
        PerLine,
        /// <summary>
        /// Tax calculated for cable services.
        /// </summary>
        SelfTaxingRate,
        /// <summary>
        /// Tax calculated for rate per bracket based on line count.
        /// </summary>
        PerBracket,
        /// <summary>
        /// Tax calculated for cable services.
        /// </summary>
        FixedOnTier,
        /// <summary>
        /// Per line tax in invoice mode (with potential tax amount adjustments).
        /// </summary>
        CustPerLine,
        /// <summary>
        /// Per bracket tax in invoice mode (with potential tax amount adjustments).
        /// </summary>
        CustPerBracket,
        /// <summary>
        /// Total of invoice mode adjustable per line tax transactions.
        /// Not normally returned to calling API but included here for completeness.
        /// </summary>
        CustPerLineTotal,
        /// <summary>
        /// Total of invoice mode adjustable bracket tax transactions.
        /// Not normally returned to calling API but included here for completeness.
        /// </summary>
        CustPerBracketTotal
    };

    /// <summary>
    /// Customer types.
    /// </summary>
    public enum CustomerType
    {
        /// <summary>
        /// When transactions are made by a customer for home use.
        /// </summary>
        Residential = 0,
        /// <summary>
        /// When transactions are made at a place of business.
        /// </summary>
        Business,
        /// <summary>
        /// When transactions are made by a customer meeting the jurisdiction requirements to be
        /// considered a senior citizen and qualify for senior citizen tax breaks.
        /// </summary>
        SeniorCitizen,
        /// <summary>
        /// When transactions are made at an industrial business.
        /// </summary>
        Industrial
    };

    /// <summary>
    /// Discount types.
    /// </summary>
    public enum DiscountType
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,
        /// <summary>
        /// An amount subtracted from the original price to arrive at a lower price. 
        /// </summary>
        RetailProduct,
        /// <summary>
        /// A discount of the total amount reimbursed to either the retailer or the customer by the manufacturer.
        /// </summary>
        ManufacturerProduct,
        /// <summary>
        /// Especially prevalent in large accounts, this discount is a stand alone discount that is not applied 
        /// against any service but instead as a stand alone product.
        /// </summary>
        AccountLevel,
        /// <summary>
        /// A discount caused exclusively in telephone service where the telephone provider provides a service 
        /// to a lifeline eligible customer. The discount will be on the local exchange service. In the states 
        /// researched, the lifeline discount will not decrease the tax base. 
        /// </summary>
        Subsidized,
        /// <summary>
        /// The total discount of a service that is recorded for accounting purposes but never billed to a customer.
        /// </summary>
        Goodwill
    };

    /// <summary>
    /// Sale type options.
    /// </summary>
    public enum SaleType
    {
        /// <summary>
        /// Indicates that the item was sold to a wholeseller.
        /// </summary>
        Wholesale = 0,
        /// <summary>
        /// Indicates that the item was sold to an end user - a retail sale.
        /// </summary>
        Retail,
        /// <summary>
        /// Indicates that the item was consumed directly.
        /// </summary>
        Consumed,
        /// <summary>
        /// Indicates that the item is subject to vendor use tax.
        /// </summary>
        VendorUse
    }

    /// <summary>
    /// Service classes.
    /// </summary>
    public enum ServiceClass
    {
        /// <summary>
        /// Primary Local Service providers are carriers vending their services with over 50% of the
        /// gross business activities in Local Service revenue.
        /// </summary>
        PrimaryLocal = 0,
        /// <summary>
        /// Primary Long Distance providers are carriers vending thier services with over 50% of the
        /// gross business activities in Long Distance revenue.
        /// </summary>
        PrimaryLongDistance
    };

    /// <summary>
    /// Tax Levels.
    /// </summary>
    public enum TaxLevel
    {
        /// <summary>
        /// Federal.
        /// </summary>
        Federal = 0,
        /// <summary>
        /// State.
        /// </summary>
        State,
        /// <summary>
        /// County.
        /// </summary>
        County,
        /// <summary>
        /// Local.
        /// </summary>
        Local,
        /// <summary>
        /// Unincorporated.
        /// </summary>
        Unincorporated
    };

    /// <summary>
    /// Safe Harbor Types.
    /// </summary>
    public enum SafeHarborType
    {
        /// <summary>
        /// Cellular
        /// </summary>
        Cellular = 1,
        /// <summary>
        /// VoIP
        /// </summary>
        VoIP = 2,
        /// <summary>
        /// Paging
        /// </summary>
        Paging = 4,
        /// <summary>
        /// ClearAll
        /// </summary>
        ClearAll = 7
    }

    /// <summary>
    /// Prorated adjustment handling types.
    /// </summary>
    public enum ProRatedAdjustmentHandlingTypes
    {
       /// <summary>
       /// Use defined default handling.
       /// </summary>
       Default = 0,
       /// <summary>
       /// Non-pro-ratable taxes will not be returned.
       /// </summary>
       StandardProratedAdjHandling,
       /// <summary>
       /// Non-pro-ratable taxes will be returned.
       /// </summary>
       CancelProratedCalcAdjHandling
    }
 }
