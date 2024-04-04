namespace Module17.AbstractFactory;

internal class Monster
{
    private IWeapon _weapon;
    private IMovement _movement;

    public Monster(IMonsterFactory factory)
    {
        _weapon = factory.CreateWeapon();
        _movement = factory.CreateMovement();
    }

    public void Move()
    {
        _movement.Move();
    }

    public void Attack()
    {
        _weapon.Attack();
    }
}
