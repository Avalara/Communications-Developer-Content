/**
 * AddressLocation.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.2RC2 Nov 16, 2004 (12:19:44 EST) WSDL2Java emitter.
 */

package com.billsoft.xml.ezgeo;

public class AddressLocation  implements java.io.Serializable {
    private java.lang.String networkID;
    private java.lang.String streetNumber;
    private java.lang.String streetName;
    private java.lang.String unit;
    private java.lang.String city;
    private java.lang.String county;
    private java.lang.String country;
    private java.lang.String state;
    private java.lang.String postalCode;
    private java.lang.String postalCodeExtenstion;
    private java.lang.String timeZone;
    private double score;
    private double latitude;
    private double longitude;
    private int censusTract;
    private int censusBlockGroup;
    private int PCode;
    private long FIPSCode;
    private boolean unincorporated;

    public AddressLocation() {
    }

    public AddressLocation(
           java.lang.String networkID,
           java.lang.String streetNumber,
           java.lang.String streetName,
           java.lang.String unit,
           java.lang.String city,
           java.lang.String county,
           java.lang.String country,
           java.lang.String state,
           java.lang.String postalCode,
           java.lang.String postalCodeExtenstion,
           java.lang.String timeZone,
           double score,
           double latitude,
           double longitude,
           int censusTract,
           int censusBlockGroup,
           int PCode,
           long FIPSCode,
           boolean unincorporated) {
           this.networkID = networkID;
           this.streetNumber = streetNumber;
           this.streetName = streetName;
           this.unit = unit;
           this.city = city;
           this.county = county;
           this.country = country;
           this.state = state;
           this.postalCode = postalCode;
           this.postalCodeExtenstion = postalCodeExtenstion;
           this.timeZone = timeZone;
           this.score = score;
           this.latitude = latitude;
           this.longitude = longitude;
           this.censusTract = censusTract;
           this.censusBlockGroup = censusBlockGroup;
           this.PCode = PCode;
           this.FIPSCode = FIPSCode;
           this.unincorporated = unincorporated;
    }


    /**
     * Gets the networkID value for this AddressLocation.
     * 
     * @return networkID
     */
    public java.lang.String getNetworkID() {
        return networkID;
    }


    /**
     * Sets the networkID value for this AddressLocation.
     * 
     * @param networkID
     */
    public void setNetworkID(java.lang.String networkID) {
        this.networkID = networkID;
    }


    /**
     * Gets the streetNumber value for this AddressLocation.
     * 
     * @return streetNumber
     */
    public java.lang.String getStreetNumber() {
        return streetNumber;
    }


    /**
     * Sets the streetNumber value for this AddressLocation.
     * 
     * @param streetNumber
     */
    public void setStreetNumber(java.lang.String streetNumber) {
        this.streetNumber = streetNumber;
    }


    /**
     * Gets the streetName value for this AddressLocation.
     * 
     * @return streetName
     */
    public java.lang.String getStreetName() {
        return streetName;
    }


    /**
     * Sets the streetName value for this AddressLocation.
     * 
     * @param streetName
     */
    public void setStreetName(java.lang.String streetName) {
        this.streetName = streetName;
    }


    /**
     * Gets the unit value for this AddressLocation.
     * 
     * @return unit
     */
    public java.lang.String getUnit() {
        return unit;
    }


    /**
     * Sets the unit value for this AddressLocation.
     * 
     * @param unit
     */
    public void setUnit(java.lang.String unit) {
        this.unit = unit;
    }


    /**
     * Gets the city value for this AddressLocation.
     * 
     * @return city
     */
    public java.lang.String getCity() {
        return city;
    }


    /**
     * Sets the city value for this AddressLocation.
     * 
     * @param city
     */
    public void setCity(java.lang.String city) {
        this.city = city;
    }


    /**
     * Gets the county value for this AddressLocation.
     * 
     * @return county
     */
    public java.lang.String getCounty() {
        return county;
    }


    /**
     * Sets the county value for this AddressLocation.
     * 
     * @param county
     */
    public void setCounty(java.lang.String county) {
        this.county = county;
    }


    /**
     * Gets the country value for this AddressLocation.
     * 
     * @return country
     */
    public java.lang.String getCountry() {
        return country;
    }


    /**
     * Sets the country value for this AddressLocation.
     * 
     * @param country
     */
    public void setCountry(java.lang.String country) {
        this.country = country;
    }


    /**
     * Gets the state value for this AddressLocation.
     * 
     * @return state
     */
    public java.lang.String getState() {
        return state;
    }


    /**
     * Sets the state value for this AddressLocation.
     * 
     * @param state
     */
    public void setState(java.lang.String state) {
        this.state = state;
    }


    /**
     * Gets the postalCode value for this AddressLocation.
     * 
     * @return postalCode
     */
    public java.lang.String getPostalCode() {
        return postalCode;
    }


    /**
     * Sets the postalCode value for this AddressLocation.
     * 
     * @param postalCode
     */
    public void setPostalCode(java.lang.String postalCode) {
        this.postalCode = postalCode;
    }


    /**
     * Gets the postalCodeExtenstion value for this AddressLocation.
     * 
     * @return postalCodeExtenstion
     */
    public java.lang.String getPostalCodeExtenstion() {
        return postalCodeExtenstion;
    }


    /**
     * Sets the postalCodeExtenstion value for this AddressLocation.
     * 
     * @param postalCodeExtenstion
     */
    public void setPostalCodeExtenstion(java.lang.String postalCodeExtenstion) {
        this.postalCodeExtenstion = postalCodeExtenstion;
    }


    /**
     * Gets the timeZone value for this AddressLocation.
     * 
     * @return timeZone
     */
    public java.lang.String getTimeZone() {
        return timeZone;
    }


    /**
     * Sets the timeZone value for this AddressLocation.
     * 
     * @param timeZone
     */
    public void setTimeZone(java.lang.String timeZone) {
        this.timeZone = timeZone;
    }


    /**
     * Gets the score value for this AddressLocation.
     * 
     * @return score
     */
    public double getScore() {
        return score;
    }


    /**
     * Sets the score value for this AddressLocation.
     * 
     * @param score
     */
    public void setScore(double score) {
        this.score = score;
    }


    /**
     * Gets the latitude value for this AddressLocation.
     * 
     * @return latitude
     */
    public double getLatitude() {
        return latitude;
    }


    /**
     * Sets the latitude value for this AddressLocation.
     * 
     * @param latitude
     */
    public void setLatitude(double latitude) {
        this.latitude = latitude;
    }


    /**
     * Gets the longitude value for this AddressLocation.
     * 
     * @return longitude
     */
    public double getLongitude() {
        return longitude;
    }


    /**
     * Sets the longitude value for this AddressLocation.
     * 
     * @param longitude
     */
    public void setLongitude(double longitude) {
        this.longitude = longitude;
    }


    /**
     * Gets the censusTract value for this AddressLocation.
     * 
     * @return censusTract
     */
    public int getCensusTract() {
        return censusTract;
    }


    /**
     * Sets the censusTract value for this AddressLocation.
     * 
     * @param censusTract
     */
    public void setCensusTract(int censusTract) {
        this.censusTract = censusTract;
    }


    /**
     * Gets the censusBlockGroup value for this AddressLocation.
     * 
     * @return censusBlockGroup
     */
    public int getCensusBlockGroup() {
        return censusBlockGroup;
    }


    /**
     * Sets the censusBlockGroup value for this AddressLocation.
     * 
     * @param censusBlockGroup
     */
    public void setCensusBlockGroup(int censusBlockGroup) {
        this.censusBlockGroup = censusBlockGroup;
    }


    /**
     * Gets the PCode value for this AddressLocation.
     * 
     * @return PCode
     */
    public int getPCode() {
        return PCode;
    }


    /**
     * Sets the PCode value for this AddressLocation.
     * 
     * @param PCode
     */
    public void setPCode(int PCode) {
        this.PCode = PCode;
    }


    /**
     * Gets the FIPSCode value for this AddressLocation.
     * 
     * @return FIPSCode
     */
    public long getFIPSCode() {
        return FIPSCode;
    }


    /**
     * Sets the FIPSCode value for this AddressLocation.
     * 
     * @param FIPSCode
     */
    public void setFIPSCode(long FIPSCode) {
        this.FIPSCode = FIPSCode;
    }


    /**
     * Gets the unincorporated value for this AddressLocation.
     * 
     * @return unincorporated
     */
    public boolean isUnincorporated() {
        return unincorporated;
    }


    /**
     * Sets the unincorporated value for this AddressLocation.
     * 
     * @param unincorporated
     */
    public void setUnincorporated(boolean unincorporated) {
        this.unincorporated = unincorporated;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof AddressLocation)) return false;
        AddressLocation other = (AddressLocation) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.networkID==null && other.getNetworkID()==null) || 
             (this.networkID!=null &&
              this.networkID.equals(other.getNetworkID()))) &&
            ((this.streetNumber==null && other.getStreetNumber()==null) || 
             (this.streetNumber!=null &&
              this.streetNumber.equals(other.getStreetNumber()))) &&
            ((this.streetName==null && other.getStreetName()==null) || 
             (this.streetName!=null &&
              this.streetName.equals(other.getStreetName()))) &&
            ((this.unit==null && other.getUnit()==null) || 
             (this.unit!=null &&
              this.unit.equals(other.getUnit()))) &&
            ((this.city==null && other.getCity()==null) || 
             (this.city!=null &&
              this.city.equals(other.getCity()))) &&
            ((this.county==null && other.getCounty()==null) || 
             (this.county!=null &&
              this.county.equals(other.getCounty()))) &&
            ((this.country==null && other.getCountry()==null) || 
             (this.country!=null &&
              this.country.equals(other.getCountry()))) &&
            ((this.state==null && other.getState()==null) || 
             (this.state!=null &&
              this.state.equals(other.getState()))) &&
            ((this.postalCode==null && other.getPostalCode()==null) || 
             (this.postalCode!=null &&
              this.postalCode.equals(other.getPostalCode()))) &&
            ((this.postalCodeExtenstion==null && other.getPostalCodeExtenstion()==null) || 
             (this.postalCodeExtenstion!=null &&
              this.postalCodeExtenstion.equals(other.getPostalCodeExtenstion()))) &&
            ((this.timeZone==null && other.getTimeZone()==null) || 
             (this.timeZone!=null &&
              this.timeZone.equals(other.getTimeZone()))) &&
            this.score == other.getScore() &&
            this.latitude == other.getLatitude() &&
            this.longitude == other.getLongitude() &&
            this.censusTract == other.getCensusTract() &&
            this.censusBlockGroup == other.getCensusBlockGroup() &&
            this.PCode == other.getPCode() &&
            this.FIPSCode == other.getFIPSCode() &&
            this.unincorporated == other.isUnincorporated();
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
        if (getNetworkID() != null) {
            _hashCode += getNetworkID().hashCode();
        }
        if (getStreetNumber() != null) {
            _hashCode += getStreetNumber().hashCode();
        }
        if (getStreetName() != null) {
            _hashCode += getStreetName().hashCode();
        }
        if (getUnit() != null) {
            _hashCode += getUnit().hashCode();
        }
        if (getCity() != null) {
            _hashCode += getCity().hashCode();
        }
        if (getCounty() != null) {
            _hashCode += getCounty().hashCode();
        }
        if (getCountry() != null) {
            _hashCode += getCountry().hashCode();
        }
        if (getState() != null) {
            _hashCode += getState().hashCode();
        }
        if (getPostalCode() != null) {
            _hashCode += getPostalCode().hashCode();
        }
        if (getPostalCodeExtenstion() != null) {
            _hashCode += getPostalCodeExtenstion().hashCode();
        }
        if (getTimeZone() != null) {
            _hashCode += getTimeZone().hashCode();
        }
        _hashCode += new Double(getScore()).hashCode();
        _hashCode += new Double(getLatitude()).hashCode();
        _hashCode += new Double(getLongitude()).hashCode();
        _hashCode += getCensusTract();
        _hashCode += getCensusBlockGroup();
        _hashCode += getPCode();
        _hashCode += new Long(getFIPSCode()).hashCode();
        _hashCode += (isUnincorporated() ? Boolean.TRUE : Boolean.FALSE).hashCode();
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(AddressLocation.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "AddressLocation"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("networkID");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "NetworkID"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("streetNumber");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "StreetNumber"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("streetName");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "StreetName"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("unit");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "Unit"));
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
        elemField.setFieldName("county");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "County"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("country");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "Country"));
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
        elemField.setFieldName("postalCodeExtenstion");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "PostalCodeExtenstion"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("timeZone");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "TimeZone"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("score");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "Score"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "double"));
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("latitude");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "Latitude"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "double"));
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("longitude");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "Longitude"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "double"));
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("censusTract");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "CensusTract"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("censusBlockGroup");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "CensusBlockGroup"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("PCode");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "PCode"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("FIPSCode");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "FIPSCode"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "long"));
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("unincorporated");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/ezgeo", "Unincorporated"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "boolean"));
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
