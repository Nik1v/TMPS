public class ClassicPizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Classic Pizza");
    }

    public void Bake()
    {
        Console.WriteLine("Baking Classic Pizza");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting Classic Pizza");
    }

    public void Box()
    {
        Console.WriteLine("Boxing Classic Pizza");
    }
}