function New-CommitResponse {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ok},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Error[]]
        ${err}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.CommitResponse' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.CommitResponse -ArgumentList @(
            ${ok},
            ${err}
        )
    }
}
