# TASK-003 — Forge Doctor Command

| Field        | Value                     |
| ------------ | ------------------------- |
| Task ID      | TASK-003                  |
| Title        | Forge Doctor Command      |
| Category     | Feature                   |
| Epic         | EPIC-001 — CLI Foundation |
| Priority     | High                      |
| Status       | Draft                     |
| Owner        | ForgeLabs Engineering     |
| Created      | 2026-07-12                |
| Last Updated | 2026-07-12                |

---

# Background

Sprint 1 established the Forge CLI foundation.

Sprint 2 introduced deterministic command routing.

Forge can now recognize commands but provides only placeholder implementations.

The next milestone is to deliver the first command that provides practical value to developers.

---

# Objective

Implement the `forge doctor` command.

The command shall validate the local development environment and report whether the current environment is ready for Forge development.

This is the first production-ready command within the Forge CLI.

---

# Behavioral Contract

| Invocation           | Expected Behavior                                                                 |                         Exit Code |
| -------------------- | --------------------------------------------------------------------------------- | --------------------------------: |
| `forge doctor`       | Executes all health checks and displays a deterministic diagnostic report.        | 0 if all checks pass, otherwise 1 |
| `forge doctor extra` | Ignores additional arguments for this milestone and performs the same validation. |                     Same as above |

---

# Scope

This task includes:

* Implementing the `doctor` command.
* Executing the required environment checks.
* Producing deterministic terminal output.
* Returning the correct exit code.
* Preserving all existing CLI behavior introduced in previous tasks.

---

# Out of Scope

The following are intentionally excluded:

* Automatic environment repair
* Network connectivity checks
* GitHub authentication
* Azure authentication
* Docker validation
* IDE detection
* NuGet validation
* Plugin support
* Configuration files
* Colored terminal output
* JSON or machine-readable output

---

# Constraints

Implementation shall:

* Follow KN-001 — Engineering Constitution.
* Follow STD-001 — Engineering Standards.
* Follow ADR-001 — Incremental CLI Architecture.
* Introduce no external NuGet packages.
* Build with zero warnings.
* Keep the implementation platform-independent where practical.
* Execute only local validation.

---

# Technical Decisions

The following architectural decisions apply to this task:

* `Program.cs` remains responsible only for CLI routing.
* Doctor functionality shall be implemented in a dedicated `DoctorCommand` class.
* No command framework shall be introduced.
* No Dependency Injection or Generic Host shall be introduced.
* External tools shall be executed using standard .NET process APIs.

This extraction is considered an earned abstraction because command execution and environment validation now represent distinct responsibilities.

---

# Health Checks

The command shall perform the following checks in order.

## Check 1 — .NET SDK

Pass when:

* `dotnet --version` executes successfully.

Fail when:

* `dotnet` cannot be executed.

---

## Check 2 — Git

Pass when:

* `git --version` executes successfully.

Fail when:

* `git` cannot be executed.

---

## Check 3 — Git Repository

Pass when:

```text
git rev-parse --is-inside-work-tree
```

returns `true`.

Fail otherwise.

---

## Check 4 — Working Tree

Pass when:

```text
git status --porcelain
```

produces no output.

Fail otherwise.

---

# Output Format

The output shall remain deterministic.

Successful example:

```text
Forge Doctor

[PASS] .NET SDK
[PASS] Git
[PASS] Git Repository
[PASS] Working Tree

Overall Status: HEALTHY
```

Failure example:

```text
Forge Doctor

[PASS] .NET SDK
[FAIL] Git
       Git executable was not found.

Overall Status: FAILED
```

The wording may evolve in future tasks, but the output structure should remain stable.

---

# Acceptance Criteria

The task is complete when:

* `forge doctor` executes successfully.
* All four health checks are implemented.
* Each check reports PASS or FAIL.
* Overall status accurately reflects the result.
* Exit codes match the Behavioral Contract.
* Existing CLI commands continue to function.
* The project builds with zero warnings.

---

# Verification

Execute the following commands:

```bash
dotnet build

dotnet run --project src/ForgeLabs.Forge.Cli -- doctor
```

Manual verification scenarios:

1. Run inside a clean Git repository.
2. Run inside a repository with uncommitted changes.
3. Run outside a Git repository.
4. Temporarily make `git` unavailable (or simulate the failure) and verify graceful error handling.

Expected result:

* Output matches the Behavioral Contract.
* Exit codes are correct.
* No unhandled exceptions occur.

---

# Testing Strategy

Automated tests are intentionally deferred.

The command interacts with external executables and the local environment. Automated testing will be introduced once the command execution logic can be isolated behind testable abstractions without introducing unnecessary complexity.

Manual verification is sufficient for this milestone.

---

# Definition of Done

The task is complete when:

* All Acceptance Criteria are satisfied.
* Verification succeeds.
* Build completes with zero warnings and zero errors.
* Documentation is updated where required.
* Code review is approved.
* No unresolved critical issues remain.

---

# Risks

* Platform-specific command behavior.
* Different Git installations and PATH configurations.
* External process execution failures.
* False negatives caused by unexpected command output.

---

# Assumptions

* The user has a supported .NET SDK installed.
* Git is available on supported developer machines.
* Forge is executed from a terminal environment capable of launching external processes.

---

# Deliverables

* Updated `Program.cs`
* New `DoctorCommand` implementation
* Working `forge doctor` command
* Environment validation logic
* Updated documentation if required

---

# References

* KN-001 — Engineering Constitution
* STD-001 — Engineering Standards
* PRD-001 — Forge Engineering Toolkit
* CAP-001 — Forge Capability Map
* ADR-001 — Incremental CLI Architecture
* ROADMAP-001 — Forge Product Roadmap
* EPIC-001 — CLI Foundation

---

# Suggested Commit Message

```text
feat: implement forge doctor command
```

---

# Implementation Review

*To be completed after implementation.*

---

# Lessons Learned

*To be completed after implementation.*

---

# Completion Checklist

* [ ] Objective achieved
* [ ] Behavioral Contract implemented
* [ ] Scope completed
* [ ] Acceptance Criteria satisfied
* [ ] Verification completed
* [ ] Testing strategy followed
* [ ] Definition of Done satisfied
* [ ] Documentation updated
* [ ] Code reviewed
* [ ] Ready for merge
