namespace DesignPatterns.Structural.Flyweight;

// The intent of this pattern is to use sharing to support large number of fine-grained objects efficiently.
// It does that by sharing parts of the state between these objects instead of keeping all that state in all of the objects.
public interface ICharacter
{
    void Draw(string fontFamily, int fontSize);
}

public class CharacterA : ICharacter
{
    private char _actualCharacter = 'a';
    private string _fontFamily = string.Empty;
    private int _fontSize;

    public void Draw(string fontFamily, int fontSize)
    {
        _fontFamily = fontFamily;
        _fontSize = fontSize;
        Console.WriteLine($"Drawing {_actualCharacter}, {_fontFamily} {_fontSize}");
    }
}

public class CharacterB : ICharacter
{
    private char _actualCharacter = 'b';
    private string _fontFamily = string.Empty;
    private int _fontSize;
    
    public void Draw(string fontFamily, int fontSize)
    {
        _fontFamily = fontFamily;
        _fontSize = fontSize;
        Console.WriteLine($"Drawing {_actualCharacter}, {_fontFamily} {_fontSize}");
    }
}

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

/// <summary>
/// Unshared Concrete Flyweight
/// </summary>
public class Paragraph : ICharacter
{
    private int _location;
    private List<ICharacter> _characters = new();

    public Paragraph(List<ICharacter> characters, int location)
    {
        _characters = characters;
        _location = location;
    }

    public void Draw(string fontFamily, int fontSize)
    {
        Console.WriteLine($"Drawing in paragraph at location {_location}");
        foreach (var character in _characters)
        {
            character.Draw(fontFamily, fontSize);
        }
    }
} 