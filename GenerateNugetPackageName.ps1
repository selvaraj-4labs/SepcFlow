# This script will generate a new environment variable that we use to set the name of the gennerated nuget package

# The three commented section below can be used to test the script.  We have three different tests.  Each block starts with a comment examplainig what it tests.

# An example of a non tagged build on master which geerates a package name of 1.28.3-alpha20200922T010006mastercc0017
#$Env:Build_SourceBranch = "refs/heads/master"
#$Env:BUILD_SOURCEBRANCHNAME = "master"
#$Env:GITVERSION_FULLSEMVER = "1.28.3+17"
#$Env:GITVERSION_MAJORMINORPATCH = "1.28.3"
#$Env:GITVERSION_COMMITSSINCEVERSIONSOURCEPADDED = "0017"

# And example of a tagged master build which generates a package name of 1.28.2
#$Env:Build_SourceBranch = "refs/heads/master"
#$Env:BUILD_SOURCEBRANCHNAME = "master"
#$Env:GITVERSION_FULLSEMVER = "1.28.2"
#$Env:GITVERSION_MAJORMINORPATCH = "1.28.2"
#$Env:GITVERSION_COMMITSSINCEVERSIONSOURCEPADDED = "0"

# An example of a non tagged build on feature branch which generates a package name of 1.28.3-alpha20200922T005902featuresubmissioncc0015
#$Env:Build_SourceBranch = "refs/heads/feature/submission"
#$Env:BUILD_SOURCEBRANCHNAME = "submission"
#$Env:GITVERSION_FULLSEMVER = "1.28.3-submission.1+15"
#$Env:GITVERSION_MAJORMINORPATCH = "1.28.3"
#$Env:GITVERSION_COMMITSSINCEVERSIONSOURCEPADDED = "0015"

# An example of a tagged support build which generates a package name of 2.0.0
#$Env:Build_SourceBranch = "refs/heads/support/2.0"
#$Env:BUILD_SOURCEBRANCHNAME = "2.0"
#$Env:GITVERSION_FULLSEMVER = "2.0.0"
#$Env:GITVERSION_MAJORMINORPATCH = "2.0.0"
#$Env:GITVERSION_COMMITSSINCEVERSIONSOURCEPADDED = "0"

# An example of a non tagged support build which generates a package name of 2.0.0-alpha20200922T005704support20cc0001
#$Env:Build_SourceBranch = "refs/heads/support/2.0"
#$Env:BUILD_SOURCEBRANCHNAME = "2.0"
#$Env:GITVERSION_FULLSEMVER = "2.0.0-support.2.0-1+15"
#$Env:GITVERSION_MAJORMINORPATCH = "2.0.0"
#$Env:GITVERSION_COMMITSSINCEVERSIONSOURCEPADDED = "0001"

# An example of a tagged release build which generates a package name of 2.0.0
#$Env:Build_SourceBranch = "refs/heads/release/2.0"
#$Env:BUILD_SOURCEBRANCHNAME = "2.0"
#$Env:GITVERSION_FULLSEMVER = "2.0.0"
#$Env:GITVERSION_MAJORMINORPATCH = "2.0.0"
#$Env:GITVERSION_COMMITSSINCEVERSIONSOURCEPADDED = "0"

# An example of a non tagged release build which generates a package name of 2.0.0-alpha20200922T010353release20cc0001
#$Env:Build_SourceBranch = "refs/heads/release/2.0"
#$Env:BUILD_SOURCEBRANCHNAME = "2.0"
#$Env:GITVERSION_FULLSEMVER = "2.0.0-release.2.0-1+15"
#$Env:GITVERSION_MAJORMINORPATCH = "2.0.0"
#$Env:GITVERSION_COMMITSSINCEVERSIONSOURCEPADDED = "0001"


if (-not $Env:Build_SourceBranch) {
	Write-Error ("Build_SourceBranch environment variable is missing.")
	exit 1
}

Write-Host $Env:Build_SourceBranch

if (-not $Env:GITVERSION_FULLSEMVER) {
	Write-Error ("GITVERSION_FULLSEMVER environment variable is missing.")
	exit 1
}

Write-Host $Env:GITVERSION_FULLSEMVER

$nugetPackageName = ""

if ($Env:Build_SourceBranch -eq "refs/heads/master" -and $Env:GITVERSION_MAJORMINORPATCH -eq $Env:GITVERSION_FULLSEMVER) {
    $nugetPackageName = $Env:GITVERSION_FULLSEMVER
}
elseif ($Env:Build_SourceBranch.ToLower().StartsWith("refs/heads/support") -and $Env:GITVERSION_MAJORMINORPATCH -eq $Env:GITVERSION_FULLSEMVER) {
    $nugetPackageName = $Env:GITVERSION_FULLSEMVER
}
elseif ($Env:Build_SourceBranch.ToLower().StartsWith("refs/heads/release") -and $Env:GITVERSION_MAJORMINORPATCH -eq $Env:GITVERSION_FULLSEMVER) {
    $nugetPackageName = $Env:GITVERSION_FULLSEMVER
}
else {
	$BUILD_SOURCEBRANCHNAME = $Env:BUILD_SOURCEBRANCHNAME 
	$pattern = '[^a-zA-Z0-9]'
	$BUILD_SOURCEBRANCHNAME = $BUILD_SOURCEBRANCHNAME -replace $pattern, '' 
    
    if($Env:Build_SourceBranch.ToLower().StartsWith("refs/heads/support"))
    {
        $BUILD_SOURCEBRANCHNAME = "support" + $BUILD_SOURCEBRANCHNAME
    }
    elseif($Env:Build_SourceBranch.ToLower().StartsWith("refs/heads/feature"))
    {
        $BUILD_SOURCEBRANCHNAME = "feature" + $BUILD_SOURCEBRANCHNAME
    }
    elseif($Env:Build_SourceBranch.ToLower().StartsWith("refs/heads/release"))
    {
        $BUILD_SOURCEBRANCHNAME = "release" + $BUILD_SOURCEBRANCHNAME
    }
    
    
    $nugetPackageName = $Env:GITVERSION_MAJORMINORPATCH + "-alpha" + (get-date -Format s).Replace('-', '').Replace(':', '') + $BUILD_SOURCEBRANCHNAME + "cc" + $Env:GITVERSION_COMMITSSINCEVERSIONSOURCEPADDED  
}

Write-Host $nugetPackageName

Write-Host "##vso[task.setvariable variable=NugetPackageName]$nugetPackageName"