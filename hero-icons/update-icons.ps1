

function Main {
    CleanupTemp
    CleanupOut

    DownloadLatest

    # Loop through files
    Write-Host "Looping through svg files and creating razor components..."
    CreateMainClass -Glob "tmp/optimized/24/solid/*.svg" -Version $version
    CreateSubclass -IconType "Micro" -Glob "tmp/optimized/16/solid/*.svg" -Version $version
    CreateSubclass -IconType "Mini" -Glob "tmp/optimized/20/solid/*.svg" -Version $version
    CreateSubclass -IconType "Solid" -Glob "tmp/optimized/24/solid/*.svg" -Version $version
    CreateSubclass -IconType "Outline" -Glob "tmp/optimized/24/outline/*.svg" -Version $version

    CleanupTemp
}

function CleanupTemp {
    if (Test-Path "tmp") {
        Write-Host "Cleaning up existing tmp files..."
        Remove-Item "tmp" -Recurse -Force
    }
}

function CleanupOut {
    if (Test-Path "out") {
        Write-Host "Cleaning up existing output files..."
        Remove-Item "out" -Recurse -Force
    }
}

function DownloadLatest {
    # Get latest release info
    Write-Host "Getting latest release info..."
    $releaseInfo = Invoke-RestMethod -Uri "https://api.github.com/repos/tailwindlabs/heroicons/releases/latest"
    $version = $releaseInfo.tag_name
    $downloadUrl = $releaseInfo.tarball_url

    # Download tarball
    Write-Host "Downloading $version..."
    $tarFilename = [System.Uri]::UnescapeDataString($downloadUrl.Split("/")[-1])

    # Create tmp directory
    New-Item -ItemType Directory -Path "tmp" -Force | Out-Null
    $tarFilename = "tmp/$tarFilename"
    Invoke-WebRequest -Uri $downloadUrl -OutFile $tarFilename
    Write-Host "Downloaded latest release to $tarFilename"

    # Extract tar
    Write-Host "Extracting tar file..."
    tar -xzf $tarFilename -C "tmp"
    $extractedFolderName = Get-ChildItem -Path "tmp" -Directory | Select-Object -First 1 -ExpandProperty Name
    Move-Item -Path "tmp/$extractedFolderName/*" -Destination "tmp" -Force
    Remove-Item -Path "tmp/$extractedFolderName" -Recurse -Force
    Remove-Item $tarFilename
}

function CreateSubclass {
    param (
        [string]$IconType,
        [string]$Glob,
        [string]$Version
    )

    # Create out directory
    if(-Not (Test-Path "out")) {
        New-Item -ItemType Directory -Path "out" -Force | Out-Null
    }

    # Grab templates
    $classTemplate = (Get-Content "templates/class.txt") -join "`n"
    $functionTemplate = (Get-Content "templates/function.txt") -join "`n"

    # Resx templates
    $resxFileTemplate = (Get-Content "templates/resx.txt") -join "`n"
    $resxDataTemplate = (Get-Content "templates/resx-data.txt") -join "`n"
    $resxDesignerFileTemplate = (Get-Content "templates/resx-designer-class.txt") -join "`n"
    $resxDesignerPropTemplate = (Get-Content "templates/resx-designer-property.txt") -join "`n"

    Write-Host "Loaded templates..."

    $iconFunctionsCode = ""
    $resxDataXml = ""
    $resxDesignerCode = ""

    $fileList = Get-ChildItem -Path $Glob -File

    # Add all the functions
    foreach ($file in $fileList) {
        $iconName = $file.Name.replace(".svg", "").replace("-", "_")
        $iconName = (Get-Culture).TextInfo.ToTitleCase($iconName)
        $iconName = $iconName.replace("_", "")

        $fullName = $file.Name.replace(".svg", "").replace("-", " ")
        $fullName = (Get-Culture).TextInfo.ToTitleCase($fullName)

        $content = Get-Content -Path $file.FullName
        $content = $content.replace("aria-hidden", 'class="{CssClass}" aria-hidden')
        $xmlFriendlyContent = $content.replace("<", "&lt;").replace(">", "&gt;").replace("`n", "")

        $iconFunctionsCode += $functionTemplate.replace("{FullName}", $fullName).replace("{Name}", $iconName).replace("{ResourceName}", "HeroIcons$($IconType)Resources")
        $resxDataXml += $resxDataTemplate.replace("{Name}", $iconName).replace("{Svg}", $xmlFriendlyContent)
        $resxDesignerCode += $resxDesignerPropTemplate.replace("{FullName}", $fullName).replace("{Name}", $iconName)
    }

    $iconClassCode = $classTemplate.replace("{Functions}", $iconFunctionsCode).replace("{IconType}", $IconType).replace("{Version}", $Version);
    $iconClassCode | Out-File -FilePath ".\out\HeroIcons$($IconType).cs" -Encoding utf8
    Write-Host "Exported $($IconType) to .\out\HeroIcons$($IconType).cs"

    $resxFileXml = $resxFileTemplate.replace("{ResxData}", $resxDataXml);
    $resxFileXml | Out-File -FilePath ".\out\HeroIcons$($IconType)Resources.resx" -Encoding utf8
    Write-Host "Exported $($IconType) to .\out\HeroIcons$($IconType)Resources.resx"

    $resxCode = $resxDesignerFileTemplate.replace("{ClassName}", "HeroIcons$($IconType)Resources").replace("{Properties}", $resxDesignerCode);
    $resxCode | Out-File -FilePath ".\out\HeroIcons$($IconType)Resources.Designer.cs" -Encoding utf8
    Write-Host "Exported $($IconType) to .\out\HeroIcons$($IconType)Resources.Designer.cs"
}

function CreateMainClass {
    param (
        [string]$Glob,
        [string]$Version
    )

    # Create out directory
    if(-Not (Test-Path "out")) {
        New-Item -ItemType Directory -Path "out" -Force | Out-Null
    }

    # Grab templates
    $mainClassTemplate = (Get-Content "templates/class-main.txt") -join "`n"
    $mainFunctionTemplate = (Get-Content "templates/function-main.txt") -join "`n"
    $mainFunctionMicroTemplate = (Get-Content "templates/function-main-micro.txt") -join "`n"

    Write-Host "Loaded templates..."

    $iconFunctionsCode = ""
    $iconMainFunctionsCode = ""

    $fileList = Get-ChildItem -Path $Glob -File

    # Add all the functions
    foreach ($file in $fileList) {
        $iconName = $file.Name.replace(".svg", "").replace("-", "_")
        $iconName = (Get-Culture).TextInfo.ToTitleCase($iconName)
        $iconName = $iconName.replace("_", "")

        $fullName = $file.Name.replace(".svg", "").replace("-", " ")
        $fullName = (Get-Culture).TextInfo.ToTitleCase($fullName)

        $thisIconsCode = $mainFunctionTemplate.replace("{FullName}", $fullName).replace("{Name}", $iconName)

        if(Test-Path "tmp/optimized/16/solid/$($file.Name)") {
            $thisIconsCode = $thisIconsCode.replace("{Micro}", $mainFunctionMicroTemplate.replace("{Name}", $iconName))
        }
        else {
            $thisIconsCode = $thisIconsCode.replace("{Micro}", "")
        }
        
        $iconMainFunctionsCode += $thisIconsCode
    }

    $iconMainClassCode = $mainClassTemplate.replace("{Functions}", $iconMainFunctionsCode).replace("{Version}", $Version);
    $iconMainClassCode | Out-File -FilePath ".\out\HeroIcons.cs" -Encoding utf8
    Write-Host "Exported main code file to .\out\HeroIcons.cs"
}

Main