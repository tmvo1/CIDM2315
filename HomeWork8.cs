namespace Lecture9;
class Program
{
    static void Main (string[] args) {
        // Test Q1
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);


        // Input 2d array for Q2
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };


        // Test Q2.1
        PrintAllOddNumber(array_2d);


        // Test Q2.2
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");


        // Test Q2.3
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
                Console.Write(num +" ");
        }
    }
     // Q1: calculate the sum of elements in a given int_array (4 points)
    public static void ArraySum(int[] int_array){
        int sum1 = 0;
        foreach(var num1 in int_array){
            sum1+=num1;
        }
        Console.WriteLine($"The Sum of int_array is: {sum1}");





    }


    //Q2.1: given a 2d array, print all the odd elements (2 points)
    public static void PrintAllOddNumber(int[ , ] array_2d){
        foreach(int num2 in array_2d){
            if(num2%2!=0){
                Console.Write($"{num2} ");
            }
        }




       
    }
    //Q2.2: given a 2d array, return the sum of all elements (2 points)
    public static int ElementSum(int[ , ] array_2d){
        int sum2 = 0;
        foreach (var num3 in array_2d){
            sum2 += num3;
        }
        return sum2;

       
    }


    // Q2.3: given a 2d array, double its element values and return it (2 points)
    public static int[ , ] DoubleArray(int[ , ] array_2d){
        int[,] double_array_2d = new int[3,3];
        for (int row = 0; row<3; row++){
            for (int col = 0; col<3; col++){
                double_array_2d[row,col] = array_2d[row,col]*2;
            }
        }
        return double_array_2d;
       
   }  
   
}
