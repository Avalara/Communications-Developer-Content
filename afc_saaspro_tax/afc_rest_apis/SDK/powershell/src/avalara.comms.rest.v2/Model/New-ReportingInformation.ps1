function New-ReportingInformation {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${acct},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${custref},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${invn},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${bcyc},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ccycd},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ccydesc}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.ReportingInformation' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.ReportingInformation -ArgumentList @(
            ${acct},
            ${custref},
            ${invn},
            ${bcyc},
            ${ccycd},
            ${ccydesc}
        )
    }
}
