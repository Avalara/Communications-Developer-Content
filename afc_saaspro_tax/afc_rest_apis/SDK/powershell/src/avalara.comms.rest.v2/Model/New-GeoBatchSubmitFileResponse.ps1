function New-GeoBatchSubmitFileResponse {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ProcessId},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Error[]]
        ${err}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.GeoBatchSubmitFileResponse' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.GeoBatchSubmitFileResponse -ArgumentList @(
            ${ProcessId},
            ${err}
        )
    }
}
