function New-CalcTaxesRequest {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.RequestConfig]
        ${cfg},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.CompanyData]
        ${cmpn},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Invoice[]]
        ${inv},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.TaxOverride[]]
        ${ovr},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.SafeHarborOverride[]]
        ${sovr}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.CalcTaxesRequest' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.CalcTaxesRequest -ArgumentList @(
            ${cfg},
            ${cmpn},
            ${inv},
            ${ovr},
            ${sovr}
        )
    }
}
