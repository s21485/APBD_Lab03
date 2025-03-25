namespace APBD_Lab03;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure; // w atmosferach

    public GasContainer(int id, double maxLoad, double height, double depth, double containerWeight)
        : base("G", id, maxLoad, height, depth, containerWeight)
    {
        Pressure = 0;
    }

    public override void Unload()
    {
        CurrentLoadWeight *= 0.05;
        Pressure *= 0.05;
    }

    public override void Load(double weight)
    {
        if (CurrentLoadWeight + weight > MaxLoad)
            Notify("nie można załadować takiej ilości gazu.");
        else
            CurrentLoadWeight += weight;
    }

    public void Notify(string message)
    {
        Console.WriteLine($"Ostrzeżenie: Do kontenera - {SerialNumber} {message}");
    }
    
    public override void PrintContainer()
    {
        base.PrintContainer();
        Console.WriteLine($"Ciśnienie: {Pressure}at");
    }
}