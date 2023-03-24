namespace DesignPatterns.Structural.Flyweight;

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