# 01-prerequisites: Verify .NET 10 upgrade prerequisites

Verify that the .NET 10 SDK is installed and that any repository SDK selection is compatible with the target framework. Capture the baseline solution state and confirm that the six projects identified by the assessment are the complete upgrade scope.

## Research Findings

- The solution contains exactly six projects: `ClassIntro`, `DegerVeReferansTiplerr`, `Donguler`, `IlkDeneme/Karsılatırmalar`, `Matematik`, and `Metotlar`.
- All six projects currently target .NET Framework 4.7.2, use legacy project format, and have no detected project-to-project dependencies or NuGet packages.
- No `global.json` file exists, so no repository SDK pin conflicts with the target.
- The .NET 10 SDK is now installed and validated: `10.0.402` at `C:\Program Files\dotnet\sdk`.
- The installed .NET 10 runtime is `10.0.13`, and the environment is Windows x64.
- The initial Visual Studio MSBuild baseline build completed successfully for all six projects, with two existing CS0219 warnings in `IlkDeneme/Program.cs` for unused variables `OgrenciSayisi` and `FaizOrani`.

## Resolution

The previous SDK blocker is resolved. The project inventory, SDK compatibility, and baseline build status are now recorded. The baseline warnings remain tracked for resolution during the upgrade validation tasks.

**Done when**: The .NET 10 SDK and repository SDK configuration are compatible, the project inventory matches the assessment, and the baseline restore/build status is recorded.
