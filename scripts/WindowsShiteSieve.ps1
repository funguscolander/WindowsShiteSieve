<#
    .EXECUTION
    Open a PowerShell window with administrator privileges by navigating to the folder containing this script in file explorer.
    Click "File", mouse over "Open Windows Powershell," and click "Open Windows Powershell as administrator."

    To run scripts in the current PowerShell session, the default execution policy must be bypassed for the current process:
        Set-ExecutionPolicy -ExecutionPolicy Bypass -Scope Process -Force

    The script can now be run:
        .\UninstallShite.ps1

    .PACKAGEFORMAT
    To search packages:
        Get-AppxPackage -AllUsers | Select Name, PackageFullName

    To remove packages:
        Get-AppxPackage PackageFullName | Remove-AppxPackage
        
        Note that the "PackageFullName" should be used, not "Name"

    .TODO
    Fix current uninstallers to use PackageFullName with wildcards (e.g. *Camera*)
    - Script fuction/execution
        - File which lists all parameters and lets you enable or disable all (Just comment out? Or will this interfere with GUI?)
        - GUI which lets you edit the list file with checkboxes and a "run" button
        ? Seperate uninstallation lists for CurrentUser and AllUsers packages (-FilterScript {
    - Explorer
        - Set explorer to dark mode
        - Set app default to dark mode
        - Set "This PC" as new exploerer window location
        - Allow viewing of know file extensions
        - Allow viewing of hidden system files
        - Option for changing the location of the temp folder to "C:\TEMP" or anywhere else
        - Option for changing the location of use folders to "C:\TEMP" or anywhere else
        - Option to change whether the Ribbon is expanded or not in each new explorer window
    - Start menu
        - Unpin "Microsoft Store" from Start menu
        - Unpin "Great apps coming" or whatever they're called when yet to be downloaded
        - Remove advertisements
        - Remove suggested apps
        - Disable Bing search
        - Option to enable indexed filesystem search instead of just start menu search
    - Taskbar
        - Hide "Meet Now" system icon
        - Hide "Microphone" system icon
        - Automatically hide the taskbar
        - Use peek to preview the desktop on "Show Desktop" mouseover
        - Unpin "Microsoft Edge" from taskbar
        - Unpin "Microsft Store" from taskbar
    - Uninstall apps
        - Update uninstallation method as is described in the Uninstaller section
        - Prevent Microsoft Store from installing apps automatically
        - Option to uninstall "Cortana" (bunch of numbers and letters)
        - Option to uninstall "Microsoft Edge" (and "Edge.Stable")
        - Option to uninstall "Office Hub" and all Office programs
        - Option to uninstall "OneDrive)
        - Option to uninstall "Paint 3D"
    - Miscellaneous
        - Option to change/reduce hard drive idle time before spinning down
#>


# Uninstaller

<#
    .NEWMETHOD
    1. Find the names of the packages with:
        Get-AppxPackage -PackageTypeFilter Bundle | Select Name
    2. Use magic to find which packages should be uninstalled
    3. Uninstall the selected packages with:
        Get-AppxPackage -PackageTypeFilter Bundle | Where-Object -FilterScript {$SearchedPackageNames -cmatch $SelectedPackageNames} | Remove-AppxPackage
        You can add -Verbose to the end to make it verbose.
        Add -AllUsers to Get-AppxPackage and Remove-AppxPackage to check and remove for all users (this is probably a good thing to do)

        Get-AppxPackage -PackageTypeFilter Bundle -AllUsers | Where-Object -FilterScript {$_.Name -cmatch $AppxPackages} | Remove-AppxPackage -AllUsers -Verbose
#>

Get-AppxPackage Microsoft.WindowsCamera | Remove-AppxPackage	# Camera
# Get-AppxPackage Windows.CBSPreview | Remove-AppxPackage		# CBS News Preview, evidently not possible to remove with this command
Get-AppxPackage Microsoft.GetHelp | Remove-AppxPackage		# Get Help, F1 still gets help :(
Get-AppxPackage Microsoft.Getstarted | Remove-AppxPackage	# Get Started
Get-AppxPackage Microsoft.WindowsMaps | Remove-AppxPackage	# Maps
Get-AppxPackage Microsoft.MixedReality.Portal | Remove-AppxPackage	# Mixed Reality Portal
Get-AppxPackage Microsoft.People | Remove-AppxPackage		# People
Get-AppxPackage Microsoft.Windows.PeopleExperinceHost | Remove-AppxPackage	# People Experience host
Get-AppxPackage Microsoft.ScreenSketch | Remove-AppxPackage	# Screen Sketch
Get-AppxPackage Microsoft.MicrosoftSolitaireCollection | Remove-AppxPackage	# Solitaire Collection
Get-AppxPackage Microsoft.Wallet* | Remove-AppxPackage		# Wallet
Get-AppxPackage Microsoft.YourPhone | Remove-AppxPackage	# YourPhone