public class Car : Vehicle
{
    public Car()
    {
        Wheels = 4;
        Color = "Black";
    }

    public override Vehicle Clone()
    {
        return (Car)MemberwiseClone();
    }
}