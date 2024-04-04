namespace Module17.AbstractFactory;

internal class DragonFactory : IMonsterFactory
{
    public IMovement CreateMovement()
    {
        return new FlyMovement();
    }

    public IWeapon CreateWeapon()
    {
        return new FireBreath();
    }
}
