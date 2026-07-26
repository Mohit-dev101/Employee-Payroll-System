# Employee-Payroll-System
# Employee Payroll System (C#)

## 📌 Project Overview

This project demonstrates an **Employee Payroll System** developed in **C#** using the concepts of **Object-Oriented Programming (OOP)**.

The application calculates employee salaries using **Inheritance**, **Interfaces**, and **Polymorphism**.

---

## 🚀 Features

- Employee Payroll Management
- Salary Calculation
- Full-Time Employee Support
- Part-Time Employee Support
- Interface Implementation
- Method Overriding
- Runtime Polymorphism
- Console-Based Application

---

## 🛠️ Technologies Used

- C#
- .NET Console Application
- Visual Studio / VS Code

---

## 📚 OOP Concepts Used

### 1. Interface
- `IPayable`
- Declares the `CalculatePay()` method.

### 2. Inheritance
- `Employee` is the base class.
- `FullTimeEmployee` inherits from `Employee`.
- `PartTimeEmployee` inherits from `Employee`.

### 3. Polymorphism
- `CalculatePay()` is overridden in derived classes.
- `Display()` is also overridden to display employee-specific details.

### 4. Encapsulation
Employee information is stored inside class members and accessed through objects.

---

## 📂 Project Structure

```
EmployeePayrollSystem/
│
├── Program.cs
└── README.md
```

---

## 🏗️ Class Diagram

```
                IPayable
                    |
                    |
            +----------------+
            |   Employee     |
            +----------------+
            | Id             |
            | Name           |
            | BasicSalary    |
            +----------------+
            | CalculatePay() |
            | Display()      |
            +----------------+
              ▲           ▲
              |           |
      +---------------+   +----------------+
      |FullTimeEmployee|  |PartTimeEmployee|
      +---------------+   +----------------+
      | Bonus         |   | HoursWorked    |
      | HRA           |   | HourlyRate     |
      +---------------+   +----------------+
      | CalculatePay()|   | CalculatePay() |
      | Display()     |   | Display()      |
      +---------------+   +----------------+
```

---

## 💻 Sample Output

```
========== EMPLOYEE PAYROLL ==========

----- Full Time Employee -----
Employee ID : 101
Employee Name : Mohit
Basic Salary : 50000
Bonus : 8000
HRA : 5000
Total Salary : 63000

--------------------------------------

----- Part Time Employee -----
Employee ID : 102
Employee Name : Rahul
Hours Worked : 120
Hourly Rate : 300
Total Salary : 36000

--------------------------------------

----- Full Time Employee -----
Employee ID : 103
Employee Name : Anjali
Basic Salary : 60000
Bonus : 10000
HRA : 7000
Total Salary : 77000

--------------------------------------

----- Part Time Employee -----
Employee ID : 104
Employee Name : Priya
Hours Worked : 80
Hourly Rate : 400
Total Salary : 32000

--------------------------------------
```

---

## ▶️ How to Run

### Clone the repository

```bash
git clone https://github.com/your-username/Employee-Payroll-System.git
```

### Open the project

- Visual Studio
- OR VS Code

### Build the project

```bash
dotnet build
```

### Run the project

```bash
dotnet run
```

---

## 🎯 Learning Objectives

This project helps understand:

- Interfaces in C#
- Inheritance
- Method Overriding
- Runtime Polymorphism
- Console Applications
- Object-Oriented Programming (OOP)

---

## 📖 Future Improvements

- Add Employee Records
- Update Employee Details
- Delete Employee
- Store Data in SQL Server/MySQL
- File Handling
- Exception Handling
- Windows Forms or ASP.NET Interface

---

## 👨‍💻 Author

**Mohit Kumar**

B.Tech Computer Engineering Student

---

## 📄 License

This project is developed for educational and learning purposes.
