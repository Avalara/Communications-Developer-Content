 /*
 * BillsoftAxisWSClient.java
 * 
 * Copyright 2008-2009 - BillSoft Inc.
 * 
 * 
 * This program is a sample of how to call the EZGeo Online web service using Java.  This sample
 * was implemented using Apache Axis (http://ws.apache.org/axis/).
 * 
 * This sample requires the following jar files from the Apache Axis project
 * to be included in the CLASSPATH.
 * 
 *   /axis/lib/axis.jar
 *   /axis/lib/commons-discovery.jar
 *   /axis/lib/commons-logging.jar
 *   /axis/lib/jaxrpc.jar
 *   /axis/lib/log4j-1.2.8.jar
 *   /axis/lib/saaj.jar
 *   /axis/lib/axis-ant.jar
 *   /axis/lib/wsdl4j.jar

 */

import org.apache.axis.client.*;
import org.apache.axis.message.*;
import javax.xml.namespace.*;

/**
 * @author BillSoft 
 **/
public class BillsoftAxisWSClient {

	public static void main(String[] args) 
	{
		try
		{
			System.out.println("EZGeo Online Java Sample Program");
			System.out.println("Geocode best match using street address, city, state and zip");

			// This block creates the address request object and fills in the
			// address data for the address you are looking up.  You also
			// specify the grammar rule and options
			System.out.println("Initializing GeocodeAddressRequest Object");
			GeocodeAddressRequest addressInfo = new GeocodeAddressRequest();
			addressInfo.setStreetAddress("10100 West 87th St");
			addressInfo.setCity("Overland Park");
			addressInfo.setState("KS");
			addressInfo.setPostalCode("66212");
			addressInfo.setGrammarRule(3);
			addressInfo.setOptions(8);
			System.out.println("Testing .....");

			// This block creates an instance of the proxy object for 
			// the web service.  The proxy object is what communicates
			// with the web service.
			System.out.println("Initializing Proxy Object");
			AddressServiceLocator service = new AddressServiceLocator();
			AddressServiceSoap proxy = service.getAddressServiceSoap();
			
            // Create custom SOAP header elements to pass the userid and password and
			// specify the actual values that will be used to authenticate the method
			// call to the web service.
            QName authQName = new QName("http://xml.billsoft.com/auth", "authentication");
            QName userQName   = new QName("http://xml.billsoft.com/auth", "userid");
            QName passwordQName    = new QName("http://xml.billsoft.com/auth", "password");
            SOAPHeaderElement authElement = new SOAPHeaderElement(authQName);
            SOAPHeaderElement userElement = new SOAPHeaderElement(userQName);
			// TODO: enter your username
			userElement.setValue("username");
            SOAPHeaderElement passwordElement = new SOAPHeaderElement(passwordQName);
            // TODO: enter your password
            passwordElement.setValue("password");
            authElement.addChildElement(userElement);
            authElement.addChildElement(passwordElement);
            // Cast the AddressServiceSoap object to a Stub so we
            // can call the setHeader method to add the custom authentication
            // elements.  
            Stub proxyStub = (Stub) proxy;
            proxyStub.setHeader(authElement);

            // Call the web service method and display the results 
			System.out.println("Call the Web Service Method...");
			AddressLocation location = proxy.geocodeAddress(addressInfo);

			System.out.println("");
			System.out.println("Display Results");
			System.out.println("Address:  " + location.getStreetNumber() + " " + location.getStreetName());
			System.out.println("City:  " + location.getCity());
			System.out.println("Zip:  " + location.getPostalCode());
			System.out.println("County:  " + location.getCounty());
			System.out.println("Score:  " + location.getScore());
			System.out.println("Zip+4:  " + location.getPostalCodeExtenstion());
			System.out.println("BillSoft PCODE:  " + location.getPCode());
			System.out.println("Incorportated:  " + !location.isUnincorporated());
         CassAddress cassAddress = location.getCassAddress(); 
         if (cassAddress == null){
            System.out.println("Address not CASS certified.");
         }
         else{
            System.out.println("DPV:  " + cassAddress.getDeliveryPointValidation());
            System.out.println("Barcode:  " + cassAddress.getUSPSBarCode());
         }
		 System.out.println("Processing complete.");
		}
		catch (Exception ex){
			System.out.println("Exception.");
			System.out.println(ex.getMessage());
			
		}
	}
}
