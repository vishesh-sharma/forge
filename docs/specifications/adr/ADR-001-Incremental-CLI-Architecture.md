# ADR-001 — Incremental CLI Architecture

| Field   | Value                        |
| ------- | ---------------------------- |
| ADR ID  | ADR-001                      |
| Title   | Incremental CLI Architecture |
| Status  | Accepted                     |
| Owner   | ForgeLabs Engineering        |
| Date    | 2026-07-12                   |
| Version | 1.0                          |

---

# Purpose

Record the architectural approach for evolving the Forge command-line application.

This Architecture Decision Record establishes the principles governing when architectural abstractions should be introduced as Forge grows.

---

# Context

Forge is an AI-native engineering platform that is being developed incrementally through small, independently valuable engineering tasks.

The initial implementation consists of:

* A bootstrap command-line application.
* Basic command routing.
* A small number of user-facing commands.

As additional capabilities are introduced, the engineering team must decide whether to introduce architectural abstractions or continue evolving the application incrementally.

Premature architecture increases complexity, slows delivery, and creates maintenance overhead before there is sufficient evidence that the abstraction provides value.

---

# Decision

Forge will adopt an **incremental architecture**.

Architectural abstractions shall be introduced only when existing implementations demonstrate a clear and measurable need.

The application should evolve naturally as requirements become more complex.

The engineering team will prefer simple, direct implementations over generalized frameworks.

---

# Decision Drivers

This decision is guided by the following engineering principles:

* Simplicity is preferred over flexibility until flexibility is required.
* Architecture should emerge from proven implementation needs.
* Repository knowledge should remain easier to understand than the implementation itself.
* Every abstraction should solve an existing problem rather than anticipate a future one.
* Small, incremental improvements reduce long-term technical risk.

---

# Current Architectural Guidance

At the current stage of the project:

* Command routing remains within `Program.cs`.
* Additional command infrastructure is intentionally deferred.
* Dependency Injection is not required.
* Generic Host is not required.
* External frameworks are not required.
* Additional projects should not be introduced without clear justification.

These decisions are appropriate for the current scale of the application and should not be interpreted as permanent constraints.

---

# Consequences

## Positive

* Lower implementation complexity.
* Faster delivery of user-facing capabilities.
* Easier onboarding for new contributors.
* Smaller review surface.
* Reduced maintenance overhead.
* Architecture evolves from real requirements rather than assumptions.

## Trade-offs

* Some files may temporarily grow larger before responsibilities are extracted.
* Refactoring may occur as the product matures.
* Certain improvements may intentionally be deferred until justified by implementation experience.

These trade-offs are accepted in exchange for maintaining a simple and understandable codebase.

---

# Review Triggers

This decision should be revisited when one or more of the following conditions occur:

* Multiple commands begin sharing substantial behavior.
* Command routing becomes difficult to understand or maintain.
* Automated testing becomes unnecessarily difficult because of implementation structure.
* A single source file accumulates multiple independent responsibilities.
* New capabilities require reusable infrastructure that cannot reasonably remain within the current architecture.

Meeting one or more of these conditions does not automatically require a redesign, but it should initiate an architectural review.

---

# Alternatives Considered

## Introduce a Command Framework Immediately

Rejected.

While a command framework provides extensibility, it introduces complexity before there is sufficient evidence that the application requires it.

---

## Adopt Clean Architecture from the Beginning

Rejected.

The current application is intentionally small.

The additional layers, abstractions, and projects would provide little immediate value while increasing implementation and maintenance effort.

---

## Use Dependency Injection and Generic Host

Rejected for the current stage.

These technologies may become appropriate in future milestones, but they are not justified by the present requirements.

---

# Alignment

This decision aligns with:

* KN-001 — Engineering Constitution
* STD-001 — Engineering Standards
* PRD-001 — Forge Engineering Toolkit
* CAP-001 — Forge Capability Map

---

# Future Evolution

This ADR defines the current architectural philosophy rather than the permanent architecture of Forge.

As the product grows, future ADRs may supersede portions of this decision.

Architecture should continue to evolve through evidence gathered from implementation rather than speculative design.

---

# Status History

| Date       | Status   | Notes                                                         |
| ---------- | -------- | ------------------------------------------------------------- |
| 2026-07-12 | Accepted | Initial architectural decision for incremental CLI evolution. |
