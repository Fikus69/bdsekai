using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

class CommandInvoker
{ 
    CommandManager commandManager;

    public CommandInvoker(CommandManager commandManager)
    {
        this.commandManager = commandManager;
    }
    public void Start()
    {
        string descr;
        do
        {
            Console.WriteLine("Добро пожаловать в Секай Баз Данных (все права принадлежат SEGA. Это лишь фан-фигня по Project Sekai: Colorful Stage ft. Hatsune Miku");
            Console.WriteLine("Введите комманду:");
            descr = Console.ReadLine();
            if (descr == "help")
                commandManager.ListCommand();
            else
                commandManager.Execute(descr);
        }
        while (descr != "exit");

    }
}
