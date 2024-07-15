using System;

class Furniture
{
    public string OrderId { get; set; }
    public string OrderDate { get; set; }
    public string FurnitureType { get; set; }
    public int Qty { get; set; }
    public double TotalAmt { get; set; }
    public string PaymentMode { get; set; }

    public virtual void GetData()
    {
        Console.Write("Enter Order ID: ");
        OrderId = Console.ReadLine();
        Console.Write("Enter Order Date: ");
        OrderDate = Console.ReadLine();
        Console.Write("Enter Furniture Type (Chair/Cot): ");
        FurnitureType = Console.ReadLine();
        Console.Write("Enter Quantity: ");
        Qty = int.Parse(Console.ReadLine());
        Console.Write("Enter Total Amount: ");
        TotalAmt = double.Parse(Console.ReadLine());
        Console.Write("Enter Payment Mode (credit/debit): ");
        PaymentMode = Console.ReadLine();
    }

    public virtual void ShowData()
    {
        Console.WriteLine($"Order ID: {OrderId}");
        Console.WriteLine($"Order Date: {OrderDate}");
        Console.WriteLine($"Furniture Type: {FurnitureType}");
        Console.WriteLine($"Quantity: {Qty}");
        Console.WriteLine($"Total Amount: {TotalAmt}");
        Console.WriteLine($"Payment Mode: {PaymentMode}");
    }
}

class Chair : Furniture
{
    public string ChairType { get; set; }
    public string Purpose { get; set; }
    public string Detail { get; set; }
    public double Rate { get; set; }

    public override void GetData()
    {
        base.GetData();
        Console.Write("Enter Chair Type (Wood/Steel/Plastic): ");
        ChairType = Console.ReadLine();
        Console.Write("Enter Purpose (Home/Office): ");
        Purpose = Console.ReadLine();

        if (ChairType == "Wood")
        {
            Console.Write("Enter Wood Type (Teak/Rose): ");
        }
        else if (ChairType == "Steel")
        {
            Console.Write("Enter Steel Type (Gray/Green/Brown): ");
        }
        else if (ChairType == "Plastic")
        {
            Console.Write("Enter Plastic Color (Green/Red/Blue/White): ");
        }
        Detail = Console.ReadLine();

        Console.Write("Enter Rate: ");
        Rate = double.Parse(Console.ReadLine());
    }

    public override void ShowData()
    {
        base.ShowData();
        Console.WriteLine($"Chair Type: {ChairType}");
        Console.WriteLine($"Purpose: {Purpose}");
        Console.WriteLine($"{(ChairType == "Wood" ? "Wood Type" : ChairType == "Steel" ? "Steel Type" : "Plastic Color")}: {Detail}");
        Console.WriteLine($"Rate: {Rate}");
    }
}

class Cot : Furniture
{
    public string CotType { get; set; }
    public string Detail { get; set; }
    public string Capacity { get; set; }
    public double Rate { get; set; }

    public override void GetData()
    {
        base.GetData();
        Console.Write("Enter Cot Type (Wood/Steel): ");
        CotType = Console.ReadLine();

        if (CotType == "Wood")
        {
            Console.Write("Enter Wood Type (Teak/Rose): ");
        }
        else if (CotType == "Steel")
        {
            Console.Write("Enter Steel Type (Gray/Green/Brown): ");
        }
        Detail = Console.ReadLine();

        Console.Write("Enter Capacity (Single/Double): ");
        Capacity = Console.ReadLine();
        Console.Write("Enter Rate: ");
        Rate = double.Parse(Console.ReadLine());
    }

    public override void ShowData()
    {
        base.ShowData();
        Console.WriteLine($"Cot Type: {CotType}");
        Console.WriteLine($"{(CotType == "Wood" ? "Wood Type" : "Steel Type")}: {Detail}");
        Console.WriteLine($"Capacity: {Capacity}");
        Console.WriteLine($"Rate: {Rate}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Furniture Type to create (Chair/Cot): ");
        string type = Console.ReadLine();

        Furniture furniture = type == "Chair" ? (Furniture)new Chair() : type == "Cot" ? (Furniture)new Cot() : null;

        if (furniture == null)
        {
            Console.WriteLine("Invalid Furniture Type!");
            return;
        }

        furniture.GetData();
        furniture.ShowData();
    }
}

