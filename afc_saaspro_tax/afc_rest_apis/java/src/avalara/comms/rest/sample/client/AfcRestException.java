package avalara.comms.rest.sample.client;

/**
 * HTTP status code returned by call to AFC REST service.
 */
public class AfcRestException extends Exception {
    private int httpCode;
    
    /**
     * HTTP status code returned by call to AFC REST service.
     * @return HTTP status code.
     */
    public int getHttpCode() {
        return httpCode;
    }
    
    /**
     * Constructor.
     * 
     * @param httpCode  HTTP status code.
     * @param message   Exception message.
     */
    public AfcRestException(int httpCode, String message) {
        this(httpCode, message, null);
    }
    
    /**
     * Constructor.
     * 
     * @param httpCode          HTTP status code.
     * @param message           Exception message.
     * @param innerException    Inner exception.
     */
    public AfcRestException(int httpCode, String message, Exception innerException) {
        super(
            message == null || message.trim().length() == 0 ?
                "Request returned an error code: " + httpCode :
                message,
            innerException);
        this.httpCode = httpCode;
    }
}