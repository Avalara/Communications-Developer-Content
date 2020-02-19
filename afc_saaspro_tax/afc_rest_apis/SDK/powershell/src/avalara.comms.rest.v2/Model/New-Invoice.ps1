function New-Invoice {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${doc},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${cmmt},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Location]
        ${bill},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${cust},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${lfln},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${date},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.TaxExemption[]]
        ${exms},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.LineItem[]]
        ${itms},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${invm},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${dtl},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${summ},
        [Parameter(Position = 11, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.KeyValuePair[]]
        ${opt},
        [Parameter(Position = 12, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${acct},
        [Parameter(Position = 13, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${custref},
        [Parameter(Position = 14, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${invn},
        [Parameter(Position = 15, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${bcyc},
        [Parameter(Position = 16, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.BillingPeriod]
        ${bpd},
        [Parameter(Position = 17, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ccycd}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.Invoice' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.Invoice -ArgumentList @(
            ${doc},
            ${cmmt},
            ${bill},
            ${cust},
            ${lfln},
            ${date},
            ${exms},
            ${itms},
            ${invm},
            ${dtl},
            ${summ},
            ${opt},
            ${acct},
            ${custref},
            ${invn},
            ${bcyc},
            ${bpd},
            ${ccycd}
        )
    }
}
