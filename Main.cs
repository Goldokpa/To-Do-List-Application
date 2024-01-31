using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list to store tasks
        List<string> tasks = new List<string>();

        // Display the menu to the user
        while (true)
        {
            Console.WriteLine("To-Do List Application");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1, 2, or 3): ");

            // Get user input for menu choice
            string choice = Console.ReadLine();

            // Process user choice
            switch (choice)
            {
                case "1":
                    // Add a task
                    Console.Write("Enter the task: ");
                    string task = Console.ReadLine();
                    tasks.Add(task);
                    Console.WriteLine("Task added successfully!");
                    break;

                case "2":
                    // View tasks
                    Console.WriteLine("Tasks:");
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("No tasks available.");
                    }
                    else
                    {
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tasks[i]}");
                        }
                    }
                    break;

                case "3":
                    // Code to Exit the application
                    Console.WriteLine("Exiting the To-Do List Application. Goodbye!");
                    return;

                default:
                    // Invalid choice
                    Console.WriteLine("Invalid choice. Please Enter a Valid Number");
                    break;
            }

            // Displays a separator line for better readability
            Console.WriteLine(new string('-', 30));
        }
    }
}
