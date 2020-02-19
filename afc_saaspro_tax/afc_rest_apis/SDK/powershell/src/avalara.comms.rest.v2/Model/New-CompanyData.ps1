function New-CompanyData {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${bscl},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${svcl},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${fclt},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${frch},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${reg},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Exclusion[]]
        ${excl},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${idnt}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.CompanyData' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.CompanyData -ArgumentList @(
            ${bscl},
            ${svcl},
            ${fclt},
            ${frch},
            ${reg},
            ${excl},
            ${idnt}
        )
    }
}
