using BehavioralPatterns.ChainOfResposibility;
using BehavioralPatterns.ChainOfResposibilityExample;
using BehavioralPatterns.Observer;
using BehavioralPatterns.State;
using BehavioralPatterns.StateExample;

class Program
{
    static void Main(string[] args)
    {
        //<ChainOfResposibility>//

        Client client = new Client();
        client.Start();

        Receiver receiver = new Receiver(false, true, true);

        NotificationHandler emailNotifyHandler = new EmailNotificationHandler();
        NotificationHandler smsNotifyHandler = new SmsNotificationHandler();
        NotificationHandler voiceNotifyHandler = new VoiceNotificationHandler();

        emailNotifyHandler.Successor = smsNotifyHandler;
        smsNotifyHandler.Successor = voiceNotifyHandler;

        emailNotifyHandler.Handle(receiver);

        Console.WriteLine("\n\n");

        //</ChainOfResposibility>//

        //<State>//

        var contextObject = new ContextObject(new StateOne());

        contextObject.Switch();
        contextObject.Switch();

        Elevator elevator = new Elevator(new GroundElevatorState());
        elevator.Up();
        elevator.Down();
        elevator.Down();
        elevator.Down();

        Console.WriteLine("\n\n");

        //</State>//

        //<Observer>//

        Stock stock = new Stock();

        var bank = new Bank(stock);
        var broker = new Broker(stock);

        stock.Market();
        broker.StopTrade();
        stock.Market();

        //</Observer>//
    }
}