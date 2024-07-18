public interface IDamage
{
    public float amount { get; }
}

public interface IDamageReceiver
{
    void GetDamage(IDamage damage);
}
