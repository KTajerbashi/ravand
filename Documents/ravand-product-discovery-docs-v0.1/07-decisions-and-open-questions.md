# Ravand — Decision Log & Open Questions

**Status:** Initial register  
**Version:** 0.1

## 1. Confirmed constraints inherited from the portfolio source context

- Ravand is one of six proposed Product repositories in a portfolio target of 20 public repositories.
- Product design is to be performed from scratch.
- Products must remain independent from Engineering Foundations and from other products in domain ownership.
- Technology must be selected based on validated product needs.
- Product discovery must precede repository specification and architecture finalization.
- No GitHub changes are allowed until explicit user approval.
- The initial product discovery topics include problem, target customer, value proposition, core use cases, domain boundaries, MVP scope, differentiation, and technology decision.

## 2. Product-specific historical clues (not confirmed requirements)

The portfolio source context records prior discussions describing Ravand as:
- A possible multi-tenant workflow and office automation platform.
- Potential visual BPMN designer.
- Dynamic forms.
- Process execution engine.
- Audit capability.
- RTL/LTR support.
- Gregorian/Jalali date support.

These are historical clues only. They must be revalidated and must not be treated as approved scope.

## 3. Initial decision register

| ID | Decision | Current status | Notes |
|---|---|---|---|
| D-001 | Product positioning: office automation vs general BPM vs broad enterprise platform | Open | Resolve before final scope |
| D-002 | Primary customer segment | Open | Requires discovery evidence |
| D-003 | Primary buyer and user personas | Open | Distinguish buyer from daily users |
| D-004 | Multi-tenant SaaS, single-tenant, self-hosted, or hybrid deployment | Open | Major architecture and commercial impact |
| D-005 | BPMN 2.0 support level | Open | Define exact supported subset |
| D-006 | Visual process designer built-in or integrated | Open | UX, licensing, extensibility, maintenance impact |
| D-007 | Scope of office correspondence/document management | Open | Avoid unbounded scope |
| D-008 | Form designer depth | Open | Basic forms vs advanced low-code forms |
| D-009 | Process version behavior for running instances | Open | Critical runtime semantics |
| D-010 | Initial integration mechanisms | Open | API, webhooks, broker, connectors |
| D-011 | Localization requirements | Open | Validate RTL, Persian/Jalali, English, timezone needs |
| D-012 | Commercial model | Open | SaaS subscription, license, self-hosted, services, or hybrid |
| D-013 | AI capability scope | Open | Candidate advanced capability only |
| D-014 | Initial MVP process scenarios | Open | Must be grounded in customer workflows |
| D-015 | Product name and brand availability | Open | Separate naming/trademark review |

## 4. Open discovery questions

### Product identity
1. Is Ravand primarily an office automation product, a general BPM platform, or a workflow-centered enterprise operations platform?
2. Which single customer problem should make a buyer choose Ravand?
3. Which industry or organization size is the initial target?

### Customers and buying
4. Who owns the budget?
5. Who configures processes?
6. Who uses tasks every day?
7. What existing tools are being replaced or integrated?
8. What evidence indicates willingness to pay or adopt?

### Process scope
9. Which 3–5 processes must Ravand support first?
10. Are processes designed by business users, technical administrators, or both?
11. How complex are approvals, exceptions, timers, parallel work, and external integrations?
12. What level of BPMN compatibility is genuinely required?

### Deployment and operations
13. Is the product SaaS, self-hosted, private cloud, or hybrid?
14. Is multi-tenancy a business requirement or only a possible implementation choice?
15. What availability, recovery, data residency, and security needs apply?

### Portfolio boundaries
16. Which capabilities belong to Ravand versus Nivora, StockPilot, Servexa, Meetra, and Knowlia?
17. Should Ravand orchestrate external products rather than own their domain data?
18. What is the explicit list of non-goals?

## 5. Change history

| Version | Date | Change |
|---|---|---|
| 0.1 | 2026-11-21 | Initial discovery document set created; all product-specific capabilities remain candidate/proposed. |

## 6. Approval protocol

A decision becomes **Confirmed** only when the product owner explicitly approves it. The assistant must not infer approval from silence, continuation, or a request to create a draft.
