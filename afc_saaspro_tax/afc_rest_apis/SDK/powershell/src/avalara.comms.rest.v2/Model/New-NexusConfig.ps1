function New-NexusConfig {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${State}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.NexusConfig' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.NexusConfig -ArgumentList @(
            ${State}
        )
    }
}
