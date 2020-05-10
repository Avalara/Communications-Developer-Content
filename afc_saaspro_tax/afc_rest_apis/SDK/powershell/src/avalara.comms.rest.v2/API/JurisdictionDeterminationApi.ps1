function Invoke-JurisdictionDeterminationApiApiV2AfcPCodePost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [avalara.comms.rest.v2.Model.PCodeLookupRequest]
        ${pCodeLookupRequest}
    )

    Process {
        'Calling method: JurisdictionDeterminationApi-ApiV2AfcPCodePost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:JurisdictionDeterminationApi.ApiV2AfcPCodePost(
            ${pCodeLookupRequest}
        )
    }
}

function Invoke-JurisdictionDeterminationApiApiV2GeoBatchLogProcessIdGet {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${processId}
    )

    Process {
        'Calling method: JurisdictionDeterminationApi-ApiV2GeoBatchLogProcessIdGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:JurisdictionDeterminationApi.ApiV2GeoBatchLogProcessIdGet(
            ${processId}
        )
    }
}

function Invoke-JurisdictionDeterminationApiApiV2GeoBatchStatusProcessIdGet {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${processId}
    )

    Process {
        'Calling method: JurisdictionDeterminationApi-ApiV2GeoBatchStatusProcessIdGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:JurisdictionDeterminationApi.ApiV2GeoBatchStatusProcessIdGet(
            ${processId}
        )
    }
}

function Invoke-JurisdictionDeterminationApiApiV2GeoBatchUploadPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${geoBatchFile}
    )

    Process {
        'Calling method: JurisdictionDeterminationApi-ApiV2GeoBatchUploadPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:JurisdictionDeterminationApi.ApiV2GeoBatchUploadPost(
            ${geoBatchFile}
        )
    }
}

function Invoke-JurisdictionDeterminationApiApiV2GeoGeocodePost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [avalara.comms.rest.v2.Model.GeocodeRequest[]]
        ${geocodeRequest}
    )

    Process {
        'Calling method: JurisdictionDeterminationApi-ApiV2GeoGeocodePost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:JurisdictionDeterminationApi.ApiV2GeoGeocodePost(
            ${geocodeRequest}
        )
    }
}

