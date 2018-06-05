$users = Import-Csv Office365Users.CSV
$users | ForEach-Object 
{
   Remove-MsolUser -UserPrincipalName $_.userprincipalname -Force
}
