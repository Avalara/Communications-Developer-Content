/**
 * Sample program for the AFC REST service.
 */
function AfcRestSample() {
    var baseAddress = "[BaseAddress]";  // Change to Base address for AFC REST service
    var userName = "[UserName]";        // Credentials user name provided by Avalara
    var password = "[Password]";        // Credentials password provided by Avalara
    var clientId = 536;                 // Client Id provided by Avalara
    var clientProfileId = 1;            // Client Profile Id provided by Avalara

    this.client = new AfcRestClient(baseAddress, userName, password, clientId, clientProfileId);

    /**
     * Executes the samples for the AFC REST service.
     */
    this.run = function () {
        $("body").append("<h1>Sample program for AFC REST service</h1>");
        $("body").append("<p><b>NOTE:</b> Update the BaseAddress, UserName, and " +
                "Password constants in the AfcRestSample.js file accordingly</p>");

        this.getServerTime();
        this.getPCode();
        this.getAddress();
        this.calculateTaxes();
        this.calculateAdjustments();
        this.calculateBridgeConferenceTaxes();
        this.calculateTaxesWithOverrides();
    };

    /**
     * Example showing how to get the server time from the AFC REST service.
     */
    this.getServerTime = function () {
        $("body").append("<div id=\"getServerTime\"></div>");
        var div = $("#getServerTime");
        div.append("<hr class=\"topBorder\">");
        div.append("<p><b>API:</b> GET " + baseAddress + "/api/v1/Application/ServerTime</p>");

        // Invoke REST API to get the server time
        this.client.getServerTime(
            function (serverTime) {
                div.append("<p><b>RESPONSE:</p></b>");
                div.append("<p>" + serverTime.toISOString() + "</p>");
            },
            function (errorMsg) {
                div.append("<p><b>ERROR: </p></b>");
                div.append("<p>" + errorMsg + "</p>");
            });
    }

    /**
     * Example showing how to obtain the PCode for a location.
     */
    this.getPCode = function () {
        $("body").append("<div id=\"getPCode\"></div>");
        var div = $("#getPCode");
        div.append("<hr class=\"topBorder\">");
        div.append("<p><b>API:</b> GET " + baseAddress + "/api/v1/Location/PCode</p>");

        // Create a RequestPCodeDetail object for the request body
        // NOTE: only one of the following properties must be populated: FipsCode, NpaNxx, or ZipAddress
        var zipAddress = new ZipAddress()
            .countryISO(("USA"))
            .state("WA")
            .county("King")
            .locality("Seattle")
            .zipCode("98101");

        var request = new RequestPCodeDetail()
            .zipAddress(zipAddress);

        div.append("<p><b>REQUEST BODY:</b></p>");
        div.append("<p>" + toJSON(request) + "</p>");

        // Invoke REST API to obtain the PCode for the location
        this.client.getPCode(
            request,
            function (pcode) {
                div.append("<p><b>RESPONSE:</p></b>");
                div.append("<p>" + pcode + "</p>");
            },
            function (errorMsg) {
                div.append("<p><b>ERROR: </p></b>");
                div.append("<p>" + errorMsg + "</p>");
            });
    }

    /**
     * Example showing how to get address information for a PCode.
     */
    this.getAddress = function () {
        var pcode = 452600;    // PCode for Crested Butte, CO

        $("body").append("<div id=\"getAddress\"></div>");
        var div = $("#getAddress");
        div.append("<hr class=\"topBorder\">");
        div.append("<p><b>API:</b> GET " + baseAddress + "/api/v1/Location/Address/" + pcode + "</p>");

        // Invoke REST API to get the address information for the location
        this.client.getAddress(
            pcode,
            function (addressData) {
                div.append("<p><b>RESPONSE:</p></b>");
                div.append("<p>" + toJSON(addressData) + "</p>");
            },
            function (errorMsg) {
                div.append("<p><b>ERROR: </p></b>");
                div.append("<p>" + errorMsg + "</p>");
            });
    }

    /**
     * Example showing how to calculate taxes for a Transaction
     */
    this.calculateTaxes = function () {
        $("body").append("<div id=\"calculateTaxes\"></div>");
        var div = $("#calculateTaxes");
        div.append("<hr class=\"topBorder\">");
        div.append("<p><b>API:</b> GET " + baseAddress + "/api/v1/CalculateTaxes</p>");

        // Create a Transaction object to specify the input data for the tax calculation
        // NOTE: Bill-To, Origination, and Termination can be entered using PCodes, FIPS Codes, NPANXX, or ZipAddress.
        // NOTE: Use your Avalara-provided CompanyIdentifier to include this transaction and taxes in your compliance 
        // reports or leave blank otherwise (for testing and calculating taxes on quotes).
        // NOTE: CustomerNumber, InvoiceNumber, and other optional fields may be specified for reporting purposes
        var transaction = new Transaction()
            .billToAddress(new ZipAddress()
                .countryISO("USA")
                .state("WA")
                .county("King")
                .locality("Seattle")
                .zipCode("98101"))
            .businessClass(0)       // ILEC
            .charge(25.95)
            .companyIdentifier("TST")
            .customerType(0)        // Residential
            .date(new Date())
            .facilitiesBased(true)
            .franchise(true)
            .incorporated(true)
            .lifeline(false)
            .lines(1)
            .locations(0)
            .minutes(0)
            .regulated(false)
            .sale(true)
            .serviceClass(1)        // Primary long distance
            .serviceType(6)         // Access Charge
            .transactionType(19);   // VoIP

        // NOTE: Depending on the transaction/service type, Origination and Termination may not apply
        // in which case the same jurisdiction as the bill-to location must be populated into these fields
        transaction.setOriginationAddress(transaction.getBillToAddress());
        transaction.setTerminationAddress(transaction.getBillToAddress());

        div.append("<p><b>REQUEST BODY:</b></p>");
        div.append("<p>" + toJSON(transaction) + "</p>");

        // Invoke REST API to calculate taxes on the transaction
        this.client.calculateTaxes(
            transaction,
            function (taxes) {
                div.append("<p><b>RESPONSE:</p></b>");
                div.append("<p>" + toJSON(taxes) + "</p>");
            },
            function (errorMsg) {
                div.append("<p><b>ERROR: </p></b>");
                div.append("<p>" + errorMsg + "</p>");
            });
    }

    /**
     * Example showing how to calculate tax adjustments for a Transaction.
     */
    this.calculateAdjustments = function () {
        $("body").append("<div id=\"calculateAdjustments\"></div>");
        var div = $("#calculateAdjustments");
        div.append("<hr class=\"topBorder\">");
        div.append("<p><b>API:</b> GET " + baseAddress + "/api/v1/CalculateAdjustments</p>");

        // Create a Transaction object similarly as for processing a regular tax calculation
        var transaction = new Transaction()
            .adjustmentDiscount(3)      // Specify a discount type for adjustments
            .adjustmentMethod(0)        // Use default adjustment method to apply tax brackets normally
            .billToAddress(new ZipAddress()
                .countryISO("USA")
                .state("WA")
                .county("King")
                .locality("Seattle")
                .zipCode("98101"))
            .businessClass(0)           // ILEC
            .charge(25.95)              // NOTE: Enter a positive amount for the amount being refunded
            .companyIdentifier("TST")
            .customerType(0)            // Residential
            .date(new Date())  // NOTE: For adjustments, use the same date as original transaction
            .facilitiesBased(true)
            .franchise(true)
            .incorporated(true)
            .lifeline(false)
            .lines(1)
            .locations(0)
            .minutes(0)
            .regulated(false)
            .sale(true)
            .serviceClass(1)            // Primary long distance
            .serviceType(6)             // Access Charge
            .transactionType(19);       // VoIP

        transaction.setOriginationAddress(transaction.getBillToAddress());
        transaction.setTerminationAddress(transaction.getBillToAddress());

        div.append("<p><b>REQUEST BODY:</b></p>");
        div.append("<p>" + toJSON(transaction) + "</p>");

        // Invoke REST API to calculate tax adjustments on the transaction
        this.client.calculateAdjustments(
            transaction,
            function (taxes) {
                div.append("<p><b>RESPONSE:</p></b>");
                div.append("<p>" + toJSON(taxes) + "</p>");
            },
            function (errorMsg) {
                div.append("<p><b>ERROR: </p></b>");
                div.append("<p>" + errorMsg + "</p>");
            });
    }

    /**
     * Example showing how to calculate taxes for a bridge conference transaction.
     */
    this.calculateBridgeConferenceTaxes = function () {
        $("body").append("<div id=\"calculateBridgeConferenceTaxes\"></div>");
        var div = $("#calculateBridgeConferenceTaxes");
        div.append("<hr class=\"topBorder\">");
        div.append("<p><b>API:</b> GET " + baseAddress + "/api/v1/BridgeConference/Taxes</p>");

        // Create a BridgeConferenceTransaction object to specify the input data for the tax calculation
        var transaction = new BridgeConferenceTransaction()
            .billingAddress(new ZipAddress()
                .countryISO("USA")
                .state("WA")
                .county("King")
                .locality("Seattle")
                .zipCode("98101"))
            .bridgeAddress(new ZipAddress()
                .countryISO("USA")
                .state("KS")
                .county("Johnson")
                .locality("Overland Park")
                .zipCode("66212"))
            .businessClass(0)          // ILEC
            .charge(25.95)
            .companyIdentifier("TST")
            .customerType(0)           // Residential
            .date(new Date())
            .facilitiesBased(true)
            .franchise(true)
            .hostAddress(new ZipAddress()
                .countryISO("USA")
                .state("KS")
                .county("Johnson")
                .locality("Overland Park")
                .zipCode("66212"))
            .incorporated(true)
            .lifeline(false)
            .lines(1)
            .locations(0)
            .minutes(35.5)
            .processInvalidParticipant(true) // Don't fail transaction if a participant fails to be processed
            .regulated(false)
            .returnParticipantTaxes(true) // Return each individual participant's taxes in the response  
            .sale(true)
            .serviceClass(1);        // Primary long distance

        // Set the list of participants for the conference bridge
        transaction.addParticipant(new BridgeConferenceParticipant()
            .participantAddress(new ZipAddress()
                .countryISO("USA")
                .state("WA")
                .county("King")
                .locality("Seattle")
                .zipCode("98101"))
            .participantRef("1"));

        transaction.addParticipant(new BridgeConferenceParticipant()
            .participantAddress(new ZipAddress()
                .countryISO("USA")
                .state("CO")
                .county("Denver")
                .locality("Denver")
                .zipCode("80014"))
            .participantRef("2"));

        div.append("<p>REQUEST BODY:");
        div.append("<p>" + toJSON(transaction) + "</p>");

        // Invoke REST API to calculate taxes on the bridge conference transaction
        this.client.calculateBridgeConferenceTaxes(
            transaction,
            function (results) {
                div.append("<p><b>RESPONSE:</p></b>");
                div.append("<p>" + toJSON(results) + "</p>");
            },
            function (errorMsg) {
                div.append("<p><b>ERROR: </p></b>");
                div.append("<p>" + errorMsg + "</p>");
            });
    }

    /**
     * Example showing how to calculate taxes on a transaction while overriding the 
     * tax rate for a specific tax.
     */
    this.calculateTaxesWithOverrides = function () {
        $("body").append("<div id=\"calculateTaxesWithOverrides\"></div>");
        var div = $("#calculateTaxesWithOverrides");
        div.append("<hr class=\"topBorder\">");
        div.append("<p><b>API:</b> GET " + baseAddress + "/api/v1/CalculateWithOverrides/Taxes</p>");

        // Create a CalculateWithOverridesRequest object to specify the trasaction and override data
        var request = new CalculateWithOverridesRequest()
            .transaction(new Transaction()
                .billToPCode(4133800)       // PCode for Seattle, WA
                .businessClass(0)           // ILEC
                .charge(25.95)
                .companyIdentifier("TST")
                .customerType(0)            // Residential
                .date(new Date())
                .facilitiesBased(true)
                .franchise(true)
                .incorporated(true)
                .lifeline(false)
                .lines(1)
                .locations(0)
                .minutes(0)
                .originationPCode(4133800)  // PCode for Seattle, WA
                .regulated(false)
                .sale(true)
                .serviceClass(1)            // Primary long distance
                .serviceType(15)            // Product
                .terminationPCode(4133800)  // PCode for Seattle, WA
                .transactionType(10));      // Sales

        // Specify tax rate overrides for request
        var rateOverride = new TaxRateOverrideInfo()
            .pcode(4133800)         // PCode for Seattle, WA
            .levelExemptible(true)
            .scope(1)               // State-level scope
            .taxLevel(1)            // State-level tax
            .taxType(1);            // Sales tax type

        rateOverride.addBracket(new TaxBracketInfo()
            .maxBase(2000000000)    // Use max value if bracket has no limit
            .rate(0.0123));         // Enter rate as decimal for percentage-based taxes

        request.addOverride(rateOverride);

        div.append("<p><b>REQUEST BODY:</b></p>");
        div.append("<p>" + toJSON(request) + "</p>");


        // Invoke REST API to calculate taxes on the transaction using the specified tax rate override
        this.client.calculateTaxesWithOverrides(
            request,
            function (taxes) {
                div.append("<p><b>RESPONSE:</p></b>");
                div.append("<p>" + toJSON(taxes) + "</p>");
            },
            function (errorMsg) {
                div.append("<p><b>ERROR: </p></b>");
                div.append("<p>" + errorMsg + "</p>");
            });
    }
}

/**
 * Formats the specified object as a JSON string for display inside HTML.
 */
this.toJSON = function (obj) {
    var json = JSON.stringify(obj, null, 2);

    while (json.indexOf("\n") > 0)
        json = json.replace("\n", "<br>");

    while (json.indexOf(" ") > 0)
        json = json.replace(" ", "&nbsp;");

    return json;
}