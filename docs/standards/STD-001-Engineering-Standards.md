# STD-001 — ForgeLabs Engineering Standards

| Field        | Value                           |
| ------------ | ------------------------------- |
| Document ID  | STD-001                         |
| Title        | ForgeLabs Engineering Standards |
| Category     | Standards                       |
| Version      | 1.0                             |
| Status       | Approved                        |
| Owner        | ForgeLabs                       |
| Last Updated | 2026-07-11                      |

---

# Purpose

This document defines the engineering practices followed by ForgeLabs.

It translates the principles established in KN-001 into consistent day-to-day engineering behavior.

All repositories, engineering tasks, code reviews, documentation, and AI-assisted development should follow these standards unless an approved exception exists.

---

# Standard 1 — Work Begins with a Specification

Every meaningful implementation begins with a documented specification.

Depending on the scope, this may include:

* PRD
* RFC
* ADR
* Engineering Task

Implementation should not begin until the required specification exists.

---

# Standard 2 — Small, Reviewable Changes

Work should be delivered in small increments.

Each change should:

* Have a single objective.
* Be independently reviewable.
* Leave the repository in a working state.

---

# Standard 3 — Definition of Done

Work is complete only when:

* Acceptance criteria are satisfied.
* Code builds successfully.
* Automated tests pass (when applicable).
* Documentation is updated.
* Code review is completed.
* No known critical issues remain.

---

# Standard 4 — Repository Health

The default branch should always remain in a releasable state.

Broken builds should be treated as high-priority issues.

Builds must complete with zero warnings. Warnings must be resolved before merging unless an approved exception is documented.

---

# Standard 5 — Documentation as an Engineering Deliverable

Engineering work includes documentation.

Architectural decisions, standards, specifications, and lessons learned should be preserved alongside implementation.

Documentation should explain intent rather than duplicate source code.

---

# Standard 6 — AI-Assisted Engineering

Artificial intelligence is used to accelerate engineering work.

AI may assist with:

* Drafting
* Implementation
* Refactoring
* Testing
* Documentation
* Code review

Human engineers remain responsible for architecture, engineering judgment, security, and final approval.

---

# Standard 7 — Code Reviews

Every meaningful change should be reviewed before merging.

Reviews should evaluate:

* Correctness
* Simplicity
* Maintainability
* Alignment with architecture
* Alignment with KN-001

The goal of review is improvement rather than criticism.

---

# Standard 8 — Engineering Tasks

Every implementation task should include:

* Objective
* Background
* Scope
* Out of Scope
* Acceptance Criteria
* Definition of Done
* References
* Deliverables

Engineering tasks serve as the contract between design and implementation.

---

# Standard 9 — Continuous Improvement

After completing significant work, engineers should capture:

* Lessons learned
* Improvement opportunities
* Technical debt introduced or removed

Engineering standards evolve through experience.

---

# Standard 10 — Long-Term Maintainability

Engineering decisions should optimize for long-term clarity and maintainability.

Premature optimization, unnecessary complexity, and speculative abstractions should be avoided.

Simple systems that evolve intentionally are preferred over elaborate systems built for hypothetical future requirements.

---

# Governance

This document is expected to evolve.

Changes should be based on practical engineering experience and should remain consistent with the principles defined in KN-001.
