public class PizzaStore
{
    private IPizzaFactory pizzaFactory;

    public PizzaStore(IPizzaFactory factory)
    {
        pizzaFactory = factory;
    }

    public void OrderPizza()
    {
        IPizza pizza = pizzaFactory.CreatePizza();

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
    }
}