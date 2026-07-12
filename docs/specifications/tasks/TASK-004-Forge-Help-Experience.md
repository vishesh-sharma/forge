# TASK-004 — Forge Help Experience

| Field        | Value                     |
| ------------ | ------------------------- |
| Task ID      | TASK-004                  |
| Title        | Forge Help Experience     |
| Category     | Feature                   |
| Epic         | EPIC-001 — CLI Foundation |
| Priority     | High                      |
| Status       | Completed                 |
| Owner        | ForgeLabs Engineering     |
| Created      | 2026-07-12                |
| Last Updated | 2026-07-12                |

---

# Background

Forge currently supports command routing and environment validation through the `doctor` command.

The `--help` command remains a placeholder.

A professional command-line application should provide clear guidance for first-time users and expose available functionality through a consistent help experience.

---

# Objective

Replace the placeholder help output with a production-quality help experience that clearly communicates:

* What Forge is
* How Forge is used
* Which commands are currently available
* Where users can learn more

---

# Behavioral Contract

| Invocation           | Expected Behavior                               | Exit Code |
| -------------------- | ----------------------------------------------- | --------: |
| `forge --help`       | Display help information.                       |         0 |
| `forge help`         | Display identical help information.             |         0 |
| `forge --help extra` | Ignore additional arguments for this milestone. |         0 |
| `forge help extra`   | Ignore additional arguments for this milestone. |         0 |

---

# Scope

Included:

* Replace placeholder help output.
* Support both `help` and `--help`.
* Display current commands.
* Display usage information.
* Display documentation location.

Excluded:

* ANSI colors
* Interactive help
* Paging
* Dynamic command discovery
* Examples
* Plugin documentation
* Configuration documentation

---

# Constraints

Implementation shall:

* Follow KN-001 — Engineering Constitution.
* Follow STD-001 — Engineering Standards.
* Follow ADR-001 — Incremental CLI Architecture.
* Introduce no external NuGet packages.
* Build with zero warnings.
* Preserve deterministic output.
* Preserve existing command behavior.

---

# Technical Decisions

The following architectural decisions apply:

* `Program.cs` remains responsible only for command routing.
* Help functionality shall be implemented in a dedicated `HelpCommand` class.
* No command framework shall be introduced.
* No dependency injection shall be introduced.
* Help content shall be static for this milestone.

This continues the incremental architecture established by TASK-003.

---

# Help Output

The command shall produce the following output.

```text
Forge Engineering Toolkit

Repository-native engineering platform for humans and AI.

Usage
  forge [command]

Commands
  doctor        Validate the local development environment
  help          Display this help information

Options
  --help        Display this help information
  --version     Display version information

Documentation
  See the repository documentation under the docs/ directory.
```

The formatting shall remain deterministic.

---

# Acceptance Criteria

The task is complete when:

* `forge --help` displays the documented output.
* `forge help` displays identical output.
* Existing commands continue to function.
* Output is deterministic.
* Build completes with zero warnings.
* No unnecessary architectural changes are introduced.

---

# Verification

Execute:

```bash
dotnet build

dotnet run --project src/ForgeLabs.Forge.Cli -- --help

dotnet run --project src/ForgeLabs.Forge.Cli -- help
```

Verify:

* Output matches the documented help text.
* Exit code is `0`.
* Existing commands continue to behave correctly.
* `git diff --check` passes.

---

# Testing Strategy

Automated tests remain deferred.

The help command produces deterministic output and can be verified through documented manual execution.

Automated testing may be introduced when Forge establishes a shared testing strategy.

---

# Definition of Done

The task is complete when:

* All Acceptance Criteria are satisfied.
* Verification succeeds.
* Build completes with zero warnings.
* Documentation is updated where required.
* Code review is approved.
* No unresolved critical issues remain.

---

# Risks

* Future commands may require help text updates.
* Static help content may become outdated if not maintained.

These risks are acceptable for the current milestone.

---

# Assumptions

* Help content reflects the currently available commands.
* Documentation continues to reside under the `docs/` directory.

---

# Deliverables

* Updated `Program.cs`
* New `HelpCommand` implementation
* Production-quality help output

---

# References

* KN-001 — Engineering Constitution
* STD-001 — Engineering Standards
* ADR-001 — Incremental CLI Architecture
* PRD-001 — Forge Engineering Toolkit
* CAP-001 — Forge Capability Map
* ROADMAP-001 — Forge Product Roadmap
* EPIC-001 — CLI Foundation

---

# Suggested Commit Message

```text
feat: implement forge help command
```

---

# Implementation Review

Implementation completed successfully.

Summary

- Introduced a dedicated `HelpCommand` class.
- Preserved `Program.cs` as the command router.
- Replaced placeholder help output with deterministic production-quality help.
- Added support for both `forge help` and `forge --help`.
- Preserved all existing CLI behavior.
- Build completed with zero warnings.
- Manual verification completed successfully.
- `git diff --check` passed.

Result

Approved and merged.

---

# Lessons Learned

- Static help content is sufficient at the current maturity level.
- A dedicated command class improves separation of responsibilities without introducing unnecessary architecture.
- Help output should evolve alongside CLI capabilities.
- Manual verification remains appropriate for deterministic CLI output at this stage.

---

# Completion Checklist

- [x] Objective achieved
- [x] Behavioral Contract implemented
- [x] Acceptance Criteria satisfied
- [x] Verification completed
- [x] Documentation updated
- [x] Code reviewed
- [x] Merged
