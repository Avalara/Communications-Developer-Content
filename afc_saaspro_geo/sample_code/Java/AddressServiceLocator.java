/**
 * AddressServiceLocator.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.2RC2 Nov 16, 2004 (12:19:44 EST) WSDL2Java emitter.
 */

package com.billsoft.xml.ezgeo;

import java.io.BufferedReader;
import java.io.DataOutputStream;
import java.io.InputStreamReader;
import java.io.StringReader;
import java.io.StringWriter;
import java.net.HttpURLConnection;
import java.net.URL;

import javax.xml.transform.OutputKeys;
import javax.xml.transform.Source;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.stream.StreamResult;
import javax.xml.transform.stream.StreamSource;

public class AddressServiceLocator {
	public static void main(String[] args) {
		try {
			String url = "https://ezgeoasp.billsoft.com/LocatorService.svc";
			URL obj = new URL(url);
			HttpURLConnection con = (HttpURLConnection) obj.openConnection();			
			con.setRequestMethod("POST");
			 con.setRequestProperty("Content-Type","text/xml; charset=utf-8");
			 con.setRequestProperty("SOAPAction", "http://tempuri.org/ILocatorService/GeocodeAddress");
			 String xml = "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:u=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd\">\r\n" + 
			 		"	<s:Header>\r\n" + 
			 		"		<o:Security s:mustUnderstand=\"1\" xmlns:o=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd\">\r\n" + 
			 		"			<o:UsernameToken>\r\n" + 
			 		"				<o:Username>***********</o:Username>\r\n" + 
			 		"				<o:Password>***********</o:Password>\r\n" + 
			 		"			</o:UsernameToken>\r\n" + 
			 		"		</o:Security>\r\n" + 
			 		"	</s:Header>\r\n" + 
			 		"	<s:Body>\r\n" + 
			 		"		<GeocodeAddress xmlns=\"http://tempuri.org/\">\r\n" + 
			 		"			<inputAddress xmlns:a=\"http://schemas.datacontract.org/2004/07/EZGeoSaaS\" xmlns:i=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n" + 
			 		"				<a:CassCertify>true</a:CassCertify>\r\n" + 
			 		"				<a:City>Durham</a:City>\r\n" + 
			 		"				<a:CityStateZip/>\r\n" + 
			 		"				<a:MinimumScore>0.7</a:MinimumScore>\r\n" + 
			 		"				<a:Offset>3</a:Offset>\r\n" + 
			 		"				<a:Options>312</a:Options>\r\n" + 
			 		"				<a:SecondaryUnit></a:SecondaryUnit>\r\n" + 
			 		"				<a:State>NC</a:State>\r\n" + 
			 		"				<a:StreetAddress>512 S Mangum St</a:StreetAddress>\r\n" + 
			 		"				<a:Zip>27701</a:Zip>\r\n" + 
			 		"			</inputAddress>\r\n" + 
			 		"		</GeocodeAddress>\r\n" + 
			 		"	</s:Body>\r\n" + 
			 		"</s:Envelope>";
			 con.setDoOutput(true);
			 DataOutputStream wr = new DataOutputStream(con.getOutputStream());
			 wr.writeBytes(xml);
			 wr.flush();
			 wr.close();
			 BufferedReader in = new BufferedReader(new InputStreamReader(
			 con.getInputStream()));
			 String inputLine;
			 StringBuffer response = new StringBuffer();
			 while ((inputLine = in.readLine()) != null) {
			 response.append(inputLine);
			 }
			 in.close();
			 
		    Source xmlInput = new StreamSource(new StringReader(response.toString()));
	        StringWriter stringWriter = new StringWriter();
	        StreamResult xmlOutput = new StreamResult(stringWriter);
	        TransformerFactory transformerFactory = TransformerFactory.newInstance();
	        transformerFactory.setAttribute("indent-number", 2);
	        Transformer transformer = transformerFactory.newTransformer(); 
	        transformer.setOutputProperty(OutputKeys.INDENT, "yes");
	        transformer.transform(xmlInput, xmlOutput);
		      
			System.out.println(xmlOutput.getWriter().toString());	
			 
		} catch (Exception e) {
			System.out.println(e);
		}
	}
	
}
