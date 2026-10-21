# .NET Version Upgrade Plan

## Overview

**Target**: Upgrade six .NET Framework 4.7.2 projects to .NET 10 and convert their legacy project files to SDK-style format.
**Scope**: Six small, standalone classic projects totaling 15 code files and 489 lines of code, with no detected project-to-project dependencies or NuGet packages.

## Upgrade Options

| Option | Selected | Why |
|--------|----------|-----|
| Upgrade Strategy | Bottom-Up | Six .NET Framework projects require different SDK-style and framework migration mechanics, so dependency-ordered validation is appropriate. |
| Project Approach | In-place | The solution contains small, standalone classic projects with no detected project-to-project dependencies or web migration surface. |
| Package Management | Per-Project (defer CPM to post-migration) | The upgrade crosses the .NET Framework-to-modern .NET boundary and all projects are legacy-format, so centralized package management should be deferred until migration stabilizes. |

## Tasks

### 01-prerequisites: Verify .NET 10 upgrade prerequisites

Verify that the .NET 10 SDK is installed and that any repository SDK selection is compatible with the target framework. Capture the baseline solution state and confirm that the six projects identified by the assessment are the complete upgrade scope.

**Done when**: The .NET 10 SDK and repository SDK configuration are compatible, the project inventory matches the assessment, and the baseline restore/build status is recorded.

---

### 02-sdk-style-conversion: Convert legacy projects to SDK-style

Convert ClassIntro, DegerVeReferansTiplerr, Donguler, IlkDeneme/Karsılatırmalar, Matematik, and Metotlar from legacy project format to SDK-style while retaining .NET Framework 4.7.2 temporarily. The assessment found all six projects are non-SDK-style, have no NuGet packages, and have no project-to-project dependencies, so conversion should remain structural and isolated from framework/API changes.

**Done when**: All six projects load as SDK-style projects, preserve their source files and executable behavior, restore successfully, and build on the existing .NET Framework target before framework changes begin.

---

### 03-console-projects: Upgrade all projects to .NET 10

Upgrade the target framework for all six converted projects to net10.0 and resolve any compilation or project-system issues introduced by the framework boundary. The assessment reports zero incompatible packages and zero binary/source API incompatibilities across 159 analyzed APIs, so expected code changes are minimal; still validate each project independently and run available tests after the target changes.

**Done when**: ClassIntro, DegerVeReferansTiplerr, Donguler, IlkDeneme/Karsılatırmalar, Matematik, and Metotlar target net10.0, restore successfully, build without errors or warnings, and retain their expected entry-point behavior.

---

### 04-solution-validation: Validate the upgraded solution

Perform final solution-wide validation after all projects target .NET 10. Confirm that no legacy target framework or project-format artifacts remain, document the deferred Central Package Management recommendation, and run the complete available test suite and solution build.

**Done when**: The full solution builds with zero errors and warnings, all available tests pass, all six projects target net10.0, no legacy project files remain in active use, and deferred package-management follow-up is documented.
