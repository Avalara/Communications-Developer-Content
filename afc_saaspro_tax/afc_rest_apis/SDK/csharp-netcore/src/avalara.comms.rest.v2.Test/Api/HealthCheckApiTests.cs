/*
 * SaasPro
 *
 * APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.<br /><br />Effective January 1st, 2022 all Avalara products will be enforcing TLS 1.2 server-side. Please ensure that your implementation sets a minimal of TLS 1.2 encryption when making web requests to Avalara APIs.
 *
 * The version of the OpenAPI document: v2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Api;

namespace avalara.comms.rest.v2.Test.Api
{
    /// <summary>
    ///  Class for testing HealthCheckApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class HealthCheckApiTests : IDisposable
    {
        private HealthCheckApi instance;

        public HealthCheckApiTests()
        {
            instance = new HealthCheckApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of HealthCheckApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' HealthCheckApi
            //Assert.IsType<HealthCheckApi>(instance);
        }

        /// <summary>
        /// Test ApiV2HealthCheckGet
        /// </summary>
        [Fact]
        public void ApiV2HealthCheckGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ApiV2HealthCheckGet();
        }
    }
}
