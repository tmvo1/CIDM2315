namespace Lecture10;
class Program
{
    static void Main(string[] args)
    {
      Student alice = new Student(111, "Alice");
      Student bob = new Student(222, "Bob");
      Student cathy = new Student(333, "Cathy");
      Student david = new Student(444, "David");

      Dictionary<string, double> gradebook = new Dictionary<string, double>();
      gradebook.Add("Alice", 4.0);
      gradebook.Add("Bob", 3.6);
      gradebook.Add("Cathy", 2.5);
      gradebook.Add("David", 1.8);

      if(gradebook.ContainsKey("Tom")){
        Console.WriteLine("Tom is present in grade book");
      }
      else{
        gradebook.Add("Tom", 3.3);
      }

      double sum = 0;
      foreach(var stu in gradebook){
        sum += stu.Value;
      }
      double avg = sum/gradebook.Count;
      Console.WriteLine($"The average GPA is: " + avg);

       //foreach(var stuObj in Student.stu_list){
            //if(gradebook[stuObj.stuName]>avg){
                //stuObj.PrintInfo();
            //}
                
         //}
     }
}
class Student{
    private int studentID {get; set; }
    private string studentName {get; set; }
    public void PrintInfo(){
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
    public static List<Student> stu_list = new List<Student>();
    public Student(int inputID, string inputName){
        studentID = inputID;
        studentName = inputName;
        stu_list.Add(this);
    }
}