namespace APBD_Lab03;

public class LiquidContainer : Container, IHazardNotifier
{

    public bool IsHazardous; // czy ładunek jest niebezpieczny

    public LiquidContainer(int id, double maxLoad, double height, double depth, double containerWeight,
        bool isHazardous)
        : base("L", id, maxLoad, height, depth, containerWeight)
    {
        IsHazardous = isHazardous;
    }

    public override void Load(double weight)
    {
        double allowedLoad = IsHazardous ? MaxLoad * 0.5 : MaxLoad * 0.9;
        if (CurrentLoadWeight + weight > allowedLoad)
            Notify("nie można załadować takiej ilości płynu.");
        else
            CurrentLoadWeight += weight;

    }

    public override void Unload()
    {
        CurrentLoadWeight = 0;
    }

    public void Notify(string message)
    {
        Console.WriteLine($"Ostrzeżenie: Do kontenera - {SerialNumber} {message}");
    }
}