/**
 * Tax information returned from tax calculation APIs.
 */

function TaxData() {

    this.AdjustmentType = 0;
    this.Billable = false;
    this.CalculationType = 0;
    this.CategoryDescription = "";
    this.CategoryID = 0;
    this.CompanyIdentifier = "";
    this.Compliance = false;
    this.CustomerNumber = "";
    this.Description = "";
    this.ExemptionType = 0;
    this.ExemptSaleAmount = 0;
    this.InvoiceNumber = 0;
    this.Optional = 0;
    this.OptionalAlpha1 = "";
    this.Optional4 = 0;
    this.Optional5 = 0;
    this.Optional6 = 0;
    this.Optional7 = 0;
    this.Optional8 = 0;
    this.Optional9 = 0;
    this.Optional10 = 0;
    this.PCode = 0;
    this.Rate = 0;
    this.RefundUncollect = 0;
    this.ServiceLevelNumber = 0;
    this.Surcharge = false;
    this.TaxableMeasure = 0;
    this.TaxAmount = 0;
    this.TaxLevel = 0;
    this.TaxType = 0;
    this.Lines = 0;
    this.Locations = 0;
    this.Minutes = 0;
    this.OptionalFields = [];
    this.TransCharge = 0;

    /**
     * Sets the adjustment type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid adjustment types.
     * @param adjustmentType Number
     * @return Reference to this object for method chaining. 
     */
    this.adjustmentType = function (adjustmentType) {
        this.AdjustmentType = adjustmentType;
        return this;
    }

    /**
     * Adjustment type. See the CommsPlatform.API.WrapperClasses User's Manual
     * for a list of valid adjustment types.
     * @return Number
     */
    this.getAdjustmentType = function () {
        return this.AdjustmentType;
    }

    /* Reference to this object for method chaining.*
     * Sets the adjustment type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid adjustment types.
     * @param adjustmentType Number 
     */
    this.setAdjustmentType = function (adjustmentType) {
        this.AdjustmentType = adjustmentType;
    }

    /**
     * Sets a value indicating if the tax is billable to the customer.
     * @param billable Boolean
     * @return Reference to this object for method chaining. 
     */
    this.billable = function (billable) {
        this.Billable = billable;
        return this;
    }

    /**
     * Indicates if the tax is billable to the customer.
     * @return Boolean
     */
    this.getBillable = function () {
        return this.Billable;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating if the tax is billable to the customer.
     * @param billable Boolean 
     */
    this.setBillable = function (billable) {
        this.Billable = billable;
    }

    /**
     * Sets the calculation type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid calculation types.
     * @param calculationType Number
     * @return Reference to this object for method chaining. 
     */
    this.calculationType = function (calculationType) {
        this.CalculationType = calculationType;
        return this;
    }

    /**
     * Calculation type. See the CommsPlatform.API.WrapperClasses User's Manual
     * for a list of valid calculation types.
     * @return Number
     */
    this.getCalculationType = function () {
        return this.CalculationType;
    }

    /* Reference to this object for method chaining.*
     * Sets the calculation type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid calculation types.
     * @param calculationType Number 
     */
    this.setCalculationType = function (calculationType) {
        this.CalculationType = calculationType;
    }

    /**
     * Sets the tax Category Description.
     * @param categoryDescription String
     * @return Reference to this object for method chaining. 
     */
    this.categoryDescription = function (categoryDescription) {
        this.CategoryDescription = categoryDescription;
        return this;
    }

    /**
     * Tax Category Description.
     * @return String
     */
    this.getCategoryDescription = function () {
        return this.CategoryDescription;
    }

    /* Reference to this object for method chaining.*
     * Sets the tax Category Description.
     * @param categoryDescription String 
     */
    this.setCategoryDescription = function (categoryDescription) {
        this.CategoryDescription = categoryDescription;
    }

    /**
     * Sets the tax category ID.
     * @param categoryID Number
     * @return Reference to this object for method chaining. 
     */
    this.categoryID = function (categoryID) {
        this.CategoryID = categoryID;
        return this;
    }

    /**
     * Tax category ID.
     * @return Number
     */
    this.getCategoryID = function () {
        return this.CategoryID;
    }

    /* Reference to this object for method chaining.*
     * Sets the tax category ID.
     * @param categoryID Number 
     */
    this.setCategoryID = function (categoryID) {
        this.CategoryID = categoryID;
    }

    /**
     * Sets the customer identifier.
     * @param companyIdentifier String
     * @return Reference to this object for method chaining. 
     */
    this.companyIdentifier = function (companyIdentifier) {
        this.CompanyIdentifier = companyIdentifier;
        return this;
    }

    /**
     * Customer identifier from transaction input.
     * @return String
     */
    this.getCompanyIdentifier = function () {
        return this.CompanyIdentifier;
    }

    /* Reference to this object for method chaining.*
     * Sets the customer identifier.
     * @param companyIdentifier String 
     */
    this.setCompanyIdentifier = function (companyIdentifier) {
        this.CompanyIdentifier = companyIdentifier;
    }

    /**
     * Sets a value indicating if the tax is reportable to the jurisdiction.
     * @param compliance Boolean
     * @return Reference to this object for method chaining. 
     */
    this.compliance = function (compliance) {
        this.Compliance = compliance;
        return this;
    }

    /**
     * Indicates if the tax is reportable to the jurisdiction.
     * @return Boolean
     */
    this.getCompliance = function () {
        return this.Compliance;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating if the tax is reportable to the jurisdiction.
     * @param compliance Boolean 
     */
    this.setCompliance = function (compliance) {
        this.Compliance = compliance;
    }

    /**
     * Sets the user-defined customer number.
     * @param customerNumber String
     * @return Reference to this object for method chaining. 
     */
    this.customerNumber = function (customerNumber) {
        this.CustomerNumber = customerNumber;
        return this;
    }

    /**
     * User-defined customer number.
     * @return String
     */
    this.getCustomerNumber = function () {
        return this.CustomerNumber;
    }

    /* Reference to this object for method chaining.*
     * Sets the user-defined customer number.
     * @param customerNumber String 
     */
    this.setCustomerNumber = function (customerNumber) {
        this.CustomerNumber = customerNumber;
    }

    /**
     * Sets the tax description.
     * @param description String
     * @return Reference to this object for method chaining. 
     */
    this.description = function (description) {
        this.Description = description;
        return this;
    }

    /**
     * Tax description.
     * @return String
     */
    this.getDescription = function () {
        return this.Description;
    }

    /* Reference to this object for method chaining.*
     * Sets the tax description.
     * @param description String 
     */
    this.setDescription = function (description) {
        this.Description = description;
    }

    /**
     * Sets the exemption type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid exemption types.
     * @param exemptionType Number
     * @return Reference to this object for method chaining. 
     */
    this.exemptionType = function (exemptionType) {
        this.ExemptionType = exemptionType;
        return this;
    }

    /**
     * Exemption type from transaction input. See the
     * CommsPlatform.API.WrapperClasses User's Manual for a list of valid
     * exemption types.
     * @return Number
     */
    this.getExemptionType = function () {
        return this.ExemptionType;
    }

    /* Reference to this object for method chaining.*
     * Sets the exemption type. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid exemption types.
     * @param exemptionType Number 
     */
    this.setExemptionType = function (exemptionType) {
        this.ExemptionType = exemptionType;
    }

    /**
     * Sets the amount of the charge exempt from taxes.
     * @param exemptSaleAmount Number
     * @return Reference to this object for method chaining. 
     */
    this.exemptSaleAmount = function (exemptSaleAmount) {
        this.ExemptSaleAmount = exemptSaleAmount;
        return this;
    }

    /**
     * Amount of the charge exempt from taxes.
     * @return Number
     */
    this.getExemptSaleAmount = function () {
        return this.ExemptSaleAmount;
    }

    /* Reference to this object for method chaining.*
     * Sets the amount of the charge exempt from taxes.
     * @param exemptSaleAmount Number 
     */
    this.setExemptSaleAmount = function (exemptSaleAmount) {
        this.ExemptSaleAmount = exemptSaleAmount;
    }

    /**
     * Sets the user-defined invoice number.
     * @param invoiceNumber Number
     * @return Reference to this object for method chaining. 
     */
    this.invoiceNumber = function (invoiceNumber) {
        this.InvoiceNumber = invoiceNumber;
        return this;
    }

    /**
     * User-defined invoice number.
     * @return Number
     */
    this.getInvoiceNumber = function () {
        return this.InvoiceNumber;
    }

    /* Reference to this object for method chaining.*
     * Sets the user-defined invoice number.
     * @param invoiceNumber Number 
     */
    this.setInvoiceNumber = function (invoiceNumber) {
        this.InvoiceNumber = invoiceNumber;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional Number
     * @return Reference to this object for method chaining. 
     */
    this.optional = function (optional) {
        this.Optional = optional;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return Number
     */
    this.getOptional = function () {
        return this.Optional;
    }

    /* Reference to this object for method chaining.*
     * Sets an optional user-defined value.
     * @param optional Number 
     */
    this.setOptional = function (optional) {
        this.Optional = optional;
    }

    /**
     * Sets an optional user-defined string value.
     * @param optionalAlpha1 String
     * @return Reference to this object for method chaining. 
     */
    this.optionalAlpha1 = function (optionalAlpha1) {
        this.OptionalAlpha1 = optionalAlpha1;
        return this;
    }

    /**
     * Optional user-defined string value.
     * @return String
     */
    this.getOptionalAlpha1 = function () {
        return this.OptionalAlpha1;
    }

    /* Reference to this object for method chaining.*
     * Sets an optional user-defined string value.
     * @param optionalAlpha1 String 
     */
    this.setOptionalAlpha1 = function (optionalAlpha1) {
        this.OptionalAlpha1 = optionalAlpha1;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional4 Number
     * @return Reference to this object for method chaining. 
     */
    this.optional4 = function (optional4) {
        this.Optional4 = optional4;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return Number
     */
    this.getOptional4 = function () {
        return this.Optional4;
    }

    /* Reference to this object for method chaining.*
     * Sets an optional user-defined value.
     * @param optional4 Number 
     */
    this.setOptional4 = function (optional4) {
        this.Optional4 = optional4;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional5 Number
     * @return Reference to this object for method chaining. 
     */
    this.optional5 = function (optional5) {
        this.Optional5 = optional5;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return Number
     */
    this.getOptional5 = function () {
        return this.Optional5;
    }

    /* Reference to this object for method chaining.*
     * Sets an optional user-defined value.
     * @param optional5 Number 
     */
    this.setOptional5 = function (optional5) {
        this.Optional5 = optional5;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional6 Number
     * @return Reference to this object for method chaining. 
     */
    this.optional6 = function (optional6) {
        this.Optional6 = optional6;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return Number
     */
    this.getOptional6 = function () {
        return this.Optional6;
    }

    /* Reference to this object for method chaining.*
     * Sets an optional user-defined value.
     * @param optional6 Number 
     */
    this.setOptional6 = function (optional6) {
        this.Optional6 = optional6;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional7 Number
     * @return Reference to this object for method chaining. 
     */
    this.optional7 = function (optional7) {
        this.Optional7 = optional7;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return Number
     */
    this.getOptional7 = function () {
        return this.Optional7;
    }

    /* Reference to this object for method chaining.*
     * Sets an optional user-defined value.
     * @param optional7 Number 
     */
    this.setOptional7 = function (optional7) {
        this.Optional7 = optional7;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional8 Number
     * @return Reference to this object for method chaining. 
     */
    this.optional8 = function (optional8) {
        this.Optional8 = optional8;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return Number
     */
    this.getOptional8 = function () {
        return this.Optional8;
    }

    /* Reference to this object for method chaining.*
     * Sets an optional user-defined value.
     * @param optional8 Number 
     */
    this.setOptional8 = function (optional8) {
        this.Optional8 = optional8;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional9 Number
     * @return Reference to this object for method chaining. 
     */
    this.optional9 = function (optional9) {
        this.Optional9 = optional9;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return Number
     */
    this.getOptional9 = function () {
        return this.Optional9;
    }

    /* Reference to this object for method chaining.*
     * Sets an optional user-defined value.
     * @param optional9 Number 
     */
    this.setOptional9 = function (optional9) {
        this.Optional9 = optional9;
    }

    /**
     * Sets an optional user-defined value.
     * @param optional10 Number
     * @return Reference to this object for method chaining. 
     */
    this.optional10 = function (optional10) {
        this.Optional10 = optional10;
        return this;
    }

    /**
     * Optional user-defined value.
     * @return Number
     */
    this.getOptional10 = function () {
        return this.Optional10;
    }

    /* Reference to this object for method chaining.*
     * Sets an optional user-defined value.
     * @param optional10 Number 
     */
    this.setOptional10 = function (optional10) {
        this.Optional10 = optional10;
    }

    /**
     * Sets the PCode for the reporting jurisdiction.
     * @param pCode Number
     * @return Reference to this object for method chaining. 
     */
    this.pCode = function (pCode) {
        this.PCode = pCode;
        return this;
    }

    /**
     * PCode for the reporting jurisdiction.
     * @return Number
     */
    this.getPCode = function () {
        return this.PCode;
    }

    /* Reference to this object for method chaining.*
     * Sets the PCode for the reporting jurisdiction.
     * @param pCode Number 
     */
    this.setPCode = function (pCode) {
        this.PCode = pCode;
    }

    /**
     * Sets the tax rate.
     * @param rate Number
     * @return Reference to this object for method chaining. 
     */
    this.rate = function (rate) {
        this.Rate = rate;
        return this;
    }

    /**
     * Tax rate.
     * @return Number
     */
    this.getRate = function () {
        return this.Rate;
    }

    /* Reference to this object for method chaining.*
     * Sets the tax rate.
     * @param rate Number 
     */
    this.setRate = function (rate) {
        this.Rate = rate;
    }

    /**
     * Sets the refund uncollect value.
     * @param refundUncollect Number
     * @return Reference to this object for method chaining. 
     */
    this.refundUncollect = function (refundUncollect) {
        this.RefundUncollect = refundUncollect;
        return this;
    }

    /**
     * Taxable measure if tax is smaller than 0 (tax adjustments).
     * @return Number
     */
    this.getRefundUncollect = function () {
        return this.RefundUncollect;
    }

    /* Reference to this object for method chaining.*
     * Sets the refund uncollect value.
     * @param refundUncollect Number 
     */
    this.setRefundUncollect = function (refundUncollect) {
        this.RefundUncollect = refundUncollect;
    }

    /**
     * Sets the user-defined service level number.
     * @param serviceLevelNumber Number
     * @return Reference to this object for method chaining. 
     */
    this.serviceLevelNumber = function (serviceLevelNumber) {
        this.ServiceLevelNumber = serviceLevelNumber;
        return this;
    }

    /**
     * User-defined service level number.
     * @return Number
     */
    this.getServiceLevelNumber = function () {
        return this.ServiceLevelNumber;
    }

    /* Reference to this object for method chaining.*
     * Sets the user-defined service level number.
     * @param serviceLevelNumber Number 
     */
    this.setServiceLevelNumber = function (serviceLevelNumber) {
        this.ServiceLevelNumber = serviceLevelNumber;
    }

    /**
     * Sets a value indicating if tax is considered a surcharge.
     * @param surcharge Boolean
     * @return Reference to this object for method chaining. 
     */
    this.surcharge = function (surcharge) {
        this.Surcharge = surcharge;
        return this;
    }

    /**
     * Indicates if tax is considered a surcharge.
     * @return Boolean
     */
    this.getSurcharge = function () {
        return this.Surcharge;
    }

    /* Reference to this object for method chaining.*
     * Sets a value indicating if tax is considered a surcharge.
     * @param surcharge Boolean 
     */
    this.setSurcharge = function (surcharge) {
        this.Surcharge = surcharge;
    }

    /**
     * Sets the amount of sale subject to tax plus any taxed taxes.
     * @param taxableMeasure Number
     * @return Reference to this object for method chaining. 
     */
    this.taxableMeasure = function (taxableMeasure) {
        this.TaxableMeasure = taxableMeasure;
        return this;
    }

    /**
     * Amount of sale subject to tax plus any taxed taxes.
     * @return Number
     */
    this.getTaxableMeasure = function () {
        return this.TaxableMeasure;
    }

    /* Reference to this object for method chaining.*
     * Sets the amount of sale subject to tax plus any taxed taxes.
     * @param taxableMeasure Number 
     */
    this.setTaxableMeasure = function (taxableMeasure) {
        this.TaxableMeasure = taxableMeasure;
    }

    /**
     * Sets the calculated tax amount.
     * @param taxAmount Number
     * @return Reference to this object for method chaining. 
     */
    this.taxAmount = function (taxAmount) {
        this.TaxAmount = taxAmount;
        return this;
    }

    /**
     * Calculated tax amount.
     * @return Number
     */
    this.getTaxAmount = function () {
        return this.TaxAmount;
    }

    /* Reference to this object for method chaining.*
     * Sets the calculated tax amount.
     * @param taxAmount Number 
     */
    this.setTaxAmount = function (taxAmount) {
        this.TaxAmount = taxAmount;
    }

    /**
     * Sets the tax level. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid tax levels.
     * @param taxLevel Number
     * @return Reference to this object for method chaining. 
     */
    this.taxLevel = function (taxLevel) {
        this.TaxLevel = taxLevel;
        return this;
    }

    /**
     * Tax level. See the CommsPlatform.API.WrapperClasses User's Manual for a
     * list of valid tax levels.
     * @return Number
     */
    this.getTaxLevel = function () {
        return this.TaxLevel;
    }

    /* Reference to this object for method chaining.*
     * Sets the tax level. See the CommsPlatform.API.WrapperClasses User's 
     * Manual for a list of valid tax levels.
     * @param taxLevel Number 
     */
    this.setTaxLevel = function (taxLevel) {
        this.TaxLevel = taxLevel;
    }

    /**
     * Sets the tax type. See the CommsPlatform.API.WrapperClasses User's Manual 
     * for a list of valid tax types.
     * @param taxType Number
     * @return Reference to this object for method chaining. 
     */
    this.taxType = function (taxType) {
        this.TaxType = taxType;
        return this;
    }

    /**
     * Tax type. See the CommsPlatform.API.WrapperClasses User's Manual for a
     * list of valid tax types.
     * @return Number
     */
    this.getTaxType = function () {
        return this.TaxType;
    }

    /* Reference to this object for method chaining.*
     * Sets the tax type. See the CommsPlatform.API.WrapperClasses User's Manual 
     * for a list of valid tax types.
     * @param taxType Number 
     */
    this.setTaxType = function (taxType) {
        this.TaxType = taxType;
    }

    /**
     * Sets the number of lines used to calculate the tax (for per-line tax
     * calculations).
     * @param lines Number
     * @return Reference to this object for method chaining. 
     */
    this.lines = function (lines) {
        this.Lines = lines;
        return this;
    }

    /**
     * Number of lines used to calculate the tax (for per-line tax
     * calculations).
     * @return Number
     */
    this.getLines = function () {
        return this.Lines;
    }

    /* Reference to this object for method chaining.*
     * Sets the number of lines used to calculate the tax (for per-line tax
     * calculations).
     * @param lines Number 
     */
    this.setLines = function (lines) {
        this.Lines = lines;
    }

    /**
     * Sets the number of locations.
     * @param locations Number
     * @return Reference to this object for method chaining. 
     */
    this.locations = function (locations) {
        this.Locations = locations;
        return this;
    }

    /**
     * Number of locations from transaction input.
     * @return Number
     */
    this.getLocations = function () {
        return this.Locations;
    }

    /* Reference to this object for method chaining.*
     * Sets the number of locations.
     * @param locations Number 
     */
    this.setLocations = function (locations) {
        this.Locations = locations;
    }

    /**
     * Sets the number of minutes used to calculate the tax (for per-minute tax
     * calculations).
     * @param minutes Number
     * @return Reference to this object for method chaining. 
     */
    this.minutes = function (minutes) {
        this.Minutes = minutes;
        return this;
    }

    /**
     * Number of minutes used to calculate the tax (for per-minute tax
     * calculations).
     * @return Number
     */
    this.getMinutes = function () {
        return this.Minutes;
    }

    /* Reference to this object for method chaining.*
     * Sets the number of minutes used to calculate the tax (for per-minute tax
     * calculations).
     * @param minutes Number 
     */
    this.setMinutes = function (minutes) {
        this.Minutes = minutes;
    }

    /**
     * Sets the user-defined list of optional alphanumeric fields.
     * @param optionalFields Array of OptionalField
     * @return Reference to this object for method chaining. 
     */
    this.optionalFields = function (optionalFields) {
        this.OptionalFields = optionalFields;
        return this;
    }

    /**
     * Sets the user-defined list of optional alphanumeric fields.
     * @param optionalFieldsItem OptionalField object.
     * @return Reference to this object for method chaining. 
     */
    this.addOptionalFieldsItem = function (optionalFieldsItem) {
        this.OptionalFields.push(optionalFieldsItem);
        return this;
    }

    /**
     * User-defined list of optional alphanumeric fields.
     * @return Array of OptionalField
     */
    this.getOptionalFields = function () {
        return this.OptionalFields;
    }

    /* Reference to this object for method chaining.*
     * Sets the user-defined list of optional alphanumeric fields.
     * @param optionalFields Array of OptionalField 
     */
    this.setOptionalFields = function (optionalFields) {
        this.OptionalFields = optionalFields;
    }

    /**
     * Sets the transaction charge amount.
     * @param transCharge Number
     * @return Reference to this object for method chaining. 
     */
    this.transCharge = function (transCharge) {
        this.TransCharge = transCharge;
        return this;
    }

    /**
     * Transaction charge amount.
     * @return Number
     */
    this.getTransCharge = function () {
        return this.TransCharge;
    }

    /* Reference to this object for method chaining.*
     * Sets the transaction charge amount.
     * @param transCharge Number 
     */
    this.setTransCharge = function (transCharge) {
        this.TransCharge = transCharge;
    }
}
