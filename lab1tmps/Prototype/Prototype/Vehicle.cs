public abstract class Vehicle
{
    public int Wheels { get; set; }
    public string Color { get; set; }

    public abstract Vehicle Clone();
}
