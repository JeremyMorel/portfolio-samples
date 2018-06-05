$cred = Import-Clixml creds.xml
Connect-MsolService -Credential $cred