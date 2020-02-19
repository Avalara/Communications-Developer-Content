function New-Configuration {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.TrafficStudyOverride[]]
        ${TrafficStudyOverrides},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ReturnNonBillable},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${TaxOnTaxAlgorithm},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${SelfTaxAlgorithm}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.Configuration' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.Configuration -ArgumentList @(
            ${TrafficStudyOverrides},
            ${ReturnNonBillable},
            ${TaxOnTaxAlgorithm},
            ${SelfTaxAlgorithm}
        )
    }
}
