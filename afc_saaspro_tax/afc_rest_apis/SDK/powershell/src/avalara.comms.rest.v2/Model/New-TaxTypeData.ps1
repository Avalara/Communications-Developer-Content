function New-TaxTypeData {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${TaxType},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${CategoryType},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TaxDescription},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CategoryDescription}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.TaxTypeData' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.TaxTypeData -ArgumentList @(
            ${TaxType},
            ${CategoryType},
            ${TaxDescription},
            ${CategoryDescription}
        )
    }
}
