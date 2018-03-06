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

import java.util.Set;
import java.util.TreeSet;
import javax.xml.namespace.QName;
import javax.xml.soap.SOAPElement;
import javax.xml.soap.SOAPEnvelope;
import javax.xml.soap.SOAPFactory;
import javax.xml.soap.SOAPHeader;
import javax.xml.ws.handler.MessageContext;
import javax.xml.ws.handler.soap.SOAPHandler;
import javax.xml.ws.handler.soap.SOAPMessageContext;

/*
 * This class is used to add the user's credentials in custom SOAP headers for every 
 * request made to the EZTax Web Service.
 */
class EZTaxSOAPHandler implements SOAPHandler<SOAPMessageContext> {
	
	private String userName = "";
	private String password = "";
	
	/*
	 * Constructor.
	 */
	public EZTaxSOAPHandler(String userName, String password) {
		this.userName = userName;
		this.password = password;
	}
	
	/*
	 * 
	 * @see javax.xml.ws.handler.soap.SOAPHandler#getHeaders()
	 */
	public Set<QName> getHeaders() {
		return new TreeSet<QName>();
	}
	
	/*
	 * Adds the custom SOAP headers to the message
	 * @see javax.xml.ws.handler.Handler#handleMessage(javax.xml.ws.handler.MessageContext)
	 */
	public boolean handleMessage(SOAPMessageContext context) {
		Boolean outboundProperty = (Boolean) context.get(MessageContext.MESSAGE_OUTBOUND_PROPERTY);
		
		if (outboundProperty.booleanValue()) {
			try {
				SOAPEnvelope envelope = context.getMessage().getSOAPPart().getEnvelope();
				SOAPFactory factory = SOAPFactory.newInstance();
				String prefix = "ez";
				String uri = "http://eztaxasp.billsoft.com/eztaxwebservice";
				
				SOAPElement userElem = factory.createElement("UserName", prefix, uri);
				userElem.addTextNode(userName);
				
				SOAPElement passElem = factory.createElement("Password", prefix, uri);
				passElem.addTextNode(password);
				
				if (envelope.getHeader() != null) {
				    envelope.getHeader().detachNode();
				}
				  
				SOAPHeader header = envelope.addHeader();
				header.addChildElement(userElem);
				header.addChildElement(passElem);
			} 
			catch (Exception e) {
				System.out.println("Exception in handler: " + e);
			}
		}
		
		return true;
	}
	
	/*
	 * 
	 * @see javax.xml.ws.handler.Handler#handleFault(javax.xml.ws.handler.MessageContext)
	 */
	public boolean handleFault(SOAPMessageContext context) {
		throw new UnsupportedOperationException("Unsupported operation.");
	}
	
	/*
	 * 
	 * @see javax.xml.ws.handler.Handler#close(javax.xml.ws.handler.MessageContext)
	 */
	public void close(MessageContext context) {
	}
}

