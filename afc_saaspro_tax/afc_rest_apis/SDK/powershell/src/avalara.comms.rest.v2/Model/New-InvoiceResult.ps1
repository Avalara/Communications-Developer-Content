function New-InvoiceResult {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${doc},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.LineItemResult[]]
        ${itms},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.SummarizedTax[]]
        ${summ},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Error[]]
        ${err},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.ReportingInformation]
        ${incrf}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.InvoiceResult' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.InvoiceResult -ArgumentList @(
            ${doc},
            ${itms},
            ${summ},
            ${err},
            ${incrf}
        )
    }
}
