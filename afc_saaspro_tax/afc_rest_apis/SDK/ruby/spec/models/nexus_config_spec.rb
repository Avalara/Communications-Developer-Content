=begin
#SaasPro

#APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.

The version of the OpenAPI document: v2

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.0-SNAPSHOT

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for OpenapiClient::NexusConfig
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'NexusConfig' do
  before do
    # run before each test
    @instance = OpenapiClient::NexusConfig.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of NexusConfig' do
    it 'should create an instance of NexusConfig' do
      expect(@instance).to be_instance_of(OpenapiClient::NexusConfig)
    end
  end
  describe 'test attribute "state"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end