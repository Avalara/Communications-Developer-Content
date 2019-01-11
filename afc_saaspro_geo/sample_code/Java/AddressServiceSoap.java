/**
 * AddressServiceSoap.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.2RC2 Nov 16, 2004 (12:19:44 EST) WSDL2Java emitter.
 */

package com.billsoft.xml.ezgeo;

public interface AddressServiceSoap extends java.rmi.Remote {
    public java.util.Calendar getServerTime() throws java.rmi.RemoteException;
    public com.billsoft.xml.ezgeo.AddressLocation geocodeAddress(com.billsoft.xml.ezgeo.GeocodeAddressRequest addressInfo) throws java.rmi.RemoteException;
    public com.billsoft.xml.ezgeo.ArrayOfAddressLocation geocodeAllMatches(com.billsoft.xml.ezgeo.GeocodeAddressRequest addressInfo) throws java.rmi.RemoteException;
}
