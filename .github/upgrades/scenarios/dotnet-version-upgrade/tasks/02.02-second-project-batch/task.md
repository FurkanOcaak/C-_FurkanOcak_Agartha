# 02.02-second-project-batch: Convert remaining three independent console projects

## Objective
Convert the remaining three projects from the tool-reported topological order to SDK-style while preserving their .NET Framework 4.7.2 target.

## Scope
- Donguler\Donguler.csproj
- DegerVeReferansTiplerr\DegerVeReferansTiplerr.csproj
- ClassIntro\ClassIntro.csproj

## Required validation
Use `convert_project_to_sdk_style` sequentially, build each converted project with restore using Visual Studio MSBuild, confirm the TargetFramework remains net472, and record any warnings or conversion issues before proceeding to final task validation.
