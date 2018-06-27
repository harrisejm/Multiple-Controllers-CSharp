using System.Collections.Generic;
using System;
namespace ToDoList.Models
{
  public class Item
  {

    private string _description;
    private static List<Item> _instances = new List<Item> {};

    public Item (string description)
    {
      _description = description;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public static List<Item> GetAll()
    {
       return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }

  class Program
  {
    static void Main()
    {
      bool IsDone= true;
      // Item newItem = new Item(description);
      Console.WriteLine ("Welcome to todo list, you can add anything you want");

      while (IsDone == true)
      {


        Console.WriteLine("You want to add an item or view the list? select one (Add/View/Exit)");

        string description = Console.ReadLine();
        if (description=="add")
        {
          Console.WriteLine("Please enter your item ");
          string newItems= Console.ReadLine();
          Item newItem = new Item(newItems);
          newItem.Save();
          // Main(); This also works if you comment out while loop
        }
        else if(description=="view")
        {
          Console.WriteLine("You have these items in your to do list");
          List<Item> result = Item.GetAll();
          foreach (Item thisItem in result)
          {
            Console.WriteLine("List items: " + thisItem.GetDescription());
          }
          // Main();
        }
        else if(description == "exit")
        {
          Console.WriteLine("Goodbye");
          IsDone = false;
        }
      }
      // else
      // {
      //   Main();
      // }
    }
  }
}
