public class DatabaseConnection
{
    private static DatabaseConnection instance;
    private string connectionString;

    private DatabaseConnection()
    {
        // Inițializarea conexiunii la baza de date
        connectionString = "your_database_connection_string";
    }

    public static DatabaseConnection Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new DatabaseConnection();
            }
            return instance;
        }
    }

    public void Connect()
    {
        // Logica de conectare la bază de date
        Console.WriteLine("Conexiunea la baza de date a fost realizată.");
    }

    public void Disconnect()
    {
        // Logica de deconectare de la bază de date
        Console.WriteLine("Deconectarea de la baza de date a fost realizată.");
    }

    // Alte metode specifice conexiunii la bază de date
}
