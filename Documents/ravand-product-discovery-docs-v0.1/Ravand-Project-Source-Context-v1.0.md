# Ravand — Project Source Context
**نسخه:** 1.0  
**تاریخ تهیه:** 2026-11-21  
**وضعیت:** مرجع کاری برای ادامه Product Discovery — پیش‌نویس، غیرنهایی  
**زبان همکاری:** فارسی؛ اصطلاحات تخصصی به انگلیسی حفظ شوند.

---

## 1. هدف این سند

این فایل مرجع اصلی زمینه‌ای برای دستیار ChatGPT در پروژه Ravand است. دستیار باید با مطالعه آن بتواند:

- بداند Ravand در چارچوب کدام Portfolio طراحی می‌شود.
- تصمیم‌های قطعی و موارد پیشنهادی/حل‌نشده را از هم تفکیک کند.
- وضعیت فعلی Product Discovery را بشناسد.
- نقشه قابلیت‌های محصول، سناریوها، مرزهای دامنه و مسیر توسعه را دنبال کند.
- تصمیم‌ها، فرضیه‌ها، ریسک‌ها و تغییرات را ثبت و به‌روزرسانی کند.
- از تکرار بحث‌ها، گم‌شدن مسیر و تبدیل زودهنگام پیشنهادها به تصمیم قطعی جلوگیری کند.
- تا زمان دریافت اجازه صریح کاربر هیچ تغییری در GitHub انجام ندهد.

این سند خلاصه‌ای ساختاریافته از سند `GitHub Portfolio Source Context v1.0` و گفت‌وگوهای Product Discovery مربوط به Ravand است. برای جزئیات کامل قابلیت‌ها، فایل Capability Map که در بخش 9 معرفی شده مرجع مکمل است.

## 2. قوانین قطعی همکاری

1. **هیچ عملیات GitHub بدون تأیید صریح کاربر انجام نشود.** ایجاد، حذف، Rename، Archive، انتقال، تغییر تنظیمات، Commit، Push، ساخت Issue/PR و هر نوع تغییر دیگر ممنوع است تا کاربر صریحاً اجازه دهد.
2. طراحی محصولات Portfolio از صفر انجام می‌شود؛ Repositoryها یا ساختارهای قدیمی نباید بدون بررسی مبنای طراحی جدید قرار گیرند.
3. هر پیشنهاد باید با برچسب وضعیت روشن شود: `Proposed`، `Candidate`، `Open`، `Deferred`، `Out of Scope` یا `Confirmed`.
4. صرف درج یک قابلیت در سند به معنی تأیید آن نیست. **هیچ قابلیت Ravand در این نسخه نهایی و مصوب نیست.**
5. تصمیم‌ها با دلیل، مزایا، معایب، Trade-off، وابستگی و ریسک توضیح داده شوند.
6. ابتدا مسئله، مشتری، ارزش، نیازمندی و مرز دامنه مشخص شود؛ سپس فناوری و معماری انتخاب شوند.
7. فناوری صرفاً برای نمایش مهارت به محصول تحمیل نشود.
8. از فرض‌سازی درباره مشتری، بازار، درآمد، SLA، حجم بار، تیم، زمان‌بندی یا شاخص‌های تجاری خودداری شود.
9. در هر نوبت ترجیحاً یک سؤال تعیین‌کننده مطرح شود؛ از پرسشنامه‌های طولانی و تصمیم‌گیری عجولانه پرهیز شود.
10. مستندات باید نسخه‌پذیر و قابل ردیابی باشند. تغییر مهم باید در Decision Log ثبت شود.

## 3. جایگاه Ravand در GitHub Portfolio

هدف Portfolio اصلی دقیقاً ۲۰ Repository عمومی است:

| گروه | تعداد | نقش |
|---|---:|---|
| Products | 6 | محصولات تجاری مستقل |
| Engineering Foundations | 6 | زیرساخت‌ها و الگوهای مهندسی قابل استفاده مجدد |
| Knowledge & Labs | 6 | یادگیری، تحقیق، آزمایش و ثبت دانش |
| Special | 2 | پروفایل GitHub و آموزش Git/GitHub |
| **مجموع** | **20** | |

Ravand یکی از شش Product پیشنهادی است و Repository پیشنهادی آن `ravand` است. نام و حوزه هر شش محصول هنوز نهایی نشده‌اند.

### 3.1 شش محصول پیشنهادی Portfolio

| # | نام پیشنهادی | حوزه اولیه پیشنهادی | وضعیت |
|---:|---|---|---|
| 1 | `ravand` | Workflow Automation / Business Process Management | در حال Product Discovery |
| 2 | `nivora` | مدیریت منابع و عملیات سازمانی | پیشنهادی، نیازمند Discovery |
| 3 | `stockpilot` | مدیریت انبار، موجودی و زنجیره تأمین | پیشنهادی، نیازمند Discovery |
| 4 | `servexa` | مدیریت خدمات، پشتیبانی، تیکت و SLA | پیشنهادی، نیازمند Discovery |
| 5 | `meetra` | همکاری تیمی و ارتباطات بلادرنگ | پیشنهادی، نیازمند Discovery |
| 6 | `knowlia` | مدیریت دانش سازمانی و دستیار هوشمند | پیشنهادی، نیازمند Discovery |

### 3.2 اصول استقلال محصول

- هر محصول مالک مستقل Domain Model، داده‌ها، تنظیمات، تست‌ها، نسخه‌بندی، مستندات و چرخه انتشار خود است.
- Foundationها مستقل از محصولات نگهداری می‌شوند.
- استفاده از Foundation مجاز است، اما باید از طریق Package، Template، نسخه مشخص یا قرارداد فنی روشن باشد.
- اشتراک مفاهیم عمومی نباید باعث ادغام Domainها یا وابستگی مبهم Repositoryها شود.
- Ravand می‌تواند فرآیندهایی را در محصولات دیگر هماهنگ کند، اما نباید مالک داده و منطق اصلی آن محصولات شود.

### 3.3 سایر گروه‌های Portfolio

**Engineering Foundations پیشنهادی:**
- `dotnet-foundation`
- `typescript-platform-foundation`
- `frontend-foundation`
- `python-foundation`
- `data-platform-foundation`
- `cloud-native-foundation`

**Knowledge & Labs پیشنهادی:**
- `software-engineering-lab`
- `architecture-distributed-systems-lab`
- `backend-engineering-lab`
- `frontend-engineering-lab`
- `data-engineering-lab`
- `ai-engineering-lab`

**Special:**
- `KTajerbashi` — GitHub Profile
- `gittutorial` — آموزش Git و GitHub

این نام‌ها نیز در سطح Portfolio پیشنهادی‌اند و موضوع این مرحله، طراحی آن‌ها نیست.

## 4. هویت اولیه Ravand

### 4.1 تعریف اولیه

Ravand به‌عنوان محصولی برای طراحی، اجرا، مدیریت و پایش فرآیندهای سازمانی مطرح شده است. دسته محصول ممکن است یکی از این گزینه‌ها باشد:

- **Option A — Office Automation:** دیجیتالی‌کردن فرم‌ها، درخواست‌ها، مکاتبات و تأییدیه‌های اداری.
- **Option B — General-purpose BPM Platform:** پلتفرم عمومی برای مدل‌سازی، انتشار، اجرای فرآیندها و پایش آن‌ها.
- **Option C — Workflow-centered Enterprise Operations Platform:** پلتفرم جامع‌تر شامل Workflow به‌علاوه فرم، وظایف، کاربران، ساختار سازمانی و عملیات اداری.
- **Option D — Hybrid / Alternative:** ترکیب محدود و تعریف‌شده یا جهت متفاوتی که Product Owner مشخص کند.

**وضعیت:** انتخاب نشده است. این مهم‌ترین تصمیم باز Ravand است. نباید دستیار بدون تأیید کاربر یکی از گزینه‌ها را قطعی فرض کند.

### 4.2 فرضیه مسئله

سازمان‌ها ممکن است فرآیندهای تکرارشونده را با ایمیل، Excel، پیام‌رسان، کاغذ یا نرم‌افزارهای پراکنده اداره کنند. پیامدهای احتمالی:

- نامشخص بودن مالک فرآیند و مسئول تأیید.
- تأخیر و نبود دید کافی در انتقال کار بین افراد و واحدها.
- ناقص یا ناهماهنگ بودن سوابق.
- دشواری مشاهده کارهای معطل، ردشده، تکمیل‌شده یا ناموفق.
- دشواری تغییر فرآیند هنگام تغییر سیاست‌ها و ساختار سازمانی.
- ضعف در Auditability و ردیابی اینکه چه کسی، چه کاری و چه زمانی انجام داده است.
- ورود چندباره اطلاعات در سامانه‌های مختلف.

این موارد **فرضیه‌های قابل اعتبارسنجی** هستند، نه حقایق اثبات‌شده بازار.

### 4.3 چشم‌انداز پیشنهادی

توانمندسازی سازمان‌ها برای تعریف، اجرا، پایش و بهبود فرآیندهای کسب‌وکار با استفاده از Process Modeling، Workflow Orchestration، Human Tasks، Business Rules، Integration و Auditability.

این چشم‌انداز تا انتخاب Positioning و تأیید کاربر پیشنهادی باقی می‌ماند.

## 5. مشتریان و کاربران احتمالی

### 5.1 مشتریان/سازمان‌های هدف احتمالی
- سازمان‌های کوچک و متوسط با فرآیندهای تأیید تکرارشونده.
- سازمان‌های متوسط و بزرگ با فرآیندهای بین‌واحدی.
- سازمان‌های دولتی یا دارای الزامات ردیابی و کنترل.
- سازمان‌هایی که می‌خواهند فرم‌ها، ایمیل‌ها و Excelهای پراکنده را سامان دهند.

**بازار و Segment اصلی هنوز انتخاب نشده است.**

### 5.2 Personaهای احتمالی
- **Economic Buyer:** مالک، مدیر اجرایی، مدیر عملیات یا تصمیم‌گیرنده IT.
- **Organization Administrator:** تنظیمات سازمان، اعضا و دسترسی‌ها.
- **Process Owner:** پاسخ‌گوی عملکرد یک فرآیند.
- **Process Designer:** مدل‌سازی و پیکربندی فرآیند.
- **Process Operator:** پایش و پشتیبانی اجرای فرآیندها.
- **Requester:** آغازکننده فرآیند و ثبت‌کننده درخواست.
- **Assignee:** مسئول انجام Task.
- **Approver:** بررسی و تأیید/رد درخواست.
- **Auditor/Compliance User:** بررسی سوابق و شواهد.
- **Integration Administrator:** پیکربندی اتصال به سامانه‌های بیرونی.

در سازمان‌های کوچک ممکن است چند Persona بر عهده یک نفر باشد.

## 6. ارزش تجاری پیشنهادی

ارزش‌های احتمالی که باید با مشتری واقعی اعتبارسنجی شوند:

- شفاف‌سازی مالکیت و وضعیت فرآیندها.
- کاهش پیگیری و Hand-off دستی.
- استانداردسازی اجرای فرآیند با امکان پیکربندی کنترل‌شده.
- ثبت تصمیم‌ها و تاریخچه قابل ردیابی.
- کاهش زمان تغییر و انتشار فرآیند.
- اتصال Workflow به سامانه‌های فعلی سازمان.

هیچ ادعای عددی درباره صرفه‌جویی، افزایش بهره‌وری، درآمد یا ROI بدون داده واقعی مطرح نشود.

## 7. مرز دامنه پیشنهادی Ravand

### 7.1 مسئولیت‌های کاندید Ravand
- Process Definition و Lifecycle
- Workflow Execution و Orchestration
- Forms و Process Data Capture
- Human Task Assignment و Completion
- Rules، Timers، Events و Process Monitoring
- Identity Integration، Authorization، Audit و Administration
- APIs و Integration Mechanisms

### 7.2 مواردی که نباید خودکار وارد دامنه شوند
- ERP، حسابداری و مالی کامل
- CRM و Sales Automation کامل
- HR و Payroll کامل
- Inventory و Warehouse Management کامل
- ITSM یا Customer Support کامل
- Team Chat و Video Meeting عمومی
- Enterprise Content Management کامل

### 7.3 مرز با محصولات دیگر Portfolio
- **Nivora:** منابع و عملیات سازمانی.
- **StockPilot:** انبار و زنجیره تأمین.
- **Servexa:** درخواست خدمات و پشتیبانی.
- **Meetra:** همکاری تیمی و ارتباطات.
- **Knowlia:** مدیریت دانش و AI.

نمونه: Ravand می‌تواند فرآیند تأیید خرید را Orchestrate کند، اما مالک Stock، Inventory و Procurement Master Data نباشد. همچنین می‌تواند درخواست خدمات را به Servexa ارجاع دهد، بدون آنکه الزاماً Service Desk کامل بسازد.

## 8. نقشه جامع قابلیت‌ها (Capability Map)

در Discovery اولیه، ۲۰ حوزه قابلیت شناسایی شده‌اند. این‌ها **Candidate Inventory** هستند، نه تعهد پیاده‌سازی یا Scope مصوب. اولویت‌های P0 تا P3 در Capability Map فعلی نیز موقت‌اند.

| # | حوزه قابلیت | نمونه مسئولیت‌ها |
|---:|---|---|
| 1 | Organization & Workspace | ثبت Workspace، پروفایل سازمان، عضویت، ساختار سازمانی، تنظیمات Tenant |
| 2 | Identity & Access | Authentication، Password Lifecycle، RBAC، Permissions، SSO، MFA، Delegation |
| 3 | Process Modeling & Designer | Process Definition، Visual Designer، BPMN، Events، Tasks، Gateways، Variables، Expressions، Templates |
| 4 | Process Versioning & Governance | Draft/Publish، نسخه‌های Immutable، مقایسه نسخه، Approval، Retirement، رفتار Instanceهای در حال اجرا |
| 5 | Forms & Data Capture | Form Designer، Field Types، Validation، Conditional Visibility، Dynamic Options، Repeating Sections، Attachments، Localization |
| 6 | Workflow Execution & Orchestration | Start/Execute/Pause/Resume/Cancel، Service Tasks، Timers، Retry، Incident Handling، Long-running Processes، Concurrency، Idempotency |
| 7 | Human Tasks & Work Management | Inbox، Group Queue، Claim/Release، Assign/Reassign، Approve/Reject، Delegate، Due Dates، Comments، Task History |
| 8 | Rules & Decisions | Conditional Routing، Business Rules، Decision Tables، Approval/Escalation/Delegation Policies، Rule Testing |
| 9 | Organization Structure & Directory | Departments، Teams، Positions، Reporting Lines، Membership، Participant Resolution |
| 10 | Notifications & Communications | In-app، Email، Templates، Preferences، Reminders، Escalations، Delivery Status، کانال‌های اضافی |
| 11 | Documents & Attachments | Upload/Download، Metadata، Access Control، Scanning، Preview، Document Templates، E-signature Integration، Retention |
| 12 | Search, Dashboards & Reporting | My Work، Instance Search، Operational Dashboard، Aging، Cycle Time، Bottleneck، Custom Reports، Export، Process Mining |
| 13 | Audit, Compliance & Traceability | Audit Trail، Actor/Time/Action، Process History، Before/After، Export، Tamper Resistance، Retention |
| 14 | Integration & Extensibility | Public API، Webhooks، HTTP Connectors، Inbound Events، Credentials، Retry/Dead Letter، Broker، SDK، Plugin، MCP |
| 15 | Localization & User Experience | Responsive Web، Localization، RTL/LTR، Gregorian/Jalali (نیازمند اعتبارسنجی)، Timezone، Accessibility، Mobile، Branding |
| 16 | Platform Administration & Operations | Platform/Tenant Admin، Feature Flags، Configuration، Health، Logging، Metrics، Tracing، Background Jobs، Backup/Restore، Usage/Billing |
| 17 | Security & Privacy | Tenant Isolation، Authorization، Secrets، Encryption، Input Validation، Rate Limiting، Security Logging، Retention، Privacy، Security Testing |
| 18 | AI-assisted Capabilities | Process Draft، Form Suggestions، Documentation Assistant، Natural-language Search، Operational Insights، Human-in-the-loop، AI Governance، Agent/MCP |
| 19 | Developer & Ecosystem Experience | API/Webhook Docs، Sandbox، Process Examples، Templates، Extension Guide، Compatibility Policy، Diagnostics |
| 20 | Commercial & Customer Lifecycle | Trial/Onboarding، Plans/Entitlements، Subscription، Billing، Support Intake، Usage Analytics، In-product Announcements |

### 8.1 اولویت‌های اولیه
- **P0:** برای اولین محصول قابل استفاده ضروری، مشروط به Positioning.
- **P1:** برای محصول تجاری قابل اتکا مهم.
- **P2:** قابلیت پیشرفته یا توسعه بعدی.
- **P3:** قابلیت اختیاری، تخصصی یا اکوسیستمی.

اولویت هر قابلیت باید بعد از انتخاب مشتری، فرآیندهای واقعی، MVP و مدل تجاری بازبینی شود. حضور در Capability Map به معنی حضور در MVP نیست.

## 9. فایل‌های تفصیلی Discovery که قبلاً ایجاد شده‌اند

در گفت‌وگوی قبلی مجموعه مستندات `ravand-product-discovery` با نسخه 0.1 ساخته شده است. فایل ZIP شامل ۸ فایل Markdown است:

1. `00-PRODUCT-MASTER-INDEX.md` — فهرست و قواعد مدیریت مستندات.
2. `01-product-vision-and-positioning.md` — Vision، Problem، Personas، Value و Positioning Options.
3. `02-capability-map.md` — فهرست تفصیلی ۲۰ حوزه و شناسه قابلیت‌ها.
4. `03-requirements-and-use-cases.md` — قالب Requirements و ۱۰ Use Case اولیه.
5. `04-roadmap-and-release-stages.md` — مراحل توسعه و Release Gates.
6. `05-domain-boundaries-and-integrations.md` — Candidate Domain Areas، مرز Portfolio و Integration Strategy.
7. `06-non-functional-requirements.md` — Security، Reliability، Performance، Availability، Observability، Privacy و Maintainability.
8. `07-decisions-and-open-questions.md` — Decision Register و Open Questions.

فایل Capability Map شناسه‌های قابل ردیابی مانند `BPM-01`، `FORM-01`، `RUN-01`، `TASK-01`، `AUD-01`، `INT-01` و `AI-01` دارد. برای جزئیات هر قابلیت به همان فایل مراجعه شود؛ خلاصه این Source Context جایگزین فهرست کامل نیست.

## 10. سناریوهای End-to-End اولیه

این سناریوها کاندید هستند و هنوز نیازمند تأیید و تکمیل‌اند:

- **UC-01 Configure Organization:** ساخت Workspace، تنظیم پروفایل و Locale/Timezone، دعوت اعضا و ثبت رویدادهای مدیریتی.
- **UC-02 Define and Publish Process:** ساخت Draft، افزودن عناصر Process، فرم‌ها و Rules، اعتبارسنجی و انتشار نسخه.
- **UC-03 Start Process:** انتخاب فرآیند، تکمیل Start Form، Validation، ایجاد Instance بر اساس نسخه منتشرشده و نمایش Reference/Status.
- **UC-04 Complete Human Task:** مشاهده Inbox، بررسی Context، تکمیل Task، کنترل مجوز و State، ثبت رویداد و پیشبرد Process.
- **UC-05 Approve/Reject/Return:** بررسی داده و پیوست، تصمیم‌گیری، ثبت دلیل در صورت نیاز و هدایت به مسیر مناسب.
- **UC-06 Handle Overdue Work:** ارزیابی Deadline، Reminder یا Escalation و ثبت رخداد.
- **UC-07 Monitor Processes:** فیلتر Instanceها، مشاهده Timeline، تشخیص Delay/Failure و اقدامات مجاز.
- **UC-08 Integrate External System:** تنظیم Connector، نگهداری امن Credential، Correlation، Retry و مشاهده خطاها.
- **UC-09 Review Audit History:** جست‌وجوی سوابق، کنترل مجوز، مشاهده شواهد و Export مجاز.
- **UC-10 Publish New Process Version:** ایجاد Draft جدید، تغییر Model/Form/Rules، اعتبارسنجی سازگاری، انتشار و اعمال Policy روی Instanceهای موجود.

## 11. اصول پذیرش و کیفیت مشترک

- Authorization برای هر عملیات محافظت‌شده در Server بررسی شود.
- Tenant Context در صورت تصویب Multi-tenancy در همه Queryها و عملیات مربوطه enforce شود.
- State Transitionها معتبر و در برابر Concurrency ایمن باشند.
- Retry و Duplicate Delivery نباید اثر تجاری تکراری ناخواسته ایجاد کنند.
- Processهای Long-running پس از Restart از بین نروند.
- خطاها قابل مشاهده و بازیابی باشند و بی‌صدا ناپدید نشوند.
- تصمیم‌های مهم و تغییر وضعیت Process قابل ردیابی باشند.
- خطای کاربر اطلاعات حساس Implementation را افشا نکند.
- Timezone، Locale و Date Interpretation صریح باشند.
- Process Definition منتشرشده هویت نسخه پایدار داشته باشد.

## 12. نقشه راه پیشنهادی از 0 تا 100

Roadmap فعلی بر اساس قابلیت و Gate است، نه تاریخ یا تخمین زمانی. هیچ تاریخ، اندازه تیم یا Estimate تأیید نشده است.

### Stage 0 — Product Validation & Definition
- انتخاب Positioning و Segment.
- تعیین Buyer و Personaها.
- اعتبارسنجی سناریوهای واقعی فرآیند.
- بررسی جایگزین‌ها و رقبا.
- تعریف Value Proposition و Outcomeهای قابل اندازه‌گیری.
- تعیین مرز و Exclusionها.
- تعریف MVP و معیار موفقیت.

**Exit Gate:** تأیید Problem، Target Customer و Product Direction توسط Product Owner.

### Stage 1 — Platform Foundation & First Usable Workflow
- Workspace/Organization پایه، بسته به Deployment Model.
- Authentication و Authorization پایه.
- Lifecycle حداقلی Process Definition.
- عناصر پایه و Conditional Routing.
- Forms و Validation پایه.
- ایجاد و ذخیره Process Instance.
- Human Task Inbox و Assignment.
- Approve/Reject/Complete.
- Notification پایه.
- Process History و Audit Trail.
- Operational Visibility پایه.
- تست خودکار، Configuration امن، Logging، Backup و Deployment Baseline.

**Exit Gate:** مشتری نماینده بتواند یک فرآیند واقعی توافق‌شده را اجرا و تاریخچه آن را مشاهده کند.

### Stage 2 — Configurable Workflow Platform
- Visual Designer یا Modeling Experience منتخب.
- Gateway/Event/Taskهای بیشتر.
- Versioned Process Definitions.
- Form Designer پیشرفته‌تر.
- Assignment بر اساس Organization/Group.
- Timers، Deadline، Reminder و Escalation.
- Process Templates.
- Search و Dashboard.
- API و Webhook پایه.
- Integration Retry و Failure Visibility.

**Exit Gate:** چند فرآیند متفاوت بدون توسعه اختصاصی برای هرکدام قابل مدل‌سازی و اجرا باشند.

### Stage 3 — Commercial Readiness
- Tenant Isolation/Lifecycle در صورت انتخاب Multi-tenancy.
- SSO/MFA طبق نیاز مشتری.
- Fine-grained Access Control.
- Audit Export و Retention.
- Backup/Restore و Disaster Recovery.
- Monitoring، Metrics، Tracing و Alerting.
- Environment Promotion و Controlled Releases.
- Documentation، Onboarding و Support Process.
- Performance/Security Testing.
- Upgrade و Compatibility Policy.

**Exit Gate:** معیارهای عملیاتی، امنیتی، پشتیبانی و استقرار برای بازار هدف برآورده شوند.

### Stage 4 — Advanced BPM & Integration
- عناصر پیشرفته BPMN منتخب.
- Subprocess و Reusable Process Components.
- Advanced Rules و Decision Tables.
- Message Correlation و Event-driven Integration.
- Compensation و Exception Handling پیشرفته.
- Process Migration Policy.
- Connector Ecosystem.
- Advanced Reporting و Bottleneck Analysis.
- Extension/Plugin Mechanisms کنترل‌شده.

### Stage 5 — Ecosystem & Intelligence
- Process Template Catalog.
- Developer SDK و Sandbox.
- Process Mining در صورت وجود داده و تقاضای کافی.
- AI-assisted Process/Form/Documentation Authoring.
- Natural-language Search و Operational Summary.
- MCP/Agent Integration با Least Privilege و Human Approval.
- کانال‌های اضافی و Mobile Experience.

### Release Policy
- هیچ Stage با درج در Roadmap به‌صورت خودکار تأیید نمی‌شود.
- قابلیت‌ها ممکن است جابه‌جا، تقسیم، حذف یا جایگزین شوند.
- MVP کوچک‌ترین محصول منسجم با ارزش واقعی است، نه نسخه کوچک همه ۲۰ حوزه.
- Advanced BPMN قبل از اعتبارسنجی سناریوهای واقعی ساخته نشود.
- Billing/Subscription قبل از انتخاب Commercial Model پیاده‌سازی نشود.

## 13. مرزهای دامنه و Integration

### 13.1 Candidate Domain Areas
- Organization & Workspace
- Identity & Access
- Process Definition
- Process Runtime
- Forms & Data Capture
- Human Task Management
- Rules & Decisions
- Notifications
- Integration
- Audit & Compliance
- Reporting & Analytics
- File/Attachment Management
- Platform Operations

این‌ها صرفاً حوزه‌های دامنه پیشنهادی‌اند؛ Bounded Context، ماژول نرم‌افزاری یا ساختار کد نهایی نیستند.

### 13.2 Integration Principles
- API Contractها صریح، نسخه‌بندی‌شده، مستند و احراز هویت‌شده باشند.
- External Callها بر اساس ماهیت عملیات Timeout، Retry، Idempotency و Failure Policy داشته باشند.
- فرض نشود Remote Call و Local Database Transaction یک تراکنش Atomic هستند.
- Correlation ID برای ردیابی بین سامانه‌ها استفاده شود.
- Secretها امن نگهداری و چرخانده شوند.
- Webhook ورودی Authenticate و Validate شود.
- خطای Integration قابل مشاهده و بازیابی باشد.
- بین Productهای مستقل Direct Database Coupling ایجاد نشود.
- API، Event یا Versioned Package بر Shared Database Table ترجیح دارد.

### 13.3 Patterns برای ارزیابی، نه الزام همگانی
- Synchronous Request/Response برای عملیات کوتاه و محدود.
- Webhooks برای Event Notification.
- Message Broker برای ارتباط Decoupled در صورت توجیه.
- Outbox/Inbox برای انتشار/مصرف قابل اتکای Event در صورت نیاز.
- Saga/Compensation برای عملیات چندسامانه‌ای غیر Atomic در صورت نیاز.
- Polling فقط وقتی Push/Event مناسب یا در دسترس نیست.

## 14. Non-Functional Requirements

این موارد Candidate هستند و Target عددی ندارند:

- **Security:** Server-side AuthZ، Tenant Isolation در صورت تصویب، Secrets، Encryption، Upload Validation/Scanning، Rate Limiting، Vulnerability Management و Security Testing.
- **Reliability:** حفظ Process State در Restart، Consistent State Transition، Idempotency، Recovery تایمرها و Jobها، Integration Recovery، Backup/Restore Test.
- **Performance & Scalability:** ابتدا باید Concurrent Users، Active Instances، Start/Completion Rate، Process Duration، Payload/Attachment Size، Reporting Load، Tenant Count و Peak Load کشف شوند.
- **Availability & Recovery:** تعیین Availability، RTO، RPO، Backup Frequency/Retention، Disaster Recovery و Incident Response.
- **Observability:** Structured Logs، Correlation/Instance IDs، Metrics، Distributed Tracing، Health/Readiness، Actionable Alerts و Masking داده حساس.
- **Data Governance & Privacy:** Data Classification، Retention/Deletion، Tenant Export/Offboarding، Audit Retention، Data Residency و Data Minimization.
- **Usability & Accessibility:** تجربه قابل فهم برای Business User، خطای واضح در Designer، Inbox کارآمد، Responsive، Keyboard، Contrast، Screen Reader، RTL/LTR.
- **Compatibility & Maintainability:** Version Semantics، API Compatibility، Database Migration، Configuration Validation، Automated Tests و Runbooks.
- **Compliance:** هیچ Certification یا ادعای Legal Compliance مفروض نیست؛ الزامات پس از تعیین بازار، مشتری، داده و Hosting بررسی می‌شوند.

## 15. تصمیم‌های باز مهم

| ID | موضوع | وضعیت فعلی |
|---|---|---|
| D-001 | Positioning: Office Automation یا BPM عمومی یا Enterprise Operations | Open |
| D-002 | Primary Customer Segment | Open |
| D-003 | Buyer و User Personaهای اصلی | Open |
| D-004 | SaaS Multi-tenant، Single-tenant، Self-hosted یا Hybrid | Open |
| D-005 | سطح پشتیبانی BPMN 2.0 | Open |
| D-006 | Visual Designer داخلی یا Integration با ابزار موجود | Open |
| D-007 | دامنه مکاتبات اداری و Document Management | Open |
| D-008 | عمق Form Designer | Open |
| D-009 | رفتار Running Instance پس از انتشار Process Version جدید | Open |
| D-010 | Integration Mechanisms اولیه | Open |
| D-011 | Localization: RTL، Persian/Jalali، English، Timezone | Open |
| D-012 | Commercial Model | Open |
| D-013 | AI Scope | Open |
| D-014 | 3 تا 5 سناریوی MVP | Open |
| D-015 | نام و Brand Availability | Open |

### سؤال‌های کلیدی Discovery
1. Ravand دقیقاً کدام دسته محصول است؟
2. کدام مسئله واحد باید باعث شود مشتری Ravand را انتخاب کند؟
3. کدام صنعت یا اندازه سازمان بازار اولیه است؟
4. چه کسی بودجه را تأمین می‌کند و چه کسی Process را طراحی/اجرا می‌کند؟
5. کدام 3 تا 5 فرآیند واقعی باید در MVP پشتیبانی شوند؟
6. پیچیدگی Approval، Exception، Timer، Parallel Work و Integration چقدر است؟
7. فرآیندها را Business User طراحی می‌کند یا Technical Admin یا هر دو؟
8. Deployment Model چیست؟
9. آیا Multi-tenancy الزام تجاری است یا فقط گزینه فنی؟
10. Ravand چه چیزهایی را به Nivora، StockPilot، Servexa، Meetra و Knowlia واگذار می‌کند؟
11. Explicit Non-goals محصول چیست؟
12. چه شواهدی برای Adoption یا Willingness to Pay وجود دارد؟

## 16. فرضیه‌های تاریخی Ravand — نیازمند بازاعتبارسنجی

در Source Context اصلی و گفت‌وگوهای قبلی درباره Ravand موارد زیر مطرح شده‌اند:
- Multi-tenant Workflow و Office Automation Platform.
- Visual BPMN Designer.
- Dynamic Forms.
- Process Execution Engine.
- Audit.
- RTL/LTR.
- پشتیبانی از تاریخ میلادی/شمسی.

همچنین Stack اولیه‌ای مانند .NET/ASP.NET Core، Angular، SQL Server، BPMN 2.0، Modular Monolith، DDD، CQRS، Clean Architecture و Outbox مطرح شده بود. همه این موارد **پیشنهاد اولیه و غیرقطعی** هستند؛ هیچ‌کدام به‌عنوان Stack یا Architecture مصوب تلقی نشوند.

در Audit تاریخی Repository قبلی `ravand`، اختلافاتی میان README و Source/ Dockerfile گزارش شده بود؛ از جمله اشاره به .NET 10 در README و نسخه .NET 9 در Dockerfile، و ناسازگاری برخی نام پروژه‌های داخلی با ساختار مستندات. این موارد فقط سرنخ Audit قبلی‌اند. چون تصمیم طراحی جدید از صفر است، نباید معماری یا وضعیت فعلی را از آن‌ها استنتاج کرد.

## 17. قواعد طراحی Repository در آینده

پس از تکمیل Product Discovery و تأیید کاربر، طراحی Repository Ravand باید حداقل سه خروجی اصلی داشته باشد:

1. **Repository Name:** نام، دلیل انتخاب، هویت، رعایت Hybrid Naming، بررسی تکراری نبودن و در مرحله مناسب بررسی برند/Trademark.
2. **README.md:** Overview، Problem Statement، Product Vision، Key Features، Target Users، Technology Stack، Architecture، Project Structure، Getting Started، Configuration، Development، Testing، Deployment، Security، Roadmap، Contributing و License.
3. **Architecture and Project Structure with Technologies and Patterns:** Architecture Style، Stack و دلیل انتخاب، Patterns، ساختار پروژه و مسئولیت پوشه‌ها، Dependency Rules، Data Flow، Integration Strategy، Testing، Deployment، Security/Observability، ADRها، Trade-offها، محدودیت‌ها و گزینه‌های جایگزین.

این طراحی باید بر اساس نیاز واقعی Ravand باشد؛ هیچ ساختار ماژولار یا تکنولوژی از پیش تحمیل نشود.

## 18. معیارهای نهایی‌سازی هر قابلیت

قبل از تبدیل هر Capability به Requirement یا Task باید موارد زیر مشخص شوند:
- Capability ID و نام.
- Problem و Persona مربوط.
- Business Value.
- Main Flow و Alternative/Exception Flow.
- Trigger و Preconditions.
- داده‌های خوانده/ایجاد/تغییر داده‌شده.
- Authorization و Audit Events.
- Notificationها.
- Acceptance Criteria.
- Priority و Release Target.
- Dependencies و Risks.
- Status و Approval Date.

## 19. وضعیت فعلی پروژه و نقطه ادامه

### انجام‌شده
- سند GitHub Portfolio Source Context v1.0 به‌عنوان مرجع اصلی Portfolio بررسی شده است.
- Ravand به‌عنوان Product اول برای ادامه Discovery انتخاب شده است.
- درخواست کاربر این بوده که ابتدا قابلیت‌های Ravand از ابتدا تا انتها فهرست شوند تا مسیر گم نشود.
- مجموعه مستندات Ravand Discovery v0.1 شامل ۸ فایل Markdown و یک ZIP ساخته شده است.
- Capability Map اولیه ۲۰ حوزه دارد.
- Roadmap پیشنهادی Stage 0 تا Stage 5 تعریف شده است.
- سناریوهای End-to-End و Decision Register اولیه ثبت شده‌اند.

### هنوز انجام‌نشده
- انتخاب Positioning نهایی Ravand.
- اعتبارسنجی بازار، مشتری و Buyer.
- تعریف Use Caseهای واقعی با شواهد.
- تصویب مرزهای دامنه و Non-goals.
- انتخاب MVP و Success Metrics.
- تصویب Deployment Model و Multi-tenancy.
- تعیین سطح BPMN و رفتار Versioning.
- تعیین اولویت نهایی قابلیت‌ها و Release Scope.
- انتخاب Technology Stack.
- طراحی Architecture و Project Structure.
- آماده‌سازی Specification نهایی Repository.
- هرگونه تغییر در GitHub.

### گام بعدی پیشنهادی
به‌جای ورود مستقیم به جزئیات فنی یا شروع از حوزه Organization، ابتدا باید **D-001: Product Positioning** حل شود. انتخاب بین Office Automation، General-purpose BPM و Workflow-centered Enterprise Operations، مرز قابلیت‌ها، مشتری، MVP و معماری را به‌طور اساسی تغییر می‌دهد.

در ادامه، هر محصول/مرحله را با یک سؤال تعیین‌کننده پیش ببر و پس از پاسخ کاربر، تصمیم و اثر آن بر اسناد را ثبت کن. اگر کاربر انتخابی را قطعی نکرده، آن را Open/Proposed نگه دار.

## 20. خلاصه کوتاه برای دستیار

تو دستیار Product Discovery و طراحی محصول Ravand هستی. مأموریتت این است که کاربر را از ایده اولیه به Product Definition، Capability Scope، Requirements، MVP، Roadmap و سپس Repository Specification هدایت کنی. ابتدا محصول و بازار را بفهم، بعد فناوری را پیشنهاد بده. بین Fact، Historical Clue، Hypothesis، Proposal و Confirmed Decision تفاوت روشن نگه دار. Capability Map فعلی جامع اما غیرنهایی است. هیچ قابلیت، Stack، معماری، نام یا تاریخ تحویلی را بدون تأیید کاربر قطعی نکن. هیچ تغییری در GitHub انجام نده تا کاربر مجوز صریح بدهد.
