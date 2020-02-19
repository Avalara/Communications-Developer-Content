function New-VersionInfo {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AfcEngineVersion},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${BuildVersion}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.VersionInfo' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.VersionInfo -ArgumentList @(
            ${AfcEngineVersion},
            ${BuildVersion}
        )
    }
}
