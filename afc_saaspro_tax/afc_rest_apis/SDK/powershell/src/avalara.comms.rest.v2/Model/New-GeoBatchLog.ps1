function New-GeoBatchLog {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.GeoBatchLogItem[]]
        ${Log},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Error[]]
        ${err}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.GeoBatchLog' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.GeoBatchLog -ArgumentList @(
            ${Log},
            ${err}
        )
    }
}
