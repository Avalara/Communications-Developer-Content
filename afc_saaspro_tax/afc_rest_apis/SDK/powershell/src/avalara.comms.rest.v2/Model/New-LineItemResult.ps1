function New-LineItemResult {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ref},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${base},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Tax[]]
        ${txs},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Error[]]
        ${err}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.LineItemResult' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.LineItemResult -ArgumentList @(
            ${ref},
            ${base},
            ${txs},
            ${err}
        )
    }
}
