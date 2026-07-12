# CAP-001 — Forge Capability Map

| Field         | Value                 |
| ------------- | --------------------- |
| Capability ID | CAP-001               |
| Title         | Forge Capability Map  |
| Status        | Active                |
| Owner         | ForgeLabs Engineering |
| Version       | 1.0                   |
| Last Updated  | 2026-07-12            |

---

# Purpose

Define the long-term capabilities of the Forge platform.

This document provides a stable product architecture that guides roadmap planning, Epic creation, and feature prioritization. It describes **what Forge should be capable of**, independent of implementation details.

---

# Product Vision

Forge is an AI-native engineering platform that transforms repository knowledge into actionable engineering context for humans and AI.

The platform is organized around a small number of core capabilities rather than individual CLI commands.

---

# Capability Hierarchy

```text
Forge
│
├── Repository
│   ├── Initialize
│   ├── Analyze
│   ├── Validate
│   └── Upgrade
│
├── Knowledge
│   ├── Create
│   ├── Organize
│   ├── Search
│   ├── Assemble Context
│   └── Maintain
│
├── Engineering
│   ├── Plan
│   ├── Design Review
│   ├── Review Resolution
│   ├── Implement
│   ├── Verify
│   └── Release
│
├── AI
│   ├── Context Packaging
│   ├── Engineering Assignments
│   ├── Implementation Review
│   └── Knowledge Assistance
│
└── Developer Experience
    ├── Help
    ├── Version
    ├── Doctor
    ├── Templates
    └── Diagnostics
```

---

# Capability Descriptions

## Repository

Provides capabilities for creating, validating, analyzing, and maintaining engineering repositories.

Example future commands:

* `forge init`
* `forge analyze`
* `forge doctor`

---

## Knowledge

Manages engineering knowledge contained within the repository.

This capability enables Forge to understand relationships between:

* Knowledge documents
* Standards
* PRDs
* ADRs
* Epics
* Tasks
* Reviews
* Review Resolutions

Future goal:

```text
forge context TASK-014
```

---

## Engineering

Supports the engineering lifecycle from planning through implementation and verification.

Forge should help engineers follow the Engineering System rather than replace engineering judgment.

---

## AI

Provides structured engineering context for AI-assisted development.

The objective is to reduce prompt engineering by allowing the repository to supply the required engineering context.

---

## Developer Experience

Provides commands that improve the day-to-day experience of using Forge.

Examples include:

* Help
* Version
* Doctor
* Templates

---

# Guiding Principles

Every capability should:

* Solve a real engineering problem.
* Be independently valuable.
* Build upon existing repository knowledge.
* Avoid unnecessary complexity.
* Integrate with existing developer tooling.

---

# Capability Relationships

```text
Knowledge
      │
      ▼
Engineering
      │
      ▼
AI
      ▲
      │
Repository ─────► Developer Experience
```

Knowledge is the foundation of the platform.

Engineering processes consume knowledge.

AI consumes structured engineering context.

Developer-facing commands expose these capabilities through a simple CLI.

---

# Roadmap Alignment

| Epic                                  | Primary Capability   |
| ------------------------------------- | -------------------- |
| EPIC-001 – CLI Foundation             | Developer Experience |
| EPIC-002 – Engineering Context        | Knowledge            |
| EPIC-003 – Documentation Engine       | Knowledge            |
| EPIC-004 – Project Bootstrap          | Repository           |
| EPIC-005 – Repository Analysis        | Repository           |
| EPIC-006 – AI Engineering Integration | AI                   |

Every Epic should primarily advance one platform capability.

---

# Non-Goals

This capability map intentionally excludes implementation details.

It does not define:

* CLI syntax
* Class structure
* Software architecture
* Technology choices

Those concerns belong to task specifications and architecture decisions.

---

# Evolution

The Capability Map should remain relatively stable.

New capabilities should be introduced only when they represent long-term product direction rather than individual features.

Features, commands, and implementation details may evolve without changing the capability structure.

---

# Success Criteria

The Capability Map is successful when:

* Every Epic maps to one or more capabilities.
* Every new CLI command supports an existing capability.
* Product planning is driven by capabilities rather than isolated features.
* The overall scope of Forge remains cohesive and understandable.
