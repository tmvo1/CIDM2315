namespace Lecture3;
class Program
{
    static void Main(string[] args)
    {
        // Q1
        int counter = 0;
        Console.WriteLine("Input an interger: ");
        int num = Convert.ToInt16(Console.ReadLine());
        for(int i = 1; i<=num; i++)
        {
            if(num % i == 0)
            {
               counter++; 
            }
        }
        if(counter == 2)
        {
            Console.WriteLine($"{num} is prime");
        }
        else
        {
            Console.WriteLine($"{num} is non-prime");
        }
        // Q2
        Console.WriteLine("Assign an int value to N: ");
        int x = Convert.ToInt16(Console.ReadLine());
        for(int row = 0; row<x; row++)
        {
            for(int col = 0; col<x; col++)
            {
                Console.Write("#");
            }
            Console.WriteLine("");
        }
        // Q3
        Console.WriteLine("Assign an int value to N: ");
        int y = Convert.ToInt16(Console.ReadLine());
        for(int row = 0; row<y; row++)
        {
            for(int col = 0; col<y; col++)
            {
                if(row>=col)
                    Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}