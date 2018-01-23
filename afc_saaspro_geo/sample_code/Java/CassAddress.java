

public class CassAddress  implements java.io.Serializable {
    private java.lang.String[] address;

    private java.lang.String addressLine;

    private java.lang.String cityStateZip;

    private java.lang.String city;

    private java.lang.String state;

    private java.lang.String zip;

    private java.lang.String zip4;

    private java.lang.String addressQualityFlags;

    private java.lang.String carrierRoute;

    private int countyCode;

    private java.lang.String deliveryPointValidation;

    private java.lang.String enhancedLineOfTravel;

    private double reliability;

    private java.lang.String USPSBarCode;

    public CassAddress() {
    }

    public CassAddress(
           java.lang.String[] address,
           java.lang.String addressLine,
           java.lang.String cityStateZip,
           java.lang.String city,
           java.lang.String state,
           java.lang.String zip,
           java.lang.String zip4,
           java.lang.String addressQualityFlags,
           java.lang.String carrierRoute,
           int countyCode,
           java.lang.String deliveryPointValidation,
           java.lang.String enhancedLineOfTravel,
           double reliability,
           java.lang.String USPSBarCode) {
           this.address = address;
           this.addressLine = addressLine;
           this.cityStateZip = cityStateZip;
           this.city = city;
           this.state = state;
           this.zip = zip;
           this.zip4 = zip4;
           this.addressQualityFlags = addressQualityFlags;
           this.carrierRoute = carrierRoute;
           this.countyCode = countyCode;
           this.deliveryPointValidation = deliveryPointValidation;
           this.enhancedLineOfTravel = enhancedLineOfTravel;
           this.reliability = reliability;
           this.USPSBarCode = USPSBarCode;
    }


    /**
     * Gets the address value for this CassAddress.
     * 
     * @return address
     */
    public java.lang.String[] getAddress() {
        return address;
    }


    /**
     * Sets the address value for this CassAddress.
     * 
     * @param address
     */
    public void setAddress(java.lang.String[] address) {
        this.address = address;
    }


    /**
     * Gets the addressLine value for this CassAddress.
     * 
     * @return addressLine
     */
    public java.lang.String getAddressLine() {
        return addressLine;
    }


    /**
     * Sets the addressLine value for this CassAddress.
     * 
     * @param addressLine
     */
    public void setAddressLine(java.lang.String addressLine) {
        this.addressLine = addressLine;
    }


    /**
     * Gets the cityStateZip value for this CassAddress.
     * 
     * @return cityStateZip
     */
    public java.lang.String getCityStateZip() {
        return cityStateZip;
    }


    /**
     * Sets the cityStateZip value for this CassAddress.
     * 
     * @param cityStateZip
     */
    public void setCityStateZip(java.lang.String cityStateZip) {
        this.cityStateZip = cityStateZip;
    }


    /**
     * Gets the city value for this CassAddress.
     * 
     * @return city
     */
    public java.lang.String getCity() {
        return city;
    }


    /**
     * Sets the city value for this CassAddress.
     * 
     * @param city
     */
    public void setCity(java.lang.String city) {
        this.city = city;
    }


    /**
     * Gets the state value for this CassAddress.
     * 
     * @return state
     */
    public java.lang.String getState() {
        return state;
    }


    /**
     * Sets the state value for this CassAddress.
     * 
     * @param state
     */
    public void setState(java.lang.String state) {
        this.state = state;
    }


    /**
     * Gets the zip value for this CassAddress.
     * 
     * @return zip
     */
    public java.lang.String getZip() {
        return zip;
    }


    /**
     * Sets the zip value for this CassAddress.
     * 
     * @param zip
     */
    public void setZip(java.lang.String zip) {
        this.zip = zip;
    }


    /**
     * Gets the zip4 value for this CassAddress.
     * 
     * @return zip4
     */
    public java.lang.String getZip4() {
        return zip4;
    }


    /**
     * Sets the zip4 value for this CassAddress.
     * 
     * @param zip4
     */
    public void setZip4(java.lang.String zip4) {
        this.zip4 = zip4;
    }


    /**
     * Gets the addressQualityFlags value for this CassAddress.
     * 
     * @return addressQualityFlags
     */
    public java.lang.String getAddressQualityFlags() {
        return addressQualityFlags;
    }


    /**
     * Sets the addressQualityFlags value for this CassAddress.
     * 
     * @param addressQualityFlags
     */
    public void setAddressQualityFlags(java.lang.String addressQualityFlags) {
        this.addressQualityFlags = addressQualityFlags;
    }


    /**
     * Gets the carrierRoute value for this CassAddress.
     * 
     * @return carrierRoute
     */
    public java.lang.String getCarrierRoute() {
        return carrierRoute;
    }


    /**
     * Sets the carrierRoute value for this CassAddress.
     * 
     * @param carrierRoute
     */
    public void setCarrierRoute(java.lang.String carrierRoute) {
        this.carrierRoute = carrierRoute;
    }


    /**
     * Gets the countyCode value for this CassAddress.
     * 
     * @return countyCode
     */
    public int getCountyCode() {
        return countyCode;
    }


    /**
     * Sets the countyCode value for this CassAddress.
     * 
     * @param countyCode
     */
    public void setCountyCode(int countyCode) {
        this.countyCode = countyCode;
    }


    /**
     * Gets the deliveryPointValidation value for this CassAddress.
     * 
     * @return deliveryPointValidation
     */
    public java.lang.String getDeliveryPointValidation() {
        return deliveryPointValidation;
    }


    /**
     * Sets the deliveryPointValidation value for this CassAddress.
     * 
     * @param deliveryPointValidation
     */
    public void setDeliveryPointValidation(java.lang.String deliveryPointValidation) {
        this.deliveryPointValidation = deliveryPointValidation;
    }


    /**
     * Gets the enhancedLineOfTravel value for this CassAddress.
     * 
     * @return enhancedLineOfTravel
     */
    public java.lang.String getEnhancedLineOfTravel() {
        return enhancedLineOfTravel;
    }


    /**
     * Sets the enhancedLineOfTravel value for this CassAddress.
     * 
     * @param enhancedLineOfTravel
     */
    public void setEnhancedLineOfTravel(java.lang.String enhancedLineOfTravel) {
        this.enhancedLineOfTravel = enhancedLineOfTravel;
    }


    /**
     * Gets the reliability value for this CassAddress.
     * 
     * @return reliability
     */
    public double getReliability() {
        return reliability;
    }


    /**
     * Sets the reliability value for this CassAddress.
     * 
     * @param reliability
     */
    public void setReliability(double reliability) {
        this.reliability = reliability;
    }


    /**
     * Gets the USPSBarCode value for this CassAddress.
     * 
     * @return USPSBarCode
     */
    public java.lang.String getUSPSBarCode() {
        return USPSBarCode;
    }


    /**
     * Sets the USPSBarCode value for this CassAddress.
     * 
     * @param USPSBarCode
     */
    public void setUSPSBarCode(java.lang.String USPSBarCode) {
        this.USPSBarCode = USPSBarCode;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof CassAddress)) return false;
        CassAddress other = (CassAddress) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.address==null && other.getAddress()==null) || 
             (this.address!=null &&
              java.util.Arrays.equals(this.address, other.getAddress()))) &&
            ((this.addressLine==null && other.getAddressLine()==null) || 
             (this.addressLine!=null &&
              this.addressLine.equals(other.getAddressLine()))) &&
            ((this.cityStateZip==null && other.getCityStateZip()==null) || 
             (this.cityStateZip!=null &&
              this.cityStateZip.equals(other.getCityStateZip()))) &&
            ((this.city==null && other.getCity()==null) || 
             (this.city!=null &&
              this.city.equals(other.getCity()))) &&
            ((this.state==null && other.getState()==null) || 
             (this.state!=null &&
              this.state.equals(other.getState()))) &&
            ((this.zip==null && other.getZip()==null) || 
             (this.zip!=null &&
              this.zip.equals(other.getZip()))) &&
            ((this.zip4==null && other.getZip4()==null) || 
             (this.zip4!=null &&
              this.zip4.equals(other.getZip4()))) &&
            ((this.addressQualityFlags==null && other.getAddressQualityFlags()==null) || 
             (this.addressQualityFlags!=null &&
              this.addressQualityFlags.equals(other.getAddressQualityFlags()))) &&
            ((this.carrierRoute==null && other.getCarrierRoute()==null) || 
             (this.carrierRoute!=null &&
              this.carrierRoute.equals(other.getCarrierRoute()))) &&
            this.countyCode == other.getCountyCode() &&
            ((this.deliveryPointValidation==null && other.getDeliveryPointValidation()==null) || 
             (this.deliveryPointValidation!=null &&
              this.deliveryPointValidation.equals(other.getDeliveryPointValidation()))) &&
            ((this.enhancedLineOfTravel==null && other.getEnhancedLineOfTravel()==null) || 
             (this.enhancedLineOfTravel!=null &&
              this.enhancedLineOfTravel.equals(other.getEnhancedLineOfTravel()))) &&
            this.reliability == other.getReliability() &&
            ((this.USPSBarCode==null && other.getUSPSBarCode()==null) || 
             (this.USPSBarCode!=null &&
              this.USPSBarCode.equals(other.getUSPSBarCode())));
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
        if (getAddress() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getAddress());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getAddress(), i);
                if (obj != null &&
                    !obj.getClass().isArray()) {
                    _hashCode += obj.hashCode();
                }
            }
        }
        if (getAddressLine() != null) {
            _hashCode += getAddressLine().hashCode();
        }
        if (getCityStateZip() != null) {
            _hashCode += getCityStateZip().hashCode();
        }
        if (getCity() != null) {
            _hashCode += getCity().hashCode();
        }
        if (getState() != null) {
            _hashCode += getState().hashCode();
        }
        if (getZip() != null) {
            _hashCode += getZip().hashCode();
        }
        if (getZip4() != null) {
            _hashCode += getZip4().hashCode();
        }
        if (getAddressQualityFlags() != null) {
            _hashCode += getAddressQualityFlags().hashCode();
        }
        if (getCarrierRoute() != null) {
            _hashCode += getCarrierRoute().hashCode();
        }
        _hashCode += getCountyCode();
        if (getDeliveryPointValidation() != null) {
            _hashCode += getDeliveryPointValidation().hashCode();
        }
        if (getEnhancedLineOfTravel() != null) {
            _hashCode += getEnhancedLineOfTravel().hashCode();
        }
        _hashCode += new Double(getReliability()).hashCode();
        if (getUSPSBarCode() != null) {
            _hashCode += getUSPSBarCode().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(CassAddress.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://xml.billsoft.com/2006/08/ezgeo", "CassAddress"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("address");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/2006/08/ezgeo", "Address"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        elemField.setItemQName(new javax.xml.namespace.QName("http://xml.billsoft.com/2006/08/ezgeo", "string"));
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("addressLine");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/2006/08/ezgeo", "AddressLine"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("cityStateZip");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/2006/08/ezgeo", "CityStateZip"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("city");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/2006/08/ezgeo", "City"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("state");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/2006/08/ezgeo", "State"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("zip");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/2006/08/ezgeo", "Zip"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("zip4");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/2006/08/ezgeo", "Zip4"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("addressQualityFlags");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/2006/08/ezgeo", "AddressQualityFlags"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("carrierRoute");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/2006/08/ezgeo", "CarrierRoute"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("countyCode");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/2006/08/ezgeo", "CountyCode"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("deliveryPointValidation");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/2006/08/ezgeo", "DeliveryPointValidation"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("enhancedLineOfTravel");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/2006/08/ezgeo", "EnhancedLineOfTravel"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("reliability");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/2006/08/ezgeo", "Reliability"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "double"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("USPSBarCode");
        elemField.setXmlName(new javax.xml.namespace.QName("http://xml.billsoft.com/2006/08/ezgeo", "USPSBarCode"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
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
