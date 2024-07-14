using System;

class Student
{
    // Properties
    public int RollNo { get; set; }
    public string StudName { get; set; }
    public int MarksInEng { get; set; }
    public int MarksInMaths { get; set; }
    public int MarksInScience { get; set; }

    // Constructor to initialize student details
    public Student(int rollNo, string studName, int marksInEng, int marksInMaths, int marksInScience)
    {
        RollNo = rollNo;
        StudName = studName;
        MarksInEng = marksInEng;
        MarksInMaths = marksInMaths;
        MarksInScience = marksInScience;
    }

    // Method to calculate total marks
    public int CalculateTotalMarks()
    {
        return MarksInEng + MarksInMaths + MarksInScience;
    }

    // Method to calculate percentage
    public double CalculatePercentage()
    {
        return (CalculateTotalMarks() / 3.0);
    }

    // Method to display student details
    public void DisplayStudentDetails()
    {
        Console.WriteLine("Student Details:");
        Console.WriteLine($"Roll No: {RollNo}");
        Console.WriteLine($"Name: {StudName}");
        Console.WriteLine($"Marks in English: {MarksInEng}");
        Console.WriteLine($"Marks in Maths: {MarksInMaths}");
        Console.WriteLine($"Marks in Science: {MarksInScience}");
        Console.WriteLine($"Total Marks: {CalculateTotalMarks()}");
        Console.WriteLine($"Percentage: {CalculatePercentage():F2}%");
    }
}

class Program3
{
    static void Main()
    {
        // Reading student details
        Console.Write("Enter Roll No: ");
        int rollNo = int.Parse(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        string studName = Console.ReadLine();

        Console.Write("Enter Marks in English: ");
        int marksInEng = int.Parse(Console.ReadLine());

        Console.Write("Enter Marks in Maths: ");
        int marksInMaths = int.Parse(Console.ReadLine());

        Console.Write("Enter Marks in Science: ");
        int marksInScience = int.Parse(Console.ReadLine());

        // Creating Student object
        Student student = new Student(rollNo, studName, marksInEng, marksInMaths, marksInScience);

        // Displaying student details
        student.DisplayStudentDetails();
    }
}
