# TASK-005 — Forge Version Information

| Field    | Value                     |
| -------- | ------------------------- |
| Task ID  | TASK-005                  |
| Title    | Forge Version Information |
| Category | Feature                   |
| Epic     | EPIC-001 — CLI Foundation |
| Priority | High                      |
| Status   | Completed                 |
| Owner    | ForgeLabs Engineering     |
| Release  | v0.5.0                    |

---

# Background

Forge currently supports:

* Default startup
* Help
* Doctor

The `--version` command remains a placeholder.

A production-quality CLI should identify itself consistently and deterministically.

---

# Objective

Replace the placeholder version output with production-quality version information.

---

# Behavioral Contract

| Invocation              | Expected Behavior                 | Exit Code |
| ----------------------- | --------------------------------- | --------: |
| `forge --version`       | Display product name and version. |         0 |
| `forge --version extra` | Ignore additional arguments.      |         0 |

---

# Output

```text
Forge Engineering Toolkit
Version: 0.5.0
```

Output shall be deterministic.

---

# Scope

Included

* Replace placeholder implementation.
* Introduce a dedicated `VersionCommand`.
* Support `forge --version`.
* Ignore additional arguments.

Excluded

* Git commit SHA
* Build timestamp
* Runtime information
* OS information
* Dynamic assembly version lookup
* Semantic version parsing

---

# Constraints

Implementation shall:

* Follow KN-001.
* Follow STD-001.
* Follow ADR-001.
* Introduce no external packages.
* Preserve existing command behavior.
* Produce deterministic output.
* Build with zero warnings.

---

# Technical Decisions

* `Program.cs` remains responsible only for routing.
* Introduce a dedicated `VersionCommand` class.
* Version information remains static for this milestone.
* No reflection or assembly metadata inspection.

---

# Acceptance Criteria

The task is complete when:

* `forge --version` displays the documented output.
* Additional arguments are ignored.
* Existing commands continue to behave correctly.
* Build succeeds with zero warnings.
* Manual verification succeeds.
* `git diff --check` passes.

---

# Verification

Execute:

```bash
dotnet build

dotnet run --project src/ForgeLabs.Forge.Cli -- --version

dotnet run --project src/ForgeLabs.Forge.Cli -- --version extra

dotnet run --project src/ForgeLabs.Forge.Cli -- doctor

dotnet run --project src/ForgeLabs.Forge.Cli -- --help

git diff --check
```

---

# Testing Strategy

Automated tests remain deferred.

Manual verification is sufficient for deterministic CLI output.

---

# Definition of Done

* Acceptance Criteria satisfied.
* Verification completed.
* Build succeeds with zero warnings.
* Documentation updated.
* Code review approved.
* Ready for merge.

---

# Deliverables

* `VersionCommand.cs`
* Updated `Program.cs`

---

# Capability Added

Forge can identify its released version through a deterministic CLI command.

---

# References

* KN-001
* STD-001
* ADR-001
* PRD-001
* CAP-001
* ROADMAP-001
* EPIC-001

---

# Suggested Commit Message

```text
feat: implement forge version command
```

---

# Implementation Review

Implementation completed successfully.

Summary

- Introduced a dedicated `VersionCommand` class.
- Preserved `Program.cs` as the command router.
- Replaced placeholder help output with deterministic production-quality help.
- Added support for both `version --help` and `version --help extra`.
- Preserved all existing CLI behavior.
- Build completed with zero warnings.
- Manual verification completed successfully.
- `git diff --check` passed.

Result

Approved and merged.

---

# Lessons Learned

*To be completed after implementation.*

---

# Completion Checklist

* [ ] Objective achieved
* [ ] Behavioral Contract implemented
* [ ] Acceptance Criteria satisfied
* [ ] Verification completed
* [ ] Documentation updated
* [ ] Code reviewed
* [ ] Merged
