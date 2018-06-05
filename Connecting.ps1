Get-Credential "jeremy@morel.tech" | Export-Clixml creds.xml
$cred = Import-Clixml creds.xml
Connect-MsolService -Credential $cred