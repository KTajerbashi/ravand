# Ravand — Product Roadmap & Release Stages

**Status:** Proposed sequencing — not approved  
**Version:** 0.1

This roadmap is capability-oriented, not date-oriented. Dates, team size, and delivery estimates must not be invented before scope and capacity are known.

## Stage 0 — Product validation and definition

**Goal:** Prove that the product solves a defined customer problem.

Deliverables:
- Primary positioning and customer segment.
- Buyer and user personas.
- Validated process scenarios.
- Competitive and alternative-solution analysis.
- Value proposition and measurable outcomes.
- Product boundaries and explicit exclusions.
- MVP definition and success criteria.

**Exit gate:** Product owner approves the problem, target customer, and product direction.

## Stage 1 — Platform foundation and first usable workflow

**Goal:** Execute one real business process end to end.

Candidate scope:
- Organization/workspace setup (deployment model dependent).
- Authentication and basic authorization.
- Process definition lifecycle at a minimal level.
- Basic process elements and conditional routing.
- Basic forms and validation.
- Process instance creation and persistence.
- Human task inbox and assignment.
- Approve/reject/complete actions.
- Basic notifications.
- Process history and audit trail.
- Basic operational visibility.
- Automated tests, secure configuration, logging, backup, and deployment baseline.

**Exit gate:** A representative customer can configure or use the first agreed process, run it reliably, and inspect its history.

## Stage 2 — Configurable workflow platform

**Goal:** Allow more than one process scenario without bespoke code for every workflow.

Candidate scope:
- Visual designer or selected modeling experience.
- Broader gateway/event/task support.
- Versioned process definitions.
- Form designer improvements.
- Organization/group-based assignment.
- Timers, deadlines, reminders, and escalation.
- Process templates.
- Search and operational dashboards.
- API and webhook baseline.
- Integration retry and failure visibility.

**Exit gate:** Several materially different customer processes can be modeled and operated through supported configuration.

## Stage 3 — Commercial readiness

**Goal:** Make the product dependable to deploy, administer, secure, support, and upgrade.

Candidate scope:
- Tenant isolation and lifecycle if multi-tenancy is selected.
- SSO/MFA according to customer requirements.
- Fine-grained access control.
- Audit export and retention controls.
- Backup/restore and disaster recovery procedures.
- Monitoring, metrics, tracing, and alerting.
- Environment promotion and controlled releases.
- Documentation, onboarding, support processes.
- Performance and security testing.
- Defined upgrade and compatibility policy.

**Exit gate:** Operational, security, support, and deployment readiness criteria are met for the chosen market.

## Stage 4 — Advanced BPM and integration

**Goal:** Support more complex enterprise process scenarios.

Candidate scope:
- Advanced BPMN elements as selected.
- Subprocesses and reusable process components.
- Advanced rules and decision tables.
- Message correlation and event-driven integration.
- Compensation and advanced exception handling.
- Process migration policies.
- Connector ecosystem.
- Advanced reporting and bottleneck analysis.
- Controlled extension/plugin mechanisms.

**Exit gate:** Advanced scenarios are supported with explicit semantics, failure handling, governance, and documentation.

## Stage 5 — Ecosystem and intelligence

**Goal:** Improve discoverability, extensibility, and operational insight.

Candidate scope:
- Process template catalog.
- Developer SDKs and sandbox.
- Process mining where justified by data quality and demand.
- AI-assisted process/form/documentation authoring.
- Natural-language search or operational summaries.
- MCP/agent integrations with least privilege and human approval.
- Additional channels and mobile experiences.

**Exit gate:** Each advanced feature demonstrates customer value, governance, security, and sustainable operating cost.

## Release policy

- A stage is not automatically approved because it appears in this roadmap.
- Features may move, split, be removed, or be replaced after evidence.
- MVP means the smallest coherent product that delivers a real outcome, not a miniature version of every module.
- Avoid building advanced BPMN coverage before validating the actual process scenarios.
- Avoid implementing billing/subscriptions until the commercial model is selected.
