

public class AddressServiceSoapProxy implements AddressServiceSoap {
  private String _endpoint = null;
  private AddressServiceSoap addressServiceSoap = null;
  
  public AddressServiceSoapProxy() {
    _initAddressServiceSoapProxy();
  }
  
  public AddressServiceSoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initAddressServiceSoapProxy();
  }
  
  private void _initAddressServiceSoapProxy() {
    try {
      addressServiceSoap = (new AddressServiceLocator()).getAddressServiceSoap();
      if (addressServiceSoap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)addressServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)addressServiceSoap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (addressServiceSoap != null)
      ((javax.xml.rpc.Stub)addressServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public AddressServiceSoap getAddressServiceSoap() {
    if (addressServiceSoap == null)
      _initAddressServiceSoapProxy();
    return addressServiceSoap;
  }
  
  public java.util.Calendar getServerTime() throws java.rmi.RemoteException{
    if (addressServiceSoap == null)
      _initAddressServiceSoapProxy();
    return addressServiceSoap.getServerTime();
  }
  
  public AddressLocation geocodeAddress(GeocodeAddressRequest addressInfo) throws java.rmi.RemoteException{
    if (addressServiceSoap == null)
      _initAddressServiceSoapProxy();
    return addressServiceSoap.geocodeAddress(addressInfo);
  }
  
  public AddressLocation[] geocodeAllMatches(GeocodeAddressRequest addressInfo) throws java.rmi.RemoteException{
    if (addressServiceSoap == null)
      _initAddressServiceSoapProxy();
    return addressServiceSoap.geocodeAllMatches(addressInfo);
  }
  
  
}