# Ravand — Domain Boundaries & Integration Strategy

**Status:** Candidate boundaries — not approved  
**Version:** 0.1

## 1. Purpose

This document prevents Ravand from becoming an unbounded collection of ERP, CRM, HR, service desk, collaboration, and document-management features.

The domains below are candidates for discovery. They are not a finalized bounded-context map or code/module structure.

## 2. Candidate domain areas

| Domain area | Owns | Should not silently own |
|---|---|---|
| Organization & Workspace | Organization profile, workspace settings, organizational units if selected | Full HR employee lifecycle or payroll |
| Identity & Access | Authentication, identities, roles, permissions, sessions | External identity provider's source-of-truth data |
| Process Definition | Models, definitions, versions, publication lifecycle | Runtime execution state |
| Process Runtime | Instances, tokens/state, transitions, timers, incidents | Business master data owned by external systems |
| Forms & Data Capture | Form schemas, validation, submission experience | Full enterprise data warehouse |
| Human Task Management | Work items, assignment, claim, completion, delegation | General project management or team chat |
| Rules & Decisions | Evaluated policies, conditions, decision tables | Arbitrary application scripting without governance |
| Notifications | Templates, preferences, delivery orchestration | Full email marketing platform |
| Integration | Connectors, credentials references, webhooks, delivery/retry state | Ownership of external systems' business domains |
| Audit & Compliance | Audit records, evidence, retention policy | Unbounded event analytics |
| Reporting & Analytics | Operational views and selected metrics | Full BI/data warehouse platform |
| File/Attachment Management | Files attached to Ravand records and their access metadata | Enterprise content management unless explicitly selected |
| Platform Operations | Tenant/platform operations, configuration, health, usage | Customer business process ownership |

## 3. Portfolio boundary candidates

Potentially separate products in the wider portfolio:
- Nivora: enterprise resources and operations.
- StockPilot: inventory and supply chain.
- Servexa: service requests and support management.
- Meetra: team collaboration and real-time communication.
- Knowlia: enterprise knowledge management and AI assistance.

Ravand may orchestrate processes involving these products, but should not absorb their core domain models by default.

Examples:
- Ravand can orchestrate a purchase approval; StockPilot or an external ERP may own stock and procurement records.
- Ravand can route a service request; Servexa may own the service desk lifecycle if that product is approved.
- Ravand can invoke an HR system for employee data; it should not become a payroll system by implication.
- Ravand can attach or reference a document; it should not automatically become a full document-management system.

## 4. Integration principles

- API contracts must be explicit, versioned, authenticated, and documented.
- External calls must have timeout, retry, idempotency, and failure policies appropriate to the operation.
- Never assume a remote call and a local database transaction form one atomic transaction.
- Use correlation identifiers to trace a process across systems.
- Secrets must be stored and rotated securely.
- Webhook receivers must authenticate and validate incoming messages.
- Integration failures must be visible and operationally recoverable.
- Avoid direct database coupling between independently owned products.
- Prefer supported APIs, events, or versioned packages over shared database tables.

## 5. Integration patterns to evaluate

- Synchronous request/response for short, bounded operations.
- Webhooks for event notification.
- Message broker for decoupled asynchronous communication when justified.
- Outbox/inbox patterns where reliable event publication/consumption is required.
- Saga/compensation for multi-system business transactions where rollback is not atomic.
- Polling only when push/event integration is unavailable or unsuitable.

These are options, not mandatory patterns for every integration.

## 6. Boundary review checklist

- Is this capability central to workflow/BPM?
- Does another product own this business concept?
- Would implementing it create duplicate master data?
- Can Ravand orchestrate the use case through a contract instead?
- Who owns data quality, lifecycle, authorization, and support?
- What happens when the external system is unavailable?
