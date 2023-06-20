EventPublisher publisher = new EventPublisher();

// Creăm ascultători
EventListener listener1 = new EventListener("Listener 1");
EventListener listener2 = new EventListener("Listener 2");

// Abonăm ascultătorii pentru a primi notificări
publisher.Subscribe(listener1);
publisher.Subscribe(listener2);

// Publicăm un eveniment
publisher.PublishEvent("Event 1");

// Dezabonăm un ascultător
publisher.Unsubscribe(listener2);

// Publicăm un alt eveniment
publisher.PublishEvent("Event 2");

Console.ReadKey();
