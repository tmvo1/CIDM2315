namespace Lecture7;
class Program
{
    static void Main(string[] args)
    {
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);
        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);
        p1.ProfInfo();
        p2.ProfInfo();
        
        
        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.SetGrade(90);
        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.SetGrade(80);
        s1.StudentInfo();
        s2.StudentInfo();

        // I'm not sure how to calculate the difference in salary and total grade.
    }
}
class Professor{
    public string profName;
    public string classTeach;
    private double salary;
    public void SetSalary(double salary_amount){
        salary = salary_amount;
    }
    public double GetSalary(){
        return salary;
    }
    public void ProfInfo(){
        Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is: {salary}");
    }
}
class Student{
    public string studentName;
    public string classEnroll;
    private double studentGrade;
    public void SetGrade(double newGrade){
        studentGrade = newGrade;
    }
    public double GetGrade(){
        return studentGrade;
    }
    public void StudentInfo(){
        Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is: {studentGrade}");
    }
}