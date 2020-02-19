function New-CommitRequest {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${doc},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${cmmt},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.KeyValuePair[]]
        ${opt}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.CommitRequest' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.CommitRequest -ArgumentList @(
            ${doc},
            ${cmmt},
            ${opt}
        )
    }
}
