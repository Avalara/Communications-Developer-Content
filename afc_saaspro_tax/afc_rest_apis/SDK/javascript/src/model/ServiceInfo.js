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
import VersionInfo from './VersionInfo';

/**
 * The ServiceInfo model module.
 * @module model/ServiceInfo
 * @version v2
 */
class ServiceInfo {
    /**
     * Constructs a new <code>ServiceInfo</code>.
     * Response body for service info API.
     * @alias module:model/ServiceInfo
     */
    constructor() { 
        
        ServiceInfo.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>ServiceInfo</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/ServiceInfo} obj Optional instance to populate.
     * @return {module:model/ServiceInfo} The populated <code>ServiceInfo</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new ServiceInfo();

            if (data.hasOwnProperty('ServerTime')) {
                obj['ServerTime'] = ApiClient.convertToType(data['ServerTime'], 'Date');
            }
            if (data.hasOwnProperty('Versions')) {
                obj['Versions'] = VersionInfo.constructFromObject(data['Versions']);
            }
            if (data.hasOwnProperty('Error')) {
                obj['Error'] = ApiClient.convertToType(data['Error'], 'String');
            }
        }
        return obj;
    }


}

/**
 * Server time.
 * @member {Date} ServerTime
 */
ServiceInfo.prototype['ServerTime'] = undefined;

/**
 * @member {module:model/VersionInfo} Versions
 */
ServiceInfo.prototype['Versions'] = undefined;

/**
 * Error information.
 * @member {String} Error
 */
ServiceInfo.prototype['Error'] = undefined;






export default ServiceInfo;

