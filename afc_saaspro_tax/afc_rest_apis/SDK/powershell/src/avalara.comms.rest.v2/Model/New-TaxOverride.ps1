function New-TaxOverride {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Location]
        ${loc},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${scp},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${tid},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${lvl},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${lvlExm},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.TaxBracket[]]
        ${brkt}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.TaxOverride' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.TaxOverride -ArgumentList @(
            ${loc},
            ${scp},
            ${tid},
            ${lvl},
            ${lvlExm},
            ${brkt}
        )
    }
}
