DocumentProcessor textDocumentProcessor = new TextDocumentProcessor();
textDocumentProcessor.ProcessDocument();

Console.WriteLine();

DocumentProcessor spreadsheetDocumentProcessor = new SpreadsheetDocumentProcessor();
spreadsheetDocumentProcessor.ProcessDocument();

Console.ReadLine();
