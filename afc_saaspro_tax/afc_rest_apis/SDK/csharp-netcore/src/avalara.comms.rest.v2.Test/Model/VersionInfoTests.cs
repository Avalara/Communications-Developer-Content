/* 
 * SaasPro
 *
 * APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.<br /><br />Effective January 1st, 2022 all Avalara products will be enforcing TLS 1.2 server-side. Please ensure that your implementation sets a minimal of TLS 1.2 encryption when making web requests to Avalara APIs.
 *
 * The version of the OpenAPI document: v2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Model;
using avalara.comms.rest.v2.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace avalara.comms.rest.v2.Test
{
    /// <summary>
    ///  Class for testing VersionInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class VersionInfoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for VersionInfo
        //private VersionInfo instance;

        public VersionInfoTests()
        {
            // TODO uncomment below to create an instance of VersionInfo
            //instance = new VersionInfo();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VersionInfo
        /// </summary>
        [Fact]
        public void VersionInfoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" VersionInfo
            //Assert.IsInstanceOfType<VersionInfo> (instance, "variable 'instance' is a VersionInfo");
        }


        /// <summary>
        /// Test the property 'AfcEngineVersion'
        /// </summary>
        [Fact]
        public void AfcEngineVersionTest()
        {
            // TODO unit test for the property 'AfcEngineVersion'
        }
        /// <summary>
        /// Test the property 'BuildVersion'
        /// </summary>
        [Fact]
        public void BuildVersionTest()
        {
            // TODO unit test for the property 'BuildVersion'
        }

    }

}
