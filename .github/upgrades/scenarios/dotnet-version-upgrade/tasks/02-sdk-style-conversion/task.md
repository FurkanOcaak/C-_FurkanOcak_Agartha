# 02-sdk-style-conversion: Convert legacy projects to SDK-style

Convert ClassIntro, DegerVeReferansTiplerr, Donguler, IlkDeneme/Karsılatırmalar, Matematik, and Metotlar from legacy project format to SDK-style while retaining .NET Framework 4.7.2 temporarily. The assessment found all six projects are non-SDK-style, have no NuGet packages, and have no project-to-project dependencies, so conversion should remain structural and isolated from framework/API changes.

**Done when**: All six projects load as SDK-style projects, preserve their source files and executable behavior, restore successfully, and build on the existing .NET Framework target before framework changes begin.
