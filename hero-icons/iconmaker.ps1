[string[]]$arrayFromFile = Get-Content -Path "hero-icons.txt"
$template = (Get-Content "icon-function.txt") -join "`n"

$outline = Get-ChildItem -Path .\outline
$solid = Get-ChildItem -Path .\solid

$outlineCsvOutput = ""
$outlineClassOutput = ""

$solidCsvOutput = ""
$solidClassOutput = ""

foreach($file in $outline) {
  $iconName = $file.Name.replace(".svg", "").replace("-", "_")
  $iconName = (Get-Culture).TextInfo.ToTitleCase($iconName)
  $iconName = $iconName.replace("_", "")

  $content = Get-Content -Path ".\outline\$($file.Name)"
  $content = $content.replace("aria-hidden", 'class="{CssClass}" aria-hidden')

  $outlineCsvOutput += "$iconName,$content`n"
  $outlineClassOutput += $template.replace("{Name}", $iconName).replace("{ResourceName}", "HeroIconsOutlineResources")
}

$outlineCsvOutput | Out-File -FilePath .\outline.csv
$outlineClassOutput | Out-File -FilePath .\outline.cs

foreach($file in $solid) {
  $iconName = $file.Name.replace(".svg", "").replace("-", "_")
  $iconName = (Get-Culture).TextInfo.ToTitleCase($iconName)
  $iconName = $iconName.replace("_", "")

  $content = Get-Content -Path ".\solid\$($file.Name)"
  $content = $content.replace("aria-hidden", 'class="{CssClass}" aria-hidden')

  $solidCsvOutput += "$iconName,$content`n"
  $solidClassOutput += $template.replace("{Name}", $iconName).replace("{ResourceName}", "HeroIconsSolidResources")
}

$solidCsvOutput | Out-File -FilePath .\solid.csv
$solidClassOutput | Out-File -FilePath .\solid.cs