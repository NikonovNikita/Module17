using Module17.AbstractFactory;
using Module17.AbstractFactoryExample;
using Module17.FactoryMethod;
using Module17.Singleton;

namespace Module17;
class Program
{
    static void Main(string[] args)
    {
        //<Singleton>//

        var application = new Application();

        application.Launch("10.20.30.80");
        Console.WriteLine(application.DBConnection.Configuration);

        application.DBConnection = DataBaseConnection.GetConnectionInstance("20.20.10.11");
        Console.WriteLine(application.DBConnection.Configuration);

        //</Singleton>//

        //<AbstractFactory>//

        var dragon = new Monster(new DragonFactory());
        var bandit = new Monster(new  BanditFactory());

        dragon.Move();
        dragon.Attack();

        bandit.Move();
        bandit.Attack();

        //</AbstractFactory>//

        //<FactoryMethod>//

        string messageText = "Ваш номер заказа: 00981";

        MessageSender messageSender = new SmsMessageSender("8-800-555-35-35");
        Message smsMessage = messageSender.Send(messageText);
        Console.WriteLine($"messageSender имеет тип: {messageSender.GetType()}");

        messageSender = new EmailMessageSender("orders@yandex.ru");
        Message emailMessage = messageSender.Send(messageText);
        Console.WriteLine($"messageSender имеет тип: {messageSender.GetType()}");

        //</FactoryMethod>//
    }
}