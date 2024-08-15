### شرح المشروع باللغة العربية

#### مقدمة عن المشروع
"منصة تعليمية" هو مشروع يهدف إلى توفير بيئة تعليمية متكاملة على الإنترنت، حيث يمكن للطلاب الوصول إلى الدروس والمحاضرات، والتفاعل مع المعلمين والزملاء، والحصول على تقييمات وملاحظات بشكل دوري. يهدف المشروع إلى تسهيل عملية التعليم عن بعد وتحسين جودة التعليم الإلكتروني.

#### المميزات
- **تسجيل المستخدمين:** يمكن للطلاب والمعلمين تسجيل حسابات جديدة وتسجيل الدخول بسهولة.
- **إدارة الدروس والمحاضرات:** يمكن للمعلمين إنشاء وتنظيم الدروس والمحاضرات بشكل مرتب وسهل الوصول.
- **تعيين الأدوار:** يتم تعيين الأدوار والصلاحيات للمستخدمين لضمان تجربة استخدام مخصصة وآمنة.
- **نظام الإشعارات:** يتيح للطلاب والمعلمين الحصول على إشعارات بالتحديثات المهمة والدروس الجديدة.
- **لوحة تحكم:** لوحة تحكم شاملة لإدارة الحسابات والدروس والمحاضرات والتقييمات.

#### التكنولوجيا المستخدمة
- **Backend:** ASP.NET Core
- **Database:** SQL Server
- **Frontend:** Angular
- **ORM:** Entity Framework Core

#### المتطلبات
- .NET 6.0 SDK
- SQL Server
- Node.js و npm

#### كيفية الإعداد والتشغيل
1. **استنساخ المستودع:**
   ```bash
   git clone https://github.com/username/MyProject.git
   cd MyProject
   ```
2. **استعادة الحزم:**
   ```bash
   dotnet restore
   ```
3. **إنشاء قاعدة البيانات:**
   - تعديل `appsettings.json` ليشير إلى قاعدة البيانات المحلية.
   - تنفيذ أوامر المايجريشن:
   ```bash
   dotnet ef database update
   ```
4. **تشغيل المشروع:**
   ```bash
   dotnet run
   ```
5. **الوصول إلى التطبيق:**
   - فتح المتصفح والتوجه إلى `https://localhost:5001`

#### هيكل المشروع
```
/MyProject
├── /Controllers
├── /Services
├── /Entities
├── /DTOs
├── /Migrations
├── /Scripts
│   ├── CreateDatabase.sql
│   ├── SeedData.sql
├── /wwwroot
├── /Views
├── appsettings.json
├── MyProject.csproj
├── README.md
```

#### استخدام المشروع
يمكن للمستخدمين تسجيل حسابات جديدة أو تسجيل الدخول للوصول إلى لوحة التحكم، حيث يمكنهم إدارة الدروس والمحاضرات، وتعيين الأدوار، والتفاعل مع الطلاب والمعلمين.

#### المساهمة
نرحب بالمساهمات لتحسين المشروع. يمكنكم فتح issue جديدة أو عمل fork للمستودع وإرسال Pull Request.

---

### Project Description in English

#### Introduction
The "Educational Platform" project aims to provide a comprehensive online learning environment where students can access lessons and lectures, interact with teachers and peers, and receive regular assessments and feedback. The project is designed to facilitate remote learning and improve the quality of e-learning.

#### Features
- **User Registration:** Students and teachers can easily register new accounts and log in.
- **Lesson and Lecture Management:** Teachers can create and organize lessons and lectures in an orderly and accessible manner.
- **Role Assignment:** Roles and permissions are assigned to users to ensure a customized and secure user experience.
- **Notification System:** Provides notifications to students and teachers about important updates and new lessons.
- **Dashboard:** A comprehensive dashboard for managing accounts, lessons, lectures, and assessments.

#### Technologies Used
- **Backend:** ASP.NET Core
- **Database:** SQL Server
- **Frontend:** Angular
- **ORM:** Entity Framework Core

#### Prerequisites
- .NET 6.0 SDK
- SQL Server
- Node.js and npm

#### Setup and Running
1. **Clone the repository:**
   ```bash
   git clone https://github.com/username/MyProject.git
   cd MyProject
   ```
2. **Restore packages:**
   ```bash
   dotnet restore
   ```
3. **Create the database:**
   - Modify `appsettings.json` to point to your local database.
   - Run the migrations:
   ```bash
   dotnet ef database update
   ```
4. **Run the project:**
   ```bash
   dotnet run
   ```
5. **Access the application:**
   - Open your browser and go to `https://localhost:5001`

#### Project Structure
```
/MyProject
├── /Controllers
├── /Services
├── /Entities
├── /DTOs
├── /Migrations
├── /Scripts
│   ├── CreateDatabase.sql
│   ├── SeedData.sql
├── /wwwroot
├── /Views
├── appsettings.json
├── MyProject.csproj
├── README.md
```

#### Usage
Users can register new accounts or log in to access the dashboard, where they can manage lessons and lectures, assign roles, and interact with students and teachers.

#### Contributing
Contributions are welcome to improve the project. You can open a new issue or fork the repository and submit a Pull Request.




