namespace Module17.AbstractFactory;

internal interface IMonsterFactory
{
    IMovement CreateMovement();
    IWeapon CreateWeapon();
}
