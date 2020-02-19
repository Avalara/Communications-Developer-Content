function New-TSPairData {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${TransactionType},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ServiceType},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${MarketType},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${InterfaceType},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${InputType},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsBundle},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TransactionDescription},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceDescription},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TSPairDescription}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.TSPairData' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.TSPairData -ArgumentList @(
            ${TransactionType},
            ${ServiceType},
            ${MarketType},
            ${InterfaceType},
            ${InputType},
            ${IsBundle},
            ${TransactionDescription},
            ${ServiceDescription},
            ${TSPairDescription}
        )
    }
}
