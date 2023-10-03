
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

class sale_details
{

    public int SalesNo;
    public int ProductNo;
    public double Price;
    public DateTime DateofSale;
    public int Qty;
    public double TotalAmount;
    public sale_details(int salesNo, int productNo, double price, int qty, DateTime dateofSale)

    {

        this.SalesNo = salesNo;
        this.ProductNo = productNo;
        this.Price = price;
        this.Qty = qty;
        this.DateofSale = dateofSale;
        Sales();

    }

    public void Sales()

    {
        this.TotalAmount = Qty * Price;

    }
    public void ShowData()

    {

        Console.WriteLine($"SalesNo: {SalesNo}");
        Console.WriteLine($"ProductNo: {ProductNo}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Qty: {Qty}");
        Console.WriteLine($"DateofSale: {DateofSale}");
        Console.WriteLine($"TotalAmount: {TotalAmount}");

    }

}

class Program3

{

    static void Main()

    {
        int salesNo = 1911;
        int productNo = 1623;
        double price = 43.33;
        int qty = 13;
        DateTime dateOfSale = DateTime.Now;
        sale_details sale = new sale_details(salesNo, productNo, price, qty, dateOfSale);
        sale.ShowData();
        Console.ReadLine();

    }

}
