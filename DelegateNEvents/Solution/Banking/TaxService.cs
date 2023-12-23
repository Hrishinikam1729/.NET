namespace TaxS;

public class TaxService
{

    public static void PayIncomeTax(float amount)
    {
        Console.WriteLine("Income Tax : " + amount + " has been deducted from your bank account");
    }

    public static void PayServiceTax(float amount)
    {
        Console.WriteLine("Service Tax : " + amount + " has been deducted from your bank account");
    }

    public static void PaySalesTax(float amount)
    {
        Console.WriteLine("Sales Tax : " + amount + " has been deducted from your bank account");
    }

    public static void PayGSTTax(float amount)
    {
        Console.WriteLine("GST Tax : " + amount + " has been deducted from your bank account");
    }









}