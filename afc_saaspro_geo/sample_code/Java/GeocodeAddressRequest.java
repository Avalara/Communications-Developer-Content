/**
 * GeocodeAddressRequest.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.2RC2 Nov 16, 2004 (12:19:44 EST) WSDL2Java emitter.
 */

package com.billsoft.xml.ezgeo;

public class GeocodeAddressRequest  implements java.io.Serializable {
    private java.lang.String addressLine1;
    private java.lang.String addressLine2;
    private java.lang.String streetAddress;
    private java.lang.String city;
    private java.lang.String state;
    private java.lang.String postalCode;
    private int grammarRule;
    private double minimumScore;
    private int maxCount;
    private int options;

    public GeocodeAddressRequest() {
    }

    public GeocodeAddressRequest(
           java.lang.String addressLine1,
           java.lang.String addressLine2,
           java.lang.String streetAddress,
           java.lang.String city,
           java.lang.String state,
           java.lang.String postalCode,
           int grammarRule,
           double minimumScore,
           int maxCount,
           int options) {
           this.addressLine1 = addressLine1;
           this.addressLine2 = addressLine2;
           this.streetAddress = streetAddress;
           this.city = city;
           this.state = state;
           this.postalCode = postalCode;
           this.grammarRule = grammarRule;
           this.minimumScore = minimumScore;
           this.maxCount = maxCount;
           this.options = options;
    }


    /**
     * Gets the addressLine1 value for this GeocodeAddressRequest.
     * 
     * @return addressLine1
     */
    public java.lang.String getAddressLine1() {
        return addressLine1;
    }


    /**
     * Sets the addressLine1 value for this GeocodeAddressRequest.
     * 
     * @param addressLine1
     */
    public void setAddressLine1(java.lang.String addressLine1) {
        this.addressLine1 = addressLine1;
    }


    /**
     * Gets the addressLine2 value for this GeocodeAddressRequest.
     * 
     * @return addressLine2
     */
    public java.lang.String getAddressLine2() {
        return addressLine2;
    }


    /**
     * Sets the addressLine2 value for this GeocodeAddressRequest.
     * 
     * @param addressLine2
     */
    public void setAddressLine2(java.lang.String addressLine2) {
        this.addressLine2 = addressLine2;
    }


    /**
     * Gets the streetAddress value for this GeocodeAddressRequest.
     * 
     * @return streetAddress
     */
    public java.lang.String getStreetAddress() {
        return streetAddress;
    }


    /**
     * Sets the streetAddress value for this GeocodeAddressRequest.
     * 
     * @param streetAddress
     */
    public void setStreetAddress(java.lang.String streetAddress) {
        this.streetAddress = streetAddress;
    }


    /**
     * Gets the city value for this GeocodeAddressRequest.
     * 
     * @return city
     */
    public java.lang.String getCity() {
        return city;
    }


    /**
     * Sets the city value for this GeocodeAddressRequest.
     * 
     * @param city
     */
    public void setCity(java.lang.String city) {
        this.city = city;
    }


    /**
     * Gets the state value for this GeocodeAddressRequest.
     * 
     * @return state
     */
    public java.lang.String getState() {
        return state;
    }


    /**
     * Sets the state value for this GeocodeAddressRequest.
     * 
     * @param state
     */
    public void setState(java.lang.String state) {
        this.state = state;
    }


    /**
     * Gets the postalCode value for this GeocodeAddressRequest.
     * 
     * @return postalCode
     */
    public java.lang.String getPostalCode() {
        return postalCode;
    }


    /**
     * Sets the postalCode value for this GeocodeAddressRequest.
     * 
     * @param postalCode
     */
    public void setPostalCode(java.lang.String postalCode) {
        this.postalCode = postalCode;
    }


    /**
     * Gets the grammarRule value for this GeocodeAddressRequest.
     * 
     * @return grammarRule
     */
    public int getGrammarRule() {
        return grammarRule;
    }


    /**
     * Sets the grammarRule value for this GeocodeAddressRequest.
     * 
     * @param grammarRule
     */
    public void setGrammarRule(int grammarRule) {
        this.grammarRule = grammarRule;
    }


    /**
     * Gets the minimumScore value for this GeocodeAddressRequest.
     * 
     * @return minimumScore
     */
    public double getMinimumScore() {
        return minimumScore;
    }


    /**
     * Sets the minimumScore value for this GeocodeAddressRequest.
     * 
     * @param minimumScore
     */
    public void setMinimumScore(double minimumScore) {
        this.minimumScore = minimumScore;
    }


    /**
     * Gets the maxCount value for this GeocodeAddressRequest.
     * 
     * @return maxCount
     */
    public int getMaxCount() {
        return maxCount;
    }


    /**
     * Sets the maxCount value for this GeocodeAddressRequest.
     * 
     * @param maxCount
     */
    public void setMaxCount(int maxCount) {
        this.maxCount = maxCount;
    }


    /**
     * Gets the options value for this GeocodeAddressRequest.
     * 
     * @return options
     */
    public int getOptions() {
        return options;
    }


    /**
     * Sets the options value for this GeocodeAddressRequest.
     * 
     * @param options
     */
    public void setOptions(int options) {
        this.options = options;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GeocodeAddressRequest)) return false;
        GeocodeAddressRequest other = (GeocodeAddressRequest) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.addressLine1==null && other.getAddressLine1()==null) || 
             (this.addressLine1!=null &&
              this.addressLine1.equals(other.getAddressLine1()))) &&
            ((this.addressLine2==null && other.getAddressLine2()==null) || 
             (this.addressLine2!=null &&
              this.addressLine2.equals(other.getAddressLine2()))) &&
            ((this.streetAddress==null && other.getStreetAddress()==null) || 
             (this.streetAddress!=null &&
              this.streetAddress.equals(other.getStreetAddress()))) &&
            ((this.city==null && other.getCity()==null) || 
             (this.city!=null &&
              this.city.equals(other.getCity()))) &&
            ((this.state==null && other.getState()==null) || 
             (this.state!=null &&
              this.state.equals(other.getState()))) &&
            ((this.postalCode==null && other.getPostalCode()==null) || 
             (this.postalCode!=null &&
              this.postalCode.equals(other.getPostalCode()))) &&
            this.grammarRule == other.getGrammarRule() &&
            this.minimumScore == other.getMinimumScore() &&
            this.maxCount == other.getMaxCount() &&
            this.options == other.getOptions();
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
        if (getAddressLine1() != null) {
            _hashCode += getAddressLine1().hashCode();
        }
        if (getAddressLine2() != null) {
            _hashCode += getAddressLine2().hashCode();
        }
        if (getStreetAddress() != null) {
            _hashCode += getStreetAddress().hashCode();
        }
        if (getCity() != null) {
            _hashCode += getCity().hashCode();
        }
        if (getState() != null) {
            _hashCode += getState().hashCode();
        }
        if (getPostalCode() != null) {
            _hashCode += getPostalCode().hashCode();
        }
        _hashCode += getGrammarRule();
        _hashCode += new Double(getMinimumScore()).hashCode();
        _hashCode += getMaxCount();
        _hashCode += getOptions();
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(GeocodeAddressRequest.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "GeocodeAddressRequest"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("addressLine1");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "AddressLine1"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("addressLine2");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "AddressLine2"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("streetAddress");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "StreetAddress"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("city");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "City"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("state");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "State"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("postalCode");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "PostalCode"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("grammarRule");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "GrammarRule"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("minimumScore");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "MinimumScore"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "double"));
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("maxCount");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "MaxCount"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("options");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "Options"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
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
