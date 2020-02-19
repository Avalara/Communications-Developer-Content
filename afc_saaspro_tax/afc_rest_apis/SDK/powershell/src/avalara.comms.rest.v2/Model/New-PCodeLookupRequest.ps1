function New-PCodeLookupRequest {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CountryIso},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${State},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${County},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${City},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ZipCode},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${BestMatch},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LimitResults},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NpaNxx},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Fips}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.PCodeLookupRequest' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.PCodeLookupRequest -ArgumentList @(
            ${CountryIso},
            ${State},
            ${County},
            ${City},
            ${ZipCode},
            ${BestMatch},
            ${LimitResults},
            ${NpaNxx},
            ${Fips}
        )
    }
}
