function New-Warning {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${code},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${msg}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.Warning' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.Warning -ArgumentList @(
            ${code},
            ${msg}
        )
    }
}
