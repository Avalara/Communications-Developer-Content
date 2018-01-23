/**
 * ArrayOfAddressLocation.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.2RC2 Nov 16, 2004 (12:19:44 EST) WSDL2Java emitter.
 */

package com.billsoft.xml.ezgeo;

public class ArrayOfAddressLocation  implements java.io.Serializable {
    private com.billsoft.xml.ezgeo.AddressLocation[] addressLocation;

    public ArrayOfAddressLocation() {
    }

    public ArrayOfAddressLocation(
           com.billsoft.xml.ezgeo.AddressLocation[] addressLocation) {
           this.addressLocation = addressLocation;
    }


    /**
     * Gets the addressLocation value for this ArrayOfAddressLocation.
     * 
     * @return addressLocation
     */
    public com.billsoft.xml.ezgeo.AddressLocation[] getAddressLocation() {
        return addressLocation;
    }


    /**
     * Sets the addressLocation value for this ArrayOfAddressLocation.
     * 
     * @param addressLocation
     */
    public void setAddressLocation(com.billsoft.xml.ezgeo.AddressLocation[] addressLocation) {
        this.addressLocation = addressLocation;
    }

    public com.billsoft.xml.ezgeo.AddressLocation getAddressLocation(int i) {
        return this.addressLocation[i];
    }

    public void setAddressLocation(int i, com.billsoft.xml.ezgeo.AddressLocation _value) {
        this.addressLocation[i] = _value;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof ArrayOfAddressLocation)) return false;
        ArrayOfAddressLocation other = (ArrayOfAddressLocation) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.addressLocation==null && other.getAddressLocation()==null) || 
             (this.addressLocation!=null &&
              java.util.Arrays.equals(this.addressLocation, other.getAddressLocation())));
        __equalsCalc = null;
        return _equals;
    }

    private boolean __hashCodeCalc = false;
    public synchronized int hashCode() {
        if (__hashCodeCalc) {
            return 0;
        }
        __hashCodeCalc = true;
        int _hashCode = 1;
        if (getAddressLocation() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getAddressLocation());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getAddressLocation(), i);
                if (obj != null &&
                    !obj.getClass().isArray()) {
                    _hashCode += obj.hashCode();
                }
            }
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(ArrayOfAddressLocation.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "ArrayOfAddressLocation"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("addressLocation");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "AddressLocation"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "AddressLocation"));
        elemField.setMinOccurs(0);
        typeDesc.addFieldDesc(elemField);
    }

    /**
     * Return type metadata object
     */
    public static org.apache.axis.description.TypeDesc getTypeDesc() {
        return typeDesc;
    }

    /**
     * Get Custom Serializer
     */
    public static org.apache.axis.encoding.Serializer getSerializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanSerializer(
            _javaType, _xmlType, typeDesc);
    }

    /**
     * Get Custom Deserializer
     */
    public static org.apache.axis.encoding.Deserializer getDeserializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanDeserializer(
            _javaType, _xmlType, typeDesc);
    }

}
