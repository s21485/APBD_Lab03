namespace APBD_Lab03;

public class Ship
{
    public string Name;
    public double MaxSpeed; // w węzłach
    public double MaxLoad; // w tonach
    public int MaxContainers;
    public List<Container> Containers = new List<Container>();

    public Ship(string name, double maxSpeed, double maxLoad, int maxContainers)
    {
        Name = name;
        MaxSpeed = maxSpeed; // w węzłach
        MaxLoad = maxLoad; // w tonach
        MaxContainers = maxContainers;
        Containers = new List<Container>();
    }

    public void LoadContainer(Container container)
    {
        if (Containers.Count >= MaxContainers)
            throw new Exception("Przekroczono maksymalną liczbę kontenerów!");
        if (GetTotalWeight() + container.ContainerWeight + container.CurrentLoadWeight > MaxLoad * 1000)
            throw new Exception("Przekroczono maksymalną wagę kontenerowca!");
        
        Containers.Add(container);
    }
    
    public void LoadContainerList(List<Container> containers)
    {
        foreach (var container in containers)
        {
            LoadContainer(container);
        }
    }

    public void UnloadContainer(string serialNumber)
    {
        Containers.RemoveAll(c => c.SerialNumber == serialNumber);
    }

    public double GetTotalWeight()
    {
        double totalWeight = 0;
        foreach (var container in Containers)
        {
            totalWeight += container.CurrentLoadWeight + container.ContainerWeight;
        }
        return totalWeight;
    }

    public void SwapContainers(string serialNumber, Container container)
    {
        bool swapped = false;
        for (int i = 0; i < Containers.Count; i++)
            if (Containers[i].SerialNumber == serialNumber)
            {
                Containers[i] = container;
                swapped = true;
            }
        if (!swapped)
            throw new Exception("Nie znaleziono kontenera do zastąpienia!");

    }

    public void PrintShip()
    {
        Console.WriteLine($"Statek {Name} osiąga maksymalnie: {MaxSpeed} węzłów, może posiadać maksymalnie {MaxContainers} kontenerów i przewozi {GetTotalWeight()/1000}/{MaxLoad} ton ładunku.");
        Console.WriteLine($"Przewozi {Containers.Count} kontenerów:");
        foreach (var container in Containers)
        {
            container.PrintContainer();
        }
    }
}