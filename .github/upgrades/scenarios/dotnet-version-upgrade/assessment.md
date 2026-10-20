# Projects and dependencies analysis

This document provides a comprehensive overview of the projects and their dependencies in the context of upgrading to .NETCoreApp,Version=v10.0.

## Table of Contents

- [Executive Summary](#executive-Summary)
  - [Highlevel Metrics](#highlevel-metrics)
  - [Projects Compatibility](#projects-compatibility)
  - [Package Compatibility](#package-compatibility)
  - [API Compatibility](#api-compatibility)
  - [Binding Redirect Configuration](#binding-redirect-configuration)
- [Aggregate NuGet packages details](#aggregate-nuget-packages-details)
- [Top API Migration Challenges](#top-api-migration-challenges)
  - [Technologies and Features](#technologies-and-features)
  - [Most Frequent API Issues](#most-frequent-api-issues)
- [Projects Relationship Graph](#projects-relationship-graph)
- [Project Details](#project-details)

  - [ClassIntro\ClassIntro.csproj](#classintroclassintrocsproj)
  - [DegerVeReferansTiplerr\DegerVeReferansTiplerr.csproj](#degervereferanstiplerrdegervereferanstiplerrcsproj)
  - [Donguler\Donguler.csproj](#dongulerdongulercsproj)
  - [IlkDeneme\Karsılatırmalar.csproj](#ilkdenemekarsılatırmalarcsproj)
  - [Matematik\Matematik.csproj](#matematikmatematikcsproj)
  - [Metotlar\Metotlar.csproj](#metotlarmetotlarcsproj)


## Executive Summary

### Highlevel Metrics

| Metric | Count | Status |
| :--- | :---: | :--- |
| Total Projects | 6 | All require upgrade |
| Total NuGet Packages | 0 | All compatible |
| Total Code Files | 15 |  |
| Total Code Files with Incidents | 6 |  |
| Total Lines of Code | 489 |  |
| Total Number of Issues | 12 |  |
| Estimated LOC to modify | 0+ | at least 0,0% of codebase |

### Projects Compatibility

| Project | Target Framework | Difficulty | Package Issues | API Issues | Binding Issues | Est. LOC Impact | Description |
| :--- | :---: | :---: | :---: | :---: | :---: | :---: | :--- |
| [ClassIntro\ClassIntro.csproj](#classintroclassintrocsproj) | net472 | 🟢 Low | 0 | 0 | 0 |  | ClassicDotNetApp, Sdk Style = False |
| [DegerVeReferansTiplerr\DegerVeReferansTiplerr.csproj](#degervereferanstiplerrdegervereferanstiplerrcsproj) | net472 | 🟢 Low | 0 | 0 | 0 |  | ClassicDotNetApp, Sdk Style = False |
| [Donguler\Donguler.csproj](#dongulerdongulercsproj) | net472 | 🟢 Low | 0 | 0 | 0 |  | ClassicDotNetApp, Sdk Style = False |
| [IlkDeneme\Karsılatırmalar.csproj](#ilkdenemekarsılatırmalarcsproj) | net472 | 🟢 Low | 0 | 0 | 0 |  | ClassicDotNetApp, Sdk Style = False |
| [Matematik\Matematik.csproj](#matematikmatematikcsproj) | net472 | 🟢 Low | 0 | 0 | 0 |  | ClassicDotNetApp, Sdk Style = False |
| [Metotlar\Metotlar.csproj](#metotlarmetotlarcsproj) | net472 | 🟢 Low | 0 | 0 | 0 |  | ClassicDotNetApp, Sdk Style = False |

### Package Compatibility

| Status | Count | Percentage |
| :--- | :---: | :---: |
| ✅ Compatible | 0 | 0,0% |
| ⚠️ Incompatible | 0 | 0,0% |
| 🔄 Upgrade Recommended | 0 | 0,0% |
| ***Total NuGet Packages*** | ***0*** | ***100%*** |

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 159 |  |
| ***Total APIs Analyzed*** | ***159*** |  |

## Aggregate NuGet packages details

| Package | Current Version | Suggested Version | Projects | Description |
| :--- | :---: | :---: | :--- | :--- |

## Top API Migration Challenges

### Technologies and Features

| Technology | Issues | Percentage | Migration Path |
| :--- | :---: | :---: | :--- |

### Most Frequent API Issues

| API | Count | Percentage | Category |
| :--- | :---: | :---: | :--- |

## Projects Relationship Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart LR
    P1["<b>⚙️&nbsp;ClassIntro.csproj</b><br/><small>net472</small>"]
    P2["<b>⚙️&nbsp;DegerVeReferansTiplerr.csproj</b><br/><small>net472</small>"]
    P3["<b>⚙️&nbsp;Donguler.csproj</b><br/><small>net472</small>"]
    P4["<b>⚙️&nbsp;Karsılatırmalar.csproj</b><br/><small>net472</small>"]
    P5["<b>⚙️&nbsp;Matematik.csproj</b><br/><small>net472</small>"]
    P6["<b>⚙️&nbsp;Metotlar.csproj</b><br/><small>net472</small>"]
    click P1 "#classintroclassintrocsproj"
    click P2 "#degervereferanstiplerrdegervereferanstiplerrcsproj"
    click P3 "#dongulerdongulercsproj"
    click P4 "#ilkdenemekarsılatırmalarcsproj"
    click P5 "#matematikmatematikcsproj"
    click P6 "#metotlarmetotlarcsproj"

```

## Project Details

<a id="classintroclassintrocsproj"></a>
### ClassIntro\ClassIntro.csproj

#### Project Info

- **Current Target Framework:** net472
- **Proposed Target Framework:** net10.0
- **SDK-style**: False
- **Project Kind:** ClassicDotNetApp
- **Dependencies**: 0
- **Dependants**: 0
- **Number of Files**: 2
- **Number of Files with Incidents**: 1
- **Lines of Code**: 85
- **Estimated LOC to modify**: 0+ (at least 0,0% of the project)

#### Dependency Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart TB
    subgraph current["ClassIntro.csproj"]
        MAIN["<b>⚙️&nbsp;ClassIntro.csproj</b><br/><small>net472</small>"]
        click MAIN "#classintroclassintrocsproj"
    end

```

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 36 |  |
| ***Total APIs Analyzed*** | ***36*** |  |

<a id="degervereferanstiplerrdegervereferanstiplerrcsproj"></a>
### DegerVeReferansTiplerr\DegerVeReferansTiplerr.csproj

#### Project Info

- **Current Target Framework:** net472
- **Proposed Target Framework:** net10.0
- **SDK-style**: False
- **Project Kind:** ClassicDotNetApp
- **Dependencies**: 0
- **Dependants**: 0
- **Number of Files**: 2
- **Number of Files with Incidents**: 1
- **Lines of Code**: 62
- **Estimated LOC to modify**: 0+ (at least 0,0% of the project)

#### Dependency Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart TB
    subgraph current["DegerVeReferansTiplerr.csproj"]
        MAIN["<b>⚙️&nbsp;DegerVeReferansTiplerr.csproj</b><br/><small>net472</small>"]
        click MAIN "#degervereferanstiplerrdegervereferanstiplerrcsproj"
    end

```

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 8 |  |
| ***Total APIs Analyzed*** | ***8*** |  |

<a id="dongulerdongulercsproj"></a>
### Donguler\Donguler.csproj

#### Project Info

- **Current Target Framework:** net472
- **Proposed Target Framework:** net10.0
- **SDK-style**: False
- **Project Kind:** ClassicDotNetApp
- **Dependencies**: 0
- **Dependants**: 0
- **Number of Files**: 2
- **Number of Files with Incidents**: 1
- **Lines of Code**: 65
- **Estimated LOC to modify**: 0+ (at least 0,0% of the project)

#### Dependency Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart TB
    subgraph current["Donguler.csproj"]
        MAIN["<b>⚙️&nbsp;Donguler.csproj</b><br/><small>net472</small>"]
        click MAIN "#dongulerdongulercsproj"
    end

```

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 16 |  |
| ***Total APIs Analyzed*** | ***16*** |  |

<a id="ilkdenemekarsılatırmalarcsproj"></a>
### IlkDeneme\Karsılatırmalar.csproj

#### Project Info

- **Current Target Framework:** net472
- **Proposed Target Framework:** net10.0
- **SDK-style**: False
- **Project Kind:** ClassicDotNetApp
- **Dependencies**: 0
- **Dependants**: 0
- **Number of Files**: 2
- **Number of Files with Incidents**: 1
- **Lines of Code**: 81
- **Estimated LOC to modify**: 0+ (at least 0,0% of the project)

#### Dependency Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart TB
    subgraph current["Karsılatırmalar.csproj"]
        MAIN["<b>⚙️&nbsp;Karsılatırmalar.csproj</b><br/><small>net472</small>"]
        click MAIN "#ilkdenemekarsılatırmalarcsproj"
    end

```

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 22 |  |
| ***Total APIs Analyzed*** | ***22*** |  |

<a id="matematikmatematikcsproj"></a>
### Matematik\Matematik.csproj

#### Project Info

- **Current Target Framework:** net472
- **Proposed Target Framework:** net10.0
- **SDK-style**: False
- **Project Kind:** ClassicDotNetApp
- **Dependencies**: 0
- **Dependants**: 0
- **Number of Files**: 3
- **Number of Files with Incidents**: 1
- **Lines of Code**: 70
- **Estimated LOC to modify**: 0+ (at least 0,0% of the project)

#### Dependency Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart TB
    subgraph current["Matematik.csproj"]
        MAIN["<b>⚙️&nbsp;Matematik.csproj</b><br/><small>net472</small>"]
        click MAIN "#matematikmatematikcsproj"
    end

```

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 10 |  |
| ***Total APIs Analyzed*** | ***10*** |  |

<a id="metotlarmetotlarcsproj"></a>
### Metotlar\Metotlar.csproj

#### Project Info

- **Current Target Framework:** net472
- **Proposed Target Framework:** net10.0
- **SDK-style**: False
- **Project Kind:** ClassicDotNetApp
- **Dependencies**: 0
- **Dependants**: 0
- **Number of Files**: 4
- **Number of Files with Incidents**: 1
- **Lines of Code**: 126
- **Estimated LOC to modify**: 0+ (at least 0,0% of the project)

#### Dependency Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart TB
    subgraph current["Metotlar.csproj"]
        MAIN["<b>⚙️&nbsp;Metotlar.csproj</b><br/><small>net472</small>"]
        click MAIN "#metotlarmetotlarcsproj"
    end

```

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 67 |  |
| ***Total APIs Analyzed*** | ***67*** |  |

