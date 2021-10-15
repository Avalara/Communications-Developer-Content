<?php
/**
 * CustomizationApi
 * PHP version 7.3
 *
 * @category Class
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */

/**
 * SaasPro
 *
 * APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.<br /><br />Effective January 1st, 2022 all Avalara products will be enforcing TLS 1.2 server-side. Please ensure that your implementation sets a minimal of TLS 1.2 encryption when making web requests to Avalara APIs.
 *
 * The version of the OpenAPI document: v2
 * Generated by: https://openapi-generator.tech
 * OpenAPI Generator version: 5.2.1
 */

/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

namespace OpenAPI\Client\Api;

use GuzzleHttp\Client;
use GuzzleHttp\ClientInterface;
use GuzzleHttp\Exception\RequestException;
use GuzzleHttp\Psr7\MultipartStream;
use GuzzleHttp\Psr7\Request;
use GuzzleHttp\RequestOptions;
use OpenAPI\Client\ApiException;
use OpenAPI\Client\Configuration;
use OpenAPI\Client\HeaderSelector;
use OpenAPI\Client\ObjectSerializer;

/**
 * CustomizationApi Class Doc Comment
 *
 * @category Class
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */
class CustomizationApi
{
    /**
     * @var ClientInterface
     */
    protected $client;

    /**
     * @var Configuration
     */
    protected $config;

    /**
     * @var HeaderSelector
     */
    protected $headerSelector;

    /**
     * @var int Host index
     */
    protected $hostIndex;

    /**
     * @param ClientInterface $client
     * @param Configuration   $config
     * @param HeaderSelector  $selector
     * @param int             $hostIndex (Optional) host index to select the list of hosts if defined in the OpenAPI spec
     */
    public function __construct(
        ClientInterface $client = null,
        Configuration $config = null,
        HeaderSelector $selector = null,
        $hostIndex = 0
    ) {
        $this->client = $client ?: new Client();
        $this->config = $config ?: new Configuration();
        $this->headerSelector = $selector ?: new HeaderSelector();
        $this->hostIndex = $hostIndex;
    }

    /**
     * Set the host index
     *
     * @param int $hostIndex Host index (required)
     */
    public function setHostIndex($hostIndex): void
    {
        $this->hostIndex = $hostIndex;
    }

    /**
     * Get the host index
     *
     * @return int Host index
     */
    public function getHostIndex()
    {
        return $this->hostIndex;
    }

    /**
     * @return Configuration
     */
    public function getConfig()
    {
        return $this->config;
    }

    /**
     * Operation apiV2ProfilesGetProfilesGet
     *
     * Retrieves one or more profiles with associated settings and configurable items
     *
     * @param  int $requested_client_id Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable. (optional)
     * @param  int $requested_profile_id Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set. (optional)
     * @param  \OpenAPI\Client\Model\ClientProfileConfigTypes $item_type Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All (optional)
     *
     * @throws \OpenAPI\Client\ApiException on non-2xx response
     * @throws \InvalidArgumentException
     * @return \OpenAPI\Client\Model\ClientProfileConfigResponse[]
     */
    public function apiV2ProfilesGetProfilesGet($requested_client_id = null, $requested_profile_id = null, $item_type = null)
    {
        list($response) = $this->apiV2ProfilesGetProfilesGetWithHttpInfo($requested_client_id, $requested_profile_id, $item_type);
        return $response;
    }

    /**
     * Operation apiV2ProfilesGetProfilesGetWithHttpInfo
     *
     * Retrieves one or more profiles with associated settings and configurable items
     *
     * @param  int $requested_client_id Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable. (optional)
     * @param  int $requested_profile_id Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set. (optional)
     * @param  \OpenAPI\Client\Model\ClientProfileConfigTypes $item_type Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All (optional)
     *
     * @throws \OpenAPI\Client\ApiException on non-2xx response
     * @throws \InvalidArgumentException
     * @return array of \OpenAPI\Client\Model\ClientProfileConfigResponse[], HTTP status code, HTTP response headers (array of strings)
     */
    public function apiV2ProfilesGetProfilesGetWithHttpInfo($requested_client_id = null, $requested_profile_id = null, $item_type = null)
    {
        $request = $this->apiV2ProfilesGetProfilesGetRequest($requested_client_id, $requested_profile_id, $item_type);

        try {
            $options = $this->createHttpClientOption();
            try {
                $response = $this->client->send($request, $options);
            } catch (RequestException $e) {
                throw new ApiException(
                    "[{$e->getCode()}] {$e->getMessage()}",
                    (int) $e->getCode(),
                    $e->getResponse() ? $e->getResponse()->getHeaders() : null,
                    $e->getResponse() ? (string) $e->getResponse()->getBody() : null
                );
            }

            $statusCode = $response->getStatusCode();

            if ($statusCode < 200 || $statusCode > 299) {
                throw new ApiException(
                    sprintf(
                        '[%d] Error connecting to the API (%s)',
                        $statusCode,
                        (string) $request->getUri()
                    ),
                    $statusCode,
                    $response->getHeaders(),
                    (string) $response->getBody()
                );
            }

            switch($statusCode) {
                case 200:
                    if ('\OpenAPI\Client\Model\ClientProfileConfigResponse[]' === '\SplFileObject') {
                        $content = $response->getBody(); //stream goes to serializer
                    } else {
                        $content = (string) $response->getBody();
                    }

                    return [
                        ObjectSerializer::deserialize($content, '\OpenAPI\Client\Model\ClientProfileConfigResponse[]', []),
                        $response->getStatusCode(),
                        $response->getHeaders()
                    ];
            }

            $returnType = '\OpenAPI\Client\Model\ClientProfileConfigResponse[]';
            if ($returnType === '\SplFileObject') {
                $content = $response->getBody(); //stream goes to serializer
            } else {
                $content = (string) $response->getBody();
            }

            return [
                ObjectSerializer::deserialize($content, $returnType, []),
                $response->getStatusCode(),
                $response->getHeaders()
            ];

        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = ObjectSerializer::deserialize(
                        $e->getResponseBody(),
                        '\OpenAPI\Client\Model\ClientProfileConfigResponse[]',
                        $e->getResponseHeaders()
                    );
                    $e->setResponseObject($data);
                    break;
            }
            throw $e;
        }
    }

    /**
     * Operation apiV2ProfilesGetProfilesGetAsync
     *
     * Retrieves one or more profiles with associated settings and configurable items
     *
     * @param  int $requested_client_id Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable. (optional)
     * @param  int $requested_profile_id Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set. (optional)
     * @param  \OpenAPI\Client\Model\ClientProfileConfigTypes $item_type Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All (optional)
     *
     * @throws \InvalidArgumentException
     * @return \GuzzleHttp\Promise\PromiseInterface
     */
    public function apiV2ProfilesGetProfilesGetAsync($requested_client_id = null, $requested_profile_id = null, $item_type = null)
    {
        return $this->apiV2ProfilesGetProfilesGetAsyncWithHttpInfo($requested_client_id, $requested_profile_id, $item_type)
            ->then(
                function ($response) {
                    return $response[0];
                }
            );
    }

    /**
     * Operation apiV2ProfilesGetProfilesGetAsyncWithHttpInfo
     *
     * Retrieves one or more profiles with associated settings and configurable items
     *
     * @param  int $requested_client_id Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable. (optional)
     * @param  int $requested_profile_id Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set. (optional)
     * @param  \OpenAPI\Client\Model\ClientProfileConfigTypes $item_type Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All (optional)
     *
     * @throws \InvalidArgumentException
     * @return \GuzzleHttp\Promise\PromiseInterface
     */
    public function apiV2ProfilesGetProfilesGetAsyncWithHttpInfo($requested_client_id = null, $requested_profile_id = null, $item_type = null)
    {
        $returnType = '\OpenAPI\Client\Model\ClientProfileConfigResponse[]';
        $request = $this->apiV2ProfilesGetProfilesGetRequest($requested_client_id, $requested_profile_id, $item_type);

        return $this->client
            ->sendAsync($request, $this->createHttpClientOption())
            ->then(
                function ($response) use ($returnType) {
                    if ($returnType === '\SplFileObject') {
                        $content = $response->getBody(); //stream goes to serializer
                    } else {
                        $content = (string) $response->getBody();
                    }

                    return [
                        ObjectSerializer::deserialize($content, $returnType, []),
                        $response->getStatusCode(),
                        $response->getHeaders()
                    ];
                },
                function ($exception) {
                    $response = $exception->getResponse();
                    $statusCode = $response->getStatusCode();
                    throw new ApiException(
                        sprintf(
                            '[%d] Error connecting to the API (%s)',
                            $statusCode,
                            $exception->getRequest()->getUri()
                        ),
                        $statusCode,
                        $response->getHeaders(),
                        (string) $response->getBody()
                    );
                }
            );
    }

    /**
     * Create request for operation 'apiV2ProfilesGetProfilesGet'
     *
     * @param  int $requested_client_id Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable. (optional)
     * @param  int $requested_profile_id Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set. (optional)
     * @param  \OpenAPI\Client\Model\ClientProfileConfigTypes $item_type Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All (optional)
     *
     * @throws \InvalidArgumentException
     * @return \GuzzleHttp\Psr7\Request
     */
    public function apiV2ProfilesGetProfilesGetRequest($requested_client_id = null, $requested_profile_id = null, $item_type = null)
    {

        $resourcePath = '/api/v2/profiles/GetProfiles';
        $formParams = [];
        $queryParams = [];
        $headerParams = [];
        $httpBody = '';
        $multipart = false;

        // query params
        if ($requested_client_id !== null) {
            if('form' === 'form' && is_array($requested_client_id)) {
                foreach($requested_client_id as $key => $value) {
                    $queryParams[$key] = $value;
                }
            }
            else {
                $queryParams['RequestedClientId'] = $requested_client_id;
            }
        }
        // query params
        if ($requested_profile_id !== null) {
            if('form' === 'form' && is_array($requested_profile_id)) {
                foreach($requested_profile_id as $key => $value) {
                    $queryParams[$key] = $value;
                }
            }
            else {
                $queryParams['RequestedProfileId'] = $requested_profile_id;
            }
        }
        // query params
        if ($item_type !== null) {
            if('form' === 'form' && is_array($item_type)) {
                foreach($item_type as $key => $value) {
                    $queryParams[$key] = $value;
                }
            }
            else {
                $queryParams['ItemType'] = $item_type;
            }
        }




        if ($multipart) {
            $headers = $this->headerSelector->selectHeadersForMultipart(
                ['text/plain', 'application/json', 'text/json']
            );
        } else {
            $headers = $this->headerSelector->selectHeaders(
                ['text/plain', 'application/json', 'text/json'],
                []
            );
        }

        // for model (json/xml)
        if (count($formParams) > 0) {
            if ($multipart) {
                $multipartContents = [];
                foreach ($formParams as $formParamName => $formParamValue) {
                    $formParamValueItems = is_array($formParamValue) ? $formParamValue : [$formParamValue];
                    foreach ($formParamValueItems as $formParamValueItem) {
                        $multipartContents[] = [
                            'name' => $formParamName,
                            'contents' => $formParamValueItem
                        ];
                    }
                }
                // for HTTP post (form)
                $httpBody = new MultipartStream($multipartContents);

            } elseif ($headers['Content-Type'] === 'application/json') {
                $httpBody = \GuzzleHttp\json_encode($formParams);

            } else {
                // for HTTP post (form)
                $httpBody = \GuzzleHttp\Psr7\build_query($formParams);
            }
        }

        // this endpoint requires HTTP basic authentication
        if (!empty($this->config->getUsername()) || !(empty($this->config->getPassword()))) {
            $headers['Authorization'] = 'Basic ' . base64_encode($this->config->getUsername() . ":" . $this->config->getPassword());
        }

        $defaultHeaders = [];
        if ($this->config->getUserAgent()) {
            $defaultHeaders['User-Agent'] = $this->config->getUserAgent();
        }

        $headers = array_merge(
            $defaultHeaders,
            $headerParams,
            $headers
        );

        $query = \GuzzleHttp\Psr7\build_query($queryParams);
        return new Request(
            'GET',
            $this->config->getHost() . $resourcePath . ($query ? "?{$query}" : ''),
            $headers,
            $httpBody
        );
    }

    /**
     * Create http client option
     *
     * @throws \RuntimeException on file opening failure
     * @return array of http client options
     */
    protected function createHttpClientOption()
    {
        $options = [];
        if ($this->config->getDebug()) {
            $options[RequestOptions::DEBUG] = fopen($this->config->getDebugFile(), 'a');
            if (!$options[RequestOptions::DEBUG]) {
                throw new \RuntimeException('Failed to open the debug file: ' . $this->config->getDebugFile());
            }
        }

        return $options;
    }
}
