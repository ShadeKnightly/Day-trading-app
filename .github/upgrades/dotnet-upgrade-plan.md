# .NET 8.0 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that an .NET 8.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 8.0 upgrade.
3. Upgrade DayTradingApp\DayTradingApp.csproj


## Settings

This section contains settings and data used by execution steps.

### Excluded projects

Table below contains projects that do belong to the dependency graph for selected projects and should not be included in the upgrade.

| Project name                                   | Description                 |
|:-----------------------------------------------|:---------------------------:|


### Aggregate NuGet packages modifications across all projects

NuGet packages used across all selected projects or their dependencies that need version update in projects that reference them.

| Package Name                        | Current Version | New Version | Description                                   |
|:------------------------------------|:---------------:|:-----------:|:----------------------------------------------|
| EntityFramework                     |   6.4.4         |  6.5.1      | Replace with EntityFramework 6.5.1 (recommended)|
| Newtonsoft.Json                     |  13.0.1         | 13.0.4     | Update to latest patch recommended for security| 
| System.Collections                  |   4.3.0         |             | Functionality included with new framework reference; remove package|
| System.Data.SQLite.Linq             |  1.0.119.0      |             | No supported version found for .NET 8.0; consider replacement or alternative package|
| System.Data.SQLite.x64              |  1.0.119.0      |             | No supported version found for .NET 8.0; consider replacement or alternative package|


### Project upgrade details

#### DayTradingApp\\DayTradingApp.csproj modifications

Project properties changes:
  - Target framework should be changed from `net472` (i.e. .NETFramework,Version=v4.7.2) to `net8.0-windows`.
  - Convert project file to SDK-style format.

NuGet packages changes:
  - `EntityFramework` should be updated from `6.4.4` to `6.5.1` (replacement recommended).
  - `Newtonsoft.Json` should be updated from `13.0.1` to `13.0.4` (recommended for security/compatibility).
  - `System.Collections` package should be removed; functionality is included in the target framework reference.
  - `System.Data.SQLite.Linq` (1.0.119.0) has no supported version for .NET 8.0; investigate replacement (e.g., Microsoft.Data.Sqlite or community-maintained packages) or build native binaries compatible with the target.
  - `System.Data.SQLite.x64` (1.0.119.0) has no supported version for .NET 8.0; investigate replacement or alternative distribution.

Feature upgrades:
  - Update WinForms code and project settings for .NET 8 (single-file, application manifest, high-DPI settings may need adjustments).

Other changes:
  - Update any code that depends on APIs removed or replaced in .NET 8; address compile errors after project conversion and package updates.


