# Ravand — Product Discovery & Master Plan

**Document status:** Working draft — not approved  
**Version:** 0.1  
**Product:** Ravand  
**Purpose:** Central navigation and governance for product discovery, requirements, scope, and roadmap.

## 1. How to use this document set

This folder is the working source of truth for Ravand product discovery. It is not an implementation specification and does not authorize GitHub changes.

Read and maintain the documents in this order:

1. `01-product-vision-and-positioning.md` — product identity and problem hypotheses.
2. `02-capability-map.md` — broad capability inventory from foundational to advanced.
3. `03-requirements-and-use-cases.md` — functional requirement groups and end-to-end use cases.
4. `04-roadmap-and-release-stages.md` — staged delivery from discovery through mature platform.
5. `05-domain-boundaries-and-integrations.md` — candidate domain boundaries and system boundaries.
6. `06-non-functional-requirements.md` — quality attributes and operational requirements.
7. `07-decisions-and-open-questions.md` — decisions, assumptions, unresolved questions, and change history.

## 2. Status vocabulary

Use these labels consistently:

- **Confirmed:** explicitly approved by the product owner.
- **Proposed:** recommended for discussion; not approved.
- **Candidate:** a possible capability or scope item.
- **Deferred:** intentionally postponed to a later release.
- **Out of scope:** explicitly excluded.
- **Unknown:** requires discovery or evidence.

No item in this initial document set is approved merely because it appears here. Unless explicitly stated otherwise, all capability groups are **Candidate**.

## 3. Product discovery rules

- Discover the customer problem before selecting technology.
- Distinguish the buyer, administrator, process designer, operator, approver, and requester.
- Distinguish a reusable BPM/workflow platform from a fixed office-automation application.
- Do not assume every organization needs every capability.
- Every capability must have a user, problem, value, priority, acceptance criteria, and release target before implementation.
- Avoid implementing generic abstractions without validated use cases.
- Keep tenant-specific data, configuration, identity, and operational boundaries explicit if multi-tenancy is approved.
- Integrations must have explicit contracts, ownership, failure handling, and security.
- AI, low-code extensions, mobile clients, and advanced analytics are not automatic MVP requirements.

## 4. Current product hypothesis

**Proposed hypothesis:** Ravand may become a configurable business process management and workflow automation platform that enables organizations to model, publish, execute, monitor, and improve business processes.

This is a discovery hypothesis, not a final product definition. The exact positioning (office automation, general BPM platform, broader enterprise operations platform, or a narrower product) remains open.

## 5. Governance

The product owner reviews and approves each discovery stage. The assistant may draft, analyze, and revise documents, but must not create, modify, rename, delete, archive, or otherwise change GitHub repositories until the user gives explicit authorization.

## 6. Change control

For each material change:
1. Record the date.
2. Identify the affected capability or decision.
3. Explain the reason and evidence.
4. Identify impact on scope, roadmap, domain boundaries, and dependencies.
5. Mark the decision as proposed or confirmed only after product-owner approval.

## 7. Document map

| File | Purpose |
|---|---|
| `01-product-vision-and-positioning.md` | Vision, problem, customers, value, positioning |
| `02-capability-map.md` | Capability inventory |
| `03-requirements-and-use-cases.md` | Functional requirements and workflows |
| `04-roadmap-and-release-stages.md` | Delivery stages and release gates |
| `05-domain-boundaries-and-integrations.md` | Candidate domains and integration boundaries |
| `06-non-functional-requirements.md` | Quality attributes |
| `07-decisions-and-open-questions.md` | Decision register and unresolved questions |
