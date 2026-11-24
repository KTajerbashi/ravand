# Ravand — Product Capability Map

**Status:** Candidate inventory — not an approved commitment  
**Version:** 0.1

This map is deliberately broad so the product owner can see the possible end-to-end product landscape. It does not mean every item belongs in the product, nor that all items should be built.

Priority labels are provisional:
- **P0:** essential to a credible first usable product, subject to positioning.
- **P1:** important for a dependable commercial product.
- **P2:** advanced capability or expansion.
- **P3:** optional, specialized, or ecosystem capability.

## A. Organization, tenant, and workspace management

| ID | Capability | Description | Provisional priority |
|---|---|---|---|
| ORG-01 | Organization/workspace registration | Create and configure an organization workspace | P0 |
| ORG-02 | Organization profile | Name, contact, locale, timezone, branding | P0 |
| ORG-03 | Multi-tenancy | Isolate organizations and their data/configuration | P1 — decision required |
| ORG-04 | Organization hierarchy | Departments, units, teams, locations | P1 |
| ORG-05 | Membership management | Invite, activate, suspend, remove members | P0 |
| ORG-06 | Tenant lifecycle | Provision, suspend, reactivate, export, close tenant | P1 |
| ORG-07 | Tenant-specific settings | Locale, date format, policies, feature switches | P1 |
| ORG-08 | Tenant usage limits | Quotas and plan limits | P2 |
| ORG-09 | Tenant branding | Logo, colors, login and email branding | P2 |
| ORG-10 | Multiple workspaces per user | User belongs to multiple organizations | P2 |

## B. Identity, authentication, and access control

| ID | Capability | Description | Priority |
|---|---|---|---|
| IAM-01 | Local authentication | Secure account sign-in | P0 |
| IAM-02 | Password lifecycle | Reset, change, recovery, lockout | P0 |
| IAM-03 | Role-based access control | Roles and permission assignments | P0 |
| IAM-04 | Fine-grained permissions | Permission checks at resource/action level | P1 |
| IAM-05 | Organization-scoped roles | Roles constrained to tenant/org unit | P1 |
| IAM-06 | Delegation | Delegate authority for a defined period/scope | P1 |
| IAM-07 | Single sign-on | OIDC/SAML or other selected SSO | P2 |
| IAM-08 | MFA | Multi-factor authentication | P1 |
| IAM-09 | Session/device management | View and revoke active sessions | P1 |
| IAM-10 | External identity provider integration | Connect enterprise identity provider | P2 |
| IAM-11 | Service accounts/API credentials | Machine identities with scoped permissions | P1 |
| IAM-12 | Access review | Review and certify permissions | P2 |

## C. Process modeling and design

| ID | Capability | Description | Priority |
|---|---|---|---|
| BPM-01 | Process definition | Create a named, versioned process definition | P0 |
| BPM-02 | Visual process designer | Model process flow visually | P1 |
| BPM-03 | BPMN 2.0 support | Define supported BPMN elements and conformance | P1 — scope decision |
| BPM-04 | Start/end events | Define process entry and completion | P0 |
| BPM-05 | User tasks | Human work steps | P0 |
| BPM-06 | Service tasks | Automated work/integration steps | P1 |
| BPM-07 | Exclusive gateways | Conditional branching | P0 |
| BPM-08 | Parallel gateways | Parallel paths and synchronization | P1 |
| BPM-09 | Inclusive/event-based gateways | Advanced routing semantics | P2 |
| BPM-10 | Timers and scheduled events | Delays, deadlines, scheduled triggers | P1 |
| BPM-11 | Message/signal events | React to messages or signals | P2 |
| BPM-12 | Subprocesses | Reusable or nested process segments | P2 |
| BPM-13 | Call activities | Invoke another process definition | P2 |
| BPM-14 | Process variables | Typed runtime data | P0 |
| BPM-15 | Expressions | Conditions and value expressions | P1 |
| BPM-16 | Process templates | Start from reusable templates | P1 |
| BPM-17 | Draft and publish lifecycle | Draft, validate, publish, retire | P0 |
| BPM-18 | Model validation | Detect invalid or incomplete models | P1 |
| BPM-19 | Simulation | Simulate paths and outcomes | P3 |
| BPM-20 | Designer collaboration | Shared editing, comments, review | P3 |
| BPM-21 | Import/export definitions | Exchange supported process formats | P2 |
| BPM-22 | Process documentation | Attach descriptions and ownership metadata | P1 |

## D. Process versioning and governance

| ID | Capability | Description | Priority |
|---|---|---|---|
| GOV-01 | Immutable published versions | Published process versions remain identifiable | P0 |
| GOV-02 | Version comparison | Compare definition changes | P1 |
| GOV-03 | Controlled deployment | Promote definitions between environments | P1 |
| GOV-04 | Activation/deactivation | Control which version starts new instances | P0 |
| GOV-05 | Running-instance version policy | Define behavior when a new version is published | P0 |
| GOV-06 | Approval of process changes | Review/approve before publication | P2 |
| GOV-07 | Process ownership | Assign accountable owner | P1 |
| GOV-08 | Change history | Track who changed definition and when | P1 |
| GOV-09 | Deprecation/retirement | Retire old definitions safely | P1 |

## E. Forms and data capture

| ID | Capability | Description | Priority |
|---|---|---|---|
| FORM-01 | Form designer | Configure forms for process steps | P0 |
| FORM-02 | Basic field types | Text, number, date, select, checkbox, file | P0 |
| FORM-03 | Validation rules | Required, format, range, custom rules | P0 |
| FORM-04 | Conditional visibility | Show/hide fields based on values | P1 |
| FORM-05 | Dynamic options | Load choices from data/API | P1 |
| FORM-06 | Repeating sections | Collections of line items | P1 |
| FORM-07 | Multi-step forms | Wizard-style data entry | P1 |
| FORM-08 | Read-only/review mode | Display submitted data for review | P0 |
| FORM-09 | Form permissions | Control view/edit by role or task | P1 |
| FORM-10 | File attachments | Upload and associate files with records | P1 |
| FORM-11 | Form templates | Reuse form definitions | P1 |
| FORM-12 | Localization | Labels and validation messages per locale | P1 |
| FORM-13 | Accessibility | Keyboard and assistive technology support | P1 |
| FORM-14 | Form versioning | Keep form schema compatible with process versions | P1 |
| FORM-15 | External/public forms | Allow controlled submission without full account | P2 |
| FORM-16 | Save draft/autosave | Preserve incomplete submissions | P1 |

## F. Workflow execution and orchestration

| ID | Capability | Description | Priority |
|---|---|---|---|
| RUN-01 | Start process instance | Start from published definition | P0 |
| RUN-02 | Execute process tokens/state | Advance execution according to model semantics | P0 |
| RUN-03 | Evaluate gateways | Route based on variables/rules | P0 |
| RUN-04 | Create human tasks | Generate work for users/groups | P0 |
| RUN-05 | Execute service tasks | Invoke configured automation | P1 |
| RUN-06 | Pause/resume | Suspend and continue instance | P1 |
| RUN-07 | Cancel/terminate | End instance according to policy | P1 |
| RUN-08 | Retry failed activity | Controlled retry with limits | P1 |
| RUN-09 | Incident/error handling | Capture and manage execution failures | P1 |
| RUN-10 | Compensation | Execute defined compensating actions | P2 |
| RUN-11 | Boundary/error events | Handle modeled exceptions | P2 |
| RUN-12 | Correlation | Match external events to running instances | P2 |
| RUN-13 | Concurrency control | Prevent unsafe duplicate or conflicting transitions | P1 |
| RUN-14 | Idempotent command handling | Safely handle repeated requests/events | P1 |
| RUN-15 | Long-running process support | Persist state across days/months | P0 |
| RUN-16 | Execution history | Track activity transitions | P0 |
| RUN-17 | Process migration | Move running instances to new definitions under policy | P3 |
| RUN-18 | Bulk operations | Controlled bulk actions on instances | P2 |

## G. Human tasks and work management

| ID | Capability | Description | Priority |
|---|---|---|---|
| TASK-01 | Personal inbox | Tasks assigned to current user | P0 |
| TASK-02 | Team/group queue | Tasks available to a group | P1 |
| TASK-03 | Claim/release task | Take or return an unclaimed task | P1 |
| TASK-04 | Assign/reassign task | Assign task to eligible user/group | P0 |
| TASK-05 | Approve/reject | Standard decision actions | P0 |
| TASK-06 | Return/request changes | Send work back with reason | P1 |
| TASK-07 | Delegate task | Transfer task under policy | P1 |
| TASK-08 | Due dates and priority | Manage deadlines and urgency | P1 |
| TASK-09 | Comments and discussion | Contextual discussion on task | P1 |
| TASK-10 | Task attachments | Attach evidence/files | P1 |
| TASK-11 | Task checklist | Structured sub-steps | P2 |
| TASK-12 | Bulk task actions | Apply permitted actions to multiple tasks | P2 |
| TASK-13 | Task history | Audit assignment and completion events | P0 |
| TASK-14 | Out-of-office handling | Reassign/delegate during absence | P2 |

## H. Rules, decisions, and policies

| ID | Capability | Description | Priority |
|---|---|---|---|
| RULE-01 | Conditional routing | Route based on process data | P0 |
| RULE-02 | Configurable business rules | Define rules without code where feasible | P1 |
| RULE-03 | Decision tables | Tabular decision logic | P2 |
| RULE-04 | Rule versioning | Version and publish rule sets | P2 |
| RULE-05 | Approval policies | Configure approval thresholds/levels | P1 |
| RULE-06 | Escalation policies | Escalate overdue or unhandled work | P1 |
| RULE-07 | Delegation policies | Define eligible delegation | P1 |
| RULE-08 | Rule testing | Test rules against sample inputs | P2 |

## I. Organization structure and directory

| ID | Capability | Description | Priority |
|---|---|---|---|
| DIR-01 | Departments/units | Maintain organizational units | P1 |
| DIR-02 | Teams/groups | Define work groups | P1 |
| DIR-03 | Positions/job roles | Model positions if required | P2 |
| DIR-04 | Reporting lines | Manager relationships | P2 |
| DIR-05 | User-to-unit membership | Associate users with units | P1 |
| DIR-06 | Process participant resolution | Resolve users/groups from org data | P1 |
| DIR-07 | Organization structure history | Preserve historical context where needed | P3 |

## J. Notifications and communications

| ID | Capability | Description | Priority |
|---|---|---|---|
| NOTIF-01 | In-app notifications | Notify users inside product | P0 |
| NOTIF-02 | Email notifications | Send configurable email alerts | P1 |
| NOTIF-03 | Notification templates | Manage message templates | P1 |
| NOTIF-04 | User preferences | Choose channels and notification categories | P2 |
| NOTIF-05 | Reminder schedules | Remind before/after deadlines | P1 |
| NOTIF-06 | Escalation notifications | Notify supervisors/owners | P1 |
| NOTIF-07 | Delivery status | Track delivery/failure where supported | P2 |
| NOTIF-08 | SMS/push/chat channels | Additional channels through integrations | P3 |

## K. Documents and attachments

| ID | Capability | Description | Priority |
|---|---|---|---|
| DOC-01 | File upload/download | Attach files to forms, tasks, instances | P1 |
| DOC-02 | File metadata | Type, size, owner, timestamps | P1 |
| DOC-03 | Access-controlled files | Enforce tenant and resource permissions | P1 |
| DOC-04 | File scanning | Malware scanning integration | P2 |
| DOC-05 | Document preview | Preview supported file types | P2 |
| DOC-06 | Document templates | Generate documents from process data | P2 |
| DOC-07 | E-signature integration | Connect external signing provider | P3 |
| DOC-08 | Retention and deletion policy | Govern file lifecycle | P2 |

## L. Search, dashboards, and reporting

| ID | Capability | Description | Priority |
|---|---|---|---|
| REP-01 | My work dashboard | Personal tasks and process overview | P0 |
| REP-02 | Process instance list/search | Find and filter instances | P0 |
| REP-03 | Operational dashboard | Current workload and process state | P1 |
| REP-04 | Task aging | Identify overdue/old tasks | P1 |
| REP-05 | Process duration metrics | Measure cycle and waiting time | P1 |
| REP-06 | Bottleneck analysis | Identify slow process stages | P2 |
| REP-07 | Completion/failure metrics | Track outcomes | P1 |
| REP-08 | Custom reports | Configure report dimensions/filters | P2 |
| REP-09 | Export reports | CSV/Excel/PDF as appropriate | P2 |
| REP-10 | Scheduled reports | Deliver reports periodically | P3 |
| REP-11 | Full-text search | Search permitted process data | P2 |
| REP-12 | Process mining | Discover process patterns from event data | P3 |

## M. Audit, compliance, and traceability

| ID | Capability | Description | Priority |
|---|---|---|---|
| AUD-01 | Audit trail | Record security and business-relevant actions | P0 |
| AUD-02 | Actor/time/action context | Identify who did what and when | P0 |
| AUD-03 | Process event history | Preserve process lifecycle events | P0 |
| AUD-04 | Before/after values | Capture changes where policy permits | P1 |
| AUD-05 | Audit search/export | Review and export audit evidence | P1 |
| AUD-06 | Tamper resistance | Protect audit records from unauthorized alteration | P1 |
| AUD-07 | Retention policies | Retain records according to policy | P2 |
| AUD-08 | Legal hold | Prevent deletion for designated records | P3 |
| AUD-09 | Compliance reports | Produce evidence for defined standards | P3 |

## N. Integration and extensibility

| ID | Capability | Description | Priority |
|---|---|---|---|
| INT-01 | Public API | Documented API for supported operations | P1 |
| INT-02 | Webhooks | Notify external systems of events | P1 |
| INT-03 | Outbound HTTP/service connector | Call external APIs | P1 |
| INT-04 | Inbound event endpoint | Receive external events securely | P2 |
| INT-05 | Connector configuration | Manage endpoints, credentials, policies | P1 |
| INT-06 | Integration retry/dead-letter handling | Manage transient/permanent failures | P1 |
| INT-07 | Integration logs | Trace request/result and correlation IDs | P1 |
| INT-08 | Event/message broker integration | Connect supported broker when justified | P2 |
| INT-09 | Database integration | Controlled data access to external databases | P3 |
| INT-10 | SDK/client libraries | Typed client for selected APIs | P3 |
| INT-11 | Extension/plugin model | Add controlled custom capabilities | P3 |
| INT-12 | MCP integration | Expose selected capabilities to AI clients safely | P3 |
| INT-13 | Import/export integration packages | Move definitions/configuration between environments | P2 |

## O. Localization and user experience

| ID | Capability | Description | Priority |
|---|---|---|---|
| UX-01 | Responsive web application | Usable desktop/tablet/mobile web | P0 |
| UX-02 | Localization framework | Multiple languages | P1 |
| UX-03 | RTL/LTR layouts | Direction-aware UI | P1 |
| UX-04 | Gregorian/Jalali date support | Locale-aware date display/input if target market needs it | P1 — validate |
| UX-05 | Timezone handling | Store/convert/display timestamps consistently | P0 |
| UX-06 | Accessibility | Keyboard, semantics, contrast, screen readers | P1 |
| UX-07 | User preferences | Language, theme, density, personal settings | P2 |
| UX-08 | Guided onboarding | Help new users start using the platform | P2 |
| UX-09 | Mobile application | Native or dedicated mobile client | P3 |
| UX-10 | Configurable branding | Tenant-level visual identity | P2 |

## P. Platform administration and operations

| ID | Capability | Description | Priority |
|---|---|---|---|
| OPS-01 | Platform administration | Platform-level operational console | P1 |
| OPS-02 | Tenant administration | Tenant-level administration | P1 |
| OPS-03 | Feature flags | Enable/disable capabilities by environment/tenant | P2 |
| OPS-04 | Configuration management | Validated environment and tenant configuration | P0 |
| OPS-05 | Health/readiness checks | Expose operational health | P1 |
| OPS-06 | Structured logging | Consistent structured logs | P0 |
| OPS-07 | Metrics and tracing | Operational observability | P1 |
| OPS-08 | Background job management | Monitor scheduled/background work | P1 |
| OPS-09 | Backup/restore | Documented recovery process | P1 |
| OPS-10 | Data export | Export tenant data under authorization | P1 |
| OPS-11 | Maintenance mode | Controlled maintenance operations | P2 |
| OPS-12 | Usage metering | Measure tenant/user/resource consumption | P2 |
| OPS-13 | Subscription/billing | Plans, entitlements, invoices, payments | P3 — business model decision |
| OPS-14 | Environment promotion | Dev/test/staging/production configuration flow | P1 |

## Q. Security and privacy

| ID | Capability | Description | Priority |
|---|---|---|---|
| SEC-01 | Tenant isolation | Enforce separation of tenant data and operations | P0 if multi-tenant |
| SEC-02 | Authorization on every resource | Server-side permission enforcement | P0 |
| SEC-03 | Secrets management | Protect credentials and signing keys | P0 |
| SEC-04 | Encryption in transit | Secure network communication | P0 |
| SEC-05 | Encryption at rest | Protect stored data where required | P1 |
| SEC-06 | Input validation/output encoding | Reduce common application vulnerabilities | P0 |
| SEC-07 | Rate limiting/abuse controls | Protect APIs and authentication | P1 |
| SEC-08 | Security event logging | Record relevant security events | P1 |
| SEC-09 | Data retention/deletion | Policy-based lifecycle management | P1 |
| SEC-10 | Privacy controls | Data access/export/deletion workflows as applicable | P2 |
| SEC-11 | Vulnerability management | Dependency scanning and remediation process | P1 |
| SEC-12 | Security testing | Threat modeling, SAST/DAST and penetration testing as appropriate | P1 |

## R. AI-assisted capabilities (optional expansion)

| ID | Capability | Description | Priority |
|---|---|---|---|
| AI-01 | Natural-language process draft | Suggest a process model from a description | P3 |
| AI-02 | Form generation assistance | Suggest fields and validation | P3 |
| AI-03 | Process documentation assistant | Generate draft documentation | P3 |
| AI-04 | Natural-language process search | Search process records with authorization | P3 |
| AI-05 | Operational insight assistant | Summarize bottlenecks and trends | P3 |
| AI-06 | Human-in-the-loop recommendations | Suggest, never silently execute, consequential actions | P3 |
| AI-07 | AI governance | Data boundaries, evaluation, audit, model controls | P3 |
| AI-08 | Agent/MCP access | Restricted tool access with explicit permissions | P3 |

## S. Developer and ecosystem experience

| ID | Capability | Description | Priority |
|---|---|---|---|
| DEV-01 | API documentation | Versioned, usable API docs | P1 |
| DEV-02 | Webhook documentation | Event contracts and examples | P1 |
| DEV-03 | Sandbox/demo environment | Safe evaluation environment | P2 |
| DEV-04 | Process definition examples | Reusable sample processes | P1 |
| DEV-05 | Importable starter templates | Ready-to-configure process templates | P1 |
| DEV-06 | Extension developer guide | Build and operate extensions | P3 |
| DEV-07 | Compatibility/version policy | API and definition compatibility policy | P1 |
| DEV-08 | Diagnostics package | Export safe troubleshooting data | P2 |

## T. Commercial and customer lifecycle (depends on business model)

| ID | Capability | Description | Priority |
|---|---|---|---|
| COM-01 | Trial/onboarding flow | Evaluate and activate product | P2 |
| COM-02 | Plans and entitlements | Define feature/usage access | P2 |
| COM-03 | Subscription lifecycle | Start, renew, pause, cancel | P3 |
| COM-04 | Billing integration | Connect payment/invoice provider | P3 |
| COM-05 | Customer support intake | Receive product support requests | P2 |
| COM-06 | Product usage analytics | Understand adoption and usage | P2 |
| COM-07 | In-product announcements | Communicate product changes | P2 |

## Capability map review rules

For each candidate capability, decide:
1. Does it solve a validated customer problem?
2. Is it core to Ravand's chosen positioning?
3. Is it a platform capability or a separate product responsibility?
4. Is it required for MVP, commercial readiness, or later maturity?
5. What is the smallest useful version?
6. What dependencies and risks does it introduce?
7. What evidence will demonstrate acceptance?

Do not translate this map directly into tickets or code before scope approval.
