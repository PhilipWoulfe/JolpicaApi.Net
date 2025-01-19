::!/bin/bash

:: Ensure GitVersion is installed
dotnet tool install --global GitVersion.Tool

:: Run GitVersion to get the version
$VERSION=$(gitversion /showvariable SemVer)

:: Debug output
echo "GitVersion SemVer: $VERSION"

:: Restore dependencies
dotnet restore

:: Build the project
dotnet build --no-restore --configuration Release

:: Pack the NuGet package with the calculated version
dotnet pack --no-build --configuration Release --output ./nupkg /p:PackageVersion=$VERSION

:: Verify the package
echo "NuGet package created in ./nupkg with version $VERSION"