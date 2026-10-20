# 03-console-projects: Upgrade all projects to .NET 10

Upgrade the target framework for all six converted projects to net10.0 and resolve any compilation or project-system issues introduced by the framework boundary. The assessment reports zero incompatible packages and zero binary/source API incompatibilities across 159 analyzed APIs, so expected code changes are minimal; still validate each project independently and run available tests after the target changes.

## Research Findings

- All six projects are now SDK-style and were previously validated on `net472`.
- The six target framework properties were changed to `net10.0`:
  `ClassIntro`, `DegerVeReferansTiplerr`, `Donguler`, `IlkDeneme/Karsılatırmalar`, `Matematik`, and `Metotlar`.
- No project-to-project references or NuGet packages exist, so no dependency-specific retargeting work is required.
- Legacy explicit references to `System.Data.DataSetExtensions`, `Microsoft.CSharp`, and `System.Net.Http` caused 33 MSBuild resolution/conflict warnings on net10.0; these references are implicit in the modern target and were removed from all six project files.
- The existing unused locals in `IlkDeneme/Program.cs` were already removed during SDK conversion validation.

## Validation Evidence

`dotnet build C#_FurkanOcak.slnx --nologo` completed successfully on SDK `10.0.402` with zero errors and zero warnings. All six projects produced net10.0 output assemblies.

**Done when**: ClassIntro, DegerVeReferansTiplerr, Donguler, IlkDeneme/Karsılatırmalar, Matematik, and Metotlar target net10.0, restore successfully, build without errors or warnings, and retain their expected entry-point behavior.
