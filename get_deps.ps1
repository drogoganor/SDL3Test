$deps = "deps"
If(!(Test-Path -PathType container $deps))
{
  New-Item -ItemType Directory -Path $deps
}

$temp = "temp"
$sdl3bin = "deps\SDL3.dll"
$sdl3zip = "temp\SDL3.zip"
$sdl3tempBin = "temp\SDL3.dll"

$buildPath = "SDL3Test\bin\Debug\net8.0"

$sdl3url = "https://github.com/libsdl-org/SDL/releases/download/release-3.2.8/SDL3-3.2.8-win32-x64.zip"

if (!(Test-Path $sdl3bin)) {
  Write-Warning "$sdl3bin not found, now downloading"

  If(!(Test-Path -PathType container $temp))
  {
    New-Item -ItemType Directory -Path $temp
  }

  If(!(Test-Path $sdl3zip))
  {
    Invoke-WebRequest $sdl3url -OutFile $sdl3zip
  }

  If(!(Test-Path $sdl3tempBin))
  {
    Expand-Archive -LiteralPath $sdl3zip -DestinationPath $temp
  }

  Copy-Item $sdl3tempBin $sdl3bin

  If(!(Test-Path -PathType container $buildPath))
  {
    New-Item -ItemType Directory -Path $buildPath
  }
  
  $buildFileDest = Join-Path $buildPath "SDL3.dll"

  If(!(Test-Path $buildFileDest))
  {
    Copy-Item $sdl3bin $buildFileDest
  }
}