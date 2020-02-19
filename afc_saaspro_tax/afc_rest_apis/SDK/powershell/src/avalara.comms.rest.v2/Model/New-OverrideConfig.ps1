function New-OverrideConfig {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${RawData}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.OverrideConfig' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.OverrideConfig -ArgumentList @(
            ${RawData}
        )
    }
}
