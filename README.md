# UiPath-Codedworkflow
💡 مثال عملي: الجمع بين Coded Workflow وLow-Code Workflow

في المثال ده، هنشرح إزاي نستخدم Coded Workflow (CodedResetAssetValue.cs) جوه Workflow مرئي:

وظيفة CodedResetAssetValue.cs:

جلب القيمة الحالية: بيجيب القيمة الحالية لـ Asset معين من الـ Orchestrator.

مقارنة القيم: بيقارن القيمة الحالية بالقيمة اللي المستخدم دخلها.

تحديث القيمة: لو القيمتين مختلفتين، بيحدث الـ Asset بالقيمة الجديدة.

تسجيل الحالة: بيسجل في اللوج الحالة، سواء القيمة اتغيرت أو فضلت زي ما هي.

إزاي تدمج الكود مع الـ Workflow المرئي؟

إنشاء Coded Workflow:

اعمل Workflow جديد باسم CodedResetAssetValue.

أضف Inputs وOutputs المناسبة.

نفذ المنطق المطلوب جوه الـ Execute Method (زي المقارنة والتحديث).

دمج Workflow بالكود مع Workflow مرئي:

في الـ Low-Code Workflow:

استخدم Activity Invoke Workflow File لاستدعاء كود الـ Coded Workflow.

أضف Activity If لتسجيل رسائل السيناريوهات المختلفة (القيمة فضلت زي ما هي أو اتغيرت).
