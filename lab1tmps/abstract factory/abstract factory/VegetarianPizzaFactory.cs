public class VegetarianPizzaFactory : IPizzaFactory
{
    public IPizza CreatePizza()
    {
        return new VegetarianPizza();
    }
}