function New-PCodeLookupResult {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.LocationItem[]]
        ${LocationData},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${MatchCount},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${InputMatchType},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MatchTypeApplied},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ResultsLimit}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.PCodeLookupResult' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.PCodeLookupResult -ArgumentList @(
            ${LocationData},
            ${MatchCount},
            ${InputMatchType},
            ${MatchTypeApplied},
            ${ResultsLimit}
        )
    }
}
