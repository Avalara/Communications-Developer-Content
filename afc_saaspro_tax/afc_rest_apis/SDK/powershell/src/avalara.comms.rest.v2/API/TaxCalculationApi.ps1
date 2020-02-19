function Invoke-TaxCalculationApiApiV2AfcCalcTaxesPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [avalara.comms.rest.v2.Model.CalcTaxesRequest]
        ${calcTaxesRequest}
    )

    Process {
        'Calling method: TaxCalculationApi-ApiV2AfcCalcTaxesPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:TaxCalculationApi.ApiV2AfcCalcTaxesPost(
            ${calcTaxesRequest}
        )
    }
}

function Invoke-TaxCalculationApiApiV2AfcCommitPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [avalara.comms.rest.v2.Model.CommitRequest]
        ${commitRequest}
    )

    Process {
        'Calling method: TaxCalculationApi-ApiV2AfcCommitPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:TaxCalculationApi.ApiV2AfcCommitPost(
            ${commitRequest}
        )
    }
}

