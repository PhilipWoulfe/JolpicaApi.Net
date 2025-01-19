::!/bin/bash

:: Ensure GitVersion is installed
dotnet tool install --global GitVersion.Tool

:: Run GitVersion to get the version
dotnet-gitversion /output json /showvariable SemVer

:: Debug output
echo "$(dotnet-gitversion /showvariable SemVer)"