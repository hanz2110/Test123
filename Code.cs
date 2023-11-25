using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press any key to see its information. Press Esc to exit.");
        ConsoleKeyInfo keyInfo;
        do
        {
            keyInfo = Console.ReadKey(true); // Read a key without echoing it
            Console.WriteLine("You pressed {0}", keyInfo.KeyChar); // Display the character
            Console.WriteLine("Key code: {0}", keyInfo.Key); // Display the key code
            Console.WriteLine("Modifier keys: {0}", keyInfo.Modifiers); // Display the modifier keys
            Console.WriteLine();
        } while (keyInfo.Key != ConsoleKey.Escape); // Exit when Esc is pressed
    }
}

// Add comment by hanz2110