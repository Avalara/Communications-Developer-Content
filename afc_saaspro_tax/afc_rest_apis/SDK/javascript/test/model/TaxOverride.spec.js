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

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD.
    define(['expect.js', process.cwd()+'/src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require(process.cwd()+'/src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.SaasPro);
  }
}(this, function(expect, SaasPro) {
  'use strict';

  var instance;

  beforeEach(function() {
    instance = new SaasPro.TaxOverride();
  });

  var getProperty = function(object, getter, property) {
    // Use getter method if present; otherwise, get the property directly.
    if (typeof object[getter] === 'function')
      return object[getter]();
    else
      return object[property];
  }

  var setProperty = function(object, setter, property, value) {
    // Use setter method if present; otherwise, set the property directly.
    if (typeof object[setter] === 'function')
      object[setter](value);
    else
      object[property] = value;
  }

  describe('TaxOverride', function() {
    it('should create an instance of TaxOverride', function() {
      // uncomment below and update the code to test TaxOverride
      //var instane = new SaasPro.TaxOverride();
      //expect(instance).to.be.a(SaasPro.TaxOverride);
    });

    it('should have the property loc (base name: "loc")', function() {
      // uncomment below and update the code to test the property loc
      //var instane = new SaasPro.TaxOverride();
      //expect(instance).to.be();
    });

    it('should have the property scp (base name: "scp")', function() {
      // uncomment below and update the code to test the property scp
      //var instane = new SaasPro.TaxOverride();
      //expect(instance).to.be();
    });

    it('should have the property tid (base name: "tid")', function() {
      // uncomment below and update the code to test the property tid
      //var instane = new SaasPro.TaxOverride();
      //expect(instance).to.be();
    });

    it('should have the property lvl (base name: "lvl")', function() {
      // uncomment below and update the code to test the property lvl
      //var instane = new SaasPro.TaxOverride();
      //expect(instance).to.be();
    });

    it('should have the property lvlExm (base name: "lvlExm")', function() {
      // uncomment below and update the code to test the property lvlExm
      //var instane = new SaasPro.TaxOverride();
      //expect(instance).to.be();
    });

    it('should have the property brkt (base name: "brkt")', function() {
      // uncomment below and update the code to test the property brkt
      //var instane = new SaasPro.TaxOverride();
      //expect(instance).to.be();
    });

  });

}));
