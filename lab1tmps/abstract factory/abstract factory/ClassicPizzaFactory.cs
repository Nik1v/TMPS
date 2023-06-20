public class ClassicPizzaFactory : IPizzaFactory
{
    public IPizza CreatePizza()
    {
        return new ClassicPizza();
    }
}