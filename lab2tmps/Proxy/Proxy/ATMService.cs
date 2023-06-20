public class ResourceProxy : IResource
{
    private IResource resource;
    private string username;
    private string password;

    public ResourceProxy(string username, string password)
    {
        resource = new Resource();
        this.username = username;
        this.password = password;
    }

    public void AccessResource()
    {
        if (AuthenticateUser())
        {
            resource.AccessResource();
        }
        else
        {
            Console.WriteLine("Access denied.");
        }
    }

    private bool AuthenticateUser()
    {
        // Logica de autentificare a utilizatorului
        // Verificare username și password
        return username == "admin" && password == "secret";
    }
}