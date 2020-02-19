function New-CalcTaxesResponse {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.InvoiceResult[]]
        ${inv},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Error[]]
        ${err}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.CalcTaxesResponse' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.CalcTaxesResponse -ArgumentList @(
            ${inv},
            ${err}
        )
    }
}
