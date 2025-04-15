# 📝 Examination System 🎓

A fully interactive console-based **Examination Management System** built with **C#**, allowing instructors to create, manage, and display exams, and enabling students to take exams in a simple and structured way.

---

## 🔧 Features

### 👨‍🏫 Admin Capabilities:
- 📚 Manage question banks (MCQ and True/False).
- 🧪 Create **Practical Exams** (MCQ-only).
- 📖 Create **Final Exams** (MCQ + True/False).
- 🔍 Preview any exam before it is taken.
- ✏️ Edit, add, or delete questions from the bank.

### 👨‍🎓 Student Capabilities:
- 🧑‍💻 Take Final and Practical Exams.
- ✅ Real-time correction and scoring.
- 📊 Displays score and percentage after completion.
- 📘 Shows correct answers and explanations after wrong attempts.

---

## 🚀 How It Works

1. Upon launching, the system asks for the user's role (`admin` or `user`).
2. Based on the selected role:
   - Admins can create and modify exams.
   - Users can take available exams.
3. Exam flow:
   - Questions are displayed one by one.
   - User inputs answers.
   - The system evaluates responses instantly.
4. At the end, a detailed result summary is shown.

---

## 🗂️ Project Structure

- `Program.cs` – Entry point and UI logic (menus and exam flow).
- `Exam.cs` – Contains abstract `Exam` class, `FinalExam`, and `PracticalExam` classes.
- `Question.cs` – Defines `Question`, `MCQQuestion`, and `TrueFalseQuestion` classes.

---

## 🛠️ Technologies Used

- **.NET / C# Console Application**
- Object-Oriented Programming (OOP)
- Basic LINQ
- Clean code structure with regions and abstraction

---

## ✅ Future Enhancements

- ⏱️ Add exam timer countdown
- 💾 Load/save question bank from external file (JSON/XML)
- 🧑‍🎓 User login system with saved results
- 🌐 GUI version (WinForms or WPF)

---

## 📌 Getting Started

1. Clone or download the project.
2. Open in **Visual Studio** or any C# IDE.
3. Build and run.
4. Interact through the console menu.

---

## 👨‍💻 Author

Made with 💙 by **Amr Khaled**  
[LinkedIn](https://www.linkedin.com/in/amr-khaled-419260304/) | [GitHub](https://github.com/amrkhaled104)

---

