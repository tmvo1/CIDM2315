namespace Lecture5;
class Program
{
    static void Main(string[] args)
    {
        // Q1
        Console.WriteLine("Please input an integer: ");
        int a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input another integer: ");
        int b = Convert.ToInt16(Console.ReadLine());
        int num = LargestNum(a, b);
        Console.WriteLine($"a = {a}; b = {b}");
        Console.WriteLine($"The largest number is {num}");
        // Q2
        Console.WriteLine("----------------Q2----------------");
        Console.WriteLine("Please input an integer: ");
        int A = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input another integer: ");
        int B = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input another integer: ");
        int C = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input another integer: ");
        int D = Convert.ToInt16(Console.ReadLine());
        int num2 = LargestNum2(A,B,C,D);
        Console.WriteLine($"a = {A}; b = {B}; c = {C}; d = {D}");
        Console.WriteLine($"The largest number is {num2}");
        // BONUS
        Console.WriteLine("--------------BONUS---------------");
        createAccount();
    }
    static int LargestNum(int a, int b)
    {
        
        if(a>b)
        {
            return a;
        }
        else 
        {
            return b;
        }
    }
    static int LargestNum2(int a, int b, int c, int d)
    {
        int Max1 = LargestNum(a,b);
        int Max2 = LargestNum(c,d);
        int result = LargestNum (Max1,Max2);

        return result;
    }
    static void createAccount()
    {
        Console.WriteLine("Enter your Username:");
        string user_name1 = Console.ReadLine();
        Console.WriteLine("Enter your Password:");
        string pass_word1 = Console.ReadLine();
        Console.WriteLine("Enter your Password Again:");
        string pass_wordagain1 = Console.ReadLine();
        Console.WriteLine("Enter your Birth Year: ");
        int birth_year1 = Convert.ToInt16(Console.ReadLine());
        bool age = checkAge(birth_year1);
        if(age==true)
        {
            if(pass_word1==pass_wordagain1)
            {
                Console.WriteLine("Account is created successfully!");
            }
            else
            {
                Console.WriteLine("Wrong Password.");
            }
        }
        else 
        {
            Console.WriteLine("Could not create an account.");
        }
    }
    static bool checkAge(int birth_year)
    {
        int age = (2022-birth_year);
        if(age>=18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
