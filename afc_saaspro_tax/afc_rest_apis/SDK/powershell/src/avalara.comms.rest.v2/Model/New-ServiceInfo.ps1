function New-ServiceInfo {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${ServerTime},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.VersionInfo]
        ${Versions},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Error}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.ServiceInfo' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.ServiceInfo -ArgumentList @(
            ${ServerTime},
            ${Versions},
            ${Error}
        )
    }
}
