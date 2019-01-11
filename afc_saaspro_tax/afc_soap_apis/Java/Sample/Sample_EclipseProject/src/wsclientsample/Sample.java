//************************************************************************
//**                                                                     *
//** Use of the Licensed Product is covered by warranty, including       *
//** warranty disclaimer, and liability provisions in the license        *
//** agreement between Avalara, Inc. and Customer; any warranty          *
//** provided for the Licensed Product shall not be deemed to apply      *
//** to this or any other code example.  Avalara expressly disclaims     *
//** all warranties of any kind including, without limitation, warranties*
//** of merchantability or fitness for a particular purpose.  The code   *
//** example is for Customer's use only.  Customer assumes all           *
//** responsibilities regarding the use or adaptation of this code       *
//** example and acknowledges that use of such code example is at        *
//** Customer's own risk.                                                *
//**                                                                     *
//** Use of this code example constitutes acceptance of the aforesaid    *
//** terms, conditions, and limitations; Customer hereby releases        *
//** Avalara, Inc., its employees, directors, affiliates and assigns     *
//** from any and all financial or legal responsibility, implied or      *
//** explicit.                                                           *
//**                                                                     *
//************************************************************************
//**                                                                     *
//** This example code is intended for API demonstration only and is not *
//** intended for production use.                                        *
//**                                                                     *
//************************************************************************
//                                                                       *
// Copyright 2017 by Avalara, Inc.                                       *
//   All Rights Reserved. No part of this publication may be reproduced, *
//   stored in a retrieval system, or transmitted, in any form, by any   *
//   means, without the prior written permission of the publisher.       *
//                                                                       *
//************************************************************************
package wsclientsample;



import com.billsoft.eztaxasp.eztaxwebservice.*;

import java.util.ArrayList;
import java.util.GregorianCalendar;
import java.util.List;

import javax.xml.bind.JAXBElement;
import javax.xml.datatype.DatatypeFactory;
import javax.xml.namespace.QName;
import javax.xml.ws.handler.Handler;
import javax.xml.ws.handler.HandlerResolver;
import javax.xml.ws.handler.PortInfo;

import org.datacontract.schemas._2004._07.eztaxwebservice.AddressData;
import org.datacontract.schemas._2004._07.eztaxwebservice.ArrayOfAddressData;
import org.datacontract.schemas._2004._07.eztaxwebservice.ArrayOfTaxData;
import org.datacontract.schemas._2004._07.eztaxwebservice.ArrayOfTaxExemption;
import org.datacontract.schemas._2004._07.eztaxwebservice.ReverseTaxResults;
import org.datacontract.schemas._2004._07.eztaxwebservice.TaxData;
import org.datacontract.schemas._2004._07.eztaxwebservice.TaxExemption;
import org.datacontract.schemas._2004._07.eztaxwebservice.TaxInclusiveResults;
import org.datacontract.schemas._2004._07.eztaxwebservice.Transaction;
import org.datacontract.schemas._2004._07.eztaxwebservice.ZipAddress;

public class Sample {
   static String userName = "CHANGEME"; // Add your user name here, or use a command line argument
   static String password = "CHANGEME"; // Add your password here, or use a command line argument

   /**
    * Main entry point for application.
    * @param args
    */
   public static void main(String[] args) {
     // check to see if user name and password are on the command line
     if (args.length >= 2) {
        userName = args[0];
        password = args[1];
     }
      try {
         // NOTE: The the eztaxasp.jar package was created using the JDK wsimport executable. Although shown
         // as multiple lines for clarity, the following must be executed as a single line.
         // "C:\Program Files\Java\jdk1.8.0_65\bin\wsimport" -d \tmp\test-out.txt 
         // http://eztaxasp.billsoft.com/EZTaxWebService/EZTaxWebService.svc?wsdl -Xendorsed -extension 
         // -clientjar .\eztaxasp.jar

         // The eztaxasp.jar file will be created in the current directory. To change the directory, specify
         // the full path name.

         // To generate the jar package for another Java release, change the jak1.8.0_65 for the appropriate
         // path. For example, I have Java 7 installed in H:\wrk\java64.x1\jdk1.7.0_21. Therefore, the command
         // becomes
         // "H:\wrk\java64.x1\jdk1.7.0_21\bin\wsimport" -d \tmp\test-out.txt
         // http://eztaxasp.billsoft.com/EZTaxWebService/EZTaxWebService.svc?wsdl -Xendorsed -extension
         // -clientjar .\eztaxasp.jar

         // Don't forget to combine the three lines into one line. Alternatively, if included in a batch/command
         // file, place a blank space and the ^ symbol at the end of the first two lines to continue onto the next
         // line.

         // NOTE Use the options below in your Java command to print the SOAP requests and responses to the console
         // -Dcom.sun.xml.ws.transport.http.client.HttpTransportPipe.dump=true;

         System.out.println("EZTax SaaS Test Program -----------------------------------------");

         // Create an instance of the EZTaxWebService
         System.out.println("--- EZTaxWebService instance creation ---");
         EZTaxWebService eztaxWebService = new EZTaxWebService();

         // Used for JAXBElement namespaces
         String xmlns = "http://schemas.datacontract.org/2004/07/EZTaxWebService";

         // Define the name for the CustomBinding endpoint
         System.out.println("--- QName instance creation ---");
               // Note that a number of println statements, shch as the one above, are placed
               // into the source to help with initial bringup problem isolation.
         QName customBindingPort = new QName("http://eztaxasp.billsoft.com/eztaxwebservice", "CustomBinding_IEZTaxWebService", "");

         // Add a custom HandlerResolver in order to add the custom headers for the EZTax service credentials
         System.out.println("--- Add custom HandlerResolver ---");
         eztaxWebService.setHandlerResolver(new HandlerResolver() {
         @SuppressWarnings("rawtypes")
         public List<Handler>  getHandlerChain(PortInfo portInfo) {
               List<Handler> handlers = new ArrayList<Handler>();
               handlers.add(new EZTaxSOAPHandler(userName, password));
               return handlers;
            }
         });

         // Instantiate the interface class
         System.out.println("--- IEZTaxWebService instance creation ---");
         IEZTaxWebService eztax = eztaxWebService.getPort(customBindingPort, IEZTaxWebService.class);

         try {
            // Get the date and time of the server hosting the EZTax Web Service
            System.out.print("EZTax Server Time: ");
            System.out.println(eztax.getServerTime());
            
            // Get the version of EZTax SaaS
            System.out.print("EZTax SaaS Version: ");
            System.out.println(eztax.getVersion());
            
            // Get the version of the EZTax engine
            System.out.print("EZTax Engine Version: ");
            System.out.println(eztax.getEZTaxVersion());
            
            // Get the version of the EZTax database
            System.out.print("EZTax Database Version: ");
            System.out.println(eztax.getEZTaxDbVersion());            

            // Return and publish a tax category
            System.out.println();
            System.out.println("-----------");
            String taxCategory = eztax.getTaxCategory(1);
            System.out.println("Returned from getTaxCategory(1): " + taxCategory + ".");
            System.out.println();

            // Create a ZipAddress object in order to specify a location for the taxing jurisdiction
            ZipAddress address = new ZipAddress();
            address.setCountryISO   (new JAXBElement<String>(new QName(xmlns, "CountryISO"),   String.class, "USA"));
            address.setState      (new JAXBElement<String>(new QName(xmlns, "State"),       String.class, "KS"));
            address.setCounty      (new JAXBElement<String>(new QName(xmlns, "County"),       String.class, "Johnson"));
            address.setLocality      (new JAXBElement<String>(new QName(xmlns, "Locality"),       String.class, "Overland Park"));
            address.setZipCode      (new JAXBElement<String>(new QName(xmlns, "ZipCode"),       String.class, "66212"));
            address.setZipP4      (new JAXBElement<String>(new QName(xmlns, "ZipP4"),       String.class, "3382"));

            System.out.println("Printing address: " +
               address.getLocality().getValue() + ", " +
               address.getState().getValue() + " " +
               address.getZipCode().getValue() + "-" +
               address.getZipP4().getValue() + "  " +
               address.getCountryISO().getValue() + "." );

            System.out.println("----------------------------------------------------------");
            System.out.println("Jurisdiction type conversion examples using ZipAddress:");
            System.out.println();

            // ZipAddress to PCode conversion
            long pcode = eztax.zipToPCode(address);

            System.out.println("PCode for " +
               address.getLocality().getValue() + ", " +
               address.getState().getValue() + " " +
               address.getZipCode().getValue() + "-" +
               address.getZipP4().getValue() + ": " +
               pcode);

            // PCode to Fips conversion
            String fipsCode = eztax.pCodeToFips(pcode);
            System.out.println("FIPS Code for PCode " + pcode + ": " + fipsCode);

            // FIPS Code to PCode conversion
            long pcodeFromFips = eztax.fipsToPCode(fipsCode);
            System.out.println("PCode Code for FIPS Code " + fipsCode + ": " + pcodeFromFips);

            // NPANXX to PCode conversion
            long npanxx = 913859l;
            long pcodeFromNpaNxx = eztax.npaNxxToPCode(npanxx);
            System.out.println("PCode for NPANXX " + npanxx + ": " + pcodeFromNpaNxx);

            // GetAddress example
            System.out.println();
            System.out.println("----------------------------------------------------------");
            System.out.println("GetAddress example:");
            System.out.println();

            // Get the jurisdiction information for the specified PCode
            ArrayOfAddressData addressData = eztax.getAddress(pcode);
            System.out.println("AddressData for PCode: " + pcode + ":");

            for (AddressData addr : addressData.getAddressData())
            {
               // NOTE: The first element of the AddressData list will contain the primary
               // location for the jurisdiction. Consecutive elements may contain additional
               // zip code ranges or alternate locations.
               System.out.println("    " + 
                  addr.getCountryISO().getValue() + ", " +
                  addr.getState().getValue() + ", " +
                  addr.getCounty().getValue() + ", " +
                  addr.getLocality().getValue() + ", " +
                  addr.getZipBegin().getValue() + " to " +
                  addr.getZipEnd().getValue());
            }

            // Create a transaction for processing tax calculations
            Transaction trans = new Transaction();
            trans.setBusinessClass(new JAXBElement<Integer>(new QName(xmlns, "BusinessClass"), Integer.class, 0));    // 1 = CLEC
            trans.setCharge(100.00);
            trans.setCompanyIdentifier(new JAXBElement<String>(new QName(xmlns, "CompanyIdentifier"), String.class, "TST"));
            trans.setCustomerNumber(new JAXBElement<String>(new QName(xmlns, "CustomerNumber"), String.class, "Test Customer"));
            trans.setCustomerType(new JAXBElement<Integer>(new QName(xmlns, "CustomerType"), Integer.class, 0));     // 0 = Residential
            trans.setDate(DatatypeFactory.newInstance().newXMLGregorianCalendar(new GregorianCalendar(2011, 6, 1)));
            trans.setDebit(false);        // true is only used for prepaid card transactions
            trans.setFacilitiesBased(false);
            trans.setFranchise(false);
            trans.setIncorporated(true);    // Indicate that address is in an incorporated area. Use false for un-incorporated
            trans.setInvoiceNumber((long)1234567890);   // Optional field
            trans.setLifeline(false);
            trans.setLines(1);
            trans.setLocations(1);
            trans.setMinutes(10.5);
            trans.setRegulated(true);
            trans.setSale(true);          // true = Retail, false = Wholesale
            trans.setServiceClass(new JAXBElement<Integer>(new QName(xmlns, "ServiceClass"), Integer.class, 1)); // 1 = Primary Long Distance
            trans.setServiceType((short)6);
            trans.setTransactionType((short)13);

            // No exemptions for this transaction
            trans.setFederalExempt(false);
            trans.setStateExempt(false);
            trans.setCountyExempt(false);
            trans.setLocalExempt(false);

            System.out.println();
            System.out.println("----------------------------------------------------------");
            System.out.println("Tax calculation example using ZipAddress:");
            System.out.println();

            // Set the bill-to, origination and termination using ZipAddress
            trans.setBillToAddress(new JAXBElement<ZipAddress>(new QName(xmlns, "BillToAddress"), ZipAddress.class, address));
            trans.setOriginationAddress(new JAXBElement<ZipAddress>(new QName(xmlns, "OriginationAddress"), ZipAddress.class, address));
            trans.setTerminationAddress(new JAXBElement<ZipAddress>(new QName(xmlns, "TerminationAddress"), ZipAddress.class, address)); 

            ArrayOfTaxData taxes = eztax.calcTaxesWithZipAddress(trans); // Calculate taxes
            System.out.println("Taxes returned:");
            System.out.println();
            PrintTaxes(taxes);

            System.out.println();
            System.out.println("----------------------------------------------------------");
            System.out.println("Tax calculation example using PCode:");
            System.out.println();

            // Set the bill-to, origination and termination using PCodes 
            trans.setBillToPCode(new JAXBElement<Long>(new QName(xmlns, "BillToPCode"), Long.class, pcode));
            trans.setOriginationPCode(new JAXBElement<Long>(new QName(xmlns, "OriginationPCode"), Long.class, pcode));
            trans.setTerminationPCode(new JAXBElement<Long>(new QName(xmlns, "TerminationPCode"), Long.class, pcode));

            taxes = eztax.calcTaxesWithPCode(trans); // Calculate taxes
            System.out.println("Taxes returned:");
            System.out.println();
            PrintTaxes(taxes);

            System.out.println();
            System.out.println("----------------------------------------------------------");
            System.out.println("Tax calculation example using FIPS Code:");

            // Set the bill-to, origination and termination using FIPS Codes
            trans.setBillToFipsCode(new JAXBElement<String>(new QName(xmlns, "BillToFipsCode"), String.class, fipsCode));
            trans.setOriginationFipsCode(new JAXBElement<String>(new QName(xmlns, "OriginationFipsCode"), String.class, fipsCode));
            trans.setTerminationFipsCode(new JAXBElement<String>(new QName(xmlns, "TerminationFipsCode"), String.class, fipsCode));
            System.out.println();

            taxes = eztax.calcTaxesWithFipsCode(trans); // Calculate taxes
            System.out.println("Taxes returned:");
            System.out.println();
            PrintTaxes(taxes);

            System.out.println();
            System.out.println("----------------------------------------------------------");
            System.out.println("Tax calculation example using NPANXX:");
            System.out.println();

            // Set the bill-to, origination and termination using NPANXX numbers
            trans.setBillToNpaNxx(new JAXBElement<Long>(new QName(xmlns, "BillToNpaNxx"), Long.class, npanxx));
            trans.setOriginationNpaNxx(new JAXBElement<Long>(new QName(xmlns, "OriginationNpaNxx"), Long.class, npanxx));
            trans.setTerminationNpaNxx(new JAXBElement<Long>(new QName(xmlns, "TerminationNpaNxx"), Long.class, npanxx));

            taxes = eztax.calcTaxesWithNpaNxx(trans); // Calculate taxes
            System.out.println("Taxes returned:");
            System.out.println();
            PrintTaxes(taxes);

            System.out.println();
            System.out.println("----------------------------------------------------------");
            System.out.println("Adjustment example:");
            System.out.println();

            // NOTE: For processing adjustments, use the same transaction information that was used during
            // the original tax calculation. In particular, leave the charge amount as a positive number instead
            // of passing in a negative number, and also use the same date as the original transaction.
            taxes = eztax.calcAdjWithPCode(trans); 
            System.out.println("Taxes returned:");
            System.out.println();
            PrintTaxes(taxes);

            System.out.println();
            System.out.println("----------------------------------------------------------");
            System.out.println("Tax calculation with level exemptions:");
            System.out.println();

            // Exempt all state-level taxes for this transaction
            trans.setStateExempt(true);

            taxes = eztax.calcTaxesWithPCode(trans);    // Calculate taxes
            System.out.println("Taxes returned:");
            System.out.println();
            PrintTaxes(taxes);

            System.out.println();
            System.out.println("----------------------------------------------------------");
            System.out.println("Tax calculation with specific exemptions:");
            System.out.println();

            // Exempt only the State Sales Tax for this transaction
            trans.setStateExempt(false);

            // Create a specific exemption
            TaxExemption exempt = new TaxExemption();
            exempt.setPCode(pcode);         // Set jurisdiction for exemption
            exempt.setTaxLevel(1);          // State level
            exempt.setTaxType((short)1);   // Sales tax

            // Add the exemption to the exemption list
            ArrayOfTaxExemption exemptions = new ArrayOfTaxExemption();
            exemptions.getTaxExemption().add(exempt);
            trans.setExemptions(
               new JAXBElement<ArrayOfTaxExemption>(new QName(xmlns, "Exemptions"), 
               ArrayOfTaxExemption.class, 
               exemptions));

            taxes = eztax.calcTaxesWithPCode(trans);    // Calculate taxes
            System.out.println("Taxes returned:");
            System.out.println();
            PrintTaxes(taxes);

            System.out.println();
            System.out.println("----------------------------------------------------------");
            System.out.println("Tax Inclusive (reverse) tax calculation example:");
            System.out.println();

            // NOTE: When performing reverse tax calculations, place the total 
            // desired charge (sale amount + total tax amount) into the Charge field
            trans.setCharge(100.00);
            TaxInclusiveResults taxInclusiveResults = eztax.calcTaxInclusiveTaxes(trans);

            // EZTax SaaS returns the appropriate base sale amount required in order to arrive at the desired total charge
            System.out.println("Desired total charge: " + trans.getCharge());
            System.out.println("Base sale amount: " + taxInclusiveResults.getBaseSaleAmount());
            System.out.println("Taxes returned:");
            System.out.println();
                     PrintTaxes(taxInclusiveResults.getTaxes().getValue());

            System.out.println();
            System.out.println("----------------------------------------------------------");
            System.out.println("Tax Inclusive (reverse) adjustment example:");
            System.out.println();

            // NOTE: When performing reverse adjustments, place the total charge being refunded
            // (sale amount + total tax amount) into the Charge field as a positive number
            trans.setCharge(100.00);
            taxInclusiveResults = eztax.calcTaxInclusiveAdj(trans);

            // EZTax SaaS returns the appropriate base sale amount required in order to arrive at the desired total charge
            System.out.println("Desired total charge: " + trans.getCharge());
            System.out.println("Base sale amount: " + taxInclusiveResults.getBaseSaleAmount());
            System.out.println("Taxes returned:");
            System.out.println();
            PrintTaxes(taxInclusiveResults.getTaxes().getValue());

            System.out.println();
            System.out.println("----------------------------------------------------------");
            System.out.println("Deprecated reverse tax calculation example:");
            System.out.println();

            // NOTE: When performing reverse tax calculations, place the total
            // desired charge (sale amount + total tax amount) into the Charge field
            trans.setCharge(100.00);
            ReverseTaxResults results = eztax.calcReverseTaxesWithPCode(trans);

            // EZTax SaaS returns the appropriate base sale amount required in order to arrive at the desired total charge
            System.out.println("Desired total charge: " + trans.getCharge());
            System.out.println("Base sale amount: " + results.getBaseSaleAmount());
            System.out.println("Taxes returned:");
            System.out.println();
                     PrintTaxes(results.getTaxes().getValue());

            System.out.println();
            System.out.println("----------------------------------------------------------");
            System.out.println("Deprecated reverse adjustment example:");
            System.out.println();

            // NOTE: When performing reverse adjustments, place the total charge being refunded
            // (sale amount + total tax amount) into the Charge field as a positive number
            trans.setCharge(100.00);
            results = eztax.calcReverseAdjWithPCode(trans);

            // EZTax SaaS returns the appropriate base sale amount required in order to arrive at the desired total charge
            System.out.println("Desired total charge: " + trans.getCharge());
            System.out.println("Base sale amount: " + results.getBaseSaleAmount());
            System.out.println("Taxes returned:");
            System.out.println();
            PrintTaxes(results.getTaxes().getValue());
         }
         catch (Exception ex) {
            System.out.println(ex.getMessage());
            ex.printStackTrace();
         }
      }
      catch (Exception ex) {
         System.out.println(ex.getMessage());
         ex.printStackTrace();
      }
   }

   /*
    * Print tax information on the console
    */
   private static void PrintTaxes(ArrayOfTaxData taxes) {
      // NOTE: Not all tax data information is printed for conciseness
      for (TaxData tax : taxes.getTaxData()) {
         System.out.println("PCode:              " + tax.getPCode());
         System.out.println("Tax Type ID:        " + tax.getTaxType());
         System.out.println("Tax Level:          " + tax.getTaxLevel().getValue());
         System.out.println("Description:        " + tax.getDescription().getValue());
         System.out.println("Tax Category:       " + tax.getCategoryDescription().getValue());
         System.out.println("Taxable Measure:    " + tax.getTaxableMeasure());
         System.out.println("Exempt Sale Amount: " + tax.getExemptSaleAmount());
         System.out.println("Tax Rate:           " + tax.getRate());
         System.out.println("Tax Amount:         " + tax.getTaxAmount());
         System.out.println("Calculation Type:   " + tax.getCalculationType());    // See manual for possible values
         System.out.println();
      }
   }
}
