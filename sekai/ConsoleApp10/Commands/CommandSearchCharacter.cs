using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CommandSearchCharacter : UserCommand
{
    private CharacterDB characterDB;

    public CommandSearchCharacter(CharacterDB characterDB)
    {
        this.characterDB = characterDB;
    }

    public override void Execute()
    {
        Console.WriteLine("Поиск опездола...");
        List<Character> characters = characterDB.Search(Console.ReadLine());
        for (int i = 0; i < characters.Count; i++)
            Console.WriteLine($"{i + 1}).{characters[i].FirstName} {characters[i].LastName} {characters[i].Unit}");


    }
}
