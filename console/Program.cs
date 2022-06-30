// Author: Gabriel Ellebrink, gabell-2@student.ltu.se, L0002B, Uppgift 1 Console-variant

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
      return cost-paidAmount;
    }

    // Converts an amount to a number of different bills and coins.
    // Returns a CashBook object.
    public static CashBook amountToCash(double amount)
    {
      // Verify that amount is valid.
      if (amount < 0)
      {
        return null;
      }

      CashBook cashBook = new CashBook();

      // Possible bill or coin values, sorted high to low.
      int[] cashValues = new int[500, 200, 100, 50, 20, 10, 5, 1];

      int i = 0;
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
}