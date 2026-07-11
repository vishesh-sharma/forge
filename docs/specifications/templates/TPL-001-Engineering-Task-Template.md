# TPL-001 — Engineering Task Template

| Field         | Value                     |
| ------------- | ------------------------- |
| Template ID   | TPL-001                   |
| Template Name | Engineering Task Template |
| Version       | 1.1                       |
| Status        | Active                    |
| Owner         | ForgeLabs Engineering     |
| Last Updated  | 2026-07-12                |

---

# Purpose

Describe a single engineering task in a deterministic, implementation-independent manner.

A completed task specification should provide sufficient information for an engineer—human or AI—to implement the task without making undocumented assumptions.

---

# Metadata

| Field        | Value                                      |
| ------------ | ------------------------------------------ |
| Task ID      | TASK-XXX                                   |
| Title        |                                            |
| Category     |                                            |
| Epic         |                                            |
| Priority     |                                            |
| Status       | Draft / Approved / In Progress / Completed |
| Owner        |                                            |
| Created      |                                            |
| Last Updated |                                            |

---

# Background

Describe the context that led to this task.

Explain why the task exists and how it relates to previous work.

---

# Objective

State the desired outcome of the task.

The objective should describe **what** is to be achieved rather than **how** it should be implemented.

---

# Behavioral Contract

Describe the externally observable behavior of the completed task.

This section defines the expected behavior from the perspective of the user or consuming system.

Where appropriate, specify behavior using a deterministic table.

Example:

| Invocation | Expected Behavior | Exit Code |
| ---------- | ----------------- | --------: |
| `example`  | Example output    |         0 |

The Behavioral Contract should eliminate ambiguity by defining expected inputs, outputs, and observable results.

---

# Scope

Describe everything included within the task.

The scope should be specific, measurable, and achievable within a single engineering task.

---

# Out of Scope

Explicitly list capabilities that are intentionally excluded.

Documenting exclusions reduces implementation ambiguity and prevents unnecessary scope expansion.

---

# Constraints

List engineering, architectural, business, or technical constraints that must be respected during implementation.

Examples include:

* Existing architecture
* Technology choices
* Coding standards
* Performance requirements
* Security requirements
* Repository standards

---

# Technical Decisions

Record important implementation decisions that intentionally influence the solution.

This section documents **why** the implementation should follow a particular approach without prescribing unnecessary detail.

Example:

* Routing remains in `Program.cs`.
* Dependency Injection is intentionally deferred.
* External packages are not permitted for this milestone.

---

# Acceptance Criteria

Define the measurable conditions required for task completion.

Each criterion should be objectively verifiable.

Acceptance criteria describe **what must be true** when the implementation is complete.

---

# Verification

Describe how the implementation will be verified.

Include:

* Build commands
* Test commands
* Manual verification steps
* Expected results

Verification procedures should be executable without additional explanation.

---

# Testing Strategy

Describe the testing expectations for this task.

Examples:

* Existing automated tests updated
* New automated tests required
* Manual verification only
* Automated testing intentionally deferred with rationale

---

# Definition of Done

The task is complete when:

* All Acceptance Criteria are satisfied.
* Verification succeeds.
* Build completes without warnings or errors.
* Documentation has been updated where required.
* Code review has been completed.
* No unresolved critical issues remain.

---

# Risks

Document significant technical, architectural, or delivery risks associated with the task.

Where appropriate, describe mitigation strategies.

---

# Assumptions

List assumptions made while preparing the specification.

These assumptions should be reviewed if implementation requirements change.

---

# Deliverables

List the expected outputs of the task.

Examples:

* Source code
* Documentation
* Tests
* Configuration
* Templates

---

# References

List all documents relevant to the implementation.

Examples:

* Knowledge documents
* Standards
* PRDs
* Epics
* ADRs
* RFCs
* Previous tasks

---

# Suggested Commit Message

Provide a conventional commit message appropriate for the completed task.

Example:

```text
feat: implement feature name
```

---

# Implementation Review

*To be completed after implementation.*

Summarize:

* Significant implementation decisions
* Deviations from the original specification
* Technical observations
* Follow-up recommendations

---

# Lessons Learned

*To be completed after implementation.*

Capture engineering knowledge discovered during implementation that may improve future work, templates, or standards.

Only durable lessons should be promoted into the ForgeLabs Engineering System.

---

# Completion Checklist

* [ ] Objective achieved
* [ ] Behavioral Contract implemented
* [ ] Scope completed
* [ ] Acceptance Criteria satisfied
* [ ] Verification completed
* [ ] Testing completed or intentionally deferred
* [ ] Definition of Done satisfied
* [ ] Documentation updated
* [ ] Code reviewed
* [ ] Ready for merge
