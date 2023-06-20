public class VegetarianPizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Vegetarian Pizza");
    }

    public void Bake()
    {
        Console.WriteLine("Baking Vegetarian Pizza");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting Vegetarian Pizza");
    }

    public void Box()
    {
        Console.WriteLine("Boxing Vegetarian Pizza");
    }
}