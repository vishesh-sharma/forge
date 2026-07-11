# TASK-002 — CLI Command Infrastructure

| Field        | Value                      |
| ------------ | -------------------------- |
| Task ID      | TASK-002                   |
| Title        | CLI Command Infrastructure |
| Category     | Engineering Task           |
| Epic         | EPIC-001 — CLI Foundation  |
| Priority     | High                       |
| Status       | Complete                   |
| Owner        | ForgeLabs Engineering      |
| Created      | 2026-07-12                 |
| Last Updated | 2026-07-12                 |

---

# Purpose

Introduce the first command-routing capability for the Forge CLI.

This task establishes the minimum infrastructure required to support multiple commands while preserving the engineering principles defined in KN-001 and the engineering standards defined in STD-001.

The objective is to evolve Forge from a single executable into a command-line application without introducing unnecessary architectural complexity.

---

# Background

Sprint 1 validated the ForgeLabs Engineering System through the successful implementation of a minimal executable application.

The next milestone is to enable Forge to recognize and route supported commands while intentionally deferring command implementations to future tasks.

This task focuses exclusively on command selection and routing.

---

# Objective

Implement a simple command-routing mechanism that:

* Parses command-line arguments.
* Identifies supported commands.
* Routes execution to the appropriate placeholder response.
* Handles unsupported commands gracefully.
* Returns consistent exit codes.

---

# Behavioral Contract

The Behavioral Contract defines the externally observable behavior of the application for this milestone.

| Invocation                | Expected Behavior                                                                                      | Exit Code |
| ------------------------- | ------------------------------------------------------------------------------------------------------ | --------: |
| `forge`                   | Display the existing Forge startup banner followed by: `Run 'forge --help' to see available commands.` |         0 |
| `forge --help`            | Display: `Help is not yet implemented.`                                                                |         0 |
| `forge --version`         | Display: `Version information is not yet implemented.`                                                 |         0 |
| `forge doctor`            | Display: `Doctor is not yet implemented.`                                                              |         0 |
| `forge <unknown-command>` | Display: `Unknown command: <unknown-command>` followed by `Run 'forge --help' for available commands.` |         1 |

---

# Command Rules

For this milestone:

* Commands are case-sensitive.
* Only the first command-line argument is evaluated.
* Additional arguments are ignored.
* Command aliases are not supported.
* Subcommands are not supported.
* Command-specific option parsing is out of scope.

---

# Scope

This task includes:

* Reading command-line arguments.
* Routing supported commands.
* Producing placeholder responses.
* Returning appropriate exit codes.
* Preserving the startup banner for the default invocation.

---

# Out of Scope

The following capabilities are intentionally excluded:

* Doctor implementation
* Version retrieval
* Help generation
* Generic Host
* Dependency Injection
* Logging
* Configuration
* Plugin architecture
* Template engine
* AI integrations
* Command framework
* Custom argument parser

---

# Constraints

The implementation shall:

* Follow KN-001 — Engineering Constitution.
* Follow STD-001 — Engineering Standards.
* Align with EPIC-001 — CLI Foundation.
* Keep all routing logic inside `Program.cs`.
* Use a single `switch` statement (or equivalent simple branching) for command routing.
* Avoid premature abstractions.
* Introduce no external dependencies.
* Produce zero compiler warnings.
* Build successfully using the required .NET SDK.

---

# Technical Decisions

The application lifecycle remains intentionally simple for this milestone.

```
Program.cs
      │
      ▼
Read command-line arguments
      │
      ▼
Select command
      │
      ▼
Display placeholder response
      │
      ▼
Return exit code
```

No additional application classes or routing abstractions should be introduced.

---

# Acceptance Criteria

The task is complete when:

* The application builds successfully.
* All supported commands produce the expected output.
* Unsupported commands are handled gracefully.
* Exit codes conform to the Behavioral Contract.
* Existing startup banner behavior is preserved.
* No unnecessary abstractions have been introduced.
* No additional projects or NuGet packages have been added.

---

# Verification

The following commands shall be executed during verification:

```bash
dotnet build

dotnet run --project src/ForgeLabs.Forge.Cli

dotnet run --project src/ForgeLabs.Forge.Cli -- --help

dotnet run --project src/ForgeLabs.Forge.Cli -- --version

dotnet run --project src/ForgeLabs.Forge.Cli -- doctor

dotnet run --project src/ForgeLabs.Forge.Cli -- unknown
```

Expected verification results:

* Build succeeds with zero errors.
* Build succeeds with zero warnings.
* Output matches the Behavioral Contract.
* Exit codes match the Behavioral Contract.

---

# Testing Strategy

Automated tests are intentionally deferred for this milestone.

The routing logic is intentionally minimal and remains within `Program.cs`. Dedicated automated tests will be introduced when routing evolves into independently testable components.

Manual verification defined in this task is sufficient for completion.

---

# Definition of Done

The task is considered complete when:

* All acceptance criteria are satisfied.
* Verification has been completed successfully.
* Build succeeds with zero warnings.
* Code review has been completed.
* Documentation has been updated where required.
* No unresolved critical issues remain.

---

# Risks

* Introducing unnecessary abstractions.
* Expanding the scope beyond command routing.
* Modifying behavior introduced by TASK-001.
* Introducing inconsistent command behavior.

---

# Assumptions

* Future tasks will replace placeholder responses with real implementations.
* Future tasks may introduce richer command parsing once justified by implementation experience.
* The current routing mechanism is intentionally temporary and may evolve after multiple commands share common behavior.

---

# Deliverables

* Updated `Program.cs`
* Simple command-routing logic
* Placeholder responses for supported commands
* Graceful handling of unknown commands

---

# References

* KN-001 — Engineering Constitution
* STD-001 — Engineering Standards
* PRD-001 — Forge Engineering Toolkit
* EPIC-001 — CLI Foundation
* RET-001 — Sprint 1 Retrospective

---

# Suggested Commit Message

```
feat: introduce CLI command routing
```

---

# Implementation Review

Successfully completed TASK-002.

The implementation:

remained within the approved scope,
modified only the expected source file,
avoided unnecessary abstractions,
satisfied the documented acceptance criteria.

---

# Lessons Learned

Behavioral Contracts significantly reduced implementation ambiguity.
Review → Resolution → Documentation Validation is an effective quality gate.
Simple specifications produced simple implementations.
The repository is increasingly becoming the primary source of engineering knowledge.

---

# Completion Checklist

* [ ] Objective achieved
* [ ] Behavioral Contract implemented
* [ ] Command Rules implemented
* [ ] Acceptance Criteria satisfied
* [ ] Verification completed
* [ ] Definition of Done satisfied
* [ ] Code reviewed
* [ ] Documentation updated
* [ ] Lessons Learned recorded
* [ ] Ready for merge
