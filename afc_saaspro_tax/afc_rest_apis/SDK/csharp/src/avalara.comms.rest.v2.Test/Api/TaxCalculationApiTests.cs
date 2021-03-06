/* 
 * SaasPro
 *
 * APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.
 *
 * The version of the OpenAPI document: v2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Model;

namespace avalara.comms.rest.v2.Test
{
    /// <summary>
    ///  Class for testing TaxCalculationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TaxCalculationApiTests
    {
        private TaxCalculationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TaxCalculationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TaxCalculationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' TaxCalculationApi
            //Assert.IsInstanceOf(typeof(TaxCalculationApi), instance);
        }

        
        /// <summary>
        /// Test ApiV2AfcCalcTaxesPost
        /// </summary>
        [Test]
        public void ApiV2AfcCalcTaxesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CalcTaxesRequest calcTaxesRequest = null;
            //var response = instance.ApiV2AfcCalcTaxesPost(calcTaxesRequest);
            //Assert.IsInstanceOf(typeof(CalcTaxesResponse), response, "response is CalcTaxesResponse");
        }
        
        /// <summary>
        /// Test ApiV2AfcCommitPost
        /// </summary>
        [Test]
        public void ApiV2AfcCommitPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CommitRequest commitRequest = null;
            //var response = instance.ApiV2AfcCommitPost(commitRequest);
            //Assert.IsInstanceOf(typeof(CommitResponse), response, "response is CommitResponse");
        }
        
    }

}
