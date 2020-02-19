function New-LocationItem {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsAlternate},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CountryIso},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${State},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${County},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Locality},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${PCode}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.LocationItem' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.LocationItem -ArgumentList @(
            ${IsAlternate},
            ${CountryIso},
            ${State},
            ${County},
            ${Locality},
            ${PCode}
        )
    }
}
