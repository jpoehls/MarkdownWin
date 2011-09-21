$framework = '4.0'

properties {
  $outDir = 'dist'
}

task default -depends Test, Package

task Test -depends Compile, Clean { 
  Write-Output "No Tests"
}

task Compile -depends Clean { 
  exec { msbuild MarkdownWin.sln /t:Rebuild /p:Configuration=Release }
}

task Package {
  New-Item $outDir -ItemType Directory
  exec { ./tools/ilmerge.exe /t:winexe /copyattrs /ndebug /targetplatform:v4 /wildcards `
         /out:$outdir/MarkdownWin.exe `
         src/MarkdownWin/bin/Release/MarkdownWin.exe `
         src/MarkdownWin/bin/Release/*.dll }
}

task Clean { 
  if (Test-Path $outDir) {
    Remove-Item $outDir -Recurse -Force
  }

  exec { msbuild MarkdownWin.sln /t:Clean /p:Configuration=Release }
}

task ? -Description "Helper to display task info" {
  Write-Documentation
}