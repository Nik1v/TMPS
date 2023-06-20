public class TextDocumentProcessor : DocumentProcessor
{
    protected override void OpenDocument()
    {
        Console.WriteLine("Opening text document...");
    }

    protected override void ProcessContent()
    {
        Console.WriteLine("Processing text document...");
    }

    protected override void CloseDocument()
    {
        Console.WriteLine("Closing text document...");
    }
}
