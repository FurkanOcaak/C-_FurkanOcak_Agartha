# .NET Version Upgrade

## Preferences
- **Flow Mode**: Automatic
- **Target Framework**: net10.0

## Source Control
- **Source Branch**: master
- **Working Branch**: upgrade-dotnet-10
- **Commit Strategy**: After Each Task
- **Branch Sync**: Auto (Merge)

## Upgrade Options
- **Upgrade Strategy**: Bottom-Up
- **Project Approach**: In-place
- **Package Management**: Per-Project (defer CPM to post-migration)

## Strategy
**Selected**: Bottom-Up (Dependency-First)
**Rationale**: Six .NET Framework 4.7.2 projects are legacy-format and have no detected project-to-project dependencies, so dependency-ordered validation is appropriate.

### Execution Constraints
- Verify the .NET 10 SDK and global.json compatibility before changes.
- Convert legacy project files to SDK-style as a separate operation before changing target frameworks.
- Upgrade dependency tiers from leaf projects upward, validating restore, build, and tests after each tier.
- Validate that remaining projects continue to build between tiers where applicable.
- Defer Central Package Management until all projects are SDK-style and on a stable single target framework.
- Finish with a full solution build and test run, with zero warnings treated as errors.
