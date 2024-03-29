/**
 * SaasPro
 * APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.<br /><br />Effective January 1st, 2022 all Avalara products will be enforcing TLS 1.2 server-side. Please ensure that your implementation sets a minimal of TLS 1.2 encryption when making web requests to Avalara APIs.
 *
 * The version of the OpenAPI document: v2
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 */

import ApiClient from '../ApiClient';

/**
 * The GeocodeRequest model module.
 * @module model/GeocodeRequest
 * @version v2
 */
class GeocodeRequest {
    /**
     * Constructs a new <code>GeocodeRequest</code>.
     * Input data for Geocoding API.
     * @alias module:model/GeocodeRequest
     */
    constructor() { 
        
        GeocodeRequest.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>GeocodeRequest</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/GeocodeRequest} obj Optional instance to populate.
     * @return {module:model/GeocodeRequest} The populated <code>GeocodeRequest</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new GeocodeRequest();

            if (data.hasOwnProperty('ref')) {
                obj['ref'] = ApiClient.convertToType(data['ref'], 'String');
            }
            if (data.hasOwnProperty('cass')) {
                obj['cass'] = ApiClient.convertToType(data['cass'], 'Boolean');
            }
            if (data.hasOwnProperty('lat')) {
                obj['lat'] = ApiClient.convertToType(data['lat'], 'Number');
            }
            if (data.hasOwnProperty('long')) {
                obj['long'] = ApiClient.convertToType(data['long'], 'Number');
            }
            if (data.hasOwnProperty('addr')) {
                obj['addr'] = ApiClient.convertToType(data['addr'], 'String');
            }
            if (data.hasOwnProperty('city')) {
                obj['city'] = ApiClient.convertToType(data['city'], 'String');
            }
            if (data.hasOwnProperty('st')) {
                obj['st'] = ApiClient.convertToType(data['st'], 'String');
            }
            if (data.hasOwnProperty('zip')) {
                obj['zip'] = ApiClient.convertToType(data['zip'], 'String');
            }
        }
        return obj;
    }


}

/**
 * Optional reference Id for geocode request.   Only address information or latitude/longitude should be provided in request body but not both.
 * @member {String} ref
 */
GeocodeRequest.prototype['ref'] = undefined;

/**
 * Indicates if the CASS validated address is desired in the results.
 * @member {Boolean} cass
 */
GeocodeRequest.prototype['cass'] = undefined;

/**
 * Latitude for geocoding based on lat/long coordinates.
 * @member {Number} lat
 */
GeocodeRequest.prototype['lat'] = undefined;

/**
 * Longitude for geocoding based on lat/long coordinates.
 * @member {Number} long
 */
GeocodeRequest.prototype['long'] = undefined;

/**
 * Street address.
 * @member {String} addr
 */
GeocodeRequest.prototype['addr'] = undefined;

/**
 * City name.
 * @member {String} city
 */
GeocodeRequest.prototype['city'] = undefined;

/**
 * State name or abbreviation.
 * @member {String} st
 */
GeocodeRequest.prototype['st'] = undefined;

/**
 * Postal code.
 * @member {String} zip
 */
GeocodeRequest.prototype['zip'] = undefined;






export default GeocodeRequest;

