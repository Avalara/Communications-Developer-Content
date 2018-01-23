package avalara.comms.rest.sample;

import avalara.comms.rest.sample.client.*;
import avalara.comms.rest.sample.model.*;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

/**
 * Sample program for the AFC REST service.
 */
public class Program {
    
    private static final String baseAddress = "[BaseAddress]"; // Change to Base address for AFC REST service
    private static final String userName = "[UserName]";       // Credentials user name provided by Avalara
    private static final String password = "[Password]";       // Credentials password provided by Avalara
    private static final int clientId = 536;                   // Client Id provided by Avalara
    private static final int clientProfileId = 1;              // Client Profile Id provided by Avalara when a Client has multiple configuration
    private static final Json json = new Json();
            
    /**
     * Main entry point for AFC REST service sample program.
     * 
     * @param args Command-line arguments (none required).
     */
    public static void main(String[] args) {
        System.out.println("Sample program for AFC REST service");
        System.out.println();
        System.out.println( "NOTE: Update the BaseAddress, UserName, " +
                "Password, Client Id and Client Profile Id constants in the Program.cs file accordingly");
        System.out.println();

        getServerTime();
        getPCode();
        getAddress();
        calculateTaxes();
        calculateAdjustments();
        calculateBridgeConferenceTaxes();
        calculateTaxesWithOverrides();

        printSeparator();
        System.out.println("End of sample program.");
    }
    
    /**
     * Example showing how to get the server time from the AFC REST service.
     */
    private static void getServerTime() {
        printSeparator();
        System.out.println("API: GET " + baseAddress + "/api/v1/Application/ServerTime");
        System.out.println();

        try
        {
            AfcRestClient client = new AfcRestClient(baseAddress, userName, password, clientId, clientProfileId);
            
            // Invoke REST API to get the server time
            LocalDateTime serverTime = client.getServerTime();

            DateTimeFormatter dateFormat = 
                DateTimeFormatter.ofPattern("yyyy-MM-dd'T'HH:mm:ss.n'Z'");
            System.out.println("RESPONSE:");
            System.out.println(serverTime.format(dateFormat));
            System.out.println();
        }
        catch (AfcRestException ex) {
            System.out.println("ERROR: " + ex.getMessage());
        }
    }
    
    /**
     * Example showing how to obtain the PCode for a location.
     */
    private static void getPCode() {
        printSeparator();
        System.out.println("API: GET " + baseAddress + "/api/v1/Location/PCode");
        System.out.println();

        try
        {
            AfcRestClient client = new AfcRestClient(baseAddress, userName, password, clientId, clientProfileId);
            
            // Create a RequestPCodeDetail object for the request body
            // NOTE: only one of the following properties must be populated: FipsCode, NpaNxx, or ZipAddress
            ZipAddress zipAddress = new ZipAddress()
                .countryISO(("USA"))
                .state("WA")
                .county("King")
                .locality("Seattle")
                .zipCode("98101");
            
            RequestPCodeDetail request = new RequestPCodeDetail()
                .zipAddress(zipAddress);
            
            // Invoke REST API to obtain the PCode for the location
            long pcode = client.getPCode(request);

            System.out.println("RESPONSE:");
            System.out.println(pcode);
            System.out.println();
        }
        catch (AfcRestException ex) {
            System.out.println("ERROR: " + ex.getMessage());
        }
    }
    
    /**
     * Example showing how to get address information for a PCode.
     */
    private static void getAddress()
    {
        long pcode = 452600;    // PCode for Crested Butte, CO

        printSeparator();
        System.out.println("API: GET " + baseAddress + "/api/v1/Location/Address/" + pcode);
        System.out.println();

        try {
            AfcRestClient client = new AfcRestClient(baseAddress, userName, password, clientId, clientProfileId);
            
            // Invoke REST API to get the address information for the location
            AddressData[] addressData = client.getAddress(pcode);

            System.out.println("RESPONSE:");
            System.out.println(json.serialize(addressData));
            System.out.println();
        }
        catch (Exception ex)
        {
            System.out.println("ERROR: " + ex.getMessage());
        }
    }
    
    /**
     * Example showing how to calculate taxes for a Transaction.
     */
    private static void calculateTaxes() {
        printSeparator();
        System.out.println("API: POST " + baseAddress + "/api/v1/CalculateTaxes");
        System.out.println();

        try {
            AfcRestClient client = new AfcRestClient(baseAddress, userName, password, clientId, clientProfileId);
            
            // Create a Transaction object to specify the input data for the tax calculation
            // NOTE: Bill-To, Origination, and Termination can be entered using PCodes, FIPS Codes, NPANXX, or ZipAddress.
            // NOTE: Use your Avalara-provided CompanyIdentifier to include this transaction and taxes in your compliance 
            // reports or leave blank otherwise (for testing and calculating taxes on quotes).
            // NOTE: CustomerNumber, InvoiceNumber, and other optional fields may be specified for reporting purposes
            Transaction transaction = new Transaction()
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
                .date(LocalDateTime.now())
                .facilitiesBased(true)
                .franchise(true)
                .incorporated(true)
                .lifeline(false)
                .lines(1)
                .locations(0)
                .minutes((double)0)
                .regulated(false)
                .sale(true)
                .serviceClass(1)        // Primary long distance
                .serviceType(6)         // Access Charge
                .transactionType(19);   // VoIP

            // NOTE: Depending on the transaction/service type, Origination and Termination may not apply
            // in which case the same jurisdiction as the bill-to location must be populated into these fields
            transaction.setOriginationAddress(transaction.getBillToAddress());
            transaction.setTerminationAddress(transaction.getBillToAddress());

            System.out.println("REQUEST BODY:");
            System.out.println(json.serialize(transaction));
            System.out.println();

            // Invoke REST API to calculate taxes on the transaction
            TaxData[] taxes = client.calculateTaxes(transaction);

            System.out.println("RESPONSE:");
            System.out.println(json.serialize(taxes));
            System.out.println();
        }
        catch (Exception ex) {
            System.out.println("ERROR: " + ex.getMessage());
        }
    }

    /**
     * Example showing how to calculate tax adjustments for a Transaction.
     */
    private static void calculateAdjustments() {
        printSeparator();
        System.out.println("API: POST " + baseAddress + "/api/v1/CalculateAdjustments");
        System.out.println();

        try
        {
        AfcRestClient client = new AfcRestClient(baseAddress, userName, password, clientId, clientProfileId);
            // Create a Transaction object similarly as for processing a regular tax calculation
            Transaction transaction = new Transaction()
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
                .date(LocalDateTime.now())  // NOTE: For adjustments, use the same date as original transaction
                .facilitiesBased(true)
                .franchise(true)
                .incorporated(true)
                .lifeline(false)
                .lines(1)
                .locations(0)
                .minutes((double)0)
                .regulated(false)
                .sale(true)
                .serviceClass(1)            // Primary long distance
                .serviceType(6)             // Access Charge
                .transactionType(19);       // VoIP

            transaction.setOriginationAddress(transaction.getBillToAddress());
            transaction.setTerminationAddress(transaction.getBillToAddress());

            System.out.println("REQUEST BODY:");
            System.out.println(json.serialize(transaction));
            System.out.println();

            // Invoke REST API to calculate tax adjustments on the transaction
            TaxData[] taxes = client.calculateAdjustments(transaction);

            System.out.println("RESPONSE:");
            System.out.println(json.serialize(taxes));
            System.out.println();
        }
        catch (Exception ex) {
            System.out.println("ERROR: " + ex.getMessage());
        }
    }

    /**
     * Example showing how to calculate taxes for a bridge conference transaction.
     */
    private static void calculateBridgeConferenceTaxes() {
        printSeparator();
        System.out.println("API: POST " + baseAddress + "/api/v1/BridgeConference/Taxes");
        System.out.println();

        try {
            AfcRestClient client = new AfcRestClient(baseAddress, userName, password, clientId, clientProfileId);
            
            // Create a BridgeConferenceTransaction object to specify the input data for the tax calculation
            BridgeConferenceTransaction transaction = new BridgeConferenceTransaction()
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
                .date(LocalDateTime.now())
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
            
            System.out.println("REQUEST BODY:");
            System.out.println(json.serialize(transaction));
            System.out.println();

            // Invoke REST API to calculate taxes on the bridge conference transaction
            BridgeConferenceResults results = 
                    client.calculateBridgeConferenceTaxes(transaction);

            System.out.println("RESPONSE:");
            System.out.println(json.serialize(results));
            System.out.println();
        }
        catch (Exception ex) {
            System.out.println("ERROR: " + ex.getMessage());
        }
    }

    /**
     * Example showing how to calculate taxes on a transaction while overriding 
     * tax rate for a specific tax.
     */
    private static void calculateTaxesWithOverrides() {
        printSeparator();
        System.out.println("API: POST " + baseAddress + "/api/v1/CalculateWithOverrides/Taxes");
        System.out.println();

        try {
            AfcRestClient client = new AfcRestClient(baseAddress, userName, password, clientId, clientProfileId);

            // Create a CalculateWithOverridesRequest object to specify the trasaction and override data
            CalculateWithOverridesRequest request = new CalculateWithOverridesRequest()
                .transaction(new Transaction()
                    .billToPCode(4133800)       // PCode for Seattle, WA
                    .businessClass(0)           // ILEC
                    .charge(25.95)
                    .companyIdentifier("TST")
                    .customerType(0)            // Residential
                    .date(LocalDateTime.now())
                    .facilitiesBased(true)
                    .franchise(true)
                    .incorporated(true)
                    .lifeline(false)
                    .lines(1)
                    .locations(0)
                    .minutes((double)0)
                    .originationPCode(4133800)  // PCode for Seattle, WA
                    .regulated(false)
                    .sale(true)
                    .serviceClass(1)            // Primary long distance
                    .serviceType(15)            // Product
                    .terminationPCode(4133800)  // PCode for Seattle, WA
                    .transactionType(10));      // Sales

            // Specify tax rate overrides for request
            TaxRateOverrideInfo rateOverride = new TaxRateOverrideInfo()
                .pcode(4133800)         // PCode for Seattle, WA
                .levelExemptible(true)
                .scope(1)               // State-level scope
                .taxLevel(1)            // State-level tax
                .taxType(1);            // Sales tax type
            
            rateOverride.addBracket(new TaxBracketInfo()
                .maxBase((double)Integer.MAX_VALUE) // Use max value if bracket has no limit
                .rate(0.0123));          // Enter rate as decimal for percentage-based taxes
                                
            request.addOverride(rateOverride);
                        
            System.out.println("REQUEST BODY:");
            System.out.println(json.serialize(request));
            System.out.println();

            // Invoke REST API to calculate taxes on the transaction using the specified tax rate override
            TaxData[] taxes = client.calculateTaxesWithOverrides(request);

            System.out.println("RESPONSE:");
            System.out.println(json.serialize(taxes));
            System.out.println();
        }
        catch (Exception ex) {
            System.out.println("ERROR: " + ex.getMessage());
        }
    }
    
    /**
     * Print separator line in console output.
     */
    private static void printSeparator() { 
        System.out.println("-------------------------------------------------");
        System.out.println();
    }
}
