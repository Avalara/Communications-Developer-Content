function New-Location {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${cnty},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ctry},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${int},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${geo},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${pcd},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${npa},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${fips},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${addr},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${city},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${st},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${zip}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.Location' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.Location -ArgumentList @(
            ${cnty},
            ${ctry},
            ${int},
            ${geo},
            ${pcd},
            ${npa},
            ${fips},
            ${addr},
            ${city},
            ${st},
            ${zip}
        )
    }
}
