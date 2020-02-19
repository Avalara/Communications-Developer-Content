function New-BillingPeriod {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${month},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${year}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.BillingPeriod' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.BillingPeriod -ArgumentList @(
            ${month},
            ${year}
        )
    }
}
