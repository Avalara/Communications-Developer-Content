function New-GeoBatchStatus {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ProcessId},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${RequestDate},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${ProcessingStart},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${ProcessingEnd},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Status},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.GeoBatchDownloadResponse]
        ${Downloads},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Error[]]
        ${Error}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.GeoBatchStatus' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.GeoBatchStatus -ArgumentList @(
            ${ProcessId},
            ${RequestDate},
            ${ProcessingStart},
            ${ProcessingEnd},
            ${Status},
            ${Downloads},
            ${Error}
        )
    }
}
