function New-TaxCalculationSettingsResponse {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${ProfileConfigId},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [Int32[]]
        ${ProfileIds},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ClientId},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LastUpdateBy},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Active},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Configuration]
        ${Settings},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.ExclusionConfig[]]
        ${Exclusions},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.BundleConfig[]]
        ${Bundles},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.NexusConfig[]]
        ${Nexus},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.OverrideConfig]
        ${Overrides},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(Position = 11, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Error},
        [Parameter(Position = 12, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ItemType},
        [Parameter(Position = 13, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Error[]]
        ${Errors},
        [Parameter(Position = 14, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Warning[]]
        ${Warnings},
        [Parameter(Position = 15, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Status[]]
        ${Status}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.TaxCalculationSettingsResponse' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.TaxCalculationSettingsResponse -ArgumentList @(
            ${ProfileConfigId},
            ${ProfileIds},
            ${ClientId},
            ${LastUpdateBy},
            ${Active},
            ${Settings},
            ${Exclusions},
            ${Bundles},
            ${Nexus},
            ${Overrides},
            ${Description},
            ${Error},
            ${ItemType},
            ${Errors},
            ${Warnings},
            ${Status}
        )
    }
}
