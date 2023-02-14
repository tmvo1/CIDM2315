namespace Lecture;
class Program
{
    static void Main(string[] args)
    {
    // Q1
        Console.WriteLine("Please input an integer: ");
        int x = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input an integer: ");
        int y = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"a = {x}; b = {y}");
        LargestNum(x,y);
    // Q2
        Console.WriteLine("Please input an integer: ");
        int n = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input a shape (left or right): ");
        string shape1 = Console.ReadLine();
        Console.WriteLine($"N is {n}; shape is {shape1}");
        Triangle(n, shape1);
    }
    static void LargestNum(int a, int b)
    {
        if(a>b)
        {
            Console.WriteLine($"The largest number is: {a}");
        }
        else
        {
            Console.WriteLine($"The largest number is {b}");
        }
    }
    static void Triangle(int a, string shape)
    {
        if(shape == "left")
        {
            for(int row = 0; row<a; row++)
            {
                for(int col = 0; col<a; col++)
                {
                    if(row>=col)
                        Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        else if(shape == "right")
        {
            for(int row = 1; row<=a; row++)
            {
                for(int col = 0; col<a-row; col++)
                {
                    Console.Write(" ");
                }
                for(int asks = 0; asks<row; asks++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        else
        {
            Console.WriteLine("Invalid shape");
        }
    }

}
