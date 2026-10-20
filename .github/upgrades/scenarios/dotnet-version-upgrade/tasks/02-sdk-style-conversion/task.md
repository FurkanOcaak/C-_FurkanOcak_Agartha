# 02-sdk-style-conversion: Convert legacy projects to SDK-style

Convert ClassIntro, DegerVeReferansTiplerr, Donguler, IlkDeneme/Karsılatırmalar, Matematik, and Metotlar from legacy project format to SDK-style while retaining .NET Framework 4.7.2 temporarily. The assessment found all six projects are non-SDK-style, have no NuGet packages, and have no project-to-project dependencies, so conversion should remain structural and isolated from framework/API changes.

## Research Findings

- The topological ordering tool returned six independent projects in this order: `Metotlar`, `Matematik`, `IlkDeneme/Karsılatırmalar`, `Donguler`, `DegerVeReferansTiplerr`, `ClassIntro`.
- Because the graph is flat, there are no dependency-gated downstream projects; conversion can be split into two sequential batches while preserving the tool-reported order.
- Each project is a small console application with an `App.config`, `Program.cs`, and `Properties/AssemblyInfo.cs`; `Matematik` additionally contains `DortIslem.cs`, and `Metotlar` contains `Product.cs` and `SepetManager.cs`.
- No `packages.config` files or NuGet packages were found. No project references were detected.
- All six projects must remain on .NET Framework 4.7.2 during this task. Target framework changes are deferred to task `03-console-projects`.
- Conversion must use `convert_project_to_sdk_style` one project at a time, followed by a targeted build before the next project.

**Done when**: All six projects load as SDK-style projects, preserve their source files and executable behavior, restore successfully, and build on the existing .NET Framework target before framework changes begin.
