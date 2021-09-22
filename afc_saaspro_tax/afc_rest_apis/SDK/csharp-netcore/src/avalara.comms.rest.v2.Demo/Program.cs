using System;
using System.Collections.Generic;
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Model;

namespace avalara.comms.rest.v2.Demo
{
    class Program
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://communicationsua.avalara.net";
            // Configure HTTP basic authorization: Basic
            config.Username = "";
            config.Password = "";

            config.DefaultHeaders = new Dictionary<string, string>
            {
                { "client_id", "0" },
                { "client_profile_id", "0" }
            };

            var apiInstance = new TaxCalculationApi(config);

            CalcTaxesRequest calcTaxRequest = new CalcTaxesRequest
            {
                Cfg = GetRequestConfig(),
                Cmpn = GetCompanyData(),
                Inv = new List<Invoice>
                {
                    GetInvoice()
                }
            };

            try
            {
                CalcTaxesResponse result = apiInstance.ApiV2AfcCalcTaxesPost(calcTaxRequest);
                foreach (var invoice in result.Inv)
                {
                    Console.WriteLine($"Document Code:\t{invoice.Doc}");
                    Console.WriteLine($"Account:\t{invoice.Incrf.Acct}");
                    Console.WriteLine($"Customer:\t{invoice.Incrf.Custref}");
                    Console.WriteLine($"Bill Cycle:\t{invoice.Incrf.Bcyc}");
                    Console.WriteLine($"Invoice:\t{invoice.Incrf.Invn}\n");

                    foreach (var lineitem in invoice.Itms)
                    {
                        Console.WriteLine($"\tLine Item Ref:\t{lineitem.Ref}\n");

                        foreach (var tax in lineitem.Txs)
                        {   
                            Console.WriteLine($"\tTax Type ID:\t{tax.Tid}");
                            Console.WriteLine($"\tTax Type Description:\t{tax.Name}");
                            Console.WriteLine($"\tTax Rate:\t{tax.Rate}");
                            Console.WriteLine($"\tTax Amount:\t{tax._Tax}\n");
                        }
                    }
                }
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling : ApiV2AfcCalcTaxesPost " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }

        private static RequestConfig GetRequestConfig() => new RequestConfig
        {
            // return non-billable taxes
            Retnb = false,
            // return extended information
            Retext = true,
            // include reporting information
            Incrf = true
        };

        private static CompanyData GetCompanyData() => new CompanyData
        {
            // business class
            Bscl = 0,
            // service class
            Svcl = 0,
            // facilities
            Fclt = false,
            // franchise
            Frch = false,
            // regulated
            Reg = false,
            // exclusions
            Excl = null,
            // identifier
            Idnt = "Company A"
        };

        private static Invoice GetInvoice() => new Invoice
        {
            // document code
            Doc = Guid.NewGuid().ToString(),
            // commit
            Cmmt = false,
            // bill-to location
            Bill = GetLocation(),
            // customer type
            Cust = 0,
            // lifeline
            Lfln = false,
            // invoice date
            Date = DateTime.UtcNow,
            // exemptions
            Exms = null,
            // line items
            Itms = new List<LineItem>
            {
                GetLineItem()
            },
            // invoice mode
            Invm = true,
            // account reference
            Acct = "Account Reference",
            // customer reference
            Custref = "Customer Reference",
            // invoice reference
            Invn = "Invoice Reference",
            // bill cycle reference
            Bcyc = "Bill Cycle Reference",
            // billing period
            Bpd = new BillingPeriod
            {
                Month = DateTime.UtcNow.Month,
                Year = DateTime.UtcNow.Year
            },
            // currency code
            Ccycd = "USD"
        };

        private static LineItem GetLineItem() => new LineItem
        {
            // line item reference
            Ref = "Line Item Reference",
            // input charge
            Chg = 100,
            // lines
            Line = 1,
            // locations
            Loc = 1,
            // minutes
            Min = 1,
            // sale
            Sale = 1,
            // transaction type
            Tran = 19,
            // service type
            Serv = 6,
            // adjustment
            Adj = false,
            // quantity
            Qty = 5,
            // general ledger reference
            Glref = "General Ledger Reference"
        };

        private static Location GetLocation() => new Location
        {
            // country
            Ctry = "USA",
            St = "WASHINGTON",
            Cnty = "KING",
            City = "SEATTLE",
            Addr = "221 S KING ST",
            Zip = "98104"
        };
    }
}