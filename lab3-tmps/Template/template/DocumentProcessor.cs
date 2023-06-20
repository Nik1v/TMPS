public abstract class DocumentProcessor
{
    public void ProcessDocument()
    {
        OpenDocument();
        ProcessContent();
        CloseDocument();
    }

    protected abstract void OpenDocument();

    protected abstract void ProcessContent();

    protected abstract void CloseDocument();
}