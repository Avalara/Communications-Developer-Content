<?php
//  Copyright 2011 by BillSoft, Inc.                               
//    All Rights Reserved. No part of this publication may be reproduced, 
//    stored in a retrieval system, or transmitted, in any form, by any   
//    means, without the prior written permission of the publisher.       
//    June 28, 2011 Dennis Hostetler <dhostetler@billsoft.com>

// These classes define the Web Service Data Definitions as described in the
// EZTaxWebServiceTelecom manual.
class Transaction {
	public $CustomerType;
	public $BusinessClass;
	public $Sale;
	public $TransactionType;
	public $ServiceType;
	public $ServiceClass;
	public $Date;
	public $Charge;
	public $Incorporated;
	public $FederalExempt;
	public $StateExempt;
	public $CountyExempt;
	public $LocalExempt;
	public $FederalPCode;
	public $StatePCode;
	public $CountyPCode;
	public $LocalPCode;
	public $Exemptions;
	public $ExemptionType;
	public $InvoiceNumber;
	public $Optional;
	public $CustomerNumber;
	public $CompanyIdentifier;
	public $OptionalAlpha1;
	public $Optional4;
	public $Optional5;
	public $Optional6;
	public $Optional7;
	public $Optional8;
	public $Optional9;
	public $Optional10;
	public $AdjustmentMethod;
	public $OriginationAddress;
	public $OriginationFipsCode;
	public $OriginationPCode;
	public $OriginationNpaNxx;
	public $TerminationAddress;
	public $TerminationFipsCode;
	public $TerminationPCode;
	public $TerminationNpaNxx;
	public $BillToAddress;
	public $BillToFipsCode;
	public $BillToPCode;
	public $BillToNpaNxx;
	public $Lines;
	public $Locations;
	public $Minutes;
	public $Debit;
	public $DiscountType;
	public $FacilitiesBased;
	public $Franchise;
	public $Lifeline;
	public $Regulated;
	public $ServiceLevelNumber;
}

class ZipAddress {
	public $CountryISO;
	public $County;
	public $Locality;
   public $State;
   public $ZipCode;
   public $ZipP4;
}

class AddressData {
   public $CountryISO;
   public $County;
   public $Locality;
   public $State;
   public $TaxLevel;
   public $ZipBegin;
   public $ZipEnd;
   public $ZipP4Begin;
   public $ZipP4End;
}

class TaxExemption {
	public $PCode;
	public $TaxLevel;
	public $TaxType;
}

class TaxData {
	public $AdjustmentType;
	public $Billable;
	public $CalculationType;
	public $CategoryDescription;
	public $CategoryID;
	public $CompanyIdentifier;
	public $Compliance;
	public $CustomerNumber;
	public $Description;
	public $ExcemptionType;
	public $ExemptSaleAmount;
	public $InvoiceNumber;
	public $Lines;
	public $Locations;
	public $Minutes;
	public $Optional;
	public $Optional4;
	public $Optional5;
	public $Optional6;
	public $Optional7;
	public $Optional8;
	public $Optional9;
	public $Optional10;
	public $OptionAlpha1;
	public $PCode;
	public $Rate;
	public $RefundUncollect;
	public $ServiceLevelNumber;
	public $Surcharge;
	public $TaxableMeasure;
	public $TaxAmount;
	public $TaxLevel;
	public $TaxType;
}

// Enumerations
class TaxLevel {
	const Federal            = 0;
	const State              = 1;
	const County             = 2;
	const Local              = 3;
	const Unincorporate      = 4;
	const Other              = 5;
	const State_County_Local = 6;
	const County_Local       = 7;
}

class CalculationType {
	const Rate               = 1;
	const Fixed              = 2;
	const PerMinute          = 3;
	const PerLine            = 4;
	const SelfTaxingRate     = 5;
	const PerBracket         = 6;
	const FixedOnTier        = 7;
}

class AdjustmentMethod {
	const DefaultAdjustment  = 0; // Called Default in the manual. That name is not allowed in PHP.
	const LeastFavorableRate = 1;
	const MostFavorableRate  = 2;
}

// This maps PHP classes to the structures SOAP returns.
$classmap = array(
   'Transaction'  => 'Transaction',
   'AddressData'  => 'AddressData',
   'ZipAddress'   => 'ZipAddress',
   'AddressData'  => 'AddressData',
   'TaxExemption' => 'TaxExemption',
   'TaxData'      => 'TaxData'
);

// Initialization
$ez      = '';
$user    = 'xxxxxxxx'; // Change this to BillSoft userid
$pass    = 'xxxxxxxx'; // Change this to BillSoft password

// Constants
$ns      = 'http://eztaxasp.billsoft.com/eztaxwebservice';
$wsdl    = 'http://eztaxasp.billsoft.com/EZTaxWebService/EZTaxWebService.svc?WSDL';
$sslport = 'https://eztaxasp.billsoft.com/EZTaxWebService/EZTaxWebService.svc/SSL';

// Configuration options SoapClient
$soap_opts = array(
   'login'        => $user,
   'password'     => $pass,
   'soap_version' => SOAP_1_2,
   'trace'        => true, // Set to false for a production environment
   'classmap'     => $classmap
);

// The custom BillSoft headers
$soap_headers = array(
   new SoapHeader($ns, 'UserName', $user),
   new SoapHeader($ns, 'Password', $pass)
);
try {
   $ez = new SoapClient($wsdl, $soap_opts); // Create the SoapClient object
   $ez->__setSoapHeaders($soap_headers);    // Set the custom headers
   $ez->__setLocation($sslport);            // Set the custom SSL service location
   //print dump_var($ez->__getTypes());     // Returns all type information from the wsdl.

	// Now you can call the BillSoft service functions
	print "GetServerTime()...\n";
   $result = $ez->GetServerTime(); // Simply returns the time on the server.
   print var_dump($result);
   $datetime = $result->GetServerTimeResult;

	print "PCodeToFips()...\n";
   $result = $ez->PCodeToFips(array('aPCode' => 1248900));
   print var_dump($result);

	print "ZipToPCode()...\n";
   $zip = new ZipAddress;
   $zip->CountryISO = 'USA';
   $zip->State      = 'KS';
   $zip->ZipCode    = '66212';
   $zip->ZipP4      = '1212';
   $result = $ez->ZipToPCode(array('aZipAddress' => $zip));
   print var_dump($result);

	print "GetAddress()...\n";
   $result = $ez->GetAddress(array('aPCode' => 1248900));
   print var_dump($result);

   print "CalcTaxesWithPCode()...\n";
	$txn = new Transaction;
	$txn->CustomerType         = 1;
	$txn->BusinessClass        = 1;
	$txn->Sale                 = 1;
	$txn->TransactionType      = 1;
	$txn->ServiceType          = 1;
	$txn->ServiceClass         = 1;
	$txn->Date                 = $datetime;
	$txn->Charge               = 11.11;
	$txn->Incorporated         = 1;
	$txn->FederalExempt        = 0;
	$txn->StateExempt          = 0;
	$txn->CountyExempt         = 0;
	$txn->LocalExempt          = 0;
	$txn->FederalPCode         = 0;
	$txn->StatePCode           = 0;
	$txn->CountyPCode          = 0;
	$txn->LocalPCode           = 0;
	$txn->AdjustmentMethod     = 0;
	$txn->OriginationPCode     = 1248900;
	$txn->OriginationNpaNxx    = 0;
	$txn->TerminationPCode     = 1248900;
	$txn->TerminationNpaNxx    = 0;
	$txn->BillToPCode          = 1248900;
	$txn->BillToNpaNxx         = 0;
	$txn->Lines                = 0;
	$txn->Locations            = 0;
	$txn->Minutes              = 11;
	$txn->Debit                = 0;
	$txn->DiscountType         = 0;
	$txn->FacilitiesBased      = 0;
	$txn->Franchise            = 0;
	$txn->Lifeline             = 0;
	$txn->Regulated            = 0;
	$txn->ExemptionType        = 0;
	$txn->InvoiceNumber        = 0;
	$txn->Optional             = 0;
	$txn->Optional4            = 0;
	$txn->Optional5            = 0;
	$txn->Optional6            = 0;
	$txn->Optional7            = 0;
	$txn->Optional8            = 0;
	$txn->Optional9            = 0;
	$txn->Optional10           = 0;
	$txn->ServiceLevelNumber   = 0;

   $result = $ez->CalcTaxesWithPCode(array('aTransaction' => $txn));
   print var_dump($result);

   print "CalcTaxesWithZipAddress()...\n";
        $txn->BillToAddress = new ZipAddress;
        $txn->BillToAddress->CountryISO = "USA";
        $txn->BillToAddress->County = "Johnson";
        $txn->BillToAddress->Locality = "Overland Park";
        $txn->BillToAddress->State = "KS";
        $txn->BillToAddress->ZipCode = "66212";

        $txn->OriginationAddress = new ZipAddress;
        $txn->OriginationAddress->CountryISO = "USA";
        $txn->OriginationAddress->County = "Douglas";
        $txn->OriginationAddress->Locality = "Highlands Ranch";
        $txn->OriginationAddress->State = "CO";
        $txn->OriginationAddress->ZipCode = "80126";

        $txn->TerminationAddress = new ZipAddress;
        $txn->TerminationAddress->CountryISO = "USA";
        $txn->TerminationAddress->County = "Johnson";
        $txn->TerminationAddress->Locality = "Overland Park";
        $txn->TerminationAddress->State = "KS";
        $txn->TerminationAddress->ZipCode = "66212";

   $result = $ez->CalcTaxesWithZipAddress(array('aTransaction' => $txn));
   print var_dump($result);
}
catch (SoapFault $fault) {
	// Display the error before exiting.
	// The __get* functions only work when the trace option is true in the soap_opts array
   print $fault->__toString();
   if ($soap_opts['trace']) {
      print $ez->__getLastRequestHeaders();
      print $ez->__getLastRequest();
      print $ez->__getLastResponseHeaders();
      print $ez->__getLastResponse();
   }
}
?>
