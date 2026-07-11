# TPL-001 — Engineering Task Template

| Field        | Value                     |
| ------------ | ------------------------- |
| Document ID  | TPL-001                   |
| Title        | Engineering Task Template |
| Category     | Specification Template    |
| Version      | 1.0                       |
| Status       | Approved                  |
| Owner        | ForgeLabs                 |
| Last Updated | 2026-07-11                |

---

# Purpose

This template defines the standard format for all engineering tasks at ForgeLabs.

Every implementation task should follow this structure to ensure consistent planning, implementation, review, and traceability.

The completed task specification serves as the contract between product, architecture, engineering, and AI-assisted implementation.

---

# Document Information

| Field        | Value                                      |
| ------------ | ------------------------------------------ |
| Task ID      | TASK-XXX                                   |
| Title        |                                            |
| Priority     | Critical / High / Medium / Low             |
| Status       | Draft / Approved / In Progress / Completed |
| Owner        |                                            |
| Created      |                                            |
| Last Updated |                                            |

---

# Objective

Describe the single objective of this task.

The objective should clearly state **what** will be delivered, not how it will be implemented.

---

# Background

Explain why this task exists.

Include any relevant business, engineering, or architectural context that helps future engineers understand the motivation behind the work.

---

# Scope

Clearly define what is included in this task.

Only include work that is expected to be completed as part of this implementation.

---

# Out of Scope

Explicitly describe work that is intentionally excluded.

This section prevents scope creep and reduces ambiguity.

---

# Constraints

List constraints that must be respected.

Examples include:

* Architectural decisions
* Existing standards
* Technology constraints
* Performance requirements
* Security requirements
* Compatibility requirements

---

# Acceptance Criteria

Describe observable outcomes that determine whether the task has been successfully completed.

Acceptance criteria should be specific, measurable, and independently verifiable.

---

# Definition of Done

The task is complete only when all applicable conditions are satisfied.

Typical items include:

* Acceptance criteria satisfied
* Solution builds successfully
* Tests pass (where applicable)
* Documentation updated
* Code reviewed
* No unresolved critical issues

---

# References

List all documents required to understand this task.

Examples:

* KN-001 – Engineering Constitution
* STD-001 – Engineering Standards
* PRD-001
* ADR-001
* RFC-001

Reference documents rather than duplicating their content.

---

# Deliverables

List the expected outputs of this task.

Examples:

* Source code
* Documentation
* Tests
* Configuration
* Scripts
* Architecture updates

---

# Risks and Assumptions

Document known assumptions, dependencies, and implementation risks.

This helps reviewers understand potential trade-offs before implementation begins.

---

# Engineering Value Assessment

| Metric               | Rating |
| -------------------- | ------ |
| Customer Value       |        |
| Engineering Leverage |        |
| Business Risk        |        |
| Technical Complexity |        |

This assessment helps prioritize work based on long-term value rather than implementation effort alone.

---

# Implementation Review

To be completed after implementation.

Capture:

* Significant design decisions
* Challenges encountered
* Deviations from the original plan
* Future improvement opportunities

---

# Lessons Learned

Summarize knowledge gained while completing the task.

Lessons learned should improve future engineering work and may result in updates to engineering standards or reusable assets.

---

# Suggested Commit Message

Provide a concise commit message describing the completed work.

---

# Completion Checklist

* [ ] Objective achieved
* [ ] Scope completed
* [ ] Acceptance criteria satisfied
* [ ] Definition of Done satisfied
* [ ] Documentation updated
* [ ] Implementation reviewed
* [ ] Lessons learned recorded
* [ ] Ready for merge