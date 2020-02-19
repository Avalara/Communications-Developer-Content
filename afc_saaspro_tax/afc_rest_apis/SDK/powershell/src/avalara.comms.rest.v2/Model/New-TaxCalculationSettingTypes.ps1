function New-TaxCalculationSettingTypes {
    [CmdletBinding()]
    Param (
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.TaxCalculationSettingTypes' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.TaxCalculationSettingTypes -ArgumentList @(
        )
    }
}
