// See https://aka.ms/new-console-template for more information

using System.Globalization;

string[] options = { "Sum", "Minus", "Times", "Divided" };
int selectedOption = 0;

Console.WriteLine("Choose your first number:");
double firstNumber = double.Parse(Console.ReadLine().Trim(), CultureInfo.InvariantCulture);
Console.Clear();

Console.WriteLine("Choose your second number:");
double secondNumber = double.Parse(Console.ReadLine().Trim(), CultureInfo.InvariantCulture);
Console.Clear();

while (true)
{
    Console.Clear();
    
    Console.WriteLine("Use your arrow keys to select your operation:");

    for (int i = 0; i < options.Length; i++)
    {
        if (i == selectedOption) {
            Console.WriteLine($"{options[i]} <");
        } else {
            Console.WriteLine(options[i]);
        }
    }

    var key = Console.ReadKey(true).Key;

    if (key == ConsoleKey.UpArrow)
    {
        selectedOption = (selectedOption == 0) ? options.Length - 1 : selectedOption - 1;
    }
    else if (key == ConsoleKey.DownArrow)
    {
        selectedOption = (selectedOption == options.Length - 1) ? 0 : selectedOption + 1;
    }
    else if (key == ConsoleKey.Enter)
    {
        Console.WriteLine($"\nYou selected: {options[selectedOption]}");
        break;
    }
}

switch (selectedOption)
{
    case 0:
        Console.WriteLine($"Result: {firstNumber + secondNumber}");
        break;
    
    case 1:
        Console.WriteLine($"Result: {firstNumber - secondNumber}");
        break;
    
    case 2:
        Console.WriteLine($"Result: {firstNumber * secondNumber}");
        break;
    
    case 3:
        Console.WriteLine($"Result: {firstNumber / secondNumber}");
        break;
    
    default: 
        Console.WriteLine("Wrong option");
        break;
}