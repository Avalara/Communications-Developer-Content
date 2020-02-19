function New-SetTaxCalculationSettingRequest {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${ProfileConfigId},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [Int32[]]
        ${LinkProfileIds},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [Int32[]]
        ${UnlinkProfileIds},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ClientId},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Deactivate},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ReplaceExistingLinks},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Configuration]
        ${Settings},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.ExclusionConfig[]]
        ${Exclusions},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.BundleConfig[]]
        ${Bundles},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.NexusConfig[]]
        ${Nexus},
        [Parameter(Position = 11, ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Overrides}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.SetTaxCalculationSettingRequest' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.SetTaxCalculationSettingRequest -ArgumentList @(
            ${ProfileConfigId},
            ${LinkProfileIds},
            ${UnlinkProfileIds},
            ${ClientId},
            ${Deactivate},
            ${Description},
            ${ReplaceExistingLinks},
            ${Settings},
            ${Exclusions},
            ${Bundles},
            ${Nexus},
            ${Overrides}
        )
    }
}
