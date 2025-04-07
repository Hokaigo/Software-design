using System;

namespace Task2ClassLibrary
{
    public class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public bool IsBusy { get; private set; }

        public void SetBusy()
        {
            IsBusy = true;
            HighLightRed();
        }

        public void SetFree()
        {
            IsBusy = false;
            HighLightGreen();
        }

        public void HighLightRed() => Console.WriteLine($"Runway {this.Id} is busy now!");

        public void HighLightGreen() => Console.WriteLine($"Runway {this.Id} is free now!");
    }
}
