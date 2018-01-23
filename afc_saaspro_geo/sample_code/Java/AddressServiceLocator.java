/**
 * AddressServiceLocator.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.2RC2 Nov 16, 2004 (12:19:44 EST) WSDL2Java emitter.
 */

package com.billsoft.xml.ezgeo;

public class AddressServiceLocator extends org.apache.axis.client.Service implements com.billsoft.xml.ezgeo.AddressService {

    public AddressServiceLocator() {
    }


    public AddressServiceLocator(org.apache.axis.EngineConfiguration config) {
        super(config);
    }

    // Use to get a proxy class for AddressServiceSoap
    private java.lang.String AddressServiceSoap_address = "https://ws.billsoft.com/EZGeo/AddressService.asmx";

    public java.lang.String getAddressServiceSoapAddress() {
        return AddressServiceSoap_address;
    }

    // The WSDD service name defaults to the port name.
    private java.lang.String AddressServiceSoapWSDDServiceName = "AddressServiceSoap";

    public java.lang.String getAddressServiceSoapWSDDServiceName() {
        return AddressServiceSoapWSDDServiceName;
    }

    public void setAddressServiceSoapWSDDServiceName(java.lang.String name) {
        AddressServiceSoapWSDDServiceName = name;
    }

    public com.billsoft.xml.ezgeo.AddressServiceSoap getAddressServiceSoap() throws javax.xml.rpc.ServiceException {
       java.net.URL endpoint;
        try {
            endpoint = new java.net.URL(AddressServiceSoap_address);
        }
        catch (java.net.MalformedURLException e) {
            throw new javax.xml.rpc.ServiceException(e);
        }
        return getAddressServiceSoap(endpoint);
    }

    public com.billsoft.xml.ezgeo.AddressServiceSoap getAddressServiceSoap(java.net.URL portAddress) throws javax.xml.rpc.ServiceException {
        try {
            com.billsoft.xml.ezgeo.AddressServiceSoapStub _stub = new com.billsoft.xml.ezgeo.AddressServiceSoapStub(portAddress, this);
            _stub.setPortName(getAddressServiceSoapWSDDServiceName());
            return _stub;
        }
        catch (org.apache.axis.AxisFault e) {
            return null;
        }
    }

    public void setAddressServiceSoapEndpointAddress(java.lang.String address) {
        AddressServiceSoap_address = address;
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        try {
            if (com.billsoft.xml.ezgeo.AddressServiceSoap.class.isAssignableFrom(serviceEndpointInterface)) {
                com.billsoft.xml.ezgeo.AddressServiceSoapStub _stub = new com.billsoft.xml.ezgeo.AddressServiceSoapStub(new java.net.URL(AddressServiceSoap_address), this);
                _stub.setPortName(getAddressServiceSoapWSDDServiceName());
                return _stub;
            }
        }
        catch (java.lang.Throwable t) {
            throw new javax.xml.rpc.ServiceException(t);
        }
        throw new javax.xml.rpc.ServiceException("There is no stub implementation for the interface:  " + (serviceEndpointInterface == null ? "null" : serviceEndpointInterface.getName()));
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(javax.xml.namespace.QName portName, Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        if (portName == null) {
            return getPort(serviceEndpointInterface);
        }
        java.lang.String inputPortName = portName.getLocalPart();
        if ("AddressServiceSoap".equals(inputPortName)) {
            return getAddressServiceSoap();
        }
        else  {
            java.rmi.Remote _stub = getPort(serviceEndpointInterface);
            ((org.apache.axis.client.Stub) _stub).setPortName(portName);
            return _stub;
        }
    }

    public javax.xml.namespace.QName getServiceName() {
        return new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "AddressService");
    }

    private java.util.HashSet ports = null;

    public java.util.Iterator getPorts() {
        if (ports == null) {
            ports = new java.util.HashSet();
            ports.add(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "AddressServiceSoap"));
        }
        return ports.iterator();
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(java.lang.String portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        if ("AddressServiceSoap".equals(portName)) {
            setAddressServiceSoapEndpointAddress(address);
        }
        else { // Unknown Port Name
            throw new javax.xml.rpc.ServiceException(" Cannot set Endpoint Address for Unknown Port" + portName);
        }
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(javax.xml.namespace.QName portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        setEndpointAddress(portName.getLocalPart(), address);
    }

}
