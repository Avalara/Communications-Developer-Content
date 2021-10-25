<?php
require(__DIR__ . '/../vendor/autoload.php');

// Configure HTTP basic authorization: Basic
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()
              ->setUsername('YOUR_USERNAME')
              ->setPassword('YOUR_PASSWORD')
              ->setHost('https://communicationsua.avalara.net');

// Set Client ID
$clientId = 0;
// Profile 0 = default profile (no customizations)
$profileId = 0;

$apiInstance = new OpenAPI\Client\Api\LookupsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(['headers' => ['client_id' => $client_id, 'client_profile_id' => $profileId]]),
    $config
);

// Seattle, WA, USA
$pCode = 4133800;

try {
    $result = $apiInstance->apiV2AfcLocationPCodeGet($pCode);
    print_r($result);
}
catch (Exception $e) {
    echo 'Exception: ', $e->getMessage(), PHP_EOL;
}
?>