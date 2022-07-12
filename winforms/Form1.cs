namespace ChangeCalculatorWinForms
{
  // Class that is used to track number of bills and coins.
  // Possible bills are 500, 200, 100, 50, and 20 kr.
  // Possible coins are 10, 5, and 1 kr.
  class CashBook
  {
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
      string result = "";

      if (num500s > 0)
      {
        result += $"Number of 500 kr bills: {num500s} \n";
      }
      if (num200s > 0)
      {
        result += $"Number of 200 kr bills: {num200s} \n";
      }
      if (num100s > 0)
      {
        result += $"Number of 100 kr bills: {num100s} \n";
      }
      if (num50s > 0)
      {
        result += $"Number of 50 kr bills:  {num50s} \n";
      }
      if (num20s > 0)
      {
        result += $"Number of 20 kr bills:  {num20s} \n";
      }
      if (num10s > 0)
      {
        result += $"Number of 10 kr coins:  {num10s} \n";
      }
      if (num5s > 0)
      {
        result += $"Number of 5 kr coins:   {num5s} \n";
      }
      if (num1s > 0)
      {
        result += $"Number of 1 kr coins:   {num1s} \n";
      }

      if (result == "")
      {
        return "No change.";
      }

      return result;
    }
  }

  // Calculator class that contains the logic to calculate the change.
  class Calculator
  {
    // Gets the change from the cost and amount paid as input.
    // Returns NaN if the amount paid is less than the cost.
    public static double getChange(double cost, double paidAmount)
    {
      if (paidAmount < cost)
      {
        return double.NaN;
      }
      return paidAmount - cost;
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

  public partial class Form : System.Windows.Forms.Form
  {
    public Form()
    {
      InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      double changeAmount = Calculator.getChange(cost: Decimal.ToDouble(costInput.Value), paidAmount: Decimal.ToDouble(paidInput.Value));

      if (double.IsNaN(changeAmount))
      {
        lblResult.Text = "Not enough paid.";
        return;
      }

      // Get a CashBook object containing number of bills and coins.
      CashBook cashBook = Calculator.amountToCash(amount: changeAmount);

      lblResult.Text = cashBook.toString();
    }
  }
}