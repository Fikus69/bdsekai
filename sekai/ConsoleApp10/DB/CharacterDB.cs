using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

class CharacterDB
{
    List<Character> characters;

    public CharacterDB()
    {
        if (!File.Exists("characters.db"))
            characters = new List<Character>();
        else
            using (FileStream fs = new FileStream("characters.db", FileMode.OpenOrCreate))
            {
                characters = JsonSerializer.Deserialize<List<Character>>(fs);
            }

    }

    public List<Character> Search(string text)
    {
        List<Character> result = new();
        foreach (var character in characters)
        {
            if (character.FirstName.Contains(text)||character.LastName.Contains(text)||character.Unit.Contains(text))

                result.Add(character);
        }
        return result;
    }

    public bool Update(Character character)
    {
        if (characters.Contains(character))
            Save();
        else
            return false;
        return true;
    }

    public Character Create()
    {
        Character newCharacter = new Character { };
        characters.Add(newCharacter);
        return newCharacter;
    }

    public bool Delete(Character character)
    {
        characters.Remove(character);
        Save();
        return true;
    }

    void Save()
    {
        using (FileStream fs = new FileStream("characters.db", FileMode.Open))
        {
            JsonSerializer.Serialize(fs, characters);
        }
    }
}
