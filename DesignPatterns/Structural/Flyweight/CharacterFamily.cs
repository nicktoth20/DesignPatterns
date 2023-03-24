namespace DesignPatterns.Structural.Flyweight;

public class CharacterFamily
{
    private readonly Dictionary<char, ICharacter> _characters = new();

    public ICharacter? GetCharacter(char characterIdentifier)
    {
        if (_characters.ContainsKey(characterIdentifier))
        {
            Console.WriteLine(("Character reuse"));
            return _characters[characterIdentifier];
        }
        
        Console.WriteLine("Character construction");
        switch (characterIdentifier)
        {
            case 'a':
                _characters[characterIdentifier] = new CharacterA();
                return _characters[characterIdentifier];
            case 'b':
                _characters[characterIdentifier] = new CharacterB();
                return _characters[characterIdentifier];
            default:
                return null;
        }
    }

    // Added for the Unshared Flyweight
    public ICharacter CreateParagraph(List<ICharacter> characters, int location)
    {
        return new Paragraph(characters, location);
    }
}