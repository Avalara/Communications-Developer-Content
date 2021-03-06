=begin
#SaasPro

#APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.

The version of the OpenAPI document: v2

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.0-SNAPSHOT

=end

require 'cgi'

module OpenapiClient
  class LookupsApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Get location data associated with a PCode
    # Request will return all jurisdictions associated with the PCode
    # @param pcode [Integer] 
    # @param [Hash] opts the optional parameters
    # @return [PCodeLookupResult]
    def api_v2_afc_location_pcode_get(pcode, opts = {})
      data, _status_code, _headers = api_v2_afc_location_pcode_get_with_http_info(pcode, opts)
      data
    end

    # Get location data associated with a PCode
    # Request will return all jurisdictions associated with the PCode
    # @param pcode [Integer] 
    # @param [Hash] opts the optional parameters
    # @return [Array<(PCodeLookupResult, Integer, Hash)>] PCodeLookupResult data, response status code and response headers
    def api_v2_afc_location_pcode_get_with_http_info(pcode, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: LookupsApi.api_v2_afc_location_pcode_get ...'
      end
      # verify the required parameter 'pcode' is set
      if @api_client.config.client_side_validation && pcode.nil?
        fail ArgumentError, "Missing the required parameter 'pcode' when calling LookupsApi.api_v2_afc_location_pcode_get"
      end
      # resource path
      local_var_path = '/api/v2/afc/location/{pcode}'.sub('{' + 'pcode' + '}', CGI.escape(pcode.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['text/plain', 'application/json', 'text/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      # return_type
      return_type = opts[:return_type] || 'PCodeLookupResult' 

      # auth_names
      auth_names = opts[:auth_names] || ['Basic']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: LookupsApi#api_v2_afc_location_pcode_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get primary location data associated with a PCode
    # Request will return primary jurisdiction associated with the PCode
    # @param p_code [Integer] 
    # @param [Hash] opts the optional parameters
    # @return [PCodeLookupResult]
    def api_v2_afc_primary_p_code_get(p_code, opts = {})
      data, _status_code, _headers = api_v2_afc_primary_p_code_get_with_http_info(p_code, opts)
      data
    end

    # Get primary location data associated with a PCode
    # Request will return primary jurisdiction associated with the PCode
    # @param p_code [Integer] 
    # @param [Hash] opts the optional parameters
    # @return [Array<(PCodeLookupResult, Integer, Hash)>] PCodeLookupResult data, response status code and response headers
    def api_v2_afc_primary_p_code_get_with_http_info(p_code, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: LookupsApi.api_v2_afc_primary_p_code_get ...'
      end
      # verify the required parameter 'p_code' is set
      if @api_client.config.client_side_validation && p_code.nil?
        fail ArgumentError, "Missing the required parameter 'p_code' when calling LookupsApi.api_v2_afc_primary_p_code_get"
      end
      # resource path
      local_var_path = '/api/v2/afc/primary/{pCode}'.sub('{' + 'pCode' + '}', CGI.escape(p_code.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['text/plain', 'application/json', 'text/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      # return_type
      return_type = opts[:return_type] || 'PCodeLookupResult' 

      # auth_names
      auth_names = opts[:auth_names] || ['Basic']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: LookupsApi#api_v2_afc_primary_p_code_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Retrieves server time, service build version and engine version
    # @param [Hash] opts the optional parameters
    # @return [ServiceInfo]
    def api_v2_afc_serviceinfo_get(opts = {})
      data, _status_code, _headers = api_v2_afc_serviceinfo_get_with_http_info(opts)
      data
    end

    # Retrieves server time, service build version and engine version
    # @param [Hash] opts the optional parameters
    # @return [Array<(ServiceInfo, Integer, Hash)>] ServiceInfo data, response status code and response headers
    def api_v2_afc_serviceinfo_get_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: LookupsApi.api_v2_afc_serviceinfo_get ...'
      end
      # resource path
      local_var_path = '/api/v2/afc/serviceinfo'

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['text/plain', 'application/json', 'text/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      # return_type
      return_type = opts[:return_type] || 'ServiceInfo' 

      # auth_names
      auth_names = opts[:auth_names] || ['Basic']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: LookupsApi#api_v2_afc_serviceinfo_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get the tax information (description and category) for a tax type ID
    # This method returns the description for the specified tax type ID. If tax type * is supplied it will return all tax types.
    # @param tax_type [String] Tax type ID for the tax type.
    # @param [Hash] opts the optional parameters
    # @return [Array<TaxTypeData>]
    def api_v2_afc_taxtype_tax_type_get(tax_type, opts = {})
      data, _status_code, _headers = api_v2_afc_taxtype_tax_type_get_with_http_info(tax_type, opts)
      data
    end

    # Get the tax information (description and category) for a tax type ID
    # This method returns the description for the specified tax type ID. If tax type * is supplied it will return all tax types.
    # @param tax_type [String] Tax type ID for the tax type.
    # @param [Hash] opts the optional parameters
    # @return [Array<(Array<TaxTypeData>, Integer, Hash)>] Array<TaxTypeData> data, response status code and response headers
    def api_v2_afc_taxtype_tax_type_get_with_http_info(tax_type, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: LookupsApi.api_v2_afc_taxtype_tax_type_get ...'
      end
      # resource path
      local_var_path = '/api/v2/afc/taxtype/{taxType}'.sub('{' + 'taxType' + '}', CGI.escape(tax_type.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['text/plain', 'application/json', 'text/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      # return_type
      return_type = opts[:return_type] || 'Array<TaxTypeData>' 

      # auth_names
      auth_names = opts[:auth_names] || ['Basic']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: LookupsApi#api_v2_afc_taxtype_tax_type_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get transaction/service pair information
    # This method returns the description for the transaction type, service type and the ts pairs.
    # @param [Hash] opts the optional parameters
    # @return [Array<TSPairData>]
    def api_v2_afc_tspairs_get(opts = {})
      data, _status_code, _headers = api_v2_afc_tspairs_get_with_http_info(opts)
      data
    end

    # Get transaction/service pair information
    # This method returns the description for the transaction type, service type and the ts pairs.
    # @param [Hash] opts the optional parameters
    # @return [Array<(Array<TSPairData>, Integer, Hash)>] Array<TSPairData> data, response status code and response headers
    def api_v2_afc_tspairs_get_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: LookupsApi.api_v2_afc_tspairs_get ...'
      end
      # resource path
      local_var_path = '/api/v2/afc/tspairs'

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['text/plain', 'application/json', 'text/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      # return_type
      return_type = opts[:return_type] || 'Array<TSPairData>' 

      # auth_names
      auth_names = opts[:auth_names] || ['Basic']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: LookupsApi#api_v2_afc_tspairs_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
