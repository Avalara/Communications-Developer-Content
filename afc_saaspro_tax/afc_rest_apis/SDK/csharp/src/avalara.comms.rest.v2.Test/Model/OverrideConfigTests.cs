/* 
 * SaasPro
 *
 * APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.
 *
 * The version of the OpenAPI document: v2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

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
    ///  Class for testing OverrideConfig
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class OverrideConfigTests
    {
        // TODO uncomment below to declare an instance variable for OverrideConfig
        //private OverrideConfig instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of OverrideConfig
            //instance = new OverrideConfig();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OverrideConfig
        /// </summary>
        [Test]
        public void OverrideConfigInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" OverrideConfig
            //Assert.IsInstanceOf(typeof(OverrideConfig), instance);
        }


        /// <summary>
        /// Test the property 'RawData'
        /// </summary>
        [Test]
        public void RawDataTest()
        {
            // TODO unit test for the property 'RawData'
        }

    }

}