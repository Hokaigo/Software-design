using System.Collections.Generic;
using Task2ClassLibrary;

class Program
{
    static void Main()
    {
        var runways = new List<Runway> { new Runway(), new Runway() };

        var commandCentre = new CommandCentre(runways);

        var aircraft1 = new Aircraft("Plane1", commandCentre);
        var aircraft2 = new Aircraft("Plane2", commandCentre);
        var aircraft3 = new Aircraft("Plane3", commandCentre);

        aircraft1.Land();
        aircraft2.Land();
        aircraft3.Land(); 

        aircraft1.TakeOff();
        aircraft3.Land(); 
    }
}
