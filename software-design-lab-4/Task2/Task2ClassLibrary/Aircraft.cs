using System;

namespace Task2ClassLibrary
{
    public class Aircraft
    {
        public string Name;
        private ICommandCentreMediator mediator;
        public bool IsTakingOff { get; set; }

        public Aircraft(string name, ICommandCentreMediator mediator)
        {
            this.Name = name;
            this.mediator = mediator;
        }

        public void Land()
        {
            Console.WriteLine($"Aircraft {this.Name} is landing.");
            Console.WriteLine($"Checking runway.");
            mediator.RequestLanding(this);
        }

        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {this.Name} is taking off.");
            mediator.RequestTakeOff(this);
        }
    }
}