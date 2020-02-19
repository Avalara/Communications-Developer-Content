#region Import functions

'API', 'Model', 'Private' | Get-ChildItem -Path {
    Join-Path $PSScriptRoot $_
} -Filter '*.ps1' | ForEach-Object {
    Write-Verbose "Importing file: $($_.BaseName)"
    try {
        . $_.FullName
    } catch {
        Write-Verbose "Can't import function!"
    }
}

#endregion


#region Initialize APIs

'Creating object: avalara.comms.rest.v2.Api.CustomizationApi' | Write-Verbose
$Script:CustomizationApi= New-Object -TypeName avalara.comms.rest.v2.Api.CustomizationApi -ArgumentList @($null)

'Creating object: avalara.comms.rest.v2.Api.HealthCheckApi' | Write-Verbose
$Script:HealthCheckApi= New-Object -TypeName avalara.comms.rest.v2.Api.HealthCheckApi -ArgumentList @($null)

'Creating object: avalara.comms.rest.v2.Api.JurisdictionDeterminationApi' | Write-Verbose
$Script:JurisdictionDeterminationApi= New-Object -TypeName avalara.comms.rest.v2.Api.JurisdictionDeterminationApi -ArgumentList @($null)

'Creating object: avalara.comms.rest.v2.Api.LookupsApi' | Write-Verbose
$Script:LookupsApi= New-Object -TypeName avalara.comms.rest.v2.Api.LookupsApi -ArgumentList @($null)

'Creating object: avalara.comms.rest.v2.Api.TaxCalculationApi' | Write-Verbose
$Script:TaxCalculationApi= New-Object -TypeName avalara.comms.rest.v2.Api.TaxCalculationApi -ArgumentList @($null)


#endregion
