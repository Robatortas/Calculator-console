/* Made by Ramcantus
** Forked by Robatortas
*/
namespace Calculator {

public static class Program {

    private static long num01 = 0;
    private static long num02 = 0;
    private static String enter = "\n";
    
    public static void console() {

        // Run
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Title = "Calculator Test";
        Console.WriteLine("Console Calculator by Ram\n" + "Forked by Robatortas\r");
        Console.WriteLine("-------------------------\n");
        Console.WriteLine("\n Press enter to start! :)\n");
        Console.ReadLine();

        // Number Inputs
        Console.WriteLine("Insert a number: ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        num01 = Convert.ToInt32(Console.ReadLine());
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Insert another number: ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        num02 = Convert.ToInt32(Console.ReadLine());
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        // Commands
        Console.WriteLine("Choose an option:");
        Console.WriteLine("\ta - Add ");
        Console.WriteLine("\ts - Substarct");
        Console.WriteLine("\tm - Multiply");
        Console.WriteLine("\td - Divide");
        Console.WriteLine("\tsr - Square Root (only does sqrt of first number input!)");
        Console.WriteLine("What's you'r option: ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;

        // Switch Case (Options)
        switch (Console.ReadLine()) {
        case "a":
        Console.WriteLine(enter + $"Your result: {num01} + {num02} = " + (num01 + num02));
        break;
        case "s":
        Console.WriteLine(enter + $"Your result: {num01} - {num02} = " + (num01 - num02));
        break;
        case "m":
        Console.WriteLine(enter + $"Your result: {num01} * {num02} = " + (num01 * num02));
        break;
        case "d":
        Console.WriteLine(enter + $"Your result: {num01} / {num02} = " + (num01 / num02));
        break;
        // Sqrt addition
        case "sr":
        Console.WriteLine(enter + $"Your result for first inputted number: {num01} = " + (Math.Sqrt(num01)) + "\n" +
                          $"Your result for second inputted number: {num02} = " + (Math.Sqrt(num02))
                        );
        break;
        }

        // Exit
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\nPress enter to exit the program\n");
        Console.ReadLine();
        System.Console.write
    }

        // Main class
        public static void Main(String[] args) => console();
    }
}