function New-KeyValuePair {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${key},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${val}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.KeyValuePair' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.KeyValuePair -ArgumentList @(
            ${key},
            ${val}
        )
    }
}
