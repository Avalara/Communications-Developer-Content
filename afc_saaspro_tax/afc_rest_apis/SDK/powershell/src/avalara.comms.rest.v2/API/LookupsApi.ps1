function Invoke-LookupsApiApiV2AfcLocationPcodeGet {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [Int32]
        ${pcode}
    )

    Process {
        'Calling method: LookupsApi-ApiV2AfcLocationPcodeGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:LookupsApi.ApiV2AfcLocationPcodeGet(
            ${pcode}
        )
    }
}

function Invoke-LookupsApiApiV2AfcPrimaryPCodeGet {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [Int32]
        ${pCode}
    )

    Process {
        'Calling method: LookupsApi-ApiV2AfcPrimaryPCodeGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:LookupsApi.ApiV2AfcPrimaryPCodeGet(
            ${pCode}
        )
    }
}

function Invoke-LookupsApiApiV2AfcServiceinfoGet {
    [CmdletBinding()]
    Param (
    )

    Process {
        'Calling method: LookupsApi-ApiV2AfcServiceinfoGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:LookupsApi.ApiV2AfcServiceinfoGet(
        )
    }
}

function Invoke-LookupsApiApiV2AfcTaxtypeTaxTypeGet {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${taxType}
    )

    Process {
        'Calling method: LookupsApi-ApiV2AfcTaxtypeTaxTypeGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:LookupsApi.ApiV2AfcTaxtypeTaxTypeGet(
            ${taxType}
        )
    }
}

function Invoke-LookupsApiApiV2AfcTspairsGet {
    [CmdletBinding()]
    Param (
    )

    Process {
        'Calling method: LookupsApi-ApiV2AfcTspairsGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:LookupsApi.ApiV2AfcTspairsGet(
        )
    }
}

