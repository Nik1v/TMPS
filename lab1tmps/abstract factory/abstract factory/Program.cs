// Creăm o fabrică de Pizza Clasică
IPizzaFactory classicPizzaFactory = new ClassicPizzaFactory();
PizzaStore classicPizzaStore = new PizzaStore(classicPizzaFactory);
classicPizzaStore.OrderPizza();

// Creăm o fabrică de Pizza Vegetariană
IPizzaFactory vegetarianPizzaFactory = new VegetarianPizzaFactory();
PizzaStore vegetarianPizzaStore = new PizzaStore(vegetarianPizzaFactory);
vegetarianPizzaStore.OrderPizza();

Console.ReadLine();