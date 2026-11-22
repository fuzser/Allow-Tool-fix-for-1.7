# Allow Tool - RimWorld 1.7 Fix

This repository updates **Allow Tool** for RimWorld 1.7 while preserving the
original package ID (`UnlimitedHugs.AllowTool`) for save and translation-mod
compatibility.

Original mod and source by [UnlimitedHugs](https://github.com/UnlimitedHugs/RimworldAllowTool).
RimWorld 1.7 compatibility update by WorldLeader.

## RimWorld 1.7 fixes

- Prevent party-hunt logic from accessing world settings before HugsLib's
  `WorldLoaded` callback during save loading.
- Ignore destroyed, despawned, mapless, or cross-map entries left in the
  urgent-haul cache.
- Bridge HugsLib 1.6's legacy `UnityEngine.Rect` callback type to RimWorld
  1.7's `UnityStubs` type.
- Fix malformed Korean key-binding translation XML.
- Add a dedicated .NET 10 build and `v1.7` load folder.

## Build

Requirements:

- .NET 10 SDK
- RimWorld 1.7 installed at the repository's current relative location
- Harmony Workshop item `2009463077`
- HugsLib Workshop item `818773962`

```powershell
dotnet build .\AllowTool.1.7.csproj -c Release
```

The release assembly is written to `v1.7/Assemblies/AllowTool.dll`.

## License

The original project was released into the public domain. See `license.txt`.
