function New-GeocodeResult {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ref},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Address]
        ${cass},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${cBlk},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${cTrc},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${cnty},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${feat},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${fips},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${inc},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${jur},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${lat},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${long},
        [Parameter(Position = 11, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${pcd},
        [Parameter(Position = 12, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${scr},
        [Parameter(Position = 13, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${err}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.GeocodeResult' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.GeocodeResult -ArgumentList @(
            ${ref},
            ${cass},
            ${cBlk},
            ${cTrc},
            ${cnty},
            ${feat},
            ${fips},
            ${inc},
            ${jur},
            ${lat},
            ${long},
            ${pcd},
            ${scr},
            ${err}
        )
    }
}
