public class PizzaMaker
{
    private IPizzaBuilder pizzaBuilder;

    public PizzaMaker(IPizzaBuilder builder)
    {
        pizzaBuilder = builder;
    }

    public void MakePizza()
    {
        pizzaBuilder.BuildDough();
        pizzaBuilder.BuildSauce();
        pizzaBuilder.BuildTopping();
    }

    public Pizza GetPizza()
    {
        return pizzaBuilder.GetPizza();
    }
}