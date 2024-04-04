namespace SOLID.OpenClosedPrinciple;

internal class GroundLandingProfile : ILandingProfile
{
    public void Execute()
    {
        Console.WriteLine(">> Загружен профиль: ПОСАДКА НА ЗЕМЛЮ <<");

        Console.WriteLine("Сбрасываем скорость");
        Console.WriteLine("Опускаем руль высоты");
        Console.WriteLine("Сбрасываем скорость");
        Console.WriteLine("Выпускаем шасси");
        Console.WriteLine("Поднимаем руль высоты");
        Console.WriteLine("Сбрасываем скорость");
        Console.WriteLine("--ПОСАДКА--");
        Console.WriteLine("Выпускаем тормозной парашют");
    }
}
