# ForgeLabs Repository Instructions

## Purpose

This repository follows the ForgeLabs Engineering System (FES).

Before making implementation decisions, always use the repository documentation as the primary source of truth.

Do not make architectural assumptions without first reviewing the referenced engineering documents.

---

# Source of Truth

Review documents in the following order.

1. Knowledge

   * `docs/knowledge/`

2. Standards

   * `docs/standards/`

3. Product Specifications

   * `docs/specifications/prd/`

4. Architecture Decisions

   * `docs/specifications/adr/`

5. Engineering Tasks

   * `docs/specifications/tasks/`

Implementation should align with these documents.

If conflicts exist, request clarification rather than making assumptions.

---

# Engineering Principles

When implementing code:

* Prefer simplicity over unnecessary abstraction.
* Build only what the current task requires.
* Avoid speculative design.
* Produce clean, readable, maintainable code.
* Keep the repository in a buildable state.
* Do not introduce dependencies without justification.
* Preserve existing architectural decisions.

---

# AI Responsibilities

AI may assist with:

* Implementation
* Refactoring
* Documentation
* Testing
* Code review
* Engineering analysis

AI should not redefine product vision, engineering standards, or architectural decisions without explicitly explaining the rationale.

---

# Implementation Workflow

For every implementation:

1. Review the referenced documents.
2. Identify ambiguities.
3. Recommend improvements where appropriate.
4. Implement only the requested scope.
5. Explain significant design decisions.
6. Identify follow-up improvements separately.

---

# Expected Output

Every implementation should provide:

* Summary of work completed
* Files created or modified
* Design decisions
* Build instructions
* Suggested commit message
* Future improvement opportunities

---

# Engineering Philosophy

ForgeLabs builds reusable engineering assets.

Optimize for long-term maintainability, clarity, and incremental evolution rather than maximum short-term output.
