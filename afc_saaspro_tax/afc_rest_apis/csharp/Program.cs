using System;
using System.Linq;
using Newtonsoft.Json;
using Avalara.Comms.Rest.Sample.Model;
using Avalara.Comms.Rest.Sample.Client;

namespace Avalara.Comms.Rest.Sample
{
    /// <summary>
    /// Sample program for the AFC REST service.
    /// </summary>
    public class Program
    {
        private const string BaseAddress = "[BaseAddress]"; // Change to Base address for AFC REST service
        private const string UserName = "[UserName]";       // Credentials user name provided by Avalara
        private const string Password = "[Password]";       // Credentials password provided by Avalara
        private const int ClientId = 536;                   // Client Id provided by Avalara
        private const int ClientProfileId = 1;              // Client Profile Id provided by Avalara when a Client has multiple configuration
        private const string UtcFormat = "O";
        
        /// <summary>
        /// Main entry point for AFC REST service sample program.
        /// </summary>
        /// <param name="args">Command-line arguments (none required).</param>
        public static void Main(string[] args)
        {
            Console.WriteLine($"Sample program for AFC REST service");
            Console.WriteLine();
            Console.WriteLine(
                $"NOTE: Update the BaseAddress, UserName, Password, ClientId and Client Profile ID constants in the Program.cs file accordingly");
            Console.WriteLine();
            
            GetServerTime();
            GetPCode();
            GetAddress();
            CalculateTaxes();
            CalculateAdjustments();
            CalculateBridgeConferenceTaxes();
            CalculateTaxesWithOverrides();

            PrintSeparator();
            Console.Write($"End of sample program. Press Enter to exit...");
            Console.ReadLine();
        }

        /// <summary>
        /// Example showing how to get the server time from the AFC REST service.
        /// </summary>
        private static void GetServerTime()
        {
            PrintSeparator();
            Console.WriteLine($"API: GET {BaseAddress}/api/v1/Application/ServerTime");
            Console.WriteLine();

            using (var client = new AfcRestClient(BaseAddress, UserName, Password, ClientId, ClientProfileId))
            {
                try
                {
                    // Invoke REST API to get the server time
                    DateTime serverTime = client.GetServerTime().Result;
                    
                    Console.WriteLine($"RESPONSE:");
                    Console.WriteLine(serverTime.ToString(UtcFormat));
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Example showing how to obtain the PCode for a location.
        /// </summary>
        private static void GetPCode()
        {
            PrintSeparator();
            Console.WriteLine($"API: POST {BaseAddress}/api/v1/Location/PCode");
            Console.WriteLine();
            
            using (var client = new AfcRestClient(BaseAddress, UserName, Password, ClientId, ClientProfileId))
            {
                try
                {
                    // Create a RequestPCodeDetail object for the request body
                    // NOTE: only one of the following properties must be populated: FipsCode, NpaNxx, or ZipAddress
                    var request = new RequestPCodeDetail
                    {
                        FipsCode = null,
                        NpaNxx = null,
                        ZipAddress = new ZipAddress
                        {
                            CountryIso = "USA",
                            State = "WA",
                            County = "King",
                            Locality = "Seattle",
                            ZipCode = "98101"
                        }
                    };

                    Console.WriteLine($"REQUEST BODY:");
                    Console.WriteLine(request.ToJson());
                    Console.WriteLine();
                    
                    // Invoke REST API to obtain the PCode for the location
                    uint pcode = client.GetPCode(request).Result;

                    Console.WriteLine($"RESPONSE:");
                    Console.WriteLine(pcode);
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Example showing how to get address information for a PCode.
        /// </summary>
        private static void GetAddress()
        {
            uint pcode = 452600;    // PCode for Crested Butte, CO

            PrintSeparator();
            Console.WriteLine($"API: GET {BaseAddress}/api/v1/Location/Address/{pcode}");
            Console.WriteLine();

            using (var client = new AfcRestClient(BaseAddress, UserName, Password, ClientId, ClientProfileId))
            {
                try
                {
                    // Invoke REST API to get the server time
                    AddressData[] addressData = client.GetAddress(pcode).Result;

                    Console.WriteLine($"RESPONSE:");
                    Console.WriteLine(JsonConvert.SerializeObject(addressData, Formatting.Indented));
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}");
                }
            }
        }
        
        /// <summary>
        /// Example showing how to calculate taxes for a Transaction.
        /// </summary>
        private static void CalculateTaxes()
        {
            PrintSeparator();
            Console.WriteLine($"API: POST {BaseAddress}/api/v1/CalculateTaxes");
            Console.WriteLine();

            using (var client = new AfcRestClient(BaseAddress, UserName, Password, ClientId, ClientProfileId))
            {
                try
                {
                    // Create a Transaction object to specify the input data for the tax calculation
                    // NOTE: Bill-To, Origination, and Termination can be entered using PCodes, FIPS Codes, NPANXX, or ZipAddress.
                    // NOTE: Use your Avalara-provided CompanyIdentifier to include this transaction and taxes in your compliance 
                    // reports or leave blank otherwise (for testing and calculating taxes on quotes).
                    // NOTE: CustomerNumber, InvoiceNumber, and other optional fields may be specified for reporting purposes
                    var transaction = new Transaction
                    {
                        BillToAddress = new ZipAddress
                        {
                            CountryIso = "USA",
                            State = "WA",
                            County = "King",
                            Locality = "Seattle",
                            ZipCode = "98101"
                        },
                        BusinessClass = 0,      // ILEC
                        Charge = 25.95,
                        CompanyIdentifier = "TST",
                        CustomerType = 0,       // Residential
                        Date = DateTime.Today,
                        FacilitiesBased = true,
                        Franchise = true,
                        Incorporated = true,
                        Lifeline = false,
                        Lines = 1,
                        Locations = 0,
                        Minutes = 0,
                        Regulated = false,
                        Sale = true,
                        ServiceClass = 1,       // Primary long distance
                        ServiceType = 6,        // Access Charge
                        TransactionType = 19    // VoIP
                    };

                    // NOTE: Depending on the transaction/service type, Origination and Termination may not apply
                    // in which case the same jurisdiction as the bill-to location must be populated into these fields
                    transaction.OriginationAddress = transaction.TerminationAddress = transaction.BillToAddress;
                    
                    Console.WriteLine($"REQUEST BODY:");
                    Console.WriteLine(transaction.ToJson());
                    Console.WriteLine();

                    // Invoke REST API to calculate taxes on the transaction
                    TaxData[] taxes = client.CalculateTaxes(transaction).Result;

                    Console.WriteLine($"RESPONSE:");
                    Console.WriteLine(JsonConvert.SerializeObject(taxes, Formatting.Indented));
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Example showing how to calculate tax adjustments for a Transaction.
        /// </summary>
        private static void CalculateAdjustments()
        {
            PrintSeparator();
            Console.WriteLine($"API: POST {BaseAddress}/api/v1/CalculateAdjustments");
            Console.WriteLine();

            using (var client = new AfcRestClient(BaseAddress, UserName, Password, ClientId, ClientProfileId))
            {
                try
                {
                    // Create a Transaction object similarly as for processing a regular tax calculation
                    var transaction = new Transaction
                    {
                        AdjustmentDiscount = 3,     // Specify a discount type for adjustments
                        AdjustmentMethod = 0,       // Use default adjustment method to apply tax brackets normally
                        BillToAddress = new ZipAddress
                        {
                            CountryIso = "USA",
                            State = "WA",
                            County = "King",
                            Locality = "Seattle",
                            ZipCode = "98101"
                        },
                        BusinessClass = 0,          // ILEC
                        Charge = 25.95,             // NOTE: Enter a positive amount for the amount being refunded
                        CompanyIdentifier = "TST",
                        CustomerType = 0,           // Residential
                        Date = DateTime.Today,      // NOTE: For adjustments, use the same date as original transaction
                        FacilitiesBased = true,
                        Franchise = true,
                        Incorporated = true,
                        Lifeline = false,
                        Lines = 1,
                        Locations = 0,
                        Minutes = 0,
                        Regulated = false,
                        Sale = true,
                        ServiceClass = 1,       // Primary long distance
                        ServiceType = 6,        // Access Charge
                        TransactionType = 19    // VoIP
                    };
                    
                    transaction.OriginationAddress = transaction.TerminationAddress = transaction.BillToAddress;

                    Console.WriteLine($"REQUEST BODY:");
                    Console.WriteLine(transaction.ToJson());
                    Console.WriteLine();

                    // Invoke REST API to calculate tax adjustments on the transaction
                    TaxData[] taxes = client.CalculateAdjustments(transaction).Result;

                    Console.WriteLine($"RESPONSE:");
                    Console.WriteLine(JsonConvert.SerializeObject(taxes, Formatting.Indented));
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Example showing how to calculate taxes for a bridge conference transaction.
        /// </summary>
        private static void CalculateBridgeConferenceTaxes()
        {
            PrintSeparator();
            Console.WriteLine($"API: POST {BaseAddress}/api/v1/BridgeConference/Taxes");
            Console.WriteLine();

            using (var client = new AfcRestClient(BaseAddress, UserName, Password, ClientId, ClientProfileId))
            {
                try
                {
                    // Create a BridgeConferenceTransaction object to specify the input data for the tax calculation
                    var transaction = new BridgeConferenceTransaction
                    {
                        BillingAddress = new ZipAddress
                        {
                            CountryIso = "USA",
                            State = "WA",
                            County = "King",
                            Locality = "Seattle",
                            ZipCode = "98101"
                        },
                        BridgeAddress = new ZipAddress
                        {
                            CountryIso = "USA",
                            State = "KS",
                            County = "Johnson",
                            Locality = "Overland Park",
                            ZipCode = "66212"
                        },
                        BusinessClass = 0,          // ILEC
                        Charge = 25.95,
                        CompanyIdentifier = "TST",
                        CustomerType = 0,           // Residential
                        Date = DateTime.Today,
                        FacilitiesBased = true,
                        Franchise = true,
                        HostAddress = new ZipAddress
                        {
                            CountryIso = "USA",
                            State = "KS",
                            County = "Johnson",
                            Locality = "Overland Park",
                            ZipCode = "66212"
                        },
                        Incorporated = true,
                        Lifeline = false,
                        Lines = 1,
                        Locations = 0,
                        Minutes = 0,
                        Participants = new []
                        {
                            new BridgeConferenceParticipant
                            {
                                ParticipantAddress = new ZipAddress
                                {
                                    CountryIso = "USA",
                                    State = "WA",
                                    County = "King",
                                    Locality = "Seattle",
                                    ZipCode = "98101"
                                },
                                ParticipantRef = "1"
                            },
                            new BridgeConferenceParticipant
                            {
                                ParticipantAddress = new ZipAddress
                                {
                                    CountryIso = "USA",
                                    State = "CO",
                                    County = "Denver",
                                    Locality = "Denver",
                                    ZipCode = "80014"
                                },
                                ParticipantRef = "2"
                            }
                        }.ToList(),
                        ProcessInvalidParticipant = true, // Don't fail transaction if a participant fails to be processed
                        Regulated = false,
                        ReturnParticipantTaxes = true, // Return each individual participant's taxes in the response  
                        Sale = true,
                        ServiceClass = 1        // Primary long distance
                    };
                    
                    Console.WriteLine($"REQUEST BODY:");
                    Console.WriteLine(transaction.ToJson());
                    Console.WriteLine();

                    // Invoke REST API to calculate taxes on the bridge conference transaction
                    BridgeConferenceResults results = client.CalculateBridgeConferenceTaxes(transaction).Result;

                    Console.WriteLine($"RESPONSE:");
                    Console.WriteLine(results.ToJson());
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}");
                }
            }
        }
        
        /// <summary>
        /// Example showing how to calculate taxes on a transaction while overriding tax rate for a specific tax.
        /// </summary>
        private static void CalculateTaxesWithOverrides()
        {
            PrintSeparator();
            Console.WriteLine($"API: POST {BaseAddress}/api/v1/CalculateWithOverrides/Taxes");
            Console.WriteLine();

            using (var client = new AfcRestClient(BaseAddress, UserName, Password, ClientId, ClientProfileId))
            {
                try
                {
                    // Create a CalculateWithOverridesRequest object to specify the trasaction and override data
                    var request = new CalculateWithOverridesRequest
                    {
                        Overrides = new TaxRateOverrideInfo[]
                        {
                            new TaxRateOverrideInfo
                            {
                                Pcode = 4133800,        // PCode for Seattle, WA
                                LevelExemptible = true,
                                Scope = 1,              // State-level scope
                                TaxLevel = 1,           // State-level tax
                                TaxType = 1,            // Sales tax type
                                BracketInfo = new []
                                {
                                    new TaxBracketInfo
                                    {
                                        MaxBase = int.MaxValue, // Use max value if bracket has no limit
                                        Rate = 0.0123           // Enter rate as decimal for percentage-based taxes
                                    }
                                }.ToList()
                            }
                        }.ToList(),
                        Transaction = new Transaction
                        {
                            BillToPCode = 4133800,      // PCode for Seattle, WA
                            BusinessClass = 0,          // ILEC
                            Charge = 25.95,
                            CompanyIdentifier = "TST",
                            CustomerType = 0,           // Residential
                            Date = DateTime.Today,
                            FacilitiesBased = true,
                            Franchise = true,
                            Incorporated = true,
                            Lifeline = false,
                            Lines = 1,
                            Locations = 0,
                            Minutes = 0,
                            OriginationPCode = 4133800, // PCode for Seattle, WA
                            Regulated = false,
                            Sale = true,
                            ServiceClass = 1,           // Primary long distance
                            ServiceType = 15,           // Product
                            TerminationPCode = 4133800, // PCode for Seattle, WA
                            TransactionType = 10        // Sales
                        }
                    };

                    Console.WriteLine($"REQUEST BODY:");
                    Console.WriteLine(request.ToJson());
                    Console.WriteLine();

                    // Invoke REST API to calculate taxes on the transaction using the specified tax rate override
                    TaxData[] taxes = client.CalculateTaxesWithOverrides(request).Result;

                    Console.WriteLine($"RESPONSE:");
                    Console.WriteLine(JsonConvert.SerializeObject(taxes, Formatting.Indented));
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Print separator line in console output.
        /// </summary>
        private static void PrintSeparator() => 
            Console.WriteLine($"-------------------------------------------------{Environment.NewLine}");
    }
}
