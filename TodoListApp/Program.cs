using System;

Console.WriteLine("Application developed by: Nozdrin VV");
Console.WriteLine("=============================================");


Console.Write("Enter your firstname: ");
string firstName = Console.ReadLine() ?? "";

Console.Write("Enter your lastname: ");
string lastName = Console.ReadLine() ?? "";

Console.Write("Enter your birth year: ");
string birthYearInput = Console.ReadLine() ?? "0";


// converting birth year to int and calculating age

int birthYear = Convert.ToInt32(birthYearInput);
int currentYear = DateTime.Now.Year;
int age = currentYear - birthYear;


Console.WriteLine("---------------------------------------------");
Console.WriteLine($"User added: {firstName} {lastName}, age - {age}");



Console.WriteLine("Welcome to TodoListApp! Type 'help' to see available commands.");
Console.WriteLine("---------------------------------------------");

string[] todos = new string[2];
int taskCount = 0; // number of added tasks

while (true) // infinite loop for checking command
{
    Console.Write("Enter command: ");
    string userCommand = Console.ReadLine()?.Trim() ?? "";

    if (string.IsNullOrWhiteSpace(userCommand)) continue;


    if (userCommand.Equals("exit", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Goodbye!");
        break;
    }
    else if (userCommand.Equals("help", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Available commands: ");
        Console.WriteLine("help - Show all available commands with descriptions");
        Console.WriteLine("profile - Display user profile details");
        Console.WriteLine("add - Add a new task");
        Console.WriteLine("view - View all active tasks");
        Console.WriteLine("exit - Exit the application");
    }
    else if (userCommand.Equals("profile", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine($"User Profile: {firstName} {lastName}, Born: {birthYear} (Age: {age})");
    }
    else if (userCommand.StartsWith("add", StringComparison.OrdinalIgnoreCase))
    {

    }
    else
    {
        Console.WriteLine("Command not foun or not development. Type another command");
    }


}