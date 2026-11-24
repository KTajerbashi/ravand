# Ravand — Non-Functional Requirements (NFRs)

**Status:** Candidate quality attributes — targets not yet set  
**Version:** 0.1

Do not invent numeric SLAs, throughput targets, retention periods, or compliance claims. Establish them from customer segment, deployment model, risk, and expected load.

## 1. Security

Candidate requirements:
- Authentication and authorization are enforced server-side.
- Every tenant-scoped query and operation enforces tenant context if multi-tenancy is selected.
- Secrets are not stored in source code or exposed in logs.
- Sensitive data is protected in transit and, where required, at rest.
- Privileged operations require explicit permissions and audit records.
- Uploads are validated and scanned according to risk.
- APIs have abuse protection and rate limits.
- Dependencies and container images are scanned and patched.
- Threat modeling and security testing are part of release readiness.

## 2. Reliability and resilience

- Long-running process state survives service restart.
- Execution transitions are transactionally consistent within the chosen persistence model.
- Duplicate delivery/retry does not create unintended duplicate business effects.
- Timers and background jobs recover after failure.
- External integration failures are observable and recoverable.
- Backups are tested through restore exercises.
- Critical operations have defined timeout and retry behavior.
- Failure states are visible to authorized operators.

## 3. Performance and scalability

Targets to discover:
- Concurrent users and active process instances.
- Process starts and task completions per time unit.
- Typical and worst-case process duration.
- Form payload sizes and attachment volumes.
- Reporting query volume and latency expectations.
- Tenant count and tenant size distribution.
- Peak periods and burst behavior.

Design considerations:
- Avoid unbounded synchronous work in request paths.
- Paginate large lists.
- Index operational query paths based on measured usage.
- Isolate expensive reporting from critical execution paths where needed.
- Apply backpressure and bounded retries to integrations/background jobs.

## 4. Availability and recoverability

Define:
- Required availability by customer segment.
- Recovery Time Objective (RTO).
- Recovery Point Objective (RPO).
- Backup frequency and retention.
- Disaster recovery topology.
- Maintenance and upgrade windows.
- Operational escalation and incident response.

## 5. Observability

- Structured logs with correlation and process-instance identifiers.
- Metrics for execution, task queues, timers, integrations, and failures.
- Distributed tracing across service boundaries where appropriate.
- Health, readiness, and liveness endpoints where relevant.
- Alerts tied to actionable operational conditions.
- PII and secrets are excluded or masked in telemetry.

## 6. Data governance and privacy

- Data classification and sensitivity levels.
- Retention and deletion policies.
- Tenant data export and offboarding requirements.
- Audit retention and tamper-resistance expectations.
- Data residency and hosting constraints.
- Backup data protection.
- Personal data minimization and access logging.

## 7. Usability and accessibility

- Common tasks should be understandable to non-developer business users.
- Process designer must expose validation errors clearly.
- Task inbox and process tracking must support efficient daily work.
- Responsive behavior must match target user environments.
- Keyboard navigation, semantic structure, contrast, and assistive technology support should be evaluated.
- RTL/LTR and language support must be validated against target markets.

## 8. Compatibility and maintainability

- Published process definitions have explicit version semantics.
- API compatibility and deprecation policies are documented.
- Database migrations are repeatable and reversible where feasible.
- Configuration is validated at startup/deployment.
- Automated tests cover domain rules, runtime transitions, authorization, and integrations.
- Architecture decisions and operational runbooks are maintained.

## 9. Compliance

No compliance certification or legal compliance claim is assumed. Identify applicable obligations only after selecting target markets, customer types, data categories, and hosting model.
