namespace Homework1;
class Program
{
    static void Main(string[] args)
    {
        // Q1
        Console.WriteLine("Please input a letter grade: ");
        string letter_grade = Console.ReadLine();
        if(letter_grade=="A")
        {
            Console.WriteLine("GPA point = 4");
        }
        else
        {
            if(letter_grade=="B")
            {
                Console.WriteLine("GPA point = 3");
            }
            else
            {
                if(letter_grade=="C")
                {
                    Console.WriteLine("GPA point = 2");
                }
                else
                {
                    if(letter_grade=="D")
                    {
                        Console.WriteLine("GPA point = 1");
                    }
                    else
                    {
                        if(letter_grade=="F")
                        {
                            Console.WriteLine("GPA point = 0");
                        }
                        else
                        {
                            Console.WriteLine("Wrong Letter Grade!");
                        }
                    }
                }
            }
        }
        // Q2
        Console.WriteLine("Please input the first num: ");
        string str_num1 = Console.ReadLine();
        int num1 = Convert.ToInt16(str_num1);
        Console.WriteLine("Please input the second num: ");
        string str_num2 = Console.ReadLine();
        int num2 = Convert.ToInt16(str_num2);
        Console.WriteLine("Please input the third num: ");
        string str_num3 = Console.ReadLine();
        int num3 = Convert.ToInt16(str_num3);

        if(num1<num2)
        {
            if(num1<num3)
            {
                Console.WriteLine($"The smallest value is: {num1}");
            }
            else
            {
                Console.WriteLine($"The smallest value is: {num3}");
            }
        }
        else
        {
            if(num2<num3)
            {
                Console.WriteLine($"The smallest value is: {num2}");
            }
            else
            {
                Console.WriteLine($"The smallest number is: {num3}");
            }
        }
        //Q3 Bonus
        Console.WriteLine("Please input a year: ");
        string str_yr = Console.ReadLine();
        int yr = Convert.ToInt16(str_yr);
        
        if((yr%4==0)&&(yr%100!=0)||(yr%400==0))
        {
            Console.WriteLine($"{yr} is a Leap Year!");
        }
        else
        {
            Console.WriteLine($"{yr} is not a Leap Year.");
        }
    }
}
