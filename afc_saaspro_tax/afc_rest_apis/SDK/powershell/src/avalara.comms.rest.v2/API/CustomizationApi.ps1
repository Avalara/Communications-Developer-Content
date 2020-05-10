function Invoke-CustomizationApiApiV2ProfilesGetProfilesGet {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [Int32]
        ${requestedClientId},
        [Parameter(Position = 1, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [Int32]
        ${requestedProfileId},
        [Parameter(Position = 2, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [avalara.comms.rest.v2.Model.avalara.comms.rest.v2.Model.TaxCalculationSettingTypes]
        ${itemType}
    )

    Process {
        'Calling method: CustomizationApi-ApiV2ProfilesGetProfilesGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:CustomizationApi.ApiV2ProfilesGetProfilesGet(
            ${requestedClientId},
            ${requestedProfileId},
            ${itemType}
        )
    }
}

