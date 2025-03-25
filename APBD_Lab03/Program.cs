// See https://aka.ms/new-console-template for more information

using APBD_Lab03;

public class Program
{
    static void Main(string[] args)
    {
    
        Ship ship = new Ship("Statek A", 25, 20000, 5);


        LiquidContainer c1 = new LiquidContainer(1, 5000, 12, 250, 300, true);
        GasContainer c2 = new GasContainer(2, 3000, 5, 200, 250);
        RefrigeratedContainer c3 = new RefrigeratedContainer(3, 4000, 3, 2, 260, 320, "Bananas");
        
        
        ship.LoadContainerList(new List<Container> { c1, c2, c3 });
        ship.PrintShip();

        
        c1.Load(2000);
        c2.Load(1500);
        c3.Load(1000);
        
        ship.PrintShip();
        
        RefrigeratedContainer newc = new RefrigeratedContainer(4, 5000, 3, 2, 270, 330, "Fish");
        ship.SwapContainers("KON-C-3", newc);
        ship.PrintShip();

        
        ship.UnloadContainer("KON-G-2");
        ship.PrintShip();
// Możliwość przeniesienie kontenera między dwoma statkami
    }
}


