// Author: Gabriel Ellebrink, gabell-2@student.ltu.se, L0002B, Uppgift 1 Console-variant

using System.Text;

namespace ChangeCalculatorConsole
{
  // Class that is used to track number of bills and coins.
  // Possible bills are 500, 200, 100, 50, and 20 kr.
  // Possible coins are 10, 5, and 1 kr.
  class CashBook {
    // Bills.
    public int num500s = 0;
    public int num200s = 0;
    public int num100s = 0;
    public int num50s = 0;
    public int num20s = 0;
    // Coins.
    public int num10s = 0;
    public int num5s = 0;
    public int num1s = 0;

    // Creates a formatted string with the number of bills and coins.
    public String toString()
    {
      return $@"
      Number of 500 kr bills: {num500s}
      Number of 200 kr bills: {num200s}
      Number of 100 kr bills: {num100s}
      Number of 50 kr bills:  {num50s}
      Number of 20 kr bills:  {num20s}
      Number of 10 kr coins:  {num10s}
      Number of 5 kr coins:   {num5s}
      Number of 1 kr coins:   {num1s}";  
    }
  }

  // Calculator class that contains the logic to calculate the change.
  class Calculator {
    // Gets the change from the cost and amount paid as input.
    // Returns NaN if the amount paid is less than the cost.
    public static double getChange(double cost, double paidAmount)
    {
      if (paidAmount < cost)
      {
        return double.NaN;
      }
      return paidAmount-cost;
    }

    // Converts an amount to a number of different bills and coins.
    // Returns a CashBook object.
    public static CashBook amountToCash(double amount)
    {
      CashBook cashBook = new();

      // Possible bill or coin values, sorted high to low.
      int[] cashValues = new int[] { 500, 200, 100, 50, 20, 10, 5, 1 };

      foreach (int cashValue in cashValues)
      {
        while (amount >= cashValue)
        {
          // Add the bill or coin to the cashBook.
          switch (cashValue)
          {
            case 500:
              cashBook.num500s++;
              break;
            case 200:
              cashBook.num200s++;
              break;
            case 100:
              cashBook.num100s++;
              break;
            case 50:
              cashBook.num50s++;
              break;
            case 20:
              cashBook.num20s++;
              break;
            case 10:
              cashBook.num10s++;
              break;
            case 5:
              cashBook.num5s++;
              break;
            case 1:
              cashBook.num1s++;
              break;
            default:
              break;
          }
          // Deduct the value of the bill or coin that we just added.
          amount -= cashValue;
        }
      }

      return cashBook;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      bool quit = false;

      // Print welcome info.
      Console.WriteLine("-----------------------------------------\n");
      Console.WriteLine("--- Welcome to the Change Calculator! ---\n");
      Console.WriteLine("--- Made by: Gabriel Ellebrink ----------\n");
      Console.WriteLine("-----------------------------------------\n");

      while (!quit)
      {
        string costInput = "";
        string paidInput = "";

        // Ask user to provide the cost.
        Console.Write("What is the cost? ");
        costInput = Console.ReadLine();

        double costNum = -1;
        // Convert input to a number, or ask again if invalid.
        while (!double.TryParse(costInput, out costNum) || costNum < 0)
        {
          Console.Write("Invalid input. Please enter a positive number: ");
          costInput = Console.ReadLine();
        }

        // Ask user to provide the amount paid.
        Console.Write("How much was paid? ");
        paidInput = Console.ReadLine();

        double changeAmount = Double.NaN;
        double paidNum = -1;

        // Calculate the change amount.
        while (Double.IsNaN(changeAmount))
        {
          // Convert input to a number, or ask again if invalid.
          while (!double.TryParse(paidInput, out paidNum) || paidNum < costNum)
          {
            Console.Write("Invalid input. Please enter a number above or equal to the cost: ");
            paidInput = Console.ReadLine();
          }
          changeAmount = Calculator.getChange(cost: costNum, paidAmount: paidNum);
        }

        // Get a CashBook object containing number of bills and coins.
        CashBook cashBook = Calculator.amountToCash(amount: changeAmount);

        // Print the change.
        Console.WriteLine("---");
        Console.WriteLine("Change:");
        Console.WriteLine(cashBook.toString());
        Console.WriteLine("---\n");

        // Ask whether to quit or run again.
        Console.Write("Write 'q' to quit, or any other key to restart: ");
        if (Console.ReadLine() == "q")
        {
          quit = true;
        }
        Console.WriteLine("\n");
      }
      return;
    }
  }
}