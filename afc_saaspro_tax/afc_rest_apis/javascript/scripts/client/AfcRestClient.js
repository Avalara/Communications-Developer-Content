/**
 * Client for AFC REST service. NOTE: Only APIs shown in this sample are implemented.
 * 
 * @param baseAddress   AFC REST service base address.
 * @param userName      User name for authentication.
 * @param password      Password for authentication.
 * @param clientId      client id provided by Avalara.
 * @param clientProfileId      client Profile Id provided by Avalara.
 */
function AfcRestClient(baseAddress, userName, password, clientId, clientProfileId) {

    this.authToken = btoa(userName + ":" + password);   // Encode the credentials to base 64
    this.baseAddress = baseAddress[baseAddress.length - 1] === "/" ?
        baseAddress.substring(0, baseAddress.length - 1) :
        baseAddress;
    this.clientId = clientId;
    this.clientProfileId = clientProfileId;

    /**
     * Get server time. 
     * Returns the server time in UTC.
     * 
     * @param success   Success callback function(Date) provides the server time in UTC.
     * @param error     Error callback function(String) provides an error message in case of failure.
     */
    this.getServerTime = function (success, error) {
        this._get(
            "/api/v1/Application/ServerTime",
            true,
            function (data) {
                if (success) {
                    var serverTime = new Date(data);
                    success(serverTime);
                }
            },
            function (errorMsg) {
                if (error)
                    error(errorMsg);
            });
    };

    /**
     * Determines the PCode for a location. 
     * 
     * @param request   RequestPCodeDetail object containing ZipAddress, FipsCode or NPANXX to be converted.
     * @param success   Success callback function(Number) provides the PCode for specified ZipAddress, FipsCode or NPANXX.
     * @param error     Error callback function(String) provides an error message in case of failure.
     */
    this.getPCode = function (request, success, error) {
        this._post(
            "/api/v1/Location/PCode",
            request,
            true,
            function (data) {
                if (success)
                    success(data);
            },
            function (errorMsg) {
                if (error)
                    error(errorMsg);
            });
    }

    /**
     * Get address information for a jurisdiction.
     * This method returns a list of addresses for the specified jurisdiction.
     * 
     * @param pcode PCode (Number data type) for jurisdiction.
     * @param success   Success callback function(Array) provides an array of AddressData containing 
     * address information for the jurisdiction.
     * @param error     Error callback function(String) provides an error message in case of failure
     */
    this.getAddress = function (pcode, success, error) {
        this._get(
            "/api/v1/Location/Address/" + pcode,
            true,
            function (data) {
                if (success)
                    success(data);
            },
            function (errorMsg) {
                if (error)
                    error(errorMsg);
            });
    }

    /**
     * Calculate taxes on a transaction.
     * Accepts transaction data and performs appropriate tax calculations.
     * 
     * @param transaction Transaction object.
     * @param success   Success callback function(Array) provides an array of TaxData objects that contain the information about the taxes applied.
     * @param error     Error callback function(String) provides an error message in case of failure.
     */
    this.calculateTaxes = function (transaction, success, error) {
        this._post(
            "/api/v1/CalculateTaxes",
            transaction,
            true,
            function (data) {
                if (success)
                    success(data);
            },
            function (errorMsg) {
                if (error)
                    error(errorMsg);
            });
    }

    /**
     * Calculate tax adjustments on transaction.
     * This method accepts transaction data and performs appropriate tax adjustment calculations.
     * 
     * @param transaction Transaction object.
     * @param success   Success callback function(Array) provides an array of TaxData objects that contain the information about the taxes applied.
     * @param error     Error callback function(String) provides an error message in case of failure.
     */
    this.calculateAdjustments = function (transaction, success, error) {
        this._post(
            "/api/v1/CalculateAdjustments",
            transaction,
            true,
            function (data) {
                if (success)
                    success(data);
            },
            function (errorMsg) {
                if (error)
                    error(errorMsg);
            });
    }

    /**
     * Calculate taxes on a bridge conference transaction.
     * This method will take a Billing address, Bridge Address, Host Address 
     * (optional) and list of participants. The system will determine which taxes 
     * apply for each participant and return the summarized taxes for the bridge 
     * conference transaction. The individual participant results are returned if 
     * ReturnParticipantResults is true.
     * 
     * @param transaction BridgeConferenceTransaction object containing conference transaction details 
     * and list of participants.
     * @param success   Success callback function(Object) provides a BridgeConferenceResults object 
     * containing an array of BridgeConferenceParticipantResult objects for each participant transaction 
     * processed and TaxData array containing the summarized taxes for the bridge conference calculation.
     * @param error     Error callback function(String) provides an error message in case of failure.
     */
    this.calculateBridgeConferenceTaxes = function (transaction, success, error) {
        this._post(
            "/api/v1/BridgeConference/Taxes",
            transaction,
            true,
            function (data) {
                if (success)
                    success(data);
            },
            function (errorMsg) {
                if (error)
                    error(errorMsg);
            });
    }

    /**
     * Calculate taxes using overrides.
     * Accepts transaction and tax rate override data to perform tax calculations 
     * with the provided override information.
     * 
     * @param request CalculateWithOverridesRequest object containing transaction data to be processed and tax rate override list.
     * @param success   Success callback function(Array) provides an array of TaxData objects that contain the information about the taxes applied.
     * @param error     Error callback function(String) provides an error message in case of failure.
     */
    this.calculateTaxesWithOverrides = function (request, success, error) {
        this._post(
            "/api/v1/CalculateWithOverrides/Taxes",
            request,
            true,
            function (data) {
                if (success)
                    success(data);
            },
            function (errorMsg) {
                if (error)
                    error(errorMsg);
            });
    }

    /**
     * Performs an AJAX GET request to the specified URL.
     * 
     * @param url URL for request.
     * @param async Flag indicating if request should be made asynchronously.
     * @param success Success callback function(data).
     * @param error Error callback function(errorMsg).
     */
    this._get = function (url, async, success, error) {
        $.get({
            async: async,
            headers: {
                "Authorization": "Basic " + this.authToken,
                "client_id": this.clientId.toString(),
                "client_profile_id":this.clientProfileId.toString()
            },
            url: this.baseAddress + url
        })
        .done(function (data) {
            if (success) {
                success(data);
            }
        })
        .fail(function (jqXHR, textStatus, errorThrown) {
            if (error) {
                var errorMsg = jqXHR.getResponseHeader("error");

                if (!errorMsg)
                    errorMsg = textStatus;

                error(errorMsg);
            }
        });
    }

    /**
     * Performs an AJAX POST request to the specified URL.
     * 
     * @param url URL for request.
     * @param param Parameter to be serialized as JSON string in request body.
     * @param async Flag indicating if request should be made asynchronously.
     * @param success Success callback function(data).
     * @param error Error callback function(errorMsg).
     */
    this._post = function (url, param, async, success, error) {
        $.post({
            async: async,
            contentType: "application/json",
            data: JSON.stringify(param, function (key, value) {
                if (typeof value === 'number' && !value) {
                    return 0;
                }
                return value;
            }),
            headers: {
                "Authorization": "Basic " + this.authToken,
                "client_id": this.clientId.toString(),
                "client_profile_id": this.clientProfileId.toString()
            },
            url: this.baseAddress + url
        })
        .done(function (data) {
            if (success) {
                success(data);
            }
        })
        .fail(function (jqXHR, textStatus, errorThrown) {
            if (error) {
                var errorMsg = jqXHR.getResponseHeader("error");

                if (!errorMsg)
                    errorMsg = textStatus;

                error(errorMsg);
            }
        });
    }
}