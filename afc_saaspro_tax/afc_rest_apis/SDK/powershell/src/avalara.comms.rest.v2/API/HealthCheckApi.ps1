function Invoke-HealthCheckApiApiV2HealthCheckGet {
    [CmdletBinding()]
    Param (
    )

    Process {
        'Calling method: HealthCheckApi-ApiV2HealthCheckGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:HealthCheckApi.ApiV2HealthCheckGet(
        )
    }
}

