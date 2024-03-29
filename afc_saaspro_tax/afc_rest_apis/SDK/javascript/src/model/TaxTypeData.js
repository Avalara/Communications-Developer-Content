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
 * The TaxTypeData model module.
 * @module model/TaxTypeData
 * @version v2
 */
class TaxTypeData {
    /**
     * Constructs a new <code>TaxTypeData</code>.
     * @alias module:model/TaxTypeData
     */
    constructor() { 
        
        TaxTypeData.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>TaxTypeData</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/TaxTypeData} obj Optional instance to populate.
     * @return {module:model/TaxTypeData} The populated <code>TaxTypeData</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new TaxTypeData();

            if (data.hasOwnProperty('TaxType')) {
                obj['TaxType'] = ApiClient.convertToType(data['TaxType'], 'Number');
            }
            if (data.hasOwnProperty('CategoryType')) {
                obj['CategoryType'] = ApiClient.convertToType(data['CategoryType'], 'Number');
            }
            if (data.hasOwnProperty('TaxDescription')) {
                obj['TaxDescription'] = ApiClient.convertToType(data['TaxDescription'], 'String');
            }
            if (data.hasOwnProperty('CategoryDescription')) {
                obj['CategoryDescription'] = ApiClient.convertToType(data['CategoryDescription'], 'String');
            }
        }
        return obj;
    }


}

/**
 * @member {Number} TaxType
 */
TaxTypeData.prototype['TaxType'] = undefined;

/**
 * @member {Number} CategoryType
 */
TaxTypeData.prototype['CategoryType'] = undefined;

/**
 * @member {String} TaxDescription
 */
TaxTypeData.prototype['TaxDescription'] = undefined;

/**
 * @member {String} CategoryDescription
 */
TaxTypeData.prototype['CategoryDescription'] = undefined;






export default TaxTypeData;

