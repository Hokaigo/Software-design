namespace Task2ClassLibrary
{
    public interface ICommandCentreMediator
    {
        void RequestLanding(Aircraft aircraft);
        void RequestTakeOff(Aircraft aircraft);
    }
}
