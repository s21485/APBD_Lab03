namespace APBD_Lab03;

public abstract class Container
{
    public double CurrentLoadWeight; // w kilogramach
    public double Height; // w centymetrach
    public double ContainerWeight; // w kilogramach
    public double Depth; // w centymetrach
    public string SerialNumber;
    public double MaxLoad;

    public Container(string type, int id, double maxLoad, double height, double depth, double containerWeight)
    {
        SerialNumber = $"KON-{type}-{id}";
        MaxLoad = maxLoad;
        Height = height;
        Depth = depth;
        ContainerWeight = containerWeight;
        CurrentLoadWeight = 0;

    }

    public abstract void Unload(); // wyładowanie kontenera
    public abstract void Load(double weight); // załadowanie kontenera

    public virtual void PrintContainer()
    {
        
        Console.WriteLine($"Informacje o kontenerze: {SerialNumber}:");
        Console.WriteLine($"Wysokość - {Height}cm, Głębokość - {Depth}cm, Waga Kontenera - {ContainerWeight}kg");
        Console.WriteLine($"Ładunek - {CurrentLoadWeight}kg/{MaxLoad}kg");
    }
    // Wypisanie informacji o danym kontenerze

}