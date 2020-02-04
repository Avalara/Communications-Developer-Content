
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

public class GeocodeLatLong {
	public static void main(String[] args) {
		try {
			String url = "https://ezgeoasp.billsoft.com/LocatorService.svc";
			URL obj = new URL(url);
			HttpURLConnection con = (HttpURLConnection) obj.openConnection();			
			con.setRequestMethod("POST");
			con.setRequestProperty("Content-Type","text/xml; charset=utf-8");
			con.setRequestProperty("SOAPAction", "http://tempuri.org/ILocatorService/GeocodeLatLong");
			String xml = "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:tem=\"http://tempuri.org/\">\r\n" + 
					"   <soapenv:Header>\r\n" + 
					"		<o:Security soapenv:mustUnderstand=\"1\" xmlns:o=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd\">\r\n" + 
					"			<o:UsernameToken>\r\n" + 
					"				<o:Username>********</o:Username>\r\n" + 
					"				<o:Password>********</o:Password>\r\n" + 
					"			</o:UsernameToken>\r\n" + 
					"		</o:Security>\r\n" + 
					"	</soapenv:Header>\r\n" + 
					"   <soapenv:Body>\r\n" + 
					"      <tem:GeocodeLatLong>\r\n" + 
					"         <tem:latitude>35.991572</tem:latitude>\r\n" + 
					"         <tem:longitude>-78.902774</tem:longitude>\r\n" + 
					"      </tem:GeocodeLatLong>\r\n" + 
					"   </soapenv:Body>\r\n" + 
					"</soapenv:Envelope>";
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

