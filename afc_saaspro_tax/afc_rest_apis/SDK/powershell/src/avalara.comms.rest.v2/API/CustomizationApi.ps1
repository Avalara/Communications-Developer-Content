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

function Invoke-CustomizationApiApiV2ProfilesSetBundlesPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [avalara.comms.rest.v2.Model.SetTaxCalculationSettingRequest]
        ${setTaxCalculationSettingRequest}
    )

    Process {
        'Calling method: CustomizationApi-ApiV2ProfilesSetBundlesPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:CustomizationApi.ApiV2ProfilesSetBundlesPost(
            ${setTaxCalculationSettingRequest}
        )
    }
}

function Invoke-CustomizationApiApiV2ProfilesSetConfigPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [avalara.comms.rest.v2.Model.SetTaxCalculationSettingRequest]
        ${setTaxCalculationSettingRequest}
    )

    Process {
        'Calling method: CustomizationApi-ApiV2ProfilesSetConfigPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:CustomizationApi.ApiV2ProfilesSetConfigPost(
            ${setTaxCalculationSettingRequest}
        )
    }
}

function Invoke-CustomizationApiApiV2ProfilesSetExclusionsPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [avalara.comms.rest.v2.Model.SetTaxCalculationSettingRequest]
        ${setTaxCalculationSettingRequest}
    )

    Process {
        'Calling method: CustomizationApi-ApiV2ProfilesSetExclusionsPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:CustomizationApi.ApiV2ProfilesSetExclusionsPost(
            ${setTaxCalculationSettingRequest}
        )
    }
}

function Invoke-CustomizationApiApiV2ProfilesSetOverridesPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [avalara.comms.rest.v2.Model.SetTaxCalculationSettingRequest]
        ${setTaxCalculationSettingRequest}
    )

    Process {
        'Calling method: CustomizationApi-ApiV2ProfilesSetOverridesPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:CustomizationApi.ApiV2ProfilesSetOverridesPost(
            ${setTaxCalculationSettingRequest}
        )
    }
}

