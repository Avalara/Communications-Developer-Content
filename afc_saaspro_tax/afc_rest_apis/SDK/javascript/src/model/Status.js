/**
 * SaasPro
 * APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.
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
 * The Status model module.
 * @module model/Status
 * @version v2
 */
class Status {
    /**
     * Constructs a new <code>Status</code>.
     * Status information.
     * @alias module:model/Status
     */
    constructor() { 
        
        Status.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>Status</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/Status} obj Optional instance to populate.
     * @return {module:model/Status} The populated <code>Status</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new Status();

            if (data.hasOwnProperty('code')) {
                obj['code'] = ApiClient.convertToType(data['code'], 'Number');
            }
            if (data.hasOwnProperty('msg')) {
                obj['msg'] = ApiClient.convertToType(data['msg'], 'String');
            }
        }
        return obj;
    }


}

/**
 * Status code.
 * @member {Number} code
 */
Status.prototype['code'] = undefined;

/**
 * @member {String} msg
 */
Status.prototype['msg'] = undefined;






export default Status;
