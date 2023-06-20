// Creăm builder pentru Margherita Pizza
IPizzaBuilder margheritaBuilder = new MargheritaPizzaBuilder();

// Creăm directorul și îi atribuim builder-ul
PizzaMaker pizzaMaker = new PizzaMaker(margheritaBuilder);

// Directorul construiește pizza
pizzaMaker.MakePizza();

// Obținem pizza finală de la builder
Pizza margheritaPizza = pizzaMaker.GetPizza();

// Afișăm pizza finală
margheritaPizza.Display();

Console.ReadLine();