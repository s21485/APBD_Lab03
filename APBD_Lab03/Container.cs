namespace APBD_Lab03;

public abstract class Container
{
    public double LoadWeight; // w kilogramach
    public double Height; // w centymetrach
    public double ContainerWeight; // w kilogramach
    public double Depth; // w centymetrach
    public SerialNumber SerialNumber;
    public double MaxLoad;

    public abstract void Unload();
    public abstract void Load(double weight);

}

public class SerialNumber
{
    public string ContainerType;
    public int Number;
}