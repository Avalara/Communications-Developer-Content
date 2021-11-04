/*
 * SaasPro
 * APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.<br /><br />Effective January 1st, 2022 all Avalara products will be enforcing TLS 1.2 server-side. Please ensure that your implementation sets a minimal of TLS 1.2 encryption when making web requests to Avalara APIs.
 *
 * The version of the OpenAPI document: v2
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.BundleItem;
import org.openapitools.jackson.nullable.JsonNullable;
import org.junit.Assert;
import org.junit.Ignore;
import org.junit.Test;


/**
 * Model tests for BundleConfig
 */
public class BundleConfigTest {
    private final BundleConfig model = new BundleConfig();

    /**
     * Model tests for BundleConfig
     */
    @Test
    public void testBundleConfig() {
        // TODO: test BundleConfig
    }

    /**
     * Test the property 'bundlePackage'
     */
    @Test
    public void bundlePackageTest() {
        // TODO: test bundlePackage
    }

    /**
     * Test the property 'bundleId'
     */
    @Test
    public void bundleIdTest() {
        // TODO: test bundleId
    }

    /**
     * Test the property 'description'
     */
    @Test
    public void descriptionTest() {
        // TODO: test description
    }

    /**
     * Test the property 'bundleItems'
     */
    @Test
    public void bundleItemsTest() {
        // TODO: test bundleItems
    }

    /**
     * Test the property 'version'
     */
    @Test
    public void versionTest() {
        // TODO: test version
    }

}
