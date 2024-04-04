namespace Module17.AbstractFactory;

internal class BanditFactory : IMonsterFactory
{
    public IMovement CreateMovement()
    {
        return new RunMovement();
    }

    public IWeapon CreateWeapon()
    {
        return new Axe();
    }
}
