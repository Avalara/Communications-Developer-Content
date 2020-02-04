# Copyright (c) 2016  Avalara, Inc.  All rights reserved
#
# This PowerShell script requires the following to be run first: 

# Set-ExecutionPolicy unrestricted

# Replace username and password with the correct credentials provided by Avalara.
# Update path ("path/to") to the correct locations on your system.
#
#
# Please note that the example script functions as expected, 
# it does not take into consideration constraints of your system 
# infrastructure. For example security, privacy, scalability etc. 
#

$File = "c:\temp\test.txt"
$ftp = "ftp://username:password@ftp.billsoft.com/path/to/test.txt"


# helper message
"ftp url: $ftp"

$webclient = New-Object System.Net.WebClient
$uri = New-Object System.Uri($ftp)

"Downloading $File..."

$webclient.DownloadFile($uri, $File)
