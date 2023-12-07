#!/usr/bin/env bash

# Create a new folder titled 0-new_project
mkdir 0-new_project

# Change to the newly created folder
cd 0-new_project

# Initialize a new C# console application using dotnet
dotnet new console -n 0-new_project

# Perform post-creation actions: dotnet restore
dotnet restore 0-new_project.csproj
