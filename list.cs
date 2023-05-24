using System;
using System.Collections.Generic;

class Program
{
    static List<string> itemList = new List<string>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Add item");
            Console.WriteLine("2. Display items");
            Console.WriteLine("3. Update item");
            Console.WriteLine("4. Delete item");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice:");

            string choiceInput = Console.ReadLine();
            if (int.TryParse(choiceInput, out int choice)) // Checks to see if value entered can be converted to int
            {
                switch (choice)
                {
                    case 1:
                        AddItem();
                        break;
                    case 2:
                        DisplayItems();
                        break;
                    case 3:
                        UpdateItem();
                        break;
                    case 4:
                        DeleteItem();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a valid integer.");
            }

            Console.WriteLine();
        }
    }

    static void AddItem()
    {
        Console.WriteLine("Enter the item:");
        string item = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(item))
        {
            itemList.Add(item);
            Console.WriteLine("Item added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid item. Please enter a non-empty value.");
        }

        Console.WriteLine();
    }

    static void DisplayItems()
    {
        if (itemList.Count == 0) {
            Console.WriteLine("There is no items in the list.");
            Console.WriteLine();
        }
        else {
            Console.WriteLine("Items in the list:");
            foreach (string item in itemList)
            {
                Console.WriteLine(item);
            }
        }
        Console.WriteLine();
    }

    static void UpdateItem()
    {
        if (itemList.Count == 0)
        {
            Console.WriteLine("No items in the list to update.");
            Console.WriteLine();
            return;
        }

        Console.WriteLine("Enter the index of the item to update:");
        string indexInput = Console.ReadLine();

        if (int.TryParse(indexInput, out int index))
        {
            if (index >= 0 && index < itemList.Count)
            {
                Console.WriteLine("Enter the new item value:");
                string newItem = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(newItem))
                {
                    itemList[index] = newItem;
                    Console.WriteLine("Item updated successfully.");
                }
                else {
                    Console.Write("Invalid item. Please enter a non-empty value.");
                }
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }
        else
        {
            Console.WriteLine("Invalid index. Please enter a valid integer.");
        }

        Console.WriteLine();
    }

    static void DeleteItem()
    {
        if (itemList.Count == 0)
        {
            Console.WriteLine("No items in the list to delete.");
            Console.WriteLine();
            return;
        }

        Console.WriteLine("Enter the index of the item to delete:");
        string indexInput = Console.ReadLine();

        if (int.TryParse(indexInput, out int index))
        {
            if (index >= 0 && index < itemList.Count)
            {
                itemList.RemoveAt(index);
                Console.WriteLine("Item deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }
        else
        {
            Console.WriteLine("Invalid index. Please enter a valid integer.");
        }

        Console.WriteLine();
    }
}