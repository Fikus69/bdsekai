using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CommandCreateCharacter : UserCommand
{
    private CharacterDB characterDB;

    public CommandCreateCharacter(CharacterDB characterDB)
    {
        this.characterDB = characterDB;
    }

    public override void Execute()
    {
        Console.WriteLine("Создание опездола...");
        Character newCharacter = characterDB.Create();
        Console.WriteLine("Укажите имя...");
        newCharacter.FirstName = Console.ReadLine();
        Console.WriteLine("Укажите фамилию...");
        newCharacter.LastName = Console.ReadLine();
        Console.WriteLine("Укажите юнит...");
        newCharacter.Unit = Console.ReadLine();
        
        if (characterDB.Update(newCharacter))
            Console.WriteLine("Персонаж создан!!");
        else
            Console.WriteLine("ПЕРСОНАЖ НЕ МОЖЕТ СУЩЕСТВОВАТЬ. КУСОК ТЫ ЧЕЛОВЕКА!");
    }
}


