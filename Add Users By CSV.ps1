$users = Import-Csv Office365Users.CSV
$users | ForEach-Object 
{

     # Determine if AD Account will exist on prem or remote. 
     if ($_.OrganizationalUnit -like '*local*')
     {
 
       # Create new local AD US User 
       New-ADUser -UserPrincipalName $_.UserPrincipalName -City $_.city -State $_.State -Country $_.Country -DisplayName $_.DisplayName  
     } else
     {
       # Create new MSOL user and apply E3 License
         New-MsolUser -UserPrincipalName $_.UserPrincipalName -City $_.city -State $_.State -Country $_.Country -DisplayName $_.DisplayName
         -UsageLocation $_.Country -LicenseAssignment moreltechnology:ENTERPRISEPACK 
     }  


   # If Mailbox field is true, create a mailbox
   if ($_.MailBox)
   {
      if ($_.OrganizationalUnit -like '*local*')
      {
        # Create a remote mailbox attached to local user
        Enable-RemoteMailbox "alias" –remoteroutingaddress $_.Alias+@moreltechnology.onmicrosoft.com -OnPremisesOrganizationalUnit $_.OrganizationalUnit
      } else
      {
        # Create a remote mailbox attached to Azure AD User
        Enable-RemoteMailbox "alias" –remoteroutingaddress $_.Alias+@moreltechnology.onmicrosoft.com -OrganizationalUnit $_.OrganizationalUnit
      }
   }
}
