
# Build_Taxonomy_and_security.ps1
# ===============================
# CREATED: 03/05/2013 - Jeremy Morel, Senior Consultant with Ellucian and all around nice guy.
# PURPOSE: Gets data from a CSV file and provisions SharePoint sites automagically.
# 
# MOD: 03/06/2013 - Moved Parent and Child Security Settings to seperate runs to fix a timing issue. (Child security sometimes got applied before parent.)
# MOD: 03/07/2013 - Resolved Issue with Special Characters throwing excepions in Group Names.  I now scan and replace then with underscores.
# MOD: 03/07/2013 - Resolved Issue with duplicate Group Names.(Fatal)  Added catch for exception.  When it's found, I append a random # 1-99 to the Group name.
# MOD: 04/18/2013 - Added logic for Putting Admins and Owners into Site Permissions.
# MOD: 04/18/2013 - Added some instructions, (why not), so I can share this with all my friends!

  CLS #Keep things tidy!

 ############################################################################
#                                                                            #
# About this script:                                                         # 
# ==================                                                         #
# This script uses a template file and a CSV File to automatically           #
# Provision your Sharepoint sites.                                           #
#                                                                            #
# About the Template:                                                        #
# ===================                                                        #
# Create a template site the way you like it, then                           # 
# export your template site from within Central Admin using                  #
# the method below. (Export-SPWeb doesn't work for this.)                    #
#                                                                            #
# In central admin, use this URL to export your template site:               #
# http://<Central_Admin_URL>/_admin/SiteAndListExport.aspx                   #
# Then set the complete path to your exported file in the configuration      #
# options below.                                                             #
#                                                                            #
#                                                                            #
# About The CSV File:                                                        #
# =====================                                                      #
# Header row is ignored, but required, so MAKE SURE YOU HAVE ONE!            #
# Column headers MUST be called Path, Title and Parent. (caps don't matter.) #
# Path is the path for each site.  Be sure not to use special characters or  #
# spaces! The program will probably blow up!                                 #
#                                                                            #
# For Parent, indicate if the site is a parent by putting yes in the column. #
# Anything other than yes (such as no or blank) will be treated as           #
# a child site.  (Parent is my way of saying Top-Level-Site).                #                        
#                                                                            #
# Here's a Sample CSV File:                                                  #
#                                                                            #
# Path,Title,Parent                                                          #
# /Academics,Academics,Yes                                                   #
# /Academics/Library,Library,No                                              #
#                                                                            #
# You'll set the path to your CSV file in the configuration options below.   #
#                                                                            #
 ############################################################################ 

  # Configuration Variables 
  # ======================= 

   # Path to your Template File
   # --------------------------
     $TemplateFile = "c:\PortalBuild\SP2013InfoSite.cmp"

   # Path to the CSV File
   # ----------------------
     $CSVFile = "c:\PortalBuild\taxonomy.csv" 

   # Specify your Root Portal URL here.  Don't include traling slash (/)
   # -------------------------------------------------------------------
     $PortalURL = "http://mdf-portal-app:8901"

   # Specify your Root Portal Owners Group name.
   # --------------------------------------------
     $portalownersGroup = "DYC Portal Owners"

   # Specify your Root Portal Admins Group name.
   # --------------------------------------------
     $portaladminsGroup = "Portal Administrators"

   # Specify your Root Portal Visitors Group name.
   # ---------------------------------------------
     $portalvisitorsGroup = "DYC Portal Visitors"


  # \\\\\\\                                     /////////////////
  # /////// DANGER: Don't Edit Below This Line! \\\\\\\\\\\\\\\\\
  # \\\\\\\   (DON'T SAY I DIDN'T WARN YOU!)    /////////////////
  # ///////                                     \\\\\\\\\\\\\\\\\

  # Make sure our configuration files exist.  Otherwise quit.

    if(!(Test-Path $TemplateFile))
      {
       Write-Host "Your Template file does not exist at"$TemplateFile
       Exit
      }
    else
      {
       Write-Host "Found Template File..."
      }

    if(!(Test-Path $CSVFile))
      {
       Write-Host "Your CSV file does not exist at"$CSVFile
       Exit
      }
    else
      {
       Write-Host "Found CSV File..."
      }

      # Files Found, Let's Proceed...
  
      #########################################################
      # Create Sites.                                         #  
      # Loop through the CSV and do the following for each    #
      # Entry:                                                # 
      # 1. Create Site (With no template)                     #
      # 2. Import the Template to that site.                  #
      # 3. Update the site's Title                            #
      #########################################################
      $RecordSet = Import-CSV $CSVFile 

      ForEach ( $RecordSet in $RecordSet ) 

      {
        # Read Values
        $SiteURL=$RecordSet.path 
        $SiteName=$RecordSet.title
 

      New-SPWeb $PortalURL$SiteURL
      Import-SPWeb $PortalURL$SiteURL –Path $TemplateFile  –UpdateVersions Overwrite -NoLogFile
      $spWeb = Get-SPWeb -Identity $PortalURL$SiteURL 
      $spWeb.Title = $SiteName 
      $spWeb.Update() 
      $spWeb.Dispose()
      Write-Host Name Applied: $SiteName
     

      # Any other things you'd like to do to each site can go here. :)    

     }
   
     #################################################
     # Apply Parent Site Security.  Again, loop      #
     # through CSV and determine if site is a parent #
     # and apply necessary security settings         #
     #################################################
     
      Write-Host
      Write-Host
      Write-Host "Applying Security..."


      $RecordSet = Import-CSV $CSVFile
 
      ForEach ( $RecordSet in $RecordSet ) 

      {

        $SiteURL=$RecordSet.path 
        $SiteName=$RecordSet.title
        $isParent=$RecordSet.parent


        
          if ($isParent -eq "Yes") 

           {
             Write-Host "Applying PARENT security to $SiteName."

		# Get the parent site
                # -------------------
		$web = Get-SPWeb $PortalURL$SiteURL

		#Break permissions and delete all groups
                # --------------------------------------
		$web.BreakRoleInheritance($false)


		#Add Portal Owners back in
                # ------------------------
		$ownersGroup=$web.Site.RootWeb.SiteGroups[$portalownersGroup]
		$ownersGroupAssignment = new-object Microsoft.SharePoint.SPRoleAssignment($ownersGroup)
		$ownersRoleDefinition = $web.Site.RootWeb.RoleDefinitions["Full Control"]
		$ownersGroupAssignment.RoleDefinitionBindings.Add($ownersRoleDefinition)
		$web.RoleAssignments.Add($ownersGroupAssignment)



		#Add Portal Administrators back in
                # --------------------------------
		$adminsGroup=$web.Site.RootWeb.SiteGroups[$portaladminsGroup]
		$adminsGroupAssignment = new-object Microsoft.SharePoint.SPRoleAssignment($adminsGroup)
		$adminsRoleDefinition = $web.Site.RootWeb.RoleDefinitions["Full Control"]
		$adminsGroupAssignment.RoleDefinitionBindings.Add($adminsRoleDefinition)
		$web.RoleAssignments.Add($adminsGroupAssignment)


		#Add Portal Visitors back in
                # --------------------------
		$visitorsGroup=$web.Site.RootWeb.SiteGroups[$portalvisitorsGroup]
		$VisitorsGroupAssignment = new-object Microsoft.SharePoint.SPRoleAssignment($visitorsGroup)
		$visitorsRoleDefinition = $web.Site.RootWeb.RoleDefinitions["Read"]
		$visitorsGroupAssignment.RoleDefinitionBindings.Add($visitorsRoleDefinition)
		$web.RoleAssignments.Add($visitorsGroupAssignment)

		#Create a Group called <sitename> Content Managers and give it owner rights
                # -------------------------------------------------------------------------
                # Strip special characters out of the name
                $SafeName = [System.Text.RegularExpressions.Regex]::Replace($web,"[^1-9a-zA-Z_]","_")             

                # Cant have two groups with the same name, so check for an exception to be thrown.
                # If there is one, attach a random number, 1-999 to the end. (Yes, I know it's hoky.)

                try 
                 {
		  $web.SiteGroups.Add(“$SafeName Content Managers”, $web.Site.Owner, $web.Site.Owner, “Use this group to add content managers to the site `"$web`" located at $SiteURL”)
                 }
                 catch  
                 {
                  $caughtEx=$_.Exception.Message
     
                   If ($caughtEx -like "*already in use*")
                   {
                    $randomNum=Get-Random -minimum 1 -maximum 999
                    $saferName=$SafeName+"_"+$randomNum
                    # Give it another shot!
                    $web.SiteGroups.Add(“$SaferName Content Managers”, $web.Site.Owner, $web.Site.Owner, “Use this group to add content managers to the site `"$web`" located at $SiteURL”)
                    # reassign value and break out of this trap
                    $safeName=$SaferName                   
                   }    
                 }

		$ownerGroup = $web.SiteGroups["$SafeName Content Managers"]
		$ownerGroup.AllowMembersEditMembership = $true
		$ownerGroup.Update()

		#Assign it to the site
                # --------------------
		$ownerGroupAssignment = new-object Microsoft.SharePoint.SPRoleAssignment($ownerGroup)
		$ownerRoleDefinition = $web.Site.RootWeb.RoleDefinitions["Full Control"]
		$ownerGroupAssignment.RoleDefinitionBindings.Add($ownerRoleDefinition)
		$web.RoleAssignments.Add($ownerGroupAssignment)
		$web.Update()
		$web.Dispose()

           }

         

      }


     #################################################
     # Apply Child Site Security.  Again, loop       #
     # through CSV and determine if site is a child  #
     # and apply necessary security settings         #
     #################################################
     

      $RecordSet = Import-CSV $CSVFile
 
      ForEach ( $RecordSet in $RecordSet ) 

      {

        $SiteURL=$RecordSet.path 
        $SiteName=$RecordSet.title
        $isParent=$RecordSet.parent


          if ($isParent -ne "Yes") 
           {
             Write-Host "Applying CHILD security to $SiteName."
		#Do all the same things as a parent site, but this time, copy the permissions from the parent first

		$web = Get-SPWeb $PortalURL$SiteURL
		$web.BreakRoleInheritance($true)
                # Strip special characters out of the name
                $SafeName = [System.Text.RegularExpressions.Regex]::Replace($web,"[^1-9a-zA-Z_]","_")             

                # Cant have two groups with the same name, so check for an exception to be thrown.
                # If there is one, attach a random number, 1-999 to the end. (Yes, I know it's hoky.)

                try 
                 {
		  $web.SiteGroups.Add(“$SafeName Content Managers”, $web.Site.Owner, $web.Site.Owner, “Use this group to add content managers to the site `"$web`" located at $SiteURL”)
                 }
                 catch  
                 {
                  $caughtEx=$_.Exception.Message
     
                   If ($caughtEx -like "*already in use*")
                   {
                    $randomNum=Get-Random -minimum 1 -maximum 999
                    $saferName=$SafeName+"_"+$randomNum
                    # Give it another shot!
                    $web.SiteGroups.Add(“$SaferName Content Managers”, $web.Site.Owner, $web.Site.Owner, “Use this group to add content managers to the site `"$web`" located at $SiteURL”)
                    # reassign value and break out of this trap
                    $safeName=$SaferName                   
                   }    
                 }

		$ownerGroup = $web.SiteGroups["$SafeName Content Managers"]
		$ownerGroup.AllowMembersEditMembership = $true
		$ownerGroup.Update()
		$ownerGroupAssignment = new-object Microsoft.SharePoint.SPRoleAssignment($ownerGroup)
		$ownerRoleDefinition = $web.Site.RootWeb.RoleDefinitions["Full Control"]
		$ownerGroupAssignment.RoleDefinitionBindings.Add($ownerRoleDefinition)
		$web.RoleAssignments.Add($ownerGroupAssignment)
		$web.Update()
		$web.Dispose()

           }


      }

# All done.  Have a beer, (or a glass of wine if that's your thing).