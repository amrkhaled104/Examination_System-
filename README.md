# Examination System

This is an Examination System developed using C#. The system is designed to manage exams, questions, and subjects. It allows for the creation and management of multiple types of exams (final and practical), as well as supports multiple question types such as Multiple Choice Questions (MCQ) and True/False questions (TF).

## Features

### 1. **Subject Management**
- The system allows the creation of subjects (e.g., Math, Physics, Computer Science).
- For each subject, you can assign one or more types of exams (Final or Practical).

### 2. **Exam Creation**
- You can create both **Final Exams** and **Practical Exams** for a subject.
- The exam creation process allows you to define:
  - Exam time (in minutes).
  - Number of questions.
  - The selection of questions from the question bank.

### 3. **Question Management**
- The system supports two main types of questions:
  - **Multiple Choice Questions (MCQ)**: Questions with multiple answer choices, where the user selects one correct answer.
  - **True/False (TF)**: Questions that have a binary answer, either true or false.
- For each question type, users can modify questions, change the header, body, mark, and explanation.
- The system also supports modifying the choices for MCQ questions and updating the correct choice.

### 4. **Interactive Question Bank**
- The question bank allows users to interactively add, modify, and delete questions.
- Questions can be selected by their index number and assigned to specific exams.
- Each question in the bank has the following attributes:
  - **Header**: The question title.
  - **Body**: The main content or prompt for the question.
  - **Mark**: The score assigned to the question.
  - **Explanation**: An explanation of the correct answer.

### 5. **Display Exams**
- Users can display an exam for a specific subject, showing all questions and their details.
- The system distinguishes between **Final Exams** and **Practical Exams** and shows only the relevant questions based on the selected exam type.

### 6. **Question Bank Modification**
- The system allows the modification of questions in the bank:
  - For **MCQ Questions**, you can update the question header, body, mark, explanation, choices, and correct answer.
  - For **True/False Questions**, you can modify the question's header, body, mark, explanation, and the correct answer (True/False).

### 7. **Validation**
- The system ensures that the correct format is used when entering data (e.g., valid question choices, correct answers for MCQs, etc.).
- The system provides user feedback for invalid inputs.

## How to Use the System

### 1. **Create a Subject**
   - You can create a subject by specifying its name (e.g., Math, Physics, CS) and an ID.
   - The system allows you to create exams for each subject.

### 2. **Create Exams for Subjects**
   - After creating a subject, you can add either a **Final Exam** or a **Practical Exam** to it.
   - During the creation process, you will define the exam time, number of questions, and select questions for the exam from the question bank.

### 3. **Adding Questions to Exams**
   - You can choose from the available MCQ and TF questions in the question bank and assign them to the exam.
   - Questions can be selected interactively by entering their index numbers.

### 4. **Modify Questions**
   - Modify questions by selecting a question from the bank and updating its details (e.g., mark, body, choices, correct answer).
   - New questions can be added to the question bank.

### 5. **Display an Exam**
   - Display a subject's exam by selecting the subject and the exam type (final or practical).
   - The system will display the selected exam questions along with their details.

## Code Overview

### 1. **Question Class**
   - The `Question` class is the base class for all question types (MCQ and TF).
   - It contains common properties like `Header`, `Body`, `Mark`, and `Explanation`.

### 2. **MCQQuestion Class**
   - This class inherits from `Question` and represents multiple-choice questions.
   - It includes a list of choices and a `CorrectChoiceIndex` property to track the correct answer.

### 3. **TrueFalseQuestion Class**
   - This class inherits from `Question` and represents true/false questions.
   - It includes a `CorrectAnswer` property to store the correct answer (True or False).

### 4. **Exam Class**
   - The `Exam` class is abstract and serves as the base class for both `FinalExam` and `PracticalExam`.
   - It holds properties like `Time`, `NumberOfQuestions`, and a list of `Questions`.

### 5. **FinalExam and PracticalExam Classes**
   - These classes inherit from `Exam` and represent the types of exams (final or practical).
   - Each class contains specific properties like the types of questions (MCQs and TF).

### 6. **Subject Class**
   - Represents a subject in the system (e.g., Math, Physics).
   - Each subject can have a `FinalExam` and/or `PracticalExam`.

### 7. **ModifyQuestionBank Method**
   - This method allows users to modify the existing questions (MCQ or TF) in the question bank.
   - Users can update details such as the question header, body, explanation, choices, and correct answers.

### 8. **DisplayExam Method**
   - This method displays the questions for a specific exam (final or practical) based on the subject name and exam type.

## Example Workflow

### Step 1: Create a Subject
   - Example: Create a new subject named "Math" with ID 101.

### Step 2: Create an Exam for the Subject
   - Example: Create a final exam for the subject "Math" with a time of 90 minutes and 5 questions.

### Step 3: Add Questions to the Exam
   - Choose multiple-choice questions (MCQ) and True/False questions from the question bank and assign them to the exam.

### Step 4: Display the Exam
   - View the created exam by entering the subject name ("Math") and exam type ("final").

## Future Enhancements

- **Grading System**: A feature that will allow automatic grading of exams based on the student's answers.
- **User Authentication**: A login system for administrators and students.
- **Randomization of Questions**: Randomize question order to make exams more secure.
- **Question Bank Expansion**: Increase the number of available questions and expand the database to handle more subjects.

