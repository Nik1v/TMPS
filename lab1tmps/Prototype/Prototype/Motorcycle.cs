public class Motorcycle : Vehicle
{
    public Motorcycle()
    {
        Wheels = 2;
        Color = "Red";
    }

    public override Vehicle Clone()
    {
        return (Motorcycle)MemberwiseClone();
    }
}