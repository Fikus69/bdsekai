using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class CommandDeleteCharacter : UserCommand
    {
        private CharacterDB characterDB;

        public CommandDeleteCharacter(CharacterDB characterDB)
        {
            this.characterDB = characterDB;
        }

        public override void Execute()
        {
            Console.WriteLine("Поиск опездола...");
            List<Character> characters = characterDB.Search("");
            for (int i = 0; i < characters.Count; i++)
                Console.WriteLine($"{i + 1}).{characters[i].FirstName} {characters[i].LastName} {characters[i].Unit}");

            Console.WriteLine("Укажите порядковый номер...");
            int.TryParse(Console.ReadLine(), out int nomer);
            if (characters.Count > nomer - 1 && characterDB.Delete(characters[nomer - 1]))
                Console.WriteLine("Опездол покинул пати!");
            else
                Console.WriteLine("Не удалось выгнать опездола...");

        }
    }
