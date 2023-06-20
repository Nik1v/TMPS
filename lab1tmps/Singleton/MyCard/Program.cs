// Obținem instanța Singleton
DatabaseConnection connection = DatabaseConnection.Instance;

// Conectăm la bază de date
connection.Connect();

// Alte operații cu baza de date

// Deconectăm de la bază de date
connection.Disconnect();