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
import Address from './Address';

/**
 * The GeocodeResult model module.
 * @module model/GeocodeResult
 * @version v2
 */
class GeocodeResult {
    /**
     * Constructs a new <code>GeocodeResult</code>.
     * Results for geocoding request.
     * @alias module:model/GeocodeResult
     */
    constructor() { 
        
        GeocodeResult.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>GeocodeResult</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/GeocodeResult} obj Optional instance to populate.
     * @return {module:model/GeocodeResult} The populated <code>GeocodeResult</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new GeocodeResult();

            if (data.hasOwnProperty('ref')) {
                obj['ref'] = ApiClient.convertToType(data['ref'], 'String');
            }
            if (data.hasOwnProperty('cass')) {
                obj['cass'] = Address.constructFromObject(data['cass']);
            }
            if (data.hasOwnProperty('cBlk')) {
                obj['cBlk'] = ApiClient.convertToType(data['cBlk'], 'Number');
            }
            if (data.hasOwnProperty('cTrc')) {
                obj['cTrc'] = ApiClient.convertToType(data['cTrc'], 'Number');
            }
            if (data.hasOwnProperty('cnty')) {
                obj['cnty'] = ApiClient.convertToType(data['cnty'], 'String');
            }
            if (data.hasOwnProperty('feat')) {
                obj['feat'] = ApiClient.convertToType(data['feat'], 'Number');
            }
            if (data.hasOwnProperty('fips')) {
                obj['fips'] = ApiClient.convertToType(data['fips'], 'String');
            }
            if (data.hasOwnProperty('inc')) {
                obj['inc'] = ApiClient.convertToType(data['inc'], 'Boolean');
            }
            if (data.hasOwnProperty('jur')) {
                obj['jur'] = ApiClient.convertToType(data['jur'], 'String');
            }
            if (data.hasOwnProperty('lat')) {
                obj['lat'] = ApiClient.convertToType(data['lat'], 'Number');
            }
            if (data.hasOwnProperty('long')) {
                obj['long'] = ApiClient.convertToType(data['long'], 'Number');
            }
            if (data.hasOwnProperty('pcd')) {
                obj['pcd'] = ApiClient.convertToType(data['pcd'], 'Number');
            }
            if (data.hasOwnProperty('scr')) {
                obj['scr'] = ApiClient.convertToType(data['scr'], 'Number');
            }
            if (data.hasOwnProperty('err')) {
                obj['err'] = ApiClient.convertToType(data['err'], 'String');
            }
        }
        return obj;
    }


}

/**
 * Reference Id from geocode request input.
 * @member {String} ref
 */
GeocodeResult.prototype['ref'] = undefined;

/**
 * @member {module:model/Address} cass
 */
GeocodeResult.prototype['cass'] = undefined;

/**
 * Census block.
 * @member {Number} cBlk
 */
GeocodeResult.prototype['cBlk'] = undefined;

/**
 * Census tract.
 * @member {Number} cTrc
 */
GeocodeResult.prototype['cTrc'] = undefined;

/**
 * County
 * @member {String} cnty
 */
GeocodeResult.prototype['cnty'] = undefined;

/**
 * Feature ID.
 * @member {Number} feat
 */
GeocodeResult.prototype['feat'] = undefined;

/**
 * FIPS Code.
 * @member {String} fips
 */
GeocodeResult.prototype['fips'] = undefined;

/**
 * Indicates if address is within city limits.
 * @member {Boolean} inc
 */
GeocodeResult.prototype['inc'] = undefined;

/**
 * Tax jurisdiction name.
 * @member {String} jur
 */
GeocodeResult.prototype['jur'] = undefined;

/**
 * Latitude.
 * @member {Number} lat
 */
GeocodeResult.prototype['lat'] = undefined;

/**
 * Longitude.
 * @member {Number} long
 */
GeocodeResult.prototype['long'] = undefined;

/**
 * PCode for tax jurisdiction.
 * @member {Number} pcd
 */
GeocodeResult.prototype['pcd'] = undefined;

/**
 * Score indicating accuracy of address match in mapping database.
 * @member {Number} scr
 */
GeocodeResult.prototype['scr'] = undefined;

/**
 * Error message.
 * @member {String} err
 */
GeocodeResult.prototype['err'] = undefined;






export default GeocodeResult;

