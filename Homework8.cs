namespace Lecture8;
class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer(input_id: 110, input_name: "Alice", input_age: 28);
        c1.PrintCusInfo();
        Customer c2 = new Customer(input_id: 111, input_name: "Bob", input_age: 30);
        c2.PrintCusInfo();
        c1.ChangeID(220);
        c2.ChangeID(221);
        c1.PrintCusInfo();
        c2.PrintCusInfo();
        c1.CompareAge(c2);
    }
}
class Customer{
    private int cus_id {get;set;} = 0;
    public string cus_name {get;set;} = string.Empty;
    public int cus_age {get;set;} = 0;
    public Customer(int input_id, string input_name, int input_age){
        cus_id = input_id;
        cus_name = input_name;
        cus_age = input_age;
        this.cus_age = cus_age;
        this.cus_name = cus_name;
    }
    public void ChangeID(int new_id){
        cus_id = new_id;
    }
    public void PrintCusInfo(){
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age: {cus_age}");
    }
    public void CompareAge(Customer objCustomer){
        if(this.cus_age <= objCustomer.cus_age){
            Console.WriteLine($"{objCustomer.cus_name} is older");
        }
        else{
            Console.WriteLine($"{this.cus_name} is older");
        }
    }
}
