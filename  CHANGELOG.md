# Changelog

All notable changes to Forge will be documented in this file.

The format is inspired by Keep a Changelog and the project follows Semantic Versioning.

---
## v0.5.0 - Forge Version Information

### Added

- Introduced the `forge --version` command.
- Added dedicated `VersionCommand`.
- Added deterministic product version output.

## [v0.4.0] - 2026-07-12

### Added

- Introduced a production-quality Help command.
- Added support for:
  - `forge help`
  - `forge --help`
- Added dedicated `HelpCommand`.
- Improved CLI discoverability through deterministic help output.

---

## [v0.3.0] - 2026-07-12

### Added

- Introduced the `forge doctor` command.
- Added environment validation for:
  - .NET SDK
  - Git
  - Git repository
  - Working tree
- Added dedicated `DoctorCommand`.

---

## [v0.2.0] - 2026-07-12

### Added

- Introduced CLI command routing.
- Added placeholder support for:
  - `doctor`
  - `--help`
  - `--version`
- Added deterministic command dispatch.

---

## [v0.1.0] - 2026-07-12

### Added

- Bootstrapped the Forge CLI.
- Created the initial solution structure.
- Added the application entry point.