function New-GeocodeRequest {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ref},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${cass},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${lat},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${long},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${addr},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${city},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${st},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${zip}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.GeocodeRequest' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.GeocodeRequest -ArgumentList @(
            ${ref},
            ${cass},
            ${lat},
            ${long},
            ${addr},
            ${city},
            ${st},
            ${zip}
        )
    }
}
