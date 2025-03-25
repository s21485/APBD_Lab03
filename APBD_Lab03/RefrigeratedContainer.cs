namespace APBD_Lab03;

public class RefrigeratedContainer : Container
{
    public double Temperature;
    public string ProductType;

    public static Dictionary<string, double> ProductTemperatures = new Dictionary<string, double>
    {
        {"Bananas", 13.3},
        {"Chocolate", 18},
        {"Fish", 2},
        {"Meat", -15},
        {"Ice cream", -18},
        {"Frozen pizza", -30},
        {"Cheese", 7.2},
        {"Sausages", 5},
        {"Butter", 20.5},
        {"Eggs", 19}
    };

    public RefrigeratedContainer(int id, double maxLoad, double height, double depth, double containerWeight,
        double temperature, string productType)
        : base("C", id, maxLoad, height, depth, containerWeight)
    {
        Temperature = temperature;
        ProductType = productType;
    }

    public override void Unload()
    {
        CurrentLoadWeight = 0;
    }

    public void Load(double weight, string type)
    {
        if (ProductTemperatures.ContainsKey(type) && Temperature > ProductTemperatures[type])
            Notify("nie można dodać produktów wymagającej tak niskiej temperatury.");
        if (type == ProductType)
            Load(weight);
        else
            Notify("nie można dodać innego typu produktu.");
    }

    public override void Load(double weight)
    {
        if (CurrentLoadWeight + weight > MaxLoad)
            Notify("dodanie takiej ilości produktów przekroczyłoby ładowność.");
        else
            CurrentLoadWeight += weight;
    }

    public void Notify(string message)
    {
        Console.WriteLine($"Ostrzeżenie: Do kontenera - {SerialNumber} {message}");
    }
}