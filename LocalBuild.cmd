set PreferredToolArchitecture=x64

cmd /c az login --allow-no-subscriptions --use-device-code

RMDIR /S /Q packages

REM remove any existing output

RMDIR /S /Q Dpr.AutomationFramework\bin
RMDIR /S /Q Dpr.AutomationFramework\obj

REM restore the nuget packages for the solution - we need to do this to get the code in the Dpr.Product.Framework.Origination nuget package that is used to download the origination product framework from the azure devops feed
Tools\Nuget\NuGet.exe restore .\Dpr.AutomationFramework.sln

REM perform the build
Tools\GitVersion\GitVersion.exe 
msbuild RootBuilder.proj /target:Build /p:platform="Any CPU" /p:configuration="Release" /p:version="0.0.0" /p:BUILD_REPOSITORY_URI="https://localhost/" /p:BUILD_REPOSITORY_NAME="Local" /p:BUILD_SOURCEBRANCH="local" /p:BUILD_SOURCEVERSION="0" /p:IsLocalBuild="True" /p:SYSTEM_TEAMPROJECT="local" /p:SYSTEM_TEAMFOUNDATIONSERVERURI="http://localhost/"
msbuild Cleanse.proj