package avalara.comms.rest.sample.client;

import avalara.comms.rest.sample.model.*;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.lang.reflect.Type;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.time.LocalDateTime;
import java.util.Base64;

/**
 * Client for AFC REST service. NOTE: Only APIs shown in this sample are implemented.
 */
public class AfcRestClient {
    
    private final String newLine = System.getProperty("line.separator");
    private final String baseAddress;
    private final String authToken;
    private final int clientId;
    private final int clientProfileId;
    private final Json json = new Json();
    
    /**
     * Constructor.
     * 
     * @param baseAddress   AFC REST service base address.
     * @param userName      User name for authentication.
     * @param password      Password for authentication.
     */
    public AfcRestClient(String baseAddress, String userName, String password, int clientId, int clientProfileId) {
        // Encode the credentials to base 64
        String credentials = userName + ":" + password;
        this.authToken = Base64.getEncoder().encodeToString(credentials.getBytes());
        this.baseAddress = baseAddress.endsWith("/") ? 
            baseAddress.substring(0, baseAddress.length() - 2): 
            baseAddress;
        this.clientId = clientId;
        this.clientProfileId = clientProfileId;
    }
    
    /**
     * Get server time. 
     * Returns the server time converted to local date/time.
     * 
     * @return Server time converted to local date/time
     * @throws AfcRestException 
     */
    public LocalDateTime getServerTime() throws AfcRestException {
        return get("/api/v1/Application/ServerTime", LocalDateTime.class);
    }
    
    /**
     * Determines the PCode for a location. 
     * Converts the given request data to a PCode.
     * 
     * @param request Object containing ZipAddress, FipsCode or NPANXX to be converted.
     * @return PCode for specified ZipAddress, FipsCode or NPANXX.
     * @throws AfcRestException 
     */
    public long getPCode(RequestPCodeDetail request) throws AfcRestException {
        return post("/api/v1/Location/PCode", request, Long.class);
    }

    /**
     * Calculate taxes on a transaction.
     * Accepts transaction data and performs appropriate tax calculations.
     * 
     * @param transaction Transaction data.
     * @return An array of TaxData objects that contain the information about the taxes applied.
     * @throws avalara.comms.rest.sample.client.AfcRestException
     */
    public TaxData[] calculateTaxes(Transaction transaction) throws AfcRestException {
        return post("/api/v1/CalculateTaxes", transaction, TaxData[].class);
    }

    /**
     * Calculate tax adjustments on transaction.
     * This method accepts transaction data and performs appropriate tax adjustment calculations.
     * 
     * @param transaction Transaction data.
     * @return An array of TaxData objects that contain the information about the taxes applied.
     * @throws AfcRestException 
     */
    public TaxData[] calculateAdjustments(Transaction transaction) throws AfcRestException {
        return post("/api/v1/CalculateAdjustments", transaction, TaxData[].class);
    }

    /**
     * Get address information for a jurisdiction.
     * This method returns a list of addresses for the specified jurisdiction.
     * 
     * @param pcode PCode for jurisdiction.
     * @return List of addresses for jurisdiction.
     * @throws AfcRestException 
     */
    public AddressData[] getAddress(long pcode) throws AfcRestException {
        return get("/api/v1/Location/Address/" + pcode, AddressData[].class);
    }
    
    /**
     * Calculate taxes on a bridge conference transaction.
     * This method will take a Billing address, Bridge Address, Host Address 
     * (optional) and list of participants. The system will determine which taxes 
     * apply for each participant and return the summarized taxes for the bridge 
     * conference transaction. The individual participant results are returned if 
     * ReturnParticipantResults is true.
     * 
     * @param transaction Bridge conference transaction details including list of participants.
     * @return BridgeConferenceResults object containing an array of 
     * BridgeConferenceParticipantResult objects for each participant transaction 
     * processed and TaxData array containing the summarized taxes for the bridge 
     * conference calculation.
     * @throws avalara.comms.rest.sample.client.AfcRestException
     */
    public BridgeConferenceResults calculateBridgeConferenceTaxes(
            BridgeConferenceTransaction transaction) throws AfcRestException {
        return post("/api/v1/BridgeConference/Taxes", transaction, BridgeConferenceResults.class);
    }
    
    /**
     * Calculate taxes using overrides.
     * Accepts transaction and tax rate override data to perform tax calculations 
     * with the provided override information.
     * 
     * @param request Transaction data to be processed and tax rate override list.
     * @return An array of TaxData objects that contain the information about the taxes applied.
     * @throws AfcRestException 
     */
    public TaxData[] calculateTaxesWithOverrides(
            CalculateWithOverridesRequest request) throws AfcRestException {
        return post("/api/v1/CalculateWithOverrides/Taxes", request, TaxData[].class);
    }
    
    /**
     * Initializes a new HttpURLConnection with a GET request method.
     * 
     * @param address       Path to be appended to URL's base address.
     * @param returnType    Type for de-serializing response content.
     * @return              De-serialized response.
     * @throws AfcRestException 
     */
    private <T> T get(String address, Type returnType) throws AfcRestException {
        try {
            // Initialize connection
            URL url = new URL(baseAddress + address);
            HttpURLConnection conn = (HttpURLConnection)url.openConnection();
            conn.setRequestMethod("GET");
            conn.setRequestProperty("Accept", "application/json");
            conn.setRequestProperty("Authorization", "Basic " + authToken);
            conn.setRequestProperty("client_id", Integer.toString(clientId));
            conn.setRequestProperty("client_profile_id", Integer.toString(clientProfileId));
            
            // Invoke API
            int responseCode = conn.getResponseCode();

            // Check for errors
            if (responseCode != HttpURLConnection.HTTP_OK) {
                String errorMsg = conn.getHeaderField("error");
                throw new AfcRestException(responseCode, errorMsg);
            }

            // Return the de-serialized response
            String response = getResponseContent(conn);
            return json.deserialize(response, returnType);
        }
        catch (MalformedURLException ex) {
            throw new AfcRestException(0, "Invalid address for AFC REST service.", ex);
        }
        catch (IOException ex) {
            throw new AfcRestException(0, "Unable to connect to the AFC REST service.", ex);
        }
    }
    
    /**
     * Initializes a new HttpURLConnection with a POST request method.
     * 
     * @param address       Path to be appended to URL's base address.
     * @param param         Parameter to serialize as JSON in the request body.
     * @param returnType    Type for de-serializing response content.
     * @return              De-serialized response.
     * @throws AfcRestException 
     */
    private <T> T post(String address, Object param, Type returnType) throws AfcRestException {
        try {
            // Initialize connection
            URL url = new URL(baseAddress + address);
            HttpURLConnection conn = (HttpURLConnection)url.openConnection();
            conn.setDoOutput(true);
            conn.setRequestMethod("POST");
            conn.setRequestProperty("Accept", "application/json");
            conn.setRequestProperty("Content-Type", "application/json");
            conn.setRequestProperty("Authorization", "Basic " + authToken);
            conn.setRequestProperty("client_id", Integer.toString(clientId));
            conn.setRequestProperty("client_profile_id", Integer.toString(clientProfileId));
            
            // Set the request body JSON object
            String body = json.serialize(param);
            OutputStream os = conn.getOutputStream();
            os.write(body.getBytes());
            os.flush();

            // Invoke API
            int responseCode = conn.getResponseCode();

            // Check for errors
            if (responseCode != HttpURLConnection.HTTP_OK) {
                String errorMsg = conn.getHeaderField("error");
                throw new AfcRestException(responseCode, errorMsg);
            }

            // Return de-serialized response
            String response = getResponseContent(conn);
            return json.deserialize(response, returnType);
        }
        catch (MalformedURLException ex) {
            throw new AfcRestException(0, "Invalid address for AFC REST service.", ex);
        }
        catch (IOException ex) {
            throw new AfcRestException(0, "Unable to connect to the AFC REST service.", ex);
        }
    }
    
    /**
     * Returns a string containing the response body content.
     * 
     * @param conn  HttpURLConnection object to read.
     * @return      String containing response object.
     * @throws AfcRestException 
     */
    private String getResponseContent(HttpURLConnection conn) throws AfcRestException {
        try {
            StringBuilder stringBuilder = new StringBuilder();
            String line;
            BufferedReader br = new BufferedReader(new InputStreamReader(
                    (conn.getInputStream())));

            while ((line = br.readLine()) != null) {
                stringBuilder.append(line);
                stringBuilder.append(newLine);
            }
            
            return stringBuilder.toString();
        }
        catch (IOException ex) {
            throw new AfcRestException(0, "Unable to read response content.", ex);
        }
    }
}