function New-ExclusionConfig {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CountryIso},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${State}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.ExclusionConfig' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.ExclusionConfig -ArgumentList @(
            ${CountryIso},
            ${State}
        )
    }
}
