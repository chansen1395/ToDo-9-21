using System;
using System.Collections.Generic;
using ToDoList.Models;


namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to your ToDo List. [add/view/q]");
      string response = Console.ReadLine();

      if (response.ToLower() == "add")
      {
        Console.WriteLine("Enter the task you need to complete:");
        string task = Console.ReadLine();
        Item newItem = new Item(task);
        Main();
      }
      else if (response.ToLower() == "view")
      {
        Console.WriteLine("Your current tasks: ");
        int i = 1;
        foreach (Item task in Item.GetAll())
        {
          Console.WriteLine(i +  ". " + task.Description);
          i++;
        }
        Main();
      }
      else if (response.ToLower() == "q")
      {
        Console.WriteLine("Goodbye!");
      }
      else
      {
        Console.WriteLine("Try again: [add/view]");
        Main();
      }
    }
  }
}