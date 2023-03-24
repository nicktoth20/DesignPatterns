namespace DesignPatterns.Structural.Flyweight;

// The intent of this pattern is to use sharing to support large number of fine-grained objects efficiently.
// It does that by sharing parts of the state between these objects instead of keeping all that state in all of the objects.

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