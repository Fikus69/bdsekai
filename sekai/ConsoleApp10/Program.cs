using System.Text.RegularExpressions;

namespace ConsoleApp10
{
    class Program
    {
        public static void Main()
        {
            CommandManager commandManager = new CommandManager();
            CommandInvoker commandInvoker = new CommandInvoker(commandManager);
            CharacterDB characterDB = new CharacterDB();
            commandManager.RegisterCommand("Create", "Создание", new CommandCreateCharacter(characterDB));
            commandManager.RegisterCommand("Search", "Поиск", new CommandSearchCharacter(characterDB));
            commandManager.RegisterCommand("Delete", "Удаление", new CommandDeleteCharacter(characterDB));
            commandManager.RegisterCommand("Edit", "Редактирование", new CommandEditСharacter(characterDB));
            
            commandInvoker.Start();
        }

    }
}