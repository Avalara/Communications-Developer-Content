function New-Exclusion {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ctry},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${st},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${excl}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.Exclusion' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.Exclusion -ArgumentList @(
            ${ctry},
            ${st},
            ${excl}
        )
    }
}
