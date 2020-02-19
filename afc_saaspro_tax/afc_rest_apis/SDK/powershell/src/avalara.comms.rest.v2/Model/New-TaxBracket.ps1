function New-TaxBracket {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${rate},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${max}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.TaxBracket' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.TaxBracket -ArgumentList @(
            ${rate},
            ${max}
        )
    }
}
