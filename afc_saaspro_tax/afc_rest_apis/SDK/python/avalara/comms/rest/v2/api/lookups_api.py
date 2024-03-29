# coding: utf-8

"""
    SaasPro

    APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.<br /><br />Effective January 1st, 2022 all Avalara products will be enforcing TLS 1.2 server-side. Please ensure that your implementation sets a minimal of TLS 1.2 encryption when making web requests to Avalara APIs.  # noqa: E501

    The version of the OpenAPI document: v2
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import re  # noqa: F401

# python 2 and python 3 compatibility library
import six

from avalara.comms.rest.v2.api_client import ApiClient
from avalara.comms.rest.v2.exceptions import (  # noqa: F401
    ApiTypeError,
    ApiValueError
)


class LookupsApi(object):
    """NOTE: This class is auto generated by OpenAPI Generator
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client

    def api_v2_afc_location_p_code_get(self, p_code, **kwargs):  # noqa: E501
        """Get location data associated with a PCode  # noqa: E501

        Request will return all jurisdictions associated with the PCode  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.api_v2_afc_location_p_code_get(p_code, async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param int p_code: (required)
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: PCodeLookupResult
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        return self.api_v2_afc_location_p_code_get_with_http_info(p_code, **kwargs)  # noqa: E501

    def api_v2_afc_location_p_code_get_with_http_info(self, p_code, **kwargs):  # noqa: E501
        """Get location data associated with a PCode  # noqa: E501

        Request will return all jurisdictions associated with the PCode  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.api_v2_afc_location_p_code_get_with_http_info(p_code, async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param int p_code: (required)
        :param _return_http_data_only: response data without head status code
                                       and headers
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: tuple(PCodeLookupResult, status_code(int), headers(HTTPHeaderDict))
                 If the method is called asynchronously,
                 returns the request thread.
        """

        local_var_params = locals()

        all_params = [
            'p_code'
        ]
        all_params.extend(
            [
                'async_req',
                '_return_http_data_only',
                '_preload_content',
                '_request_timeout'
            ]
        )

        for key, val in six.iteritems(local_var_params['kwargs']):
            if key not in all_params:
                raise ApiTypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method api_v2_afc_location_p_code_get" % key
                )
            local_var_params[key] = val
        del local_var_params['kwargs']
        # verify the required parameter 'p_code' is set
        if self.api_client.client_side_validation and ('p_code' not in local_var_params or  # noqa: E501
                                                        local_var_params['p_code'] is None):  # noqa: E501
            raise ApiValueError("Missing the required parameter `p_code` when calling `api_v2_afc_location_p_code_get`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'p_code' in local_var_params:
            path_params['pCode'] = local_var_params['p_code']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['text/plain', 'application/json', 'text/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['Basic']  # noqa: E501

        return self.api_client.call_api(
            '/api/v2/afc/location/{pCode}', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='PCodeLookupResult',  # noqa: E501
            auth_settings=auth_settings,
            async_req=local_var_params.get('async_req'),
            _return_http_data_only=local_var_params.get('_return_http_data_only'),  # noqa: E501
            _preload_content=local_var_params.get('_preload_content', True),
            _request_timeout=local_var_params.get('_request_timeout'),
            collection_formats=collection_formats)

    def api_v2_afc_primary_p_code_get(self, p_code, **kwargs):  # noqa: E501
        """Get primary location data associated with a PCode  # noqa: E501

        Request will return primary jurisdiction associated with the PCode  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.api_v2_afc_primary_p_code_get(p_code, async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param int p_code: (required)
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: PCodeLookupResult
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        return self.api_v2_afc_primary_p_code_get_with_http_info(p_code, **kwargs)  # noqa: E501

    def api_v2_afc_primary_p_code_get_with_http_info(self, p_code, **kwargs):  # noqa: E501
        """Get primary location data associated with a PCode  # noqa: E501

        Request will return primary jurisdiction associated with the PCode  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.api_v2_afc_primary_p_code_get_with_http_info(p_code, async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param int p_code: (required)
        :param _return_http_data_only: response data without head status code
                                       and headers
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: tuple(PCodeLookupResult, status_code(int), headers(HTTPHeaderDict))
                 If the method is called asynchronously,
                 returns the request thread.
        """

        local_var_params = locals()

        all_params = [
            'p_code'
        ]
        all_params.extend(
            [
                'async_req',
                '_return_http_data_only',
                '_preload_content',
                '_request_timeout'
            ]
        )

        for key, val in six.iteritems(local_var_params['kwargs']):
            if key not in all_params:
                raise ApiTypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method api_v2_afc_primary_p_code_get" % key
                )
            local_var_params[key] = val
        del local_var_params['kwargs']
        # verify the required parameter 'p_code' is set
        if self.api_client.client_side_validation and ('p_code' not in local_var_params or  # noqa: E501
                                                        local_var_params['p_code'] is None):  # noqa: E501
            raise ApiValueError("Missing the required parameter `p_code` when calling `api_v2_afc_primary_p_code_get`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'p_code' in local_var_params:
            path_params['pCode'] = local_var_params['p_code']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['text/plain', 'application/json', 'text/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['Basic']  # noqa: E501

        return self.api_client.call_api(
            '/api/v2/afc/primary/{pCode}', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='PCodeLookupResult',  # noqa: E501
            auth_settings=auth_settings,
            async_req=local_var_params.get('async_req'),
            _return_http_data_only=local_var_params.get('_return_http_data_only'),  # noqa: E501
            _preload_content=local_var_params.get('_preload_content', True),
            _request_timeout=local_var_params.get('_request_timeout'),
            collection_formats=collection_formats)

    def api_v2_afc_serviceinfo_get(self, **kwargs):  # noqa: E501
        """Retrieves server time, service build version and engine version  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.api_v2_afc_serviceinfo_get(async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: ServiceInfo
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        return self.api_v2_afc_serviceinfo_get_with_http_info(**kwargs)  # noqa: E501

    def api_v2_afc_serviceinfo_get_with_http_info(self, **kwargs):  # noqa: E501
        """Retrieves server time, service build version and engine version  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.api_v2_afc_serviceinfo_get_with_http_info(async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param _return_http_data_only: response data without head status code
                                       and headers
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: tuple(ServiceInfo, status_code(int), headers(HTTPHeaderDict))
                 If the method is called asynchronously,
                 returns the request thread.
        """

        local_var_params = locals()

        all_params = [
        ]
        all_params.extend(
            [
                'async_req',
                '_return_http_data_only',
                '_preload_content',
                '_request_timeout'
            ]
        )

        for key, val in six.iteritems(local_var_params['kwargs']):
            if key not in all_params:
                raise ApiTypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method api_v2_afc_serviceinfo_get" % key
                )
            local_var_params[key] = val
        del local_var_params['kwargs']

        collection_formats = {}

        path_params = {}

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['text/plain', 'application/json', 'text/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['Basic']  # noqa: E501

        return self.api_client.call_api(
            '/api/v2/afc/serviceinfo', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='ServiceInfo',  # noqa: E501
            auth_settings=auth_settings,
            async_req=local_var_params.get('async_req'),
            _return_http_data_only=local_var_params.get('_return_http_data_only'),  # noqa: E501
            _preload_content=local_var_params.get('_preload_content', True),
            _request_timeout=local_var_params.get('_request_timeout'),
            collection_formats=collection_formats)

    def api_v2_afc_taxtype_tax_type_get(self, tax_type, **kwargs):  # noqa: E501
        """Get the tax information (description and category) for a tax type ID  # noqa: E501

        This method returns the description for the specified tax type ID. If tax type * is supplied it will return all tax types.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.api_v2_afc_taxtype_tax_type_get(tax_type, async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param str tax_type: Tax type ID for the tax type. (required)
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: list[TaxTypeData]
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        return self.api_v2_afc_taxtype_tax_type_get_with_http_info(tax_type, **kwargs)  # noqa: E501

    def api_v2_afc_taxtype_tax_type_get_with_http_info(self, tax_type, **kwargs):  # noqa: E501
        """Get the tax information (description and category) for a tax type ID  # noqa: E501

        This method returns the description for the specified tax type ID. If tax type * is supplied it will return all tax types.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.api_v2_afc_taxtype_tax_type_get_with_http_info(tax_type, async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param str tax_type: Tax type ID for the tax type. (required)
        :param _return_http_data_only: response data without head status code
                                       and headers
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: tuple(list[TaxTypeData], status_code(int), headers(HTTPHeaderDict))
                 If the method is called asynchronously,
                 returns the request thread.
        """

        local_var_params = locals()

        all_params = [
            'tax_type'
        ]
        all_params.extend(
            [
                'async_req',
                '_return_http_data_only',
                '_preload_content',
                '_request_timeout'
            ]
        )

        for key, val in six.iteritems(local_var_params['kwargs']):
            if key not in all_params:
                raise ApiTypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method api_v2_afc_taxtype_tax_type_get" % key
                )
            local_var_params[key] = val
        del local_var_params['kwargs']
        # verify the required parameter 'tax_type' is set
        if self.api_client.client_side_validation and ('tax_type' not in local_var_params or  # noqa: E501
                                                        local_var_params['tax_type'] is None):  # noqa: E501
            raise ApiValueError("Missing the required parameter `tax_type` when calling `api_v2_afc_taxtype_tax_type_get`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'tax_type' in local_var_params:
            path_params['taxType'] = local_var_params['tax_type']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['text/plain', 'application/json', 'text/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['Basic']  # noqa: E501

        return self.api_client.call_api(
            '/api/v2/afc/taxtype/{taxType}', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='list[TaxTypeData]',  # noqa: E501
            auth_settings=auth_settings,
            async_req=local_var_params.get('async_req'),
            _return_http_data_only=local_var_params.get('_return_http_data_only'),  # noqa: E501
            _preload_content=local_var_params.get('_preload_content', True),
            _request_timeout=local_var_params.get('_request_timeout'),
            collection_formats=collection_formats)

    def api_v2_afc_tspairs_get(self, **kwargs):  # noqa: E501
        """Get transaction/service pair information  # noqa: E501

        This method returns the description for the transaction type, service type and the ts pairs.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.api_v2_afc_tspairs_get(async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: list[TsPairData]
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        return self.api_v2_afc_tspairs_get_with_http_info(**kwargs)  # noqa: E501

    def api_v2_afc_tspairs_get_with_http_info(self, **kwargs):  # noqa: E501
        """Get transaction/service pair information  # noqa: E501

        This method returns the description for the transaction type, service type and the ts pairs.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.api_v2_afc_tspairs_get_with_http_info(async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param _return_http_data_only: response data without head status code
                                       and headers
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: tuple(list[TsPairData], status_code(int), headers(HTTPHeaderDict))
                 If the method is called asynchronously,
                 returns the request thread.
        """

        local_var_params = locals()

        all_params = [
        ]
        all_params.extend(
            [
                'async_req',
                '_return_http_data_only',
                '_preload_content',
                '_request_timeout'
            ]
        )

        for key, val in six.iteritems(local_var_params['kwargs']):
            if key not in all_params:
                raise ApiTypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method api_v2_afc_tspairs_get" % key
                )
            local_var_params[key] = val
        del local_var_params['kwargs']

        collection_formats = {}

        path_params = {}

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['text/plain', 'application/json', 'text/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['Basic']  # noqa: E501

        return self.api_client.call_api(
            '/api/v2/afc/tspairs', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='list[TsPairData]',  # noqa: E501
            auth_settings=auth_settings,
            async_req=local_var_params.get('async_req'),
            _return_http_data_only=local_var_params.get('_return_http_data_only'),  # noqa: E501
            _preload_content=local_var_params.get('_preload_content', True),
            _request_timeout=local_var_params.get('_request_timeout'),
            collection_formats=collection_formats)
