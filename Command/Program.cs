using Command;
using System.Reflection.Metadata;
using Document = Command.Document;

Document document = new Document();
CommandManager commandManager = new CommandManager();

//Simulate text editing
commandManager.ExecuteCommand(new InsertTextCommand(document, "Hello, ", 0));
commandManager.ExecuteCommand(new InsertTextCommand(document, "World!", 7));

Console.WriteLine(document);

//Undo last insert
commandManager.Undo();
Console.WriteLine(document);

//Redo last insert
commandManager.Redo();
Console.WriteLine(document);
