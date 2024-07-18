using System;

namespace University;

public class University
{

    private Student[] students;
    private int currentStudentCount = 0;

    private Employee[] employees;
    private int currentEmployeeCount = 0;

    private double budget;
    private double tuitionFee;
    private int studentIdCounter = 1;
    private int employeeIdCounter = 1;

    public University(double initialBudget, double tuitionFee, int maxStudents, int maxEmployees)
    {
        if (initialBudget < 0)
            throw new ArgumentException("Initial budget cannot be negative.");

        this.budget = initialBudget;
        this.tuitionFee = tuitionFee;

        students = new Student[maxStudents];
        employees = new Employee[maxEmployees];
    }

    public void AdmitStudent(string name, double testScore)
    {
        if (currentStudentCount < students.Length)
        {
            Student student = new Student(name, studentIdCounter++, testScore);
            students[currentStudentCount++] = student;
        }
        else
        {
            Console.WriteLine("Cannot admit more students, array is full.");
        }
    }

    public void HireEmployee(string name, double salary)
    {
        if (currentEmployeeCount < employees.Length)
        {
            Employee employee = new Employee(name, employeeIdCounter++, salary);
            employees[currentEmployeeCount++] = employee;
        }
        else
        {
            Console.WriteLine("Cannot hire more employees, array is full.");
        }
    }

    public void CheckTestResults(int studentId)
    {
        Student student = Array.Find(students, s => s?.ID == studentId);
        if (student != null)
        {
            Console.WriteLine($"{student.Name} has a test score of {student.TestScore}");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    public void GiveDiploma(int studentId)
    {
        Student student = Array.Find(students, s => s?.ID == studentId);
        if (student != null)
        {
            student.AssignDiploma();
            Console.WriteLine($"{student.Name} has been given a diploma.");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    public void AddTuitionFeesToBudget()
    {
        budget += currentStudentCount * tuitionFee;
    }

    public void PaySalaries()
    {
        double totalSalaries = 0;
        for (int i = 0; i < currentEmployeeCount; i++)
        {
            totalSalaries += employees[i].Salary;
        }

        if (totalSalaries <= budget)
        {
            budget -= totalSalaries;
            Console.WriteLine("Salaries have been paid.");
        }
        else
        {
            Console.WriteLine("Not enough budget to pay salaries.");
        }
    }

    public double GetBudget()
    {
        return budget;
    }
}