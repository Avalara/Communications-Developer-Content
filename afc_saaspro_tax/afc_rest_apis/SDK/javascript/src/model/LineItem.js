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
import KeyValuePair from './KeyValuePair';
import Location from './Location';

/**
 * The LineItem model module.
 * @module model/LineItem
 * @version v2
 */
class LineItem {
    /**
     * Constructs a new <code>LineItem</code>.
     * Data for an invoice or quote line item.
     * @alias module:model/LineItem
     */
    constructor() { 
        
        LineItem.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>LineItem</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/LineItem} obj Optional instance to populate.
     * @return {module:model/LineItem} The populated <code>LineItem</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new LineItem();

            if (data.hasOwnProperty('ref')) {
                obj['ref'] = ApiClient.convertToType(data['ref'], 'String');
            }
            if (data.hasOwnProperty('from')) {
                obj['from'] = Location.constructFromObject(data['from']);
            }
            if (data.hasOwnProperty('to')) {
                obj['to'] = Location.constructFromObject(data['to']);
            }
            if (data.hasOwnProperty('chg')) {
                obj['chg'] = ApiClient.convertToType(data['chg'], 'Number');
            }
            if (data.hasOwnProperty('line')) {
                obj['line'] = ApiClient.convertToType(data['line'], 'Number');
            }
            if (data.hasOwnProperty('loc')) {
                obj['loc'] = ApiClient.convertToType(data['loc'], 'Number');
            }
            if (data.hasOwnProperty('min')) {
                obj['min'] = ApiClient.convertToType(data['min'], 'Number');
            }
            if (data.hasOwnProperty('sale')) {
                obj['sale'] = ApiClient.convertToType(data['sale'], 'Number');
            }
            if (data.hasOwnProperty('plsp')) {
                obj['plsp'] = ApiClient.convertToType(data['plsp'], 'Number');
            }
            if (data.hasOwnProperty('incl')) {
                obj['incl'] = ApiClient.convertToType(data['incl'], 'Boolean');
            }
            if (data.hasOwnProperty('pror')) {
                obj['pror'] = ApiClient.convertToType(data['pror'], 'Number');
            }
            if (data.hasOwnProperty('proadj')) {
                obj['proadj'] = ApiClient.convertToType(data['proadj'], 'Number');
            }
            if (data.hasOwnProperty('tran')) {
                obj['tran'] = ApiClient.convertToType(data['tran'], 'Number');
            }
            if (data.hasOwnProperty('serv')) {
                obj['serv'] = ApiClient.convertToType(data['serv'], 'Number');
            }
            if (data.hasOwnProperty('dbt')) {
                obj['dbt'] = ApiClient.convertToType(data['dbt'], 'Boolean');
            }
            if (data.hasOwnProperty('adj')) {
                obj['adj'] = ApiClient.convertToType(data['adj'], 'Boolean');
            }
            if (data.hasOwnProperty('adjm')) {
                obj['adjm'] = ApiClient.convertToType(data['adjm'], 'Number');
            }
            if (data.hasOwnProperty('disc')) {
                obj['disc'] = ApiClient.convertToType(data['disc'], 'Number');
            }
            if (data.hasOwnProperty('opt')) {
                obj['opt'] = ApiClient.convertToType(data['opt'], [KeyValuePair]);
            }
            if (data.hasOwnProperty('prop')) {
                obj['prop'] = ApiClient.convertToType(data['prop'], 'Number');
            }
            if (data.hasOwnProperty('bill')) {
                obj['bill'] = Location.constructFromObject(data['bill']);
            }
            if (data.hasOwnProperty('cust')) {
                obj['cust'] = ApiClient.convertToType(data['cust'], 'Number');
            }
            if (data.hasOwnProperty('lfln')) {
                obj['lfln'] = ApiClient.convertToType(data['lfln'], 'Boolean');
            }
            if (data.hasOwnProperty('date')) {
                obj['date'] = ApiClient.convertToType(data['date'], 'Date');
            }
            if (data.hasOwnProperty('qty')) {
                obj['qty'] = ApiClient.convertToType(data['qty'], 'Number');
            }
            if (data.hasOwnProperty('glref')) {
                obj['glref'] = ApiClient.convertToType(data['glref'], 'String');
            }
        }
        return obj;
    }


}

/**
 * Reference ID for line item.
 * @member {String} ref
 */
LineItem.prototype['ref'] = undefined;

/**
 * @member {module:model/Location} from
 */
LineItem.prototype['from'] = undefined;

/**
 * @member {module:model/Location} to
 */
LineItem.prototype['to'] = undefined;

/**
 * Charge amount.  Default: 0.
 * @member {Number} chg
 */
LineItem.prototype['chg'] = undefined;

/**
 * Number of lines.  Default: 0.
 * @member {Number} line
 */
LineItem.prototype['line'] = undefined;

/**
 * Number of locations.  Default: 0.
 * @member {Number} loc
 */
LineItem.prototype['loc'] = undefined;

/**
 * Number of minutes.  Default: 0.
 * @member {Number} min
 */
LineItem.prototype['min'] = undefined;

/**
 * 0 - Wholesale : Indicates that the item was sold to a wholeseller.  1 - Retail : Indicates that the item was sold to an end user - a retail sale.  2 - Consumed : Indicates that the item was consumed directly (SAU products only).  3 - VendorUse : Indicates that the item is subject to vendor use tax (SAU products only).
 * @member {Number} sale
 */
LineItem.prototype['sale'] = undefined;

/**
 * Split for private-line transactions.
 * @member {Number} plsp
 */
LineItem.prototype['plsp'] = undefined;

/**
 * Indicates if the charge for this line item is tax-inclusive.
 * @member {Boolean} incl
 */
LineItem.prototype['incl'] = undefined;

/**
 * For pro-rated tax calculations. Percentage to pro-rate.
 * @member {Number} pror
 */
LineItem.prototype['pror'] = undefined;

/**
 * For pro-rated credit or adjustment calculations.  0 = default  1 = do not return non-proratable fixed taxes in response  2 = return non-proratable fixed taxes in response
 * @member {Number} proadj
 */
LineItem.prototype['proadj'] = undefined;

/**
 * Transaction type ID.
 * @member {Number} tran
 */
LineItem.prototype['tran'] = undefined;

/**
 * Service type ID.
 * @member {Number} serv
 */
LineItem.prototype['serv'] = undefined;

/**
 * Indicates if this line item is a debit card transaction.  Default: false.
 * @member {Boolean} dbt
 */
LineItem.prototype['dbt'] = undefined;

/**
 * Indicates if this line item is an adjustment.  Default: false.
 * @member {Boolean} adj
 */
LineItem.prototype['adj'] = undefined;

/**
 * Adjustment method.
 * @member {Number} adjm
 */
LineItem.prototype['adjm'] = undefined;

/**
 * Discount type for adjustments.
 * @member {Number} disc
 */
LineItem.prototype['disc'] = undefined;

/**
 * Optional values for line item. Maximum of 5. Keys must be numeric from 5 to 10.
 * @member {Array.<module:model/KeyValuePair>} opt
 */
LineItem.prototype['opt'] = undefined;

/**
 * Attribute/property value for sales and use transaction/service pairs.
 * @member {Number} prop
 */
LineItem.prototype['prop'] = undefined;

/**
 * @member {module:model/Location} bill
 */
LineItem.prototype['bill'] = undefined;

/**
 * Customer type.
 * @member {Number} cust
 */
LineItem.prototype['cust'] = undefined;

/**
 * Indicates if customer is a Lifeline participant.  Default: false.
 * @member {Boolean} lfln
 */
LineItem.prototype['lfln'] = undefined;

/**
 * Invoice date.
 * @member {Date} date
 */
LineItem.prototype['date'] = undefined;

/**
 * Quantity to be applied to the item - taxation is equivalent to repeating the item the number of times of the quantity
 * @member {Number} qty
 */
LineItem.prototype['qty'] = undefined;

/**
 * General Ledger reference to be used in reporting
 * @member {String} glref
 */
LineItem.prototype['glref'] = undefined;






export default LineItem;

