public class MargheritaPizzaBuilder : IPizzaBuilder
{
    private Pizza pizza;

    public MargheritaPizzaBuilder()
    {
        pizza = new Pizza();
    }

    public void BuildDough()
    {
        pizza.Dough = "Thin crust";
    }

    public void BuildSauce()
    {
        pizza.Sauce = "Tomato";
    }

    public void BuildTopping()
    {
        pizza.Topping = "Mozzarella cheese";
    }

    public Pizza GetPizza()
    {
        return pizza;
    }
}