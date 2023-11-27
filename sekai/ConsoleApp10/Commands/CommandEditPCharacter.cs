
class CommandEditСharacter : UserCommand
{
    private CharacterDB characterDB;

    public CommandEditСharacter(CharacterDB characterDB)
    {
        this.characterDB = characterDB;
    }

    public override void Execute()
    {
        Console.WriteLine("Поиск опездола...");
        List<Character> characters = characterDB.Search("");
        for (int i = 0; i < characters.Count; i++)
        {
            Console.WriteLine($"{i + 1}).{characters[i].FirstName} {characters[i].LastName} {characters[i].Unit}");

            Console.WriteLine("Укажите порядковый номер...");
            int.TryParse(Console.ReadLine(), out int edit);
            if (characters.Count > edit - 1)
            {
                Console.WriteLine("Измените имя...");
                characters[i].FirstName = Console.ReadLine();
                Console.WriteLine("Измените фамилию...");
                characters[i].LastName = Console.ReadLine();
                Console.WriteLine("Измените юнит..");
                characters[i].Unit = Console.ReadLine();
                if (characterDB.Update(characters[i]))
                    Console.WriteLine("Произошла ракировочка!");
                else
                    Console.WriteLine("Ракировка отменена. Попробуйте ещё раз >:)");
            }
        }


    }
}
