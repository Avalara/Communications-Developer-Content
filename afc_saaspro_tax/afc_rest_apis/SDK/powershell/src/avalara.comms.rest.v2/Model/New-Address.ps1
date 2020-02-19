function New-Address {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${addr},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${city},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${st},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${zip}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.Address' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.Address -ArgumentList @(
            ${addr},
            ${city},
            ${st},
            ${zip}
        )
    }
}
