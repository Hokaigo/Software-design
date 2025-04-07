using System;
using System.Collections.Generic;

namespace Task2ClassLibrary
{
    public class CommandCentre : ICommandCentreMediator
    {
        private readonly List<Runway> runways;
        private readonly Dictionary<Aircraft, Runway> map;

        public CommandCentre(List<Runway> runways)
        {
            this.runways = runways;
            map = new Dictionary<Aircraft, Runway>();
        }

        public void RequestLanding(Aircraft aircraft)
        {
            foreach (Runway runway in runways)
            {
                if (!runway.IsBusy)
                {
                    runway.SetBusy();
                    map[aircraft] = runway;
                    Console.WriteLine($"Aircraft {aircraft.Name} has landed.");
                    return;
                }
            }
            Console.WriteLine($"Could not land, the runway is busy.");
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            if (map.TryGetValue(aircraft, out Runway runway))
            {
                runway.SetFree();
                Console.WriteLine($"Aircraft {aircraft.Name} has took off.");
                map.Remove(aircraft);
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is not on any runway.");
            }
        }
    }
}

