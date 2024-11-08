using ExpenseTrackerCLI;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        ExpenseTrackerLib.ProcessArguments(args);
    }
}