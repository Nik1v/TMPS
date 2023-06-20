public class SpreadsheetDocumentProcessor : DocumentProcessor
{
    protected override void OpenDocument()
    {
        Console.WriteLine("Opening spreadsheet document...");
    }

    protected override void ProcessContent()
    {
        Console.WriteLine("Processing spreadsheet document...");
    }

    protected override void CloseDocument()
    {
        Console.WriteLine("Closing spreadsheet document...");
    }
}