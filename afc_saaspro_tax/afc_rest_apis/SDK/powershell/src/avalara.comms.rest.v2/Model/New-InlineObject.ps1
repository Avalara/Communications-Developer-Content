function New-InlineObject {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[String]]
        ${file}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.InlineObject' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.InlineObject -ArgumentList @(
            ${file}
        )
    }
}
