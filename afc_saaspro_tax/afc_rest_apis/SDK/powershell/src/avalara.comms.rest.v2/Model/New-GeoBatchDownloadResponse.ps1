function New-GeoBatchDownloadResponse {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${InputFile},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${InputFileDownload},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${OutputFile},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${OutputFileDownload}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.GeoBatchDownloadResponse' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.GeoBatchDownloadResponse -ArgumentList @(
            ${InputFile},
            ${InputFileDownload},
            ${OutputFile},
            ${OutputFileDownload}
        )
    }
}
