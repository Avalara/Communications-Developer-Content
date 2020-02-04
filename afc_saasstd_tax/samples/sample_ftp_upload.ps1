# Copyright (c) 2016  Avalara, Inc.  All rights reserved
#
# This PowerShell script requires the following to be run first: 

# Set-ExecutionPolicy unrestricted

# Replace username and password with the correct credentials provided by Avalara.
# Update path ("path/to") to the correct locations on the FTP site provided by Avalara.
#
#
# Please note that the example script functions as expected, 
# it does not take into consideration constraints of your system 
# infrastructure. For example security, privacy, scalability etc. 
#

$File = "C:\tmp\test.log"
$ftp = "ftp://username:password@ftp.billsoft.com/path/to/test.log"


# helper message
"ftp url: $ftp"

$webclient = New-Object System.Net.WebClient
$uri = New-Object System.Uri($ftp)

"Uploading $File..."

$webclient.UploadFile($uri, $File)
