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
    instance = new SaasPro.CalcTaxesRequest();
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

  describe('CalcTaxesRequest', function() {
    it('should create an instance of CalcTaxesRequest', function() {
      // uncomment below and update the code to test CalcTaxesRequest
      //var instane = new SaasPro.CalcTaxesRequest();
      //expect(instance).to.be.a(SaasPro.CalcTaxesRequest);
    });

    it('should have the property cfg (base name: "cfg")', function() {
      // uncomment below and update the code to test the property cfg
      //var instane = new SaasPro.CalcTaxesRequest();
      //expect(instance).to.be();
    });

    it('should have the property cmpn (base name: "cmpn")', function() {
      // uncomment below and update the code to test the property cmpn
      //var instane = new SaasPro.CalcTaxesRequest();
      //expect(instance).to.be();
    });

    it('should have the property inv (base name: "inv")', function() {
      // uncomment below and update the code to test the property inv
      //var instane = new SaasPro.CalcTaxesRequest();
      //expect(instance).to.be();
    });

    it('should have the property ovr (base name: "ovr")', function() {
      // uncomment below and update the code to test the property ovr
      //var instane = new SaasPro.CalcTaxesRequest();
      //expect(instance).to.be();
    });

    it('should have the property sovr (base name: "sovr")', function() {
      // uncomment below and update the code to test the property sovr
      //var instane = new SaasPro.CalcTaxesRequest();
      //expect(instance).to.be();
    });

  });

}));
