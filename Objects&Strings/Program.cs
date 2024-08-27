using System;

namespace ObjectStringExample
{
    // Define an interface called IBootUp
    public interface IBootUp
    {
        // Boolean property with automatic getter and setter
        bool IsOn { get; set; }

        // Method to power on or off the device
        void PowerOnOff();
    }

    // Define a class called Computer that implements IBootUp
    public class Computer : IBootUp
    {
        // Automatic properties for Brand and Type
        public string Brand { get; set; }
        public string Type { get; set; }

        // Implement the IsOn property from the interface
        public bool IsOn { get; set; }

        // Constructor that initializes Brand, Type, and IsOn
        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }

        // Implement the PowerOnOff method from the interface
        public void PowerOnOff()
        {
            // Toggle the IsOn property
            IsOn = !IsOn;

            // Print different messages depending on the IsOn value
            if (IsOn)
            {
                Console.WriteLine("The computer is booting up!");
            }
            else
            {
                Console.WriteLine("The computer is shutting down!");
            }
        }

        // Override the ToString method to provide a custom string representation of the object
        public override string ToString()
        {
            return $"This computer is made by {Brand} and is a {Type} computer.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Computer object
            Computer computer1 = new Computer("Dell", "Laptop", false);

            // Create an IBootUp object and assign it the computer object
            IBootUp bootUp1 = computer1;

            // Compare the computer1 object to the bootUp1 object using Equals and print the result
            Console.WriteLine($"computer1.Equals(bootUp1): {computer1.Equals(bootUp1)}");

            // Create another Computer object with the same values as the first one
            Computer computer2 = new Computer("Dell", "Laptop", false);

            // Compare the two Computer objects and print the result
            Console.WriteLine($"computer1.Equals(computer2): {computer1.Equals(computer2)}");

            // Create a new string variable with the value of computer1's ToString method
            string computerDescription = computer1.ToString();

            // Compare the string variable to the ToString result of computer1 and print the result
            Console.WriteLine($"computerDescription.Equals(computer1.ToString()): {computerDescription.Equals(computer1.ToString())}");

            // Compare the string variable to the ToString result of computer2 and print the result
            Console.WriteLine($"computerDescription.Equals(computer2.ToString()): {computerDescription.Equals(computer2.ToString())}");

            // Call the GetType method on a computer object and print the result
            Console.WriteLine($"computer1.GetType(): {computer1.GetType()}");

            // Call the GetType method on the IBootUp object and print the result
            Console.WriteLine($"bootUp1.GetType(): {bootUp1.GetType()}");

            // Turn on or off the computer by calling the PowerOnOff method
            computer1.PowerOnOff();

            // Check if the string variable contains the letter "i" and print the result
            Console.WriteLine($"computerDescription.Contains('i'): {computerDescription.Contains('i')}");

            // Call ToUpper on the string variable and print the result
            Console.WriteLine($"computerDescription.ToUpper(): {computerDescription.ToUpper()}");
        }
    }
}
