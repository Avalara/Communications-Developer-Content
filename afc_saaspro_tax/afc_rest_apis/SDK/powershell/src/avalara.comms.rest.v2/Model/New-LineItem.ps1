function New-LineItem {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ref},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Location]
        ${from},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Location]
        ${to},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${chg},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${line},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${loc},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${min},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${sale},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${plsp},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${incl},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${pror},
        [Parameter(Position = 11, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${proadj},
        [Parameter(Position = 12, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${tran},
        [Parameter(Position = 13, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${serv},
        [Parameter(Position = 14, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${dbt},
        [Parameter(Position = 15, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${adj},
        [Parameter(Position = 16, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${adjm},
        [Parameter(Position = 17, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${disc},
        [Parameter(Position = 18, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.KeyValuePair[]]
        ${opt},
        [Parameter(Position = 19, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${prop},
        [Parameter(Position = 20, ValueFromPipelineByPropertyName = $true)]
        [avalara.comms.rest.v2.Model.Location]
        ${bill},
        [Parameter(Position = 21, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${cust},
        [Parameter(Position = 22, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${lfln},
        [Parameter(Position = 23, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${date},
        [Parameter(Position = 24, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${qty},
        [Parameter(Position = 25, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${glref}
    )

    Process {
        'Creating object: avalara.comms.rest.v2.Model.LineItem' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName avalara.comms.rest.v2.Model.LineItem -ArgumentList @(
            ${ref},
            ${from},
            ${to},
            ${chg},
            ${line},
            ${loc},
            ${min},
            ${sale},
            ${plsp},
            ${incl},
            ${pror},
            ${proadj},
            ${tran},
            ${serv},
            ${dbt},
            ${adj},
            ${adjm},
            ${disc},
            ${opt},
            ${prop},
            ${bill},
            ${cust},
            ${lfln},
            ${date},
            ${qty},
            ${glref}
        )
    }
}
