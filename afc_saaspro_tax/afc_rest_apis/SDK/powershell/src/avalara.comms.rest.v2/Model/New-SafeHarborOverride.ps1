function New-SafeHarborOverride {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${sh},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${old},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${new}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.SafeHarborOverride' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.SafeHarborOverride -ArgumentList @(
            ${sh},
            ${old},
            ${new}
        )
    }
}
