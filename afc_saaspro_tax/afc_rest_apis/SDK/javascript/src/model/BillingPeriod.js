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
 * The BillingPeriod model module.
 * @module model/BillingPeriod
 * @version v2
 */
class BillingPeriod {
    /**
     * Constructs a new <code>BillingPeriod</code>.
     * Optional object for passing in billing period
     * @alias module:model/BillingPeriod
     */
    constructor() { 
        
        BillingPeriod.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>BillingPeriod</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/BillingPeriod} obj Optional instance to populate.
     * @return {module:model/BillingPeriod} The populated <code>BillingPeriod</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new BillingPeriod();

            if (data.hasOwnProperty('month')) {
                obj['month'] = ApiClient.convertToType(data['month'], 'Number');
            }
            if (data.hasOwnProperty('year')) {
                obj['year'] = ApiClient.convertToType(data['year'], 'Number');
            }
        }
        return obj;
    }


}

/**
 * Numeric value representing billing period month.  1 = January.
 * @member {Number} month
 */
BillingPeriod.prototype['month'] = undefined;

/**
 * Numeric 4 digit representation of billing period year.
 * @member {Number} year
 */
BillingPeriod.prototype['year'] = undefined;






export default BillingPeriod;

