function New-TrafficStudyOverride {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${TrafficStudyType},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${SafeHarborFedPcnt},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${TrafficStudyFedPcnt}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.TrafficStudyOverride' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.TrafficStudyOverride -ArgumentList @(
            ${TrafficStudyType},
            ${SafeHarborFedPcnt},
            ${TrafficStudyFedPcnt}
        )
    }
}
